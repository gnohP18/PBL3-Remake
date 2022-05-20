using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
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
            foreach (Ban i in GetAllBan())
            {
                if (i.TinhTrangBan.Equals(st) && i.Tang.Equals(fl))
                    dem++;
            }
            return dem;
        }

        public List<string> GetAllBanByTang(int fl)
        {
            List<string> data = new List<string>();
            foreach (Ban i in GetAllBan())
            {
                if (i.Tang.Equals(fl))
                    data.Add(i.ID_Ban.ToString());
            }
            return data;
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
        public List<string> LoadBanWithTinhTrangBanVaTang(bool st, int fl)
        {
            List<string> data = new List<string>();
            foreach (Ban i in GetAllBan())
            {
                if (i.TinhTrangBan.Equals(st) && i.Tang.Equals(fl))
                    data.Add(i.ID_Ban.ToString());
            }
            return data;
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
