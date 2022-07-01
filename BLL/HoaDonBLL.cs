using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BLL
{
    public class HoaDonBLL : BLL
    {
        private static HoaDonBLL _Instance;
        public static HoaDonBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new HoaDonBLL();
                return _Instance;
            }
            private set { }
        }
        private HoaDonBLL()
        {

        }
        public int GetTienFromDiemTichLuy(int Diem)
        {
            return dALQLNH.ThongTinNhaHangs.Find(1).DiemTichLuyQuyDoiThanhTien * Diem;
        }
        public List<HoaDon> GetAllHoaDonByIDKhachHang(int ID_KhachHang)
        {
            List<HoaDon> list = new List<HoaDon>();
            foreach (HoaDon i in dALQLNH.HoaDons)
            {
                if (i.ID_KhachHang == ID_KhachHang)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public List<HoaDon_View> GetAllInvoice_viewByDay(DateTime date)
        {
            List<HoaDon_View> list = new List<HoaDon_View>();
            foreach (HoaDon i in dALQLNH.HoaDons)
            {
                if (i.NgayLap >= date && i.NgayLap <= date.AddDays(1))
                {
                    HoaDon_View hdv = new HoaDon_View();
                    hdv.ID_HoaDon = i.ID_HoaDon;
                    hdv.TenNhanVien = NhanVienBLL.Instance.GetNhanVienByID(i.ID_User).TenUser;
                    hdv.TenKhachHang = KhachHangBLL.Instance.GetGuestByIDGuest(i.ID_KhachHang).TenKhachHang;
                    hdv.TienQuyDoiTuDiemTichLuy = i.TienQuyDoiTuDiemTichLuy;
                    hdv.NgayLap = i.NgayLap;
                    hdv.MaVoucher = i.MaVoucher;
                    hdv.TongTien = i.TongTien;
                    list.Add(hdv);
                }
            }
            return list;
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
        public List<HoaDon_View> GetHoaDonByFromDatetoDate(DateTime dateStart, DateTime dateEnd)
        {
            List<HoaDon_View> hoaDonviews = new List<HoaDon_View>();
            foreach (HoaDon i in dALQLNH.HoaDons.Where(s => s.NgayLap >= dateStart && s.NgayLap <= dateEnd))
            {
                hoaDonviews.Add(new HoaDon_View
                {
                    ID_HoaDon = i.ID_HoaDon,
                    NgayLap = i.NgayLap,
                    TenKhachHang = i.KhachHang.TenKhachHang,
                    TenNhanVien = i.User.TenUser,
                    MaVoucher = i.MaVoucher,
                    TienQuyDoiTuDiemTichLuy = i.TienQuyDoiTuDiemTichLuy,
                    TongTien = i.TongTien
                });
            }
            return hoaDonviews;
        }
        public List<ChiTietHoaDon_View> GetChiTietHoaDonByIDHoaDon(int id)
        {
            List<ChiTietHoaDon_View> list = new List<ChiTietHoaDon_View>();
            foreach (ChiTietHoaDon i in dALQLNH.HoaDons.Find(id).ChiTietHoaDons)
            {
                list.Add(new ChiTietHoaDon_View
                {
                    TenMonAn = i.MonAn.TenMonAn,
                    SoLuong = i.SoLuong,
                    ThanhTien = i.MonAn.ThanhTien * i.SoLuong
                });
            }
            return list;
        }
        public void AddNewDetailInvoice(int ID_Invoice, int ID_Dish, int Amount)
        {
            ChiTietHoaDon cthd = dALQLNH.ChiTietHoaDons.Create();
            cthd.ID_HoaDon = ID_Invoice;
            cthd.ID_MonAn = ID_Dish;
            cthd.SoLuong = Amount;
            dALQLNH.ChiTietHoaDons.Add(cthd);
            dALQLNH.SaveChanges();
        }
        public List<HoaDon> GetAllInvoice()
        {
            return dALQLNH.HoaDons.ToList();
        }
        public int GetNewIDHoaDon()
        {
            int id = 1;
            foreach (HoaDon i in dALQLNH.HoaDons)
            {
                if (id != i.ID_HoaDon)
                {
                    return id;
                }
                id++;
            }
            return id;
        }
        public void AddNewInvoice(HoaDon invoice, List<MonAn_View> list)
        {
            dALQLNH.HoaDons.Add(invoice);
            dALQLNH.Entry(invoice).Reference(s => s.Voucher).Load();
            dALQLNH.Entry(invoice).Reference(s => s.User).Load();
            dALQLNH.Entry(invoice).Reference(s => s.KhachHang).Load();
            dALQLNH.SaveChanges();
            foreach (MonAn_View i in list)
            {
                AddNewDetailInvoice(invoice.ID_HoaDon, i.ID_MonAn, i.SoLuong);
            }
        }
        public List<PrintReceipt_View> SetDataSetForReceipt(int ID_Table, int ID_invoice)
        {
            List<PrintReceipt_View> data = new List<PrintReceipt_View>();
            ThongTinNhaHang TTNH = dALQLNH.ThongTinNhaHangs.Find(1);
            foreach (ChiTietHoaDon i in dALQLNH.HoaDons.Find(ID_invoice).ChiTietHoaDons.ToList())
            {
                data.Add(new PrintReceipt_View
                {
                    ID_Table = ID_Table.ToString(),
                    Address = TTNH.DiaChi,
                    Dish_Name = i.MonAn.TenMonAn,
                    Name_Cashier = i.HoaDon.User.TenUser,
                    Amount = i.SoLuong.ToString(),
                    Date_Create = i.HoaDon.NgayLap.ToShortDateString(),
                    ID_Receipt = i.ID_HoaDon.ToString(),
                    Name_Restaurant = TTNH.TenNhaHang,
                    Name_Table = dALQLNH.Bans.Find(ID_Table).TenBan,
                    Total_Dish = i.SoLuong * i.MonAn.ThanhTien + "",
                    Total = i.HoaDon.TongTien + "",
                    MoneyConvertFormPoint = i.HoaDon.TienQuyDoiTuDiemTichLuy + "",
                    Voucher = i.HoaDon.MaVoucher,
                });
            }
            return data;
        }

    }
}
