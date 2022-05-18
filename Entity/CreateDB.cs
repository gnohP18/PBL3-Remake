using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entity
{
    public class CreateDB : DropCreateDatabaseAlways<DALQLNH>
    {
        protected override void Seed(DALQLNH context)
        {
            context.ChucVus.AddRange(new ChucVu[]
            {
                new ChucVu{ID_ChucVu = 1,TenChucVu ="Nhan vien",MoTa = "Phuc vu, ban hang va nhap kho",HeSoLuong = 100000},
                new ChucVu{ID_ChucVu = 2,TenChucVu ="Quan ly", MoTa = "Quan ly , toan quyen su dung phan mem",HeSoLuong = 0}
            });
            context.CaLams.AddRange(new CaLam[]
            {
                new CaLam{ID_CaLam = 1,LichCaLam = "10001000100000"},
                new CaLam{ID_CaLam = 2,LichCaLam = "01000100010000"},
                new CaLam{ID_CaLam = 3,LichCaLam = "00100010001000"},
                new CaLam{ID_CaLam = 4,LichCaLam = "00010001000100"},
                new CaLam{ID_CaLam = 5,LichCaLam = "00000000000011"},
            });
            System.Drawing.Image img = System.Drawing.Image.FromFile("C:\\Users\\quang\\Desktop\\PBL3\\QuanLyNhaHang-QuanNhau-master\\GUI\\Resources\\Ramen, Kenny Vo.jpg");
            var ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            byte[] imgbyte = ms.ToArray();
            context.Users.AddRange(new User[]
            {
                new User{ID_User = 1,ID_ChucVu = 1,TenUser = "Dinh Quang Hiep",NgaySinh = new DateTime(2002,09,21),AnhUser =imgbyte,DiaChi ="DaNa",CMND_CCCD="201869370",Username="nhanvien",Password="123",NgayBatDauLam=new DateTime(2020,09,21)},
                new User{ID_User = 2,ID_ChucVu = 2,TenUser = "Nhi",NgaySinh = new DateTime(2002,06,13),AnhUser =imgbyte,DiaChi ="DaNa",CMND_CCCD="201869370",Username="admin",Password="123",NgayBatDauLam=new DateTime(2020,09,21)},
            });
            context.BangChamCongs.AddRange(new BangChamCong[]
            {
                new BangChamCong{ID_BangChamCong = 1,ID_User=1,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,09,21) },
            });
            context.MonAns.AddRange(new MonAn[]
            {
                new MonAn{ID_MonAn = 1,TenMonAn = "Ech xao",ThanhTien =100000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 2,TenMonAn = "Bo xao",ThanhTien =120000,AnhMonAn = imgbyte},
            });
            context.LoaiNguyenLieus.AddRange(new LoaiNguyenLieu[]
            {
                new LoaiNguyenLieu{ID_LoaiNguyenLieu = 1,TenLoaiNguyenLieu = ""},
                new LoaiNguyenLieu{ID_LoaiNguyenLieu = 2,TenLoaiNguyenLieu = ""},
                new LoaiNguyenLieu{ID_LoaiNguyenLieu = 3,TenLoaiNguyenLieu = ""},
                new LoaiNguyenLieu{ID_LoaiNguyenLieu = 4,TenLoaiNguyenLieu = ""},
            });
            context.NguyenLieus.AddRange(new NguyenLieu[]
            {
                new NguyenLieu{ID_NguyenLieu = 1,DonViTinh ="kg",TenNguyenLieu = "Thit bo",HSD=30,ID_LoaiNguyenLieu=1},
                new NguyenLieu{ID_NguyenLieu = 2,DonViTinh ="kg",TenNguyenLieu = "Thit ech",HSD=30,ID_LoaiNguyenLieu=1},
            });
            context.ChiTietMonAns.AddRange(new ChiTietMonAn[]
            {
                new ChiTietMonAn{ID_MonAn = 1,ID_NguyenLieu=2,Luong = 1},
                new ChiTietMonAn{ID_MonAn = 2,ID_NguyenLieu=1,Luong = 1},
            });
            context.Bans.AddRange(new Ban[]
            {
                new Ban{ID_Ban = 1,TenBan = "Ban 1",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 2,TenBan = "Ban 2",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 3,TenBan = "Ban 3",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 4,TenBan = "Ban 4",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 5,TenBan = "Ban 5",Tang = 2,TinhTrangBan =0},
            });
            context.ChiTietBans.AddRange(new ChiTietBan[]
            {
                
            });
            context.NhaCungCaps.AddRange(new NhaCungCap[]
            {
                new NhaCungCap{ID_NhaCungCap = 1,TenNhaCungCap = "Cho Dong Xuan",DiaChi = "Da Nang",MaSoThue = "2231",SoDienThoai="0921212233"},
                new NhaCungCap{ID_NhaCungCap = 2,TenNhaCungCap = "Cho Dong Da",DiaChi = "Da Nang",MaSoThue = "2232",SoDienThoai="0921212234"},

            });
            context.ChiTietNhaCungCaps.AddRange(new ChiTietNhaCungCap[]
            {
                new ChiTietNhaCungCap{ID_NguyenLieu = 1,ID_NhaCungCap = 1,DonGia = 70000},
                new ChiTietNhaCungCap{ID_NguyenLieu = 2,ID_NhaCungCap = 1,DonGia = 90000},
                new ChiTietNhaCungCap{ID_NguyenLieu = 1,ID_NhaCungCap = 2,DonGia = 75000},
            });
            context.Khoes.AddRange(new Kho[]
            {
                new Kho{ID_NguyenLieu = 1,ID_NhaCungCap = 1,NgayNhap = new DateTime(2020,06,13),NgayHetHan = new DateTime(2020,07,13),LuongNhapVao = 20,LuongTonKho = 20},
                new Kho{ID_NguyenLieu = 2,ID_NhaCungCap = 1,NgayNhap = new DateTime(2020,06,13),NgayHetHan = new DateTime(2020,07,13),LuongNhapVao = 30,LuongTonKho = 30},
            });
        }
    }
}
