using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BLL
{
    public class BLL
    {
        protected DALQLNH dALQLNH;
        protected BLL()
        {
            dALQLNH = new DALQLNH();
        }
        public Dictionary<int,float> GetThongTinLuongNguyenLieuHienTai()
        {
            Dictionary<int, float> listThongTinLuongNguyenLieu = new Dictionary<int, float>();
            foreach (NguyenLieu i in dALQLNH.NguyenLieus)
            {
                listThongTinLuongNguyenLieu.Add(i.ID_NguyenLieu, 0);
            }
            var parentGroupKho = dALQLNH.Khoes.GroupBy(s => s.ID_NguyenLieu);
            foreach (var childGroupKho in parentGroupKho)
            {
                int ID_NguyenLieu = childGroupKho.Key;
                foreach (Kho i in childGroupKho)
                {
                    if (i.NgayHetHan > DateTime.Now)
                    {
                        listThongTinLuongNguyenLieu[ID_NguyenLieu] += i.LuongTonKho;
                    }
                }
            }
            return listThongTinLuongNguyenLieu;
        }
        public void UpdateTrangThaiMonAn( Dictionary<int,float> listThongTinLuongNguyenLieu , List<MonAn_View> ListMonAnViewLayRa = null)
        {
            if (ListMonAnViewLayRa == null || ListMonAnViewLayRa.Count == 0)
            {
                var parentGroupCTMA = dALQLNH.ChiTietMonAns.GroupBy(s => s.ID_MonAn);
                foreach (var childGroupCTMA in parentGroupCTMA)
                {
                    MonAn monAn = dALQLNH.MonAns.Find(childGroupCTMA.Key);
                    foreach (ChiTietMonAn i in childGroupCTMA)
                    {
                        if (i.Luong > listThongTinLuongNguyenLieu[i.ID_NguyenLieu])
                        {
                            monAn.TrangThai = 0;
                            break;
                        }
                        monAn.TrangThai = 1;
                    }
                }

            }
            else
            {
                foreach (MonAn_View monAn_View in ListMonAnViewLayRa)
                {
                    List<ChiTietMonAn> list = dALQLNH.ChiTietMonAns.Where(s => s.ID_MonAn == monAn_View.ID_MonAn).ToList();
                    foreach (ChiTietMonAn i in list)
                    {
                        listThongTinLuongNguyenLieu[i.ID_NguyenLieu] -= i.Luong * monAn_View.SoLuong;
                    }
                }
                UpdateTrangThaiMonAn(listThongTinLuongNguyenLieu);
            }
            dALQLNH.SaveChanges();
        }
        public int checkLoginCustomer(string username, string password)
        {
            User user = (User)dALQLNH.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
            if (user == null) return -1;
            if (user.ID_ChucVu == 1) return 1;
            if (user.ID_ChucVu == 2) return -2;
            if (user.ID_ChucVu == 3)
            {
                int dateNowHashCode = DateTime.Now.GetHashCode();
                List<ChiTietCaLam> listChiTietCaLam = dALQLNH.ChiTietCaLams.Where(s => s.ID_User == user.ID_User).ToList();
                List<string> strCaLam = new List<string>();
                foreach (ChiTietCaLam i in listChiTietCaLam)
                {
                    strCaLam.Add(dALQLNH.CaLams.Find(i.ID_CaLam).LichCaLam);
                }
                foreach (string i in strCaLam)
                {

                }
            }
            return 1;
        }
        public List<MonAn> GetAllMonAn()
        {
            return dALQLNH.MonAns.ToList();
        }
    }
}
