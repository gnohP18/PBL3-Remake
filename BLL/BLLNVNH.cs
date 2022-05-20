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
            int ttb = 0;
            if (st)
                return dALQLNH.Bans.Where(p => (p.Tang == fl && p.TinhTrangBan != 0)).ToList();
            else
                return dALQLNH.Bans.Where(p => (p.Tang == fl && p.TinhTrangBan == 0)).ToList();
        }
        public Ban GetAllBanByID_Ban(int id)
        {
            Ban table = null;
            foreach (Ban i in GetAllBan())
            {
                if (i.ID_Ban == id)
                {
                    table = i;
                    break;
                }
            }
            return table;
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
    }
}
