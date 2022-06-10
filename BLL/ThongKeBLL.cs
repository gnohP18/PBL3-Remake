using Entity;
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
                if (i.NgayLap == Datecustom)
                {
                    dem++;
                }
            }
            return dem;
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
    }
}
