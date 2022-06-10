using Entity;
using System;
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
        /*public int checkLogin(string username, string password, bool isCustomerLogin)
        {
            User user = (User)(dALQLNH.Users.Where(p => p.Username == username && p.Password == password).FirstOrDefault());
            if (user.ID_ChucVu == 1) return 1;
            if(isCustomerLogin == false && user.ID_ChucVu == 1) 
            if (user == null) return -1;
            if (user.ID_ChucVu != 3 && isCustomerLogin == true || user.ID_ChucVu != 2 && isCustomerLogin == false) return 0;
            if(isCustomerLogin == true)
            {
                ThongTinNhaHang thongTinNhaHang = dALQLNH.ThongTinNhaHangs.Find(1);
                int SangChieu = 0;
                char ThoiGianMuon = '0';
                if (DateTime.Now.TimeOfDay >= thongTinNhaHang.ThoiGianBatDauLamViecSang.TimeOfDay && DateTime.Now.TimeOfDay <= thongTinNhaHang.ThoiGianBatDauLamViecSang.TimeOfDay)
                {
                    if((DateTime.Now.TimeOfDay - thongTinNhaHang.ThoiGianBatDauLamViecSang.TimeOfDay) < new TimeSpan(0, 10, 0))
                    {
                        ThoiGianMuon = '1';
                    }
                    else
                    {

                    }
                }
                else if ()
                    foreach (ChiTietCaLam i in user.ChiTietCaLams)
                    {
                        if (i.CaLam.LichCaLam[])
                }
            }
            
        }*/
        #region Lấy tất cả nguyên liệu,nguyên liệu trong kho qua ID_NguyenLieu, lấy qua ID_NguyenLieu,ID_LoaiNguyenLieu




        #endregion
    }
}
