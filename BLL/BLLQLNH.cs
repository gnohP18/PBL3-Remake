using Entity;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace BLL
{
    public class BLLQLNH
    {
        private DALQLNH dALQLNH;
        private static BLLQLNH _Instance;
        public static BLLQLNH Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLLQLNH();
                return _Instance;
            }
            private set { }
        }
        private BLLQLNH()
        {
            dALQLNH = new DALQLNH();
        }
        public List<NguyenLieu> GetAllNguyenLieu()
        {
            List<NguyenLieu> list = new List<NguyenLieu>();
            foreach (NguyenLieu i in dALQLNH.NguyenLieus)
            {
                list.Add(i);
            }
            return list;
        }

        public List<NguyenLieu> GetListNguyenLieuByIdLoaiNguyenLieu(int id)
        {
            List<NguyenLieu> list = new List<NguyenLieu>();
            foreach (NguyenLieu i in GetAllNguyenLieu())
            {
                if (i.ID_LoaiNguyenLieu == id)
                {
                    list.Add(i);
                }
            }
            return list;
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
        public List<ChiTietNhaCungCap> GetTT(int id)
        {
            List<ChiTietNhaCungCap> list = new List<ChiTietNhaCungCap>();
            DALQLNH dALQLNH = new DALQLNH();
            foreach (ChiTietNhaCungCap i in dALQLNH.ChiTietNhaCungCaps)
            {
                if (i.ID_NguyenLieu == id)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public bool checkLoginManager(string username, string password)
        {
            User user = (User)(dALQLNH.Users.Where(p => (p.ID_ChucVu == 1 && p.Username == username && p.Password == password)).FirstOrDefault());
            if (user == null) return false;
            else return true;
        }
    }
}

