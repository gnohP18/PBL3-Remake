using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class ThongKeBLL : BLL
    {
        private static ThongKeBLL _Instance;
        public static ThongKeBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new ThongKeBLL();
                return _Instance;
            }
            private set { }
        }
        private ThongKeBLL()
        {

        }
        public ChiTietNhaCungCap GetPriceOfInGredientByIDInGredient(int ID_NguyenLieu)
        {
            return dALQLNH.ChiTietNhaCungCaps.Where(p => p.ID_NguyenLieu == ID_NguyenLieu).FirstOrDefault();
        }
        public int GetNumberOfOrdered(DateTime Datecustom)
        {
            int dem = 0;
            foreach (HoaDon i in dALQLNH.HoaDons)
            {
                if (i.NgayLap >= Datecustom && i.NgayLap <= Datecustom.AddDays(1))
                {
                    dem++;
                }
            }
            return dem;
        }
        public int GetTotalRevenue(DateTime Datecustom)
        {
            int total = 0;
            foreach (HoaDon i in dALQLNH.HoaDons)
            {
                if (i.NgayLap >= Datecustom && i.NgayLap <= Datecustom.AddDays(1))
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
                if (i.NgayNhap >= Datecustom && i.NgayNhap <= Datecustom.AddDays(1))
                {
                    if (GetPriceOfInGredientByIDInGredient(i.ID_NguyenLieu) != null)
                        spend = spend + (int)(i.LuongNhapVao * GetPriceOfInGredientByIDInGredient(i.ID_NguyenLieu).DonGia);
                }
            }
            return GetTotalRevenue(Datecustom) - spend;
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
            date = date.Distinct().ToList();
            for (int i = 0; i < date.Count; i++)
            {
                Statistic_view st = new Statistic_view();
                st.ID_money = i;
                st.TotalRevenue = GetTotal(date[i]);
                st.Profit = GetProfit(date[i]);
                st.Consuming = st.TotalRevenue - st.Profit;
                st.Date = Convert.ToDateTime(date[i]);
                liststatistic.Add(st);
            }
            return liststatistic;
        }
        public List<BangChamCong> GetAllEmployeeHasTimeSheetByDateMonth(DateTime month)
        {
            List<BangChamCong> listuser = new List<BangChamCong>();
            foreach (BangChamCong i in dALQLNH.BangChamCongs)
            {
                if (i.NgayDauTienTinhCong.Month == month.Month)
                {
                    listuser.Add(i);
                }
            }
            return listuser;
        }
        public int GetTotalSalaryByDateMonth(List<BangChamCong> ListTimeSheet)
        {
            int TotalSalary = 0;
            foreach (BangChamCong i in ListTimeSheet)
            {
                TotalSalary += i.TinhLuong;
            }
            return TotalSalary;
        }
    }
}
