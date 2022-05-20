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
                new ChucVu{ID_ChucVu = 1,TenChucVu ="Nhan vien",MoTa = "Phuc vu, ban hang va nhap kho",HeSoLuong = 100000},
                new ChucVu{ID_ChucVu = 2,TenChucVu ="Quan ly", MoTa = "Quan ly , toan quyen su dung phan mem",HeSoLuong = 0},
                new ChucVu{ID_ChucVu = 3,TenChucVu ="Admin",MoTa = "Quyen han toi thuong",HeSoLuong = 100000},
            });
            context.CaLams.AddRange(new CaLam[]
            {
                new CaLam{ID_CaLam = 1,LichCaLam = "10001000100000"},
                new CaLam{ID_CaLam = 2,LichCaLam = "01000100010000"},
                new CaLam{ID_CaLam = 3,LichCaLam = "00100010001000"},
                new CaLam{ID_CaLam = 4,LichCaLam = "00010001000100"},
                new CaLam{ID_CaLam = 5,LichCaLam = "00000000000011"},
            });
            System.Drawing.Image img = System.Drawing.Image.FromFile("E:\\PBL3-Remake\\PBL3-Remake\\Resources\\Webp.net-resizeimage (1).jpg");
            var ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            byte[] imgbyte = ms.ToArray();
            context.Users.AddRange(new User[]
            {
                new User{ID_User = 1,ID_ChucVu = 1,TenUser = "Dinh Quang Hiep",NgaySinh = new DateTime(2002,09,21),AnhUser =imgbyte,DiaChi ="DaNa",CMND_CCCD="201869370",Username="nhanvien",Password="123",NgayBatDauLam=new DateTime(2020,09,21)},
                new User{ID_User = 2,ID_ChucVu = 2,TenUser = "Nhi",NgaySinh = new DateTime(2002,06,13),AnhUser =imgbyte,DiaChi ="DaNa",CMND_CCCD="201869370",Username="admin",Password="123",NgayBatDauLam=new DateTime(2020,09,21)},
                new User{ID_User = 3,ID_ChucVu = 3,TenUser = "Nguyen Hoang Phong",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="QNa",CMND_CCCD="206337515",Username="admin",Password="123",NgayBatDauLam=new DateTime(2020,09,21)},
                new User{ID_User = 4,ID_ChucVu = 1,TenUser = "Nguyen Hoang Vu",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="QNa",CMND_CCCD="22345678",Username="user",Password="123",NgayBatDauLam=new DateTime(2020,09,21)},
                new User{ID_User = 5,ID_ChucVu = 1,TenUser = "Nguyen Xuan Hung",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="Hue",CMND_CCCD="22345678",Username="user",Password="123",NgayBatDauLam=new DateTime(2020,09,21)},
                new User{ID_User = 6,ID_ChucVu = 1,TenUser = "Nguyen Van Vien",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="QNa",CMND_CCCD="22345678",Username="user",Password="123",NgayBatDauLam=new DateTime(2020,09,21)},
                new User{ID_User = 7,ID_ChucVu = 1,TenUser = "Pham Van Tien Truong",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="NiBih",CMND_CCCD="22345678",Username="user",Password="123",NgayBatDauLam=new DateTime(2020,09,21)},
                new User{ID_User = 8,ID_ChucVu = 1,TenUser = "Tran Van Hai",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="QNa",CMND_CCCD="22345678",Username="user",Password="123",NgayBatDauLam=new DateTime(2020,09,21)},
                new User{ID_User = 9,ID_ChucVu = 1,TenUser = "Pham Cong Huy",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="HaNoi",CMND_CCCD="22345678",Username="user",Password="123",NgayBatDauLam=new DateTime(2020,09,21)},
                new User{ID_User = 10,ID_ChucVu = 1,TenUser = "Truong Tuan Kiet",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="HCM",CMND_CCCD="22345678",Username="user",Password="123",NgayBatDauLam=new DateTime(2020,09,21)},
                new User{ID_User = 11,ID_ChucVu = 1,TenUser = "Nguyen Dac Duc",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="NgheAn",CMND_CCCD="22345678",Username="user",Password="123",NgayBatDauLam=new DateTime(2020,09,21)},
                new User{ID_User = 12,ID_ChucVu = 1,TenUser = "Tran Kim Quy",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="QNa",CMND_CCCD="22345678",Username="user",Password="123",NgayBatDauLam=new DateTime(2020,09,21)},
                new User{ID_User = 13,ID_ChucVu = 1,TenUser = "Ho Thuy Tien",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="DaNa",CMND_CCCD="22345678",Username="user",Password="123",NgayBatDauLam=new DateTime(2020,09,21)},
                new User{ID_User = 14,ID_ChucVu = 1,TenUser = "Do Thi Nho",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="QNgai",CMND_CCCD="22345678",Username="user",Password="123",NgayBatDauLam=new DateTime(2020,09,21)},
                new User{ID_User = 15,ID_ChucVu = 1,TenUser = "Ho Dac Nguyen Minh",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="Hue",CMND_CCCD="22345678",Username="user",Password="123",NgayBatDauLam=new DateTime(2020,09,21)},
                new User{ID_User = 16,ID_ChucVu = 1,TenUser = "Nguyen Thi Minh Nguyet",NgaySinh = new DateTime(2002,04,18),AnhUser =imgbyte,DiaChi ="Dac Lac",CMND_CCCD="22345678",Username="user",Password="123",NgayBatDauLam=new DateTime(2020,09,21)},



            });
            context.BangChamCongs.AddRange(new BangChamCong[]
            {
                new BangChamCong{ID_BangChamCong = 1,ID_User=1,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,09,21) },
                new BangChamCong{ID_BangChamCong = 1,ID_User=2,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,09,21) },
                new BangChamCong{ID_BangChamCong = 1,ID_User=3,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,09,21) },
                new BangChamCong{ID_BangChamCong = 1,ID_User=4,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,09,21) },
                new BangChamCong{ID_BangChamCong = 1,ID_User=5,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,09,21) },
                new BangChamCong{ID_BangChamCong = 1,ID_User=6,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,09,21) },
                new BangChamCong{ID_BangChamCong = 1,ID_User=7,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,09,21) },
                new BangChamCong{ID_BangChamCong = 1,ID_User=8,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,09,21) },
                new BangChamCong{ID_BangChamCong = 1,ID_User=9,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,09,21) },
                new BangChamCong{ID_BangChamCong = 1,ID_User=10,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,09,21) },
                new BangChamCong{ID_BangChamCong = 1,ID_User=11,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,09,21) },
                new BangChamCong{ID_BangChamCong = 1,ID_User=12,LichSuLamViec ="1000100000010000",NgayDauTienTinhCong = new DateTime(2020,09,21) },
            });
            context.MonAns.AddRange(new MonAn[]
            {
                new MonAn{ID_MonAn = 1,TenMonAn = "Ech xao",ThanhTien =100000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 2,TenMonAn = "Bo xao",ThanhTien =120000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 3,TenMonAn = "Long xao nghe",ThanhTien =70000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 4,TenMonAn = "Lau nam",ThanhTien =150000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 5,TenMonAn = "Ga nuong",ThanhTien =120000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 6,TenMonAn = "Bo nuong la lot",ThanhTien =130000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 7,TenMonAn = "Trung cut lon xao me",ThanhTien =80000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 8,TenMonAn = "Banh trang tron",ThanhTien =12000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 9,TenMonAn = "Ga xe",ThanhTien =110000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 10,TenMonAn = "Ga um cu chuoi",ThanhTien =135000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 11,TenMonAn = "Bo um mang",ThanhTien =100000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 12,TenMonAn = "ca loc um chuoi",ThanhTien =120000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 13,TenMonAn = "Lau ca loc",ThanhTien =150000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 14,TenMonAn = "Lau thai",ThanhTien =150000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 15,TenMonAn = "pepsi",ThanhTien =10000,AnhMonAn = imgbyte},
                new MonAn{ID_MonAn = 16,TenMonAn = "cocacola",ThanhTien =10000,AnhMonAn = imgbyte},

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
                new Ban{ID_Ban = 1,TenBan = "Ban 1",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 2,TenBan = "Ban 2",Tang = 1,TinhTrangBan =1},
                new Ban{ID_Ban = 3,TenBan = "Ban 3",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 4,TenBan = "Ban 4",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 5,TenBan = "Ban 5",Tang = 1,TinhTrangBan =1},
                new Ban{ID_Ban = 6,TenBan = "Ban 1",Tang = 1,TinhTrangBan =1},
                new Ban{ID_Ban = 7,TenBan = "Ban 2",Tang = 1,TinhTrangBan =1},
                new Ban{ID_Ban = 8,TenBan = "Ban 3",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 9,TenBan = "Ban 4",Tang = 1,TinhTrangBan =1},
                new Ban{ID_Ban = 10,TenBan = "Ban 5",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 11,TenBan = "Ban 1",Tang = 1,TinhTrangBan =1},
                new Ban{ID_Ban = 12,TenBan = "Ban 2",Tang = 1,TinhTrangBan =1},
                new Ban{ID_Ban = 13,TenBan = "Ban 3",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 14,TenBan = "Ban 4",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 15,TenBan = "Ban 5",Tang = 1,TinhTrangBan =1},
                new Ban{ID_Ban = 16,TenBan = "Ban 1",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 17,TenBan = "Ban 2",Tang = 1,TinhTrangBan =1},
                new Ban{ID_Ban = 18,TenBan = "Ban 3",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 19,TenBan = "Ban 4",Tang = 1,TinhTrangBan =1},
                new Ban{ID_Ban = 20,TenBan = "Ban 5",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 1,TenBan = "Ban 1",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 2,TenBan = "Ban 2",Tang = 2,TinhTrangBan =1},
                new Ban{ID_Ban = 3,TenBan = "Ban 3",Tang = 2,TinhTrangBan =1},
                new Ban{ID_Ban = 4,TenBan = "Ban 4",Tang = 2,TinhTrangBan =1},
                new Ban{ID_Ban = 5,TenBan = "Ban 5",Tang = 2,TinhTrangBan =1},
                new Ban{ID_Ban = 6,TenBan = "Ban 1",Tang = 2,TinhTrangBan =1},
                new Ban{ID_Ban = 7,TenBan = "Ban 2",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 8,TenBan = "Ban 3",Tang = 2,TinhTrangBan =1},
                new Ban{ID_Ban = 9,TenBan = "Ban 4",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 10,TenBan = "Ban 5",Tang = 2,TinhTrangBan =1},
                new Ban{ID_Ban = 11,TenBan = "Ban 1",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 12,TenBan = "Ban 2",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 13,TenBan = "Ban 3",Tang = 2,TinhTrangBan =1},
                new Ban{ID_Ban = 14,TenBan = "Ban 4",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 15,TenBan = "Ban 5",Tang = 2,TinhTrangBan =1},
                new Ban{ID_Ban = 16,TenBan = "Ban 1",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 17,TenBan = "Ban 2",Tang = 2,TinhTrangBan =1},
                new Ban{ID_Ban = 18,TenBan = "Ban 3",Tang = 2,TinhTrangBan =1},
                new Ban{ID_Ban = 19,TenBan = "Ban 4",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 20,TenBan = "Ban 5",Tang = 2,TinhTrangBan =1},
                new Ban{ID_Ban = 21,TenBan = "Ban 1",Tang = 2,TinhTrangBan =0},
                new Ban{ID_Ban = 22,TenBan = "Ban 2",Tang = 2,TinhTrangBan =1},
                new Ban{ID_Ban = 23,TenBan = "Ban 3",Tang = 2,TinhTrangBan =1},
                new Ban{ID_Ban = 24,TenBan = "Ban 4",Tang = 2,TinhTrangBan =1},
                new Ban{ID_Ban = 25,TenBan = "Ban 5",Tang = 2,TinhTrangBan =0},
            });
            context.ChiTietBans.AddRange(new ChiTietBan[]
            {

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
