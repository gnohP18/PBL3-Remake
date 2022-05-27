using Entity;
using System;
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

        public List<Ban> GetBanByTinhTrangBanVaTang(int st, int fl)
        {
            if (st == -1)
                return dALQLNH.Bans.Where(p => p.Tang == fl ).ToList();
            else if(st == 0)
                return dALQLNH.Bans.Where(p => (p.Tang == fl && p.TinhTrangBan == 0)).ToList();
            else
                return dALQLNH.Bans.Where(p => (p.Tang == fl && p.TinhTrangBan != 0)).ToList();
        }
        public Ban GetBanByID_Ban(int id)
        {
            return dALQLNH.Bans.Where(p => p.ID_Ban == id).FirstOrDefault();
        }
        public List<MonAn> GetAllDishByIDDishAndIDKindOfDish(int idmonan, int idloaimonan)
        {
            return dALQLNH.MonAns.Where(p => (p.ID_MonAn == idmonan && p.ID_LoaiMonAn == idloaimonan)).ToList();
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
        public void AddDetailTable(List<MonAn_View> lt, int Idtable)
        {
            foreach (MonAn_View item in lt)
            {
                dALQLNH.ChiTietBans.Add(new ChiTietBan
                {
                    ID_ChiTietBan = GetNewIDChiTietBan(),
                    ID_Ban = Idtable,
                    ID_MonAn = item.ID_MonAn,
                    SoLuong = item.SoLuong,
                    TinhTrang = 0
                }); dALQLNH.SaveChanges();
            }

        }
        public int GetNewIDChiTietBan()
        {
            int id = 1;
            foreach (ChiTietBan i in dALQLNH.ChiTietBans)
            {
                if (id != i.ID_ChiTietBan)
                {
                    return id;
                }
                id++;
            }
            return id;
        }

        public void ChangeStatusTable(int idtatable, int idbanghep)
        {
            var table = dALQLNH.Bans.Where(p => p.ID_Ban == idtatable).FirstOrDefault();
            table.TinhTrangBan = idbanghep;
            dALQLNH.SaveChanges();
        }

        public void SetCollabTable(Ban tb, int ttban)
        {
            if (tb.ID_Ban == tb.TinhTrangBan || tb.TinhTrangBan == 0)
            {
                tb.TinhTrangBan = ttban;
                GetBanByID_Ban(ttban).TinhTrangBan = ttban;
                dALQLNH.SaveChanges();
            }
            else if (tb.ID_Ban != tb.TinhTrangBan)
            {
                SetCollabTable(GetBanByID_Ban(tb.TinhTrangBan), ttban);
            }
        }
        public string GetAllCollabTable(Ban tb, int ttban, string txt)
        {
            if (tb.ID_Ban == tb.TinhTrangBan || tb.TinhTrangBan == 0)
            {
                Console.WriteLine(txt);
                return txt;
            }
            else
            {
                Console.WriteLine(txt);
                txt = txt + " " + GetBanByID_Ban(tb.TinhTrangBan).TenBan;
                return GetAllCollabTable(GetBanByID_Ban(tb.TinhTrangBan), ttban, txt);
            }
        }

        public int FindMainTable(Ban tb)
        {
            if (dALQLNH.Bans.Where(s => s.TinhTrangBan == tb.ID_Ban && s.ID_Ban != s.TinhTrangBan).FirstOrDefault() == null)
            {
                return tb.ID_Ban;
            }
            else
            {
                return FindMainTable(dALQLNH.Bans.Where(s => s.TinhTrangBan == tb.ID_Ban && s.ID_Ban != s.TinhTrangBan).FirstOrDefault());
            }
        }
        public string GetAllMainTable(Ban tb, string txt)
        {
            if (dALQLNH.Bans.Where(s => s.TinhTrangBan == tb.ID_Ban && s.ID_Ban != s.TinhTrangBan).FirstOrDefault() == null)
            {
                return txt;
            }
            else
            {
                Ban bn = dALQLNH.Bans.Where(s => s.TinhTrangBan == tb.ID_Ban && s.ID_Ban != s.TinhTrangBan).FirstOrDefault();
                txt = txt + " " + bn.TenBan.ToString();
                return GetAllMainTable(bn, txt);
            }
        }

        public List<ChiTietBan> GetAllDetailTableByStatus(int st)
        {
            List<ChiTietBan> list = new List<ChiTietBan>();
            if (st == 3)
            {
                foreach (ChiTietBan i in dALQLNH.ChiTietBans)
                {
                    list.Add(i);
                }
            }
            else
            {
                foreach (ChiTietBan i in dALQLNH.ChiTietBans)
                {
                    if (i.TinhTrang == st)
                    {
                        list.Add(i);
                    }
                }
            }
            return list;
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
        public ChiTietBan GetDetailTableByID(int idctb)
        {
            return dALQLNH.ChiTietBans.Where(i => i.ID_ChiTietBan == idctb).FirstOrDefault();
        }
    }
}

