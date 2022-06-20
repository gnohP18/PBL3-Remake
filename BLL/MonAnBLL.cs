using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using DTO;
namespace BLL
{
    public class MonAnBLL : BLL
    {
        private static MonAnBLL _Instance;
        public static MonAnBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new MonAnBLL();
                return _Instance;
            }
            private set { }
        }
        private MonAnBLL()
        {

        }
        public List<MonAn> GetMonAn(int ID_LoaiMonAn, string txt, int TrangThai)
        {
            return dALQLNH.MonAns.Where(p => p.ID_LoaiMonAn == ID_LoaiMonAn && p.TrangThai == TrangThai && p.TenMonAn.Contains(txt)).ToList();
        }
        public List<MonAn_View> GetListMonAnByIDBan(int ID_Ban)
        {
            List<MonAn_View> data = new List<MonAn_View>();
            var groupMonAn = dALQLNH.ChiTietBans.GroupBy(s => s.ID_Ban).Where(g => g.Key == ID_Ban);
            foreach (var childGroup in groupMonAn)
            {
                foreach (ChiTietBan i in childGroup)
                {
                    MonAn monAn = dALQLNH.MonAns.Find(i.ID_MonAn);
                    bool checkMonAnExisted = false;
                    foreach (MonAn_View j in data)
                    {
                        if (j.ID_MonAn == monAn.ID_MonAn)
                        {
                            j.SoLuong += i.SoLuong;
                            j.ThanhTien = j.SoLuong * monAn.ThanhTien;
                            checkMonAnExisted = true;
                            continue;
                        }
                    }
                    if (!checkMonAnExisted)
                        data.Add(new MonAn_View { ID_MonAn = monAn.ID_MonAn, TenMonAn = monAn.TenMonAn, SoLuong = i.SoLuong, ThanhTien = monAn.ThanhTien });
                }
            }
            return data;
        }
        public void ChangeStatusDishByID(int id)
        {
            foreach (ChiTietBan i in dALQLNH.ChiTietBans)
            {
                if (i.ID_ChiTietBan == id)
                {
                    i.TinhTrang = 1;
                    break;
                }
            }
            dALQLNH.SaveChanges();
        }
        public MonAn GetMonAnByID(int ID_MonAn)
        {
            return dALQLNH.MonAns.Where(x => x.ID_MonAn == ID_MonAn).FirstOrDefault();
        }
        public List<MonAn> GetAllMonAn()
        {
            return dALQLNH.MonAns.ToList();
        }
        public List<MonAn> GetAllMonAnByIDLoaiMonAn(int ID_LoaiMonAn)
        {
            List<MonAn> listMonAn = new List<MonAn>();
            foreach (MonAn monan in dALQLNH.MonAns)
            {
                if (ID_LoaiMonAn == monan.ID_LoaiMonAn)
                    listMonAn.Add(monan);
            }
            return listMonAn;
        }
        public void UpdateTrangThaiMonAn(Dictionary<int, float> listThongTinLuongNguyenLieu, List<MonAn_View> ListMonAnViewLayRa = null)
        {
            if (ListMonAnViewLayRa == null || ListMonAnViewLayRa.Count == 0)
            {
                var parentGroupCTMA = dALQLNH.ChiTietMonAns.GroupBy(s => s.ID_MonAn);
                foreach (var childGroupCTMA in parentGroupCTMA)
                {
                    MonAn monAn = dALQLNH.MonAns.Find(childGroupCTMA.Key);
                    foreach (ChiTietMonAn i in childGroupCTMA)
                    {
                        if (i.Luong > listThongTinLuongNguyenLieu[i.ID_NguyenLieu])
                        {
                            monAn.TrangThai = 0;
                            break;
                        }
                        monAn.TrangThai = 1;
                    }
                }

            }
            else
            {
                foreach (MonAn_View monAn_View in ListMonAnViewLayRa)
                {
                    List<ChiTietMonAn> list = dALQLNH.ChiTietMonAns.Where(s => s.ID_MonAn == monAn_View.ID_MonAn).ToList();
                    foreach (ChiTietMonAn i in list)
                    {
                        listThongTinLuongNguyenLieu[i.ID_NguyenLieu] -= i.Luong * monAn_View.SoLuong;
                    }
                }
                UpdateTrangThaiMonAn(listThongTinLuongNguyenLieu);
            }
            dALQLNH.SaveChanges();
        }
        public int GetNewIDMonAn()
        {
            int ID = 1;
            foreach (MonAn i in dALQLNH.MonAns)
            {
                if (ID != i.ID_MonAn)
                {
                    return ID;
                }
                ID++;
            }
            return ID;
        }
        public void AddNewMonAn(List<ChiTietNhapMonAn_View> lt, string TenMonAn, int ID_LoaiMonAn, int thanhtien, Byte[] img)
        {
            MonAn mon = new MonAn();
            mon.ID_MonAn = GetNewIDMonAn();
            mon.ID_LoaiMonAn = ID_LoaiMonAn;
            mon.TenMonAn = TenMonAn;
            mon.ThanhTien = thanhtien;
            mon.AnhMonAn = img;
            mon.TrangThai = 0;
            dALQLNH.MonAns.Add(mon);
            dALQLNH.SaveChanges();
            foreach (ChiTietNhapMonAn_View i in lt)
            {
                dALQLNH.ChiTietMonAns.Add(new ChiTietMonAn
                {
                    ID_MonAn = mon.ID_MonAn,
                    ID_NguyenLieu = i.ID_NguyenLieu,
                    Luong = i.Luong,
                });
                dALQLNH.SaveChanges();
            }
        }
        public List<ChiTietMonAn> GetChiTietMonAnByIDMonAn(int ID_MonAn)
        {
            List<ChiTietMonAn> list = new List<ChiTietMonAn>();
            foreach (ChiTietMonAn mon in dALQLNH.ChiTietMonAns)
            {
                if (ID_MonAn == mon.ID_MonAn)
                {
                    list.Add(mon);
                }
            }
            return list;
        }
        public List<MonAn_View> GetAllDish_viewByIDDetailTable(int ID_Detail_Table)
        {
            List<MonAn_View> list = new List<MonAn_View>();
            foreach (ChiTietBan i in BanBLL.Instance.GetAllDetailTableByID_Table(ID_Detail_Table))
            {
                MonAn_View mnv = new MonAn_View();
                mnv.ID_MonAn = i.ID_MonAn;
                mnv.TenMonAn = i.MonAn.TenMonAn;
                mnv.SoLuong = i.SoLuong;
                mnv.ThanhTien = i.SoLuong * i.MonAn.ThanhTien;
                list.Add(mnv);
            }
            return list;
        }
    }
}
