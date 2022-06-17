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
        
        #region Lấy tất cả nguyên liệu,nguyên liệu trong kho qua ID_NguyenLieu, lấy qua ID_NguyenLieu,ID_LoaiNguyenLieu




        #endregion
    }
}
