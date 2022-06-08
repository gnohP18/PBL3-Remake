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
        public Dictionary<int, float> GetThongTinLuongNguyenLieuHienTai()
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
        public void UpdateTrangThaiMonAn(Dictionary<int, float> listThongTinLuongNguyenLieu, List<MonAn_View> ListMonAnViewLayRa = null)
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
        public NguyenLieu GetNguyenLieuByTenNguyenLieu(string name)
        {
            return dALQLNH.NguyenLieus.Where(p => p.TenNguyenLieu == name).FirstOrDefault();
        }
        public int GetNewIDMonAn()
        {
            int ID = 1;
            foreach (MonAn i in dALQLNH.MonAns)
            {
                if (ID != i.ID_MonAn)
                {
                    return ID;
                }
                ID++;
            }
            return ID;
        }
        public void AddNewMonAn(List<ChiTietNhapMonAn_View> lt, string TenMonAn, int ID_LoaiMonAn, int thanhtien, Byte[] img)
        {
            MonAn mon = new MonAn();
            mon.ID_MonAn = GetNewIDMonAn();
            mon.ID_LoaiMonAn = ID_LoaiMonAn;
            mon.TenMonAn = TenMonAn;
            mon.ThanhTien = thanhtien;
            mon.AnhMonAn = img;
            mon.TrangThai = 0;
            dALQLNH.MonAns.Add(mon);
            dALQLNH.SaveChanges();
            foreach (ChiTietNhapMonAn_View i in lt)
            {
                dALQLNH.ChiTietMonAns.Add(new ChiTietMonAn
                {
                    ID_MonAn = mon.ID_MonAn,
                    ID_NguyenLieu = i.ID_NguyenLieu,
                    Luong = i.Luong,
                });
                dALQLNH.SaveChanges();
            }
        }
        public List<User> GetAllUser()
        {
            return dALQLNH.Users.ToList();
        }
        public int GetNumberOfOrdered(DateTime Datecustom)
        {
            int dem = 0;
            foreach (HoaDon i in dALQLNH.HoaDons)
            {
                if (i.NgayLap == Datecustom)
                {
                    dem++;
                }
            }
            return dem;
        }
        public ChiTietNhaCungCap GetPriceOfInGredientByIDInGredient(int ID_NguyenLieu)
        {
            return dALQLNH.ChiTietNhaCungCaps.Where(p => p.ID_NguyenLieu == ID_NguyenLieu).FirstOrDefault();
        }
        public int GetTotal(DateTime Datecustom)
        {
            int total = 0;
            foreach (HoaDon i in dALQLNH.HoaDons)
            {
                if (i.NgayLap == Datecustom)
                {
                    total += i.TongTien;
                }
            }
            return total;
        }
        public int GetProfit(DateTime Datecustom)
        {
            int spend = 0;
            foreach (Kho i in dALQLNH.Khoes)
            {
                if (i.NgayNhap == Datecustom)
                {
                    if (GetPriceOfInGredientByIDInGredient(i.ID_NguyenLieu) != null)
                        spend = spend + (int)(i.LuongNhapVao * GetPriceOfInGredientByIDInGredient(i.ID_NguyenLieu).DonGia);
                }
            }
            return GetTotal(Datecustom) - spend;
        }
        public int GetTotal(string Datecustom)
        {
            int total = 0;
            foreach (HoaDon i in dALQLNH.HoaDons)
            {
                if (i.NgayLap.ToShortDateString() == Datecustom)
                {
                    total += i.TongTien;
                }
            }
            return total;
        }
        public int GetProfit(string Datecustom)
        {
            int spend = 0;
            foreach (Kho i in dALQLNH.Khoes)
            {
                if (i.NgayNhap.ToShortDateString() == Datecustom)
                {
                    if (GetPriceOfInGredientByIDInGredient(i.ID_NguyenLieu) != null)
                        spend = spend + (int)(i.LuongNhapVao * GetPriceOfInGredientByIDInGredient(i.ID_NguyenLieu).DonGia);
                }
            }
            return GetTotal(Datecustom) - spend;
        }
        public List<Statistic_view> GetAllDoanhThu()
        {
            List<string> date = new List<string>();
            List<Statistic_view> liststatistic = new List<Statistic_view>();
            foreach (HoaDon i in dALQLNH.HoaDons)
            {
                date.Add(i.NgayLap.ToShortDateString());
            }
            int Songay = date.Distinct().Count();
            for (int i = 0; i < Songay; i++)
            {
                Statistic_view st = new Statistic_view();
                st.ID_money = i;
                st.Total = GetTotal(date[i]);
                st.Profit = GetProfit(date[i]);
                st.Consuming = st.Total - st.Profit;
                st.Date = Convert.ToDateTime(date[i]);
                liststatistic.Add(st);
            }
            return liststatistic;
        }
        public List<HoaDon> GetHoaDonByNgay(DateTime dt)
        {
            List<HoaDon> hd = new List<HoaDon>();
            foreach (HoaDon i in dALQLNH.HoaDons)
            {
                if (dt == i.NgayLap) hd.Add(i);
            }
            return hd;
        }
        public List<ChiTietHoaDon> GetAllChiTietHoaDonByIDHoaDon(int id)
        {
            List<ChiTietHoaDon> list = new List<ChiTietHoaDon>();
            foreach (ChiTietHoaDon i in dALQLNH.ChiTietHoaDons)
            {
                if (i.ID_HoaDon == id)
                {
                    list.Add(i);
                }
            }
            return list;
        }
    }
}
