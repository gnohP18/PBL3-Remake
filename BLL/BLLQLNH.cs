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

