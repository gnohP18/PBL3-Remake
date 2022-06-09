using Entity;
using System.Data;
using System.Linq;
namespace BLL
{
    public class BLLQLNH : BLL
    {
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
        public bool checkLoginManager(string username, string password)
        {
            User user = (User)(dALQLNH.Users.Where(p => (p.ID_ChucVu == 1 && p.Username == username && p.Password == password)).FirstOrDefault());
            if (user == null) return false;
            else return true;
        }
        #region Lấy tất cả nguyên liệu,nguyên liệu trong kho qua ID_NguyenLieu, lấy qua ID_NguyenLieu,ID_LoaiNguyenLieu




        #endregion
    }
}
