using Entity;
using System.Collections.Generic;
using System.Linq;
namespace BLL
{
    public class BLLNVNH : BLL
    {
        private static BLLNVNH _Instance;
        public static BLLNVNH Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLLNVNH();
                return _Instance;
            }
            private set { }
        }
        private BLLNVNH()
        {
            
        }
        public int NumberOfStatusAndFloor(bool st, int fl)
        {
            int dem = 0;
            if (st)
                dem = dALQLNH.Bans.Where(p => (p.Tang == fl && p.TinhTrangBan != 0)).Count();
            else
                dem = dALQLNH.Bans.Where(p => (p.Tang == fl && p.TinhTrangBan == 0)).Count();
            return dem;
        }

        public List<Ban> GetAllBanByTang(int fl)
        {
            return dALQLNH.Bans.Where(p => p.Tang == fl).ToList();
        }
        public List<Ban> GetAllBanByTinhTrangBanVaTang(bool st, int fl)
        {
            if (st)
                return dALQLNH.Bans.Where(p => (p.Tang == fl && p.TinhTrangBan != 0)).ToList();
            else
                return dALQLNH.Bans.Where(p => (p.Tang == fl && p.TinhTrangBan == 0)).ToList();
        }
        public Ban GetBanByID_Ban(int id)
        {
            return dALQLNH.Bans.Where(p => p.ID_Ban == id).FirstOrDefault();
        }
        public List<MonAn> GetAllDishByIDDishAndIDKindOfDish(int idmonan, int idloaimonan)
        {
            return dALQLNH.MonAns.Where(p => (p.ID_MonAn == idmonan && p.ID_LoaiMonAn == idloaimonan)).ToList();
        }
        private List<Ban> GetAllBan()
        {
            return dALQLNH.Bans.ToList();
        }

        public List<string> GetKindOfFood()
        {
            DALQLNH dALQLNH = new DALQLNH();
            List<string> list = new List<string>();
            foreach (LoaiNguyenLieu i in dALQLNH.LoaiNguyenLieus)
            {
                list.Add(i.TenLoaiNguyenLieu);
            }
            return list;
        }

        public float GetSoLuongNguyenLieuByIDNguyenLieu(int id)
        {
            float count = 0;
            DALQLNH dALQLNH = new DALQLNH();
            foreach (Kho i in dALQLNH.Khoes)
            {
                if (i.ID_NguyenLieu == id)
                {
                    count = i.LuongTonKho;
                }
            }
            return count;
        }
        public List<MonAn> GetMonAn(int ID_LoaiMonAn , string txt, int TrangThai)
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
    }
}
