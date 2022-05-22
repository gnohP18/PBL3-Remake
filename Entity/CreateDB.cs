using System;
using System.Data.Entity;
using System.IO;
namespace Entity
{
    public class CreateDB : DropCreateDatabaseAlways<DALQLNH>
    {
        protected override void Seed(DALQLNH context)
        {
            context.ChucVus.AddRange(new ChucVu[]
            {
                new ChucVu{ID_ChucVu = 1,TenChucVu ="Admin",MoTa = "Quyen han toi thuong",HeSoLuong = 0},
                new ChucVu{ID_ChucVu = 2,TenChucVu ="Quan ly", MoTa = "Quan ly doanh thu, nhap xuat nha hang",HeSoLuong = 0},
                new ChucVu{ID_ChucVu = 3,TenChucVu ="Nhan vien",MoTa = "Phuc vu, ban hang va nhap kho",HeSoLuong = 100000},
            });
            context.CaLams.AddRange(new CaLam[]
            {
                new CaLam{ID_CaLam = 1,LichCaLam = "00100010001000"},
                new CaLam{ID_CaLam = 2,LichCaLam = "00010001000100"},
                new CaLam{ID_CaLam = 3,LichCaLam = "00001000100010"},
                new CaLam{ID_CaLam = 4,LichCaLam = "00000100010001"},
                new CaLam{ID_CaLam = 5,LichCaLam = "11000000000000"},
            });
            System.Drawing.Image img = System.Drawing.Image.FromFile("C:\\Users\\quang\\Desktop\\PBL3\\PBL3-Remake\\PBL3-Remake\\Resources\\Webp.net-resizeimage (1).jpg");
            var ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            byte[] imgbyte = ms.ToArray();
            context.Users.AddRange(new User[]
            {
                new User{ID_User = 1,ID_ChucVu = 2,TenUser = "Dinh Quang Hiep",NgaySinh = new DateTime(2002,09,21),AnhUser =imgbyte,DiaChi ="DaNa",CMND_CCCD="201869370",Username="quanly",Password="123",NgayBatDauLam=new DateTime(2020,05,02)},
                new User{ID_User = 2,ID_ChucVu = 1,TenUser = "Nhi",NgaySinh = new DateTime(2002,06,13),AnhUser =imgbyte,DiaChi ="DaNa",CMND_CCCD="201869370",Username="admin",Password="123",NgayBatDauLam=new DateTime(2020,05,02)},
                new User{ID_User = 3,ID_ChucVu = 3,TenUser = "Nguyen Hoang Phong",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="QNa",CMND_CCCD="206337515",Username="admin",Password="123",NgayBatDauLam=new DateTime(2020,05,02)},
                new User{ID_User = 4,ID_ChucVu = 3,TenUser = "Nguyen Hoang Vu",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="QNa",CMND_CCCD="22345678",Username="user1",Password="123",NgayBatDauLam=new DateTime(2020,05,02)},
                new User{ID_User = 5,ID_ChucVu = 3,TenUser = "Nguyen Xuan Hung",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="Hue",CMND_CCCD="22345678",Username="user2",Password="123",NgayBatDauLam=new DateTime(2020,05,02)},
                new User{ID_User = 6,ID_ChucVu = 3,TenUser = "Nguyen Van Vien",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="QNa",CMND_CCCD="22345678",Username="user3",Password="123",NgayBatDauLam=new DateTime(2020,05,02)},
                new User{ID_User = 7,ID_ChucVu = 3,TenUser = "Pham Van Tien Truong",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="NiBih",CMND_CCCD="22345678",Username="user4",Password="123",NgayBatDauLam=new DateTime(2020,05,02)},
                new User{ID_User = 8,ID_ChucVu = 3,TenUser = "Tran Van Hai",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="QNa",CMND_CCCD="22345678",Username="user5",Password="123",NgayBatDauLam=new DateTime(2020,05,02)},
                new User{ID_User = 9,ID_ChucVu = 3,TenUser = "Pham Cong Huy",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="HaNoi",CMND_CCCD="22345678",Username="user6",Password="123",NgayBatDauLam=new DateTime(2020,05,02)},
                new User{ID_User = 10,ID_ChucVu = 3,TenUser = "Truong Tuan Kiet",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="HCM",CMND_CCCD="22345678",Username="user7",Password="123",NgayBatDauLam=new DateTime(2020,05,02)},
                new User{ID_User = 11,ID_ChucVu = 3,TenUser = "Nguyen Dac Duc",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="NgheAn",CMND_CCCD="22345678",Username="user8",Password="123",NgayBatDauLam=new DateTime(2020,05,02)},
                new User{ID_User = 12,ID_ChucVu = 3,TenUser = "Tran Kim Quy",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="QNa",CMND_CCCD="22345678",Username="user9",Password="123",NgayBatDauLam=new DateTime(2020,05,02)},
                new User{ID_User = 13,ID_ChucVu = 3,TenUser = "Ho Thuy Tien",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="DaNa",CMND_CCCD="22345678",Username="user10",Password="123",NgayBatDauLam=new DateTime(2020,05,02)},
                new User{ID_User = 14,ID_ChucVu = 3,TenUser = "Do Thi Nho",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="QNgai",CMND_CCCD="22345678",Username="user11",Password="123",NgayBatDauLam=new DateTime(2020,05,02)},
                new User{ID_User = 15,ID_ChucVu = 3,TenUser = "Ho Dac Nguyen Minh",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="Hue",CMND_CCCD="22345678",Username="user12",Password="123",NgayBatDauLam=new DateTime(2020,05,02)}
            });
            context.BangChamCongs.AddRange(new BangChamCong[]
            {
                new BangChamCong{ID_BangChamCong = 1,ID_User=1,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,05,02) },
                new BangChamCong{ID_BangChamCong = 2,ID_User=2,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,05,02) },
                new BangChamCong{ID_BangChamCong = 3,ID_User=3,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,05,02) },
                new BangChamCong{ID_BangChamCong = 4,ID_User=4,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,05,02) },
                new BangChamCong{ID_BangChamCong = 5,ID_User=5,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,05,02) },
                new BangChamCong{ID_BangChamCong = 6,ID_User=6,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,05,02) },
                new BangChamCong{ID_BangChamCong = 7,ID_User=7,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,05,02) },
                new BangChamCong{ID_BangChamCong = 8,ID_User=8,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,05,02) },
                new BangChamCong{ID_BangChamCong = 9,ID_User=9,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,05,02) },
                new BangChamCong{ID_BangChamCong = 10,ID_User=10,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,05,02) },
                new BangChamCong{ID_BangChamCong = 11,ID_User=11,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,05,02) },
                new BangChamCong{ID_BangChamCong = 12,ID_User=12,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,05,02) },
            });
            context.LoaiMonAns.AddRange(new LoaiMonAn[]
            {
                new LoaiMonAn{ID_LoaiMonAnh = 1,TenLoaiMonAn = "Khai vi"},
                new LoaiMonAn{ID_LoaiMonAnh = 2,TenLoaiMonAn = "Mon chinh"},
                new LoaiMonAn{ID_LoaiMonAnh = 3,TenLoaiMonAn = "Trang mieng"},
                new LoaiMonAn{ID_LoaiMonAnh = 4,TenLoaiMonAn = "Do uong"},
            });
            context.MonAns.AddRange(new MonAn[]
            {
                new MonAn{ID_MonAn = 1,ID_LoaiMonAn =2,TenMonAn = "Ech xao",ThanhTien =100000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 2,ID_LoaiMonAn =2,TenMonAn = "Bo xao",ThanhTien =120000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 3,ID_LoaiMonAn =2,TenMonAn = "Long xao nghe",ThanhTien =70000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 4,ID_LoaiMonAn =2,TenMonAn = "Lau nam",ThanhTien =150000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 5,ID_LoaiMonAn =2,TenMonAn = "Ga nuong",ThanhTien =120000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 6,ID_LoaiMonAn =2,TenMonAn = "Bo nuong la lot",ThanhTien =130000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 7,ID_LoaiMonAn =2,TenMonAn = "Trung cut lon xao me",ThanhTien =80000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 8,ID_LoaiMonAn =2,TenMonAn = "Banh trang tron",ThanhTien =12000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 9,ID_LoaiMonAn =2,TenMonAn = "Ga xe",ThanhTien =110000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 10,ID_LoaiMonAn =2,TenMonAn = "Ga um cu chuoi",ThanhTien =135000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 11,ID_LoaiMonAn =2,TenMonAn = "Bo um mang",ThanhTien =100000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 12,ID_LoaiMonAn =2,TenMonAn = "ca loc um chuoi",ThanhTien =120000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 13,ID_LoaiMonAn =2,TenMonAn = "Lau ca loc",ThanhTien =150000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 14,ID_LoaiMonAn =2,TenMonAn = "Lau thai",ThanhTien =150000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 15,ID_LoaiMonAn =4,TenMonAn = "pepsi",ThanhTien =10000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 16,ID_LoaiMonAn =4,TenMonAn = "cocacola",ThanhTien =10000,AnhMonAn = imgbyte},
                 new MonAn{ID_MonAn = 17,ID_LoaiMonAn =1,TenMonAn = "Rau tron",ThanhTien =100000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 18,ID_LoaiMonAn =1,TenMonAn = "Dau khuon",ThanhTien =120000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 19,ID_LoaiMonAn =1,TenMonAn = "Dau phung rang",ThanhTien =70000,AnhMonAn = imgbyte},
            });
            context.LoaiNguyenLieus.AddRange(new LoaiNguyenLieu[]
            {
                new LoaiNguyenLieu{ID_LoaiNguyenLieu = 1,TenLoaiNguyenLieu = "Thit tuoi song"},
                new LoaiNguyenLieu{ID_LoaiNguyenLieu = 2,TenLoaiNguyenLieu = "Rau cu "},
                new LoaiNguyenLieu{ID_LoaiNguyenLieu = 3,TenLoaiNguyenLieu = "Do kho"},
                new LoaiNguyenLieu{ID_LoaiNguyenLieu = 4,TenLoaiNguyenLieu = "Do uong"},
            });
            context.NguyenLieus.AddRange(new NguyenLieu[]
            {
                new NguyenLieu{ID_NguyenLieu = 1,DonViTinh ="kg",TenNguyenLieu = "Thit bo",HSD=60,ID_LoaiNguyenLieu=1},
                new NguyenLieu{ID_NguyenLieu = 2,DonViTinh ="kg",TenNguyenLieu = "Thit ga",HSD=60,ID_LoaiNguyenLieu=1},
                new NguyenLieu{ID_NguyenLieu = 3,DonViTinh ="kg",TenNguyenLieu = "Thit ech",HSD=60,ID_LoaiNguyenLieu=1},
                new NguyenLieu{ID_NguyenLieu = 4,DonViTinh ="kg",TenNguyenLieu = "Ca loc",HSD=7,ID_LoaiNguyenLieu=1},
                new NguyenLieu{ID_NguyenLieu = 5,DonViTinh ="kg",TenNguyenLieu = "Ca chua",HSD=7,ID_LoaiNguyenLieu=2},
                new NguyenLieu{ID_NguyenLieu = 6,DonViTinh ="kg",TenNguyenLieu = "Hanh tay",HSD=60,ID_LoaiNguyenLieu=2},
                new NguyenLieu{ID_NguyenLieu = 7,DonViTinh ="kg",TenNguyenLieu = "Hanh la",HSD=7,ID_LoaiNguyenLieu=2},
                new NguyenLieu{ID_NguyenLieu = 8,DonViTinh ="kg",TenNguyenLieu = "Nam rom",HSD=30,ID_LoaiNguyenLieu=2},
                new NguyenLieu{ID_NguyenLieu = 9,DonViTinh ="lon",TenNguyenLieu = "pepsi",HSD=365,ID_LoaiNguyenLieu=4},
                new NguyenLieu{ID_NguyenLieu = 10,DonViTinh ="kg",TenNguyenLieu = "Nam tai meo",HSD=120,ID_LoaiNguyenLieu=3},
                new NguyenLieu{ID_NguyenLieu = 11,DonViTinh ="kg",TenNguyenLieu = "Khoai tay",HSD=30,ID_LoaiNguyenLieu=2},
                new NguyenLieu{ID_NguyenLieu = 12,DonViTinh ="kg",TenNguyenLieu = "Bo lac",HSD=365,ID_LoaiNguyenLieu=3},
                new NguyenLieu{ID_NguyenLieu = 13,DonViTinh ="kg",TenNguyenLieu = "Bot mi",HSD=365,ID_LoaiNguyenLieu=3},
                new NguyenLieu{ID_NguyenLieu = 14,DonViTinh ="kg",TenNguyenLieu = "Toi",HSD=240,ID_LoaiNguyenLieu=3},
                new NguyenLieu{ID_NguyenLieu = 15,DonViTinh ="kg",TenNguyenLieu = "Me dot",HSD=240,ID_LoaiNguyenLieu=3},
                new NguyenLieu{ID_NguyenLieu = 16,DonViTinh ="lon",TenNguyenLieu = "coca",HSD=365,ID_LoaiNguyenLieu=4},
                new NguyenLieu{ID_NguyenLieu = 17,DonViTinh ="Chai",TenNguyenLieu = "aquafina",HSD=365,ID_LoaiNguyenLieu=4},
                new NguyenLieu{ID_NguyenLieu = 18,DonViTinh ="kg",TenNguyenLieu = "Rau thom",HSD=7,ID_LoaiNguyenLieu=2},
                new NguyenLieu{ID_NguyenLieu = 19,DonViTinh ="lon",TenNguyenLieu = "Tiger beer",HSD=365,ID_LoaiNguyenLieu=4},
                new NguyenLieu{ID_NguyenLieu = 20,DonViTinh ="lon",TenNguyenLieu = "Huda beer",HSD=365,ID_LoaiNguyenLieu=4},
                new NguyenLieu{ID_NguyenLieu = 21,DonViTinh ="kg",TenNguyenLieu = "Thit nai",HSD=60,ID_LoaiNguyenLieu=1},
                new NguyenLieu{ID_NguyenLieu = 22,DonViTinh ="kg",TenNguyenLieu = "Banh mi",HSD=2,ID_LoaiNguyenLieu=3},
                new NguyenLieu{ID_NguyenLieu = 23,DonViTinh ="Qua",TenNguyenLieu = "Trung ga",HSD=60,ID_LoaiNguyenLieu=3},
                new NguyenLieu{ID_NguyenLieu = 24,DonViTinh ="kg",TenNguyenLieu = "Banh trang",HSD=30,ID_LoaiNguyenLieu=3},

            });
            context.ChiTietMonAns.AddRange(new ChiTietMonAn[]
            {
                new ChiTietMonAn{ID_MonAn = 1,ID_NguyenLieu=2,Luong = 1},
                new ChiTietMonAn{ID_MonAn = 2,ID_NguyenLieu=1,Luong = 1},
                new ChiTietMonAn{ID_MonAn = 1,ID_NguyenLieu=6,Luong = 1},
                new ChiTietMonAn{ID_MonAn = 1,ID_NguyenLieu=7,Luong = 1},
                new ChiTietMonAn{ID_MonAn = 1,ID_NguyenLieu=14,Luong = 1},
                new ChiTietMonAn{ID_MonAn = 1,ID_NguyenLieu=5,Luong = 1},
                new ChiTietMonAn{ID_MonAn = 14,ID_NguyenLieu=10,Luong = 1},
                new ChiTietMonAn{ID_MonAn = 14,ID_NguyenLieu=14,Luong = 1},
                new ChiTietMonAn{ID_MonAn = 14,ID_NguyenLieu=18,Luong = 1},
                new ChiTietMonAn{ID_MonAn = 14,ID_NguyenLieu=23,Luong = 1},
                new ChiTietMonAn{ID_MonAn = 14,ID_NguyenLieu=4,Luong = 1},
                new ChiTietMonAn{ID_MonAn = 14,ID_NguyenLieu=8,Luong = 1},
            });
            context.Bans.AddRange(new Ban[]
            {
                new Ban{ID_Ban = 1,TenBan = "Ban T01-1",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 2,TenBan = "Ban T01-2",Tang = 1,TinhTrangBan =2},
                new Ban{ID_Ban = 3,TenBan = "Ban T01-3",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 4,TenBan = "Ban T01-4",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 5,TenBan = "Ban T01-5",Tang = 1,TinhTrangBan =5},
                new Ban{ID_Ban = 6,TenBan = "Ban T01-6",Tang = 1,TinhTrangBan =6},
                new Ban{ID_Ban = 7,TenBan = "Ban T01-7",Tang = 1,TinhTrangBan =7},
                new Ban{ID_Ban = 8,TenBan = "Ban T01-8",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 9,TenBan = "Ban T01-9",Tang = 1,TinhTrangBan =9},
                new Ban{ID_Ban = 10,TenBan = "Ban T01-10",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 11,TenBan = "Ban T01-11",Tang = 1,TinhTrangBan =11},
                new Ban{ID_Ban = 12,TenBan = "Ban T01-12",Tang = 1,TinhTrangBan =12},
                new Ban{ID_Ban = 13,TenBan = "Ban T01-13",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 14,TenBan = "Ban T01-14",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 15,TenBan = "Ban T01-15",Tang = 1,TinhTrangBan =15},
                new Ban{ID_Ban = 16,TenBan = "Ban T01-16",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 17,TenBan = "Ban T01-17",Tang = 1,TinhTrangBan =17},
                new Ban{ID_Ban = 18,TenBan = "Ban T01-18",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 19,TenBan = "Ban T01-19",Tang = 1,TinhTrangBan =19},
                new Ban{ID_Ban = 20,TenBan = "Ban T01-20",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 21,TenBan = "Ban T02-1",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 22,TenBan = "Ban T02-2",Tang = 2,TinhTrangBan =22},
                new Ban{ID_Ban = 23,TenBan = "Ban T02-3",Tang = 2,TinhTrangBan =23},
                new Ban{ID_Ban = 24,TenBan = "Ban T02-4",Tang = 2,TinhTrangBan =24},
                new Ban{ID_Ban = 25,TenBan = "Ban T02-5",Tang = 2,TinhTrangBan =25},
                new Ban{ID_Ban = 26,TenBan = "Ban T02-6",Tang = 2,TinhTrangBan =26},
                new Ban{ID_Ban = 27,TenBan = "Ban T02-7",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 28,TenBan = "Ban T02-8",Tang = 2,TinhTrangBan =28},
                new Ban{ID_Ban = 29,TenBan = "Ban T02-9",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 30,TenBan = "Ban T02-10",Tang = 2,TinhTrangBan =30},
                new Ban{ID_Ban = 31,TenBan = "Ban T02-11",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 32,TenBan = "Ban T02-12",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 33,TenBan = "Ban T02-13",Tang = 2,TinhTrangBan =33},
                new Ban{ID_Ban = 34,TenBan = "Ban T02-14",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 35,TenBan = "Ban T02-15",Tang = 2,TinhTrangBan =35},
                new Ban{ID_Ban = 36,TenBan = "Ban T02-16",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 37,TenBan = "Ban T02-17",Tang = 2,TinhTrangBan =37},
                new Ban{ID_Ban = 38,TenBan = "Ban T02-18",Tang = 2,TinhTrangBan =38},
                new Ban{ID_Ban = 39,TenBan = "Ban T02-19",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 40,TenBan = "Ban T02-20",Tang = 2,TinhTrangBan =40},
                new Ban{ID_Ban = 41,TenBan = "Ban T02-21",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 42,TenBan = "Ban T02-22",Tang = 2,TinhTrangBan =42},
                new Ban{ID_Ban = 43,TenBan = "Ban T02-23",Tang = 2,TinhTrangBan =43},
                new Ban{ID_Ban = 44,TenBan = "Ban T02-24",Tang = 2,TinhTrangBan =44},
                new Ban{ID_Ban = 45,TenBan = "Ban T02-25",Tang = 2,TinhTrangBan =0},
            });
            context.ChiTietBans.AddRange(new ChiTietBan[]
            {
                new ChiTietBan{ID_ChiTietBan = 1,ID_Ban =2,ID_MonAn = 1,TinhTrang=1,SoLuong = 2},
                new ChiTietBan{ID_ChiTietBan = 2,ID_Ban =2,ID_MonAn = 1,TinhTrang=1,SoLuong = 5},
                new ChiTietBan{ID_ChiTietBan = 3,ID_Ban =2,ID_MonAn = 16,TinhTrang=1,SoLuong = 2},
                new ChiTietBan{ID_ChiTietBan = 4,ID_Ban =5,ID_MonAn = 4,TinhTrang=1,SoLuong = 2},
                new ChiTietBan{ID_ChiTietBan = 5,ID_Ban =5,ID_MonAn = 5,TinhTrang=1,SoLuong = 2},
                new ChiTietBan{ID_ChiTietBan = 6,ID_Ban =5,ID_MonAn = 6,TinhTrang=1,SoLuong = 2},
                new ChiTietBan{ID_ChiTietBan = 7,ID_Ban =5,ID_MonAn = 16,TinhTrang=1,SoLuong = 10},
            });
            context.NhaCungCaps.AddRange(new NhaCungCap[]
            {
                new NhaCungCap{ID_NhaCungCap = 1,TenNhaCungCap = "Cho Dong Xuan",DiaChi = "Da Nang",MaSoThue = "2231",SoDienThoai="0921212233"},
                new NhaCungCap{ID_NhaCungCap = 2,TenNhaCungCap = "Cho Dong Da",DiaChi = "Da Nang",MaSoThue = "2232",SoDienThoai="0921212234"},
                new NhaCungCap{ID_NhaCungCap = 3,TenNhaCungCap = "Cho Thanh Khe",DiaChi = "Da Nang",MaSoThue = "2233",SoDienThoai="0921212234"},
                new NhaCungCap{ID_NhaCungCap = 4,TenNhaCungCap = "Cho Bac Mi An",DiaChi = "Da Nang",MaSoThue = "2234",SoDienThoai="0921212234"},
                new NhaCungCap{ID_NhaCungCap = 5,TenNhaCungCap = "Cho Tam ki",DiaChi = "Da Nang",MaSoThue = "2235",SoDienThoai="0921212234"},
                new NhaCungCap{ID_NhaCungCap = 6,TenNhaCungCap = "Cho Dong Anh",DiaChi = "Da Nang",MaSoThue = "2236",SoDienThoai="0921212234"},
                new NhaCungCap{ID_NhaCungCap = 7,TenNhaCungCap = "Cho Ba Ren",DiaChi = "Da Nang",MaSoThue = "2237",SoDienThoai="0921212234"},
                new NhaCungCap{ID_NhaCungCap = 8,TenNhaCungCap = "Cho Ke Xuyen",DiaChi = "Da Nang",MaSoThue = "2238",SoDienThoai="0921212234"},
                new NhaCungCap{ID_NhaCungCap = 9,TenNhaCungCap = "Cho Dau Moi",DiaChi = "Da Nang",MaSoThue = "2239",SoDienThoai="0921212234"},
                new NhaCungCap{ID_NhaCungCap = 10,TenNhaCungCap = "Cho Thang Binh",DiaChi = "Da Nang",MaSoThue = "2240",SoDienThoai="0921212234"},
                new NhaCungCap{ID_NhaCungCap = 11,TenNhaCungCap = "Cho Thac Gian",DiaChi = "Da Nang",MaSoThue = "2241",SoDienThoai="0921212234"},
                new NhaCungCap{ID_NhaCungCap = 12,TenNhaCungCap = "Cho Dac Nong",DiaChi = "Da Nang",MaSoThue = "2242",SoDienThoai="0921212234"},
                new NhaCungCap{ID_NhaCungCap = 13,TenNhaCungCap = "Cho Hoa Huong",DiaChi = "Da Nang",MaSoThue = "2243",SoDienThoai="0921212234"},
                new NhaCungCap{ID_NhaCungCap = 14,TenNhaCungCap = "Cho Quan Go",DiaChi = "Da Nang",MaSoThue = "2244",SoDienThoai="0921212234"},
                new NhaCungCap{ID_NhaCungCap = 15,TenNhaCungCap = "Cho Hoa Khanh",DiaChi = "Da Nang",MaSoThue = "2245",SoDienThoai="0921212234"},
            });
            context.ChiTietNhaCungCaps.AddRange(new ChiTietNhaCungCap[]
            {
                new ChiTietNhaCungCap{ID_NguyenLieu = 1,ID_NhaCungCap = 1,DonGia = 70000},
                new ChiTietNhaCungCap{ID_NguyenLieu = 2,ID_NhaCungCap = 1,DonGia = 90000},
                new ChiTietNhaCungCap{ID_NguyenLieu = 3,ID_NhaCungCap = 2,DonGia = 75000},
                new ChiTietNhaCungCap{ID_NguyenLieu = 4,ID_NhaCungCap = 3,DonGia = 7000},
                new ChiTietNhaCungCap{ID_NguyenLieu = 5,ID_NhaCungCap = 4,DonGia = 22000},
                new ChiTietNhaCungCap{ID_NguyenLieu = 6,ID_NhaCungCap = 5,DonGia = 33000},
                new ChiTietNhaCungCap{ID_NguyenLieu = 7,ID_NhaCungCap = 6,DonGia = 44000},
                new ChiTietNhaCungCap{ID_NguyenLieu = 8,ID_NhaCungCap = 7,DonGia = 55000},
                new ChiTietNhaCungCap{ID_NguyenLieu = 9,ID_NhaCungCap = 8,DonGia = 66000},
                new ChiTietNhaCungCap{ID_NguyenLieu = 10,ID_NhaCungCap = 9,DonGia = 77000},
            });
            context.Khoes.AddRange(new Kho[]
            {
                new Kho{ID_ChiTietNguyenLieu=1,ID_NguyenLieu = 1,ID_NhaCungCap = 1,NgayNhap = new DateTime(2022,05,19),NgayHetHan = new DateTime(2022,07,13),LuongNhapVao = 20,LuongTonKho = 20},
                new Kho{ID_ChiTietNguyenLieu=2,ID_NguyenLieu = 2,ID_NhaCungCap = 1,NgayNhap = new DateTime(2022,05,18),NgayHetHan = new DateTime(2022,07,13),LuongNhapVao = 30,LuongTonKho = 30},
                new Kho{ID_ChiTietNguyenLieu=3,ID_NguyenLieu = 1,ID_NhaCungCap = 1,NgayNhap = new DateTime(2022,05,17),NgayHetHan = new DateTime(2022,07,13),LuongNhapVao = 20,LuongTonKho = 20},
                new Kho{ID_ChiTietNguyenLieu=4,ID_NguyenLieu = 1,ID_NhaCungCap = 1,NgayNhap = new DateTime(2022,05,20),NgayHetHan = new DateTime(2022,07,13),LuongNhapVao = 20,LuongTonKho = 20},
                new Kho{ID_ChiTietNguyenLieu=5,ID_NguyenLieu = 3,ID_NhaCungCap = 2,NgayNhap = new DateTime(2022,05,19),NgayHetHan = new DateTime(2022,07,13),LuongNhapVao = 20,LuongTonKho = 20},
                new Kho{ID_ChiTietNguyenLieu=6,ID_NguyenLieu = 10,ID_NhaCungCap = 9,NgayNhap = new DateTime(2022,05,18),NgayHetHan = new DateTime(2022,07,13),LuongNhapVao = 30,LuongTonKho = 30},
                new Kho{ID_ChiTietNguyenLieu=7,ID_NguyenLieu = 9,ID_NhaCungCap = 8,NgayNhap = new DateTime(2022,05,17),NgayHetHan = new DateTime(2022,07,13),LuongNhapVao = 20,LuongTonKho = 20},
                new Kho{ID_ChiTietNguyenLieu=8,ID_NguyenLieu = 10,ID_NhaCungCap = 9,NgayNhap = new DateTime(2022,05,20),NgayHetHan = new DateTime(2022,07,13),LuongNhapVao = 20,LuongTonKho = 20},
            });
        }
    }
}
