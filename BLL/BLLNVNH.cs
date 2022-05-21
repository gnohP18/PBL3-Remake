using Entity;
using System.Collections.Generic;
using System.Linq;
namespace BLL
{
    public class BLLNVNH
    {
        private DALQLNH dALQLNH;
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
            dALQLNH = new DALQLNH();
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
        public int NumberOfKindDish(int idloaimonan)
        {
            return dALQLNH.MonAns.Where(p => p.ID_LoaiMonAn == idloaimonan).Count();
        }
        public List<MonAn> GetAllDishByIDKindOfDish(int idloaimonan)
        {
            return dALQLNH.MonAns.Where(p => p.ID_LoaiMonAn == idloaimonan).ToList();
        }
        public List<MonAn_View> GetListMonAnByIDBan(int ID_Ban)
        {
            List<MonAn_View> data = new List<MonAn_View>();
            var groupMonAn = dALQLNH.ChiTietBans.GroupBy(s => s.ID_Ban).Where(g => g.Key == ID_Ban);
            foreach(ChiTietBan i in groupMonAn)
            {
                MonAn monAn =dALQLNH.MonAns.Find(i.ID_MonAn);
                foreach(MonAn_View j in data)
                {
                    if(j.TenMonAn == monAn.TenMonAn)
                    {
                        j.SoLuong++;
                        j.ThanhTien += monAn.ThanhTien;
                        continue;
                    }
                    data.Add(new MonAn_View { TenMonAn = monAn.TenMonAn, SoLuong = 1, ThanhTien = monAn.ThanhTien });
                }
            }
            return data;
        }
    }
}
