﻿using Entity;
using System.Collections.Generic;
using System.Linq;
namespace BLL
{
    public class NguyenLieuBLL : BLL
    {
        private static NguyenLieuBLL _Instance;
        public static NguyenLieuBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new NguyenLieuBLL();
                return _Instance;
            }
            private set { }
        }
        private NguyenLieuBLL()
        {

        }
        public List<NguyenLieu> GetAllNguyenLieu()
        {
            List<NguyenLieu> list = new List<NguyenLieu>();
            foreach (NguyenLieu i in dALQLNH.NguyenLieus)
            {
                list.Add(i);
            }
            return list;
        }

        public List<ChiTietNguyenLieu_View> GetThongTinNguyenLieuTrongKho(int iD_NguyenLieu)
        {
            List<Kho> listChiTietNguyenLieu = dALQLNH.Khoes.Where(p => p.ID_NguyenLieu == iD_NguyenLieu).ToList();
            List<ChiTietNguyenLieu_View> data = new List<ChiTietNguyenLieu_View>();
            foreach (Kho i in listChiTietNguyenLieu)
            {
                data.Add(new ChiTietNguyenLieu_View { ID_ChiTietNguyenLieu = i.ID_ChiTietNguyenLieu, ID_NguyenLieu = i.ID_NguyenLieu, TenNguyenLieu = i.NguyenLieu.TenNguyenLieu, LuongTonKho = i.LuongTonKho, LuongNhapVao = i.LuongNhapVao, NgayNhap = i.NgayNhap, NgayHetHan = i.NgayHetHan, ID_NhaCungCap = i.ID_NhaCungCap });
            }
            return data;
        }
        public List<ChiTietNguyenLieu_View> GetAllNguyenLieuTrongKho()
        {
            List<Kho> listChiTietNguyenLieu = dALQLNH.Khoes.ToList();
            List<ChiTietNguyenLieu_View> data = new List<ChiTietNguyenLieu_View>();
            foreach (Kho i in listChiTietNguyenLieu)
            {
                data.Add(new ChiTietNguyenLieu_View { ID_ChiTietNguyenLieu = i.ID_ChiTietNguyenLieu, ID_NguyenLieu = i.ID_NguyenLieu, TenNguyenLieu = i.NguyenLieu.TenNguyenLieu, LuongTonKho = i.LuongTonKho, LuongNhapVao = i.LuongNhapVao, NgayNhap = i.NgayNhap, NgayHetHan = i.NgayHetHan, ID_NhaCungCap = i.ID_NhaCungCap });
            }
            return data;
        }
        public List<NguyenLieu_View> GetListNguyenLieuTrongKhoByIdLoaiNguyenLieu(int ID_LoaiNguyenLieu)
        {
            List<NguyenLieu_View> data = new List<NguyenLieu_View>();
            var groupedResult = dALQLNH.Khoes.GroupBy(s => s.ID_NguyenLieu);
            foreach (var childGroup in groupedResult)
            {
                int ID_NguyenLieu = childGroup.Key;
                NguyenLieu nl = dALQLNH.NguyenLieus.Find(ID_NguyenLieu);
                if (nl.ID_LoaiNguyenLieu != ID_LoaiNguyenLieu && ID_LoaiNguyenLieu != 0) continue;
                float LuongTonKhoConHSD = 0;
                foreach (Kho s in childGroup)
                {
                    if (s.NgayHetHan > System.DateTime.Now)
                    {
                        LuongTonKhoConHSD += s.LuongTonKho;
                    }
                }
                data.Add(new NguyenLieu_View { ID_NguyenLieu = nl.ID_NguyenLieu, TenNguyenLieu = nl.TenNguyenLieu, DonViTinh = nl.DonViTinh, TenLoaiNguyenLieu = nl.LoaiNguyenLieu.TenLoaiNguyenLieu, LuongTonKho = LuongTonKhoConHSD });
            }
            return data;
        }

        public List<NguyenLieu> GetListNguyenLieuByIdLoaiNguyenLieu(int ID_LoaiNguyenLieu)
        {
            List<NguyenLieu> data = new List<NguyenLieu>();
            foreach (NguyenLieu i in dALQLNH.NguyenLieus)
            {
                if (i.ID_LoaiNguyenLieu == ID_LoaiNguyenLieu)
                {
                    data.Add(i);
                }
            }
            return data;
        }

        public void DelChiTietNguyenLieu(List<int> listIDChiTietNguyenLieuDel)
        {
            foreach (int i in listIDChiTietNguyenLieuDel)
            {
                Kho kho = dALQLNH.Khoes.Find(i);
                if (kho.NgayHetHan < System.DateTime.Now)
                {
                    dALQLNH.Khoes.Remove(kho);
                    dALQLNH.SaveChanges();
                }
            }
        }

        public List<ChiTietNguyenLieu_View> getListNguyenLieuHetHan()
        {
            List<ChiTietNguyenLieu_View> list = new List<ChiTietNguyenLieu_View>();
            foreach (ChiTietNguyenLieu_View i in GetAllNguyenLieuTrongKho())
            {
                if (i.NgayHetHan < System.DateTime.Now)
                {
                    list.Add(i);
                }
            }

            return list;
        }
        public List<LoaiNguyenLieu> GetAllLoaiNguyenLieu()
        {
            List<LoaiNguyenLieu> list = new List<LoaiNguyenLieu>();
            foreach (LoaiNguyenLieu i in dALQLNH.LoaiNguyenLieus)
            {
                list.Add(i);
            }
            return list;
        }

        public int GetNewIDNguyenLieu()
        {
            int ID = 1;
            foreach (NguyenLieu i in dALQLNH.NguyenLieus)
            {
                if (ID != i.ID_NguyenLieu)
                {
                    return ID;
                }
                ID++;
            }
            return ID;
        }
        public int GetNewIDChiTietNguyenLieu()
        {
            int ID = 1;
            foreach (Kho i in dALQLNH.Khoes)
            {
                if (ID != i.ID_ChiTietNguyenLieu)
                {
                    return ID;
                }
                ID++;
            }
            return ID;
        }
        public bool checkAddorUpdate(int id)
        {
            foreach (NguyenLieu i in GetAllNguyenLieu())
            {
                if (i.ID_NguyenLieu == id)
                {
                    return true;
                }
            }
            return false;
        }
        public void ExcuteUpdate(NguyenLieu i)
        {
            NguyenLieu nl = dALQLNH.NguyenLieus.Find(i.ID_NguyenLieu);
            nl.ID_NguyenLieu = i.ID_NguyenLieu;
            nl.DonViTinh = i.DonViTinh;
            nl.TenNguyenLieu = i.TenNguyenLieu;
            nl.HSD = i.HSD;
            nl.ID_LoaiNguyenLieu = i.ID_LoaiNguyenLieu;

            dALQLNH.SaveChanges();

        }
        public void ExcuteAdd(NguyenLieu i)
        {
            dALQLNH.NguyenLieus.Add(i);
            dALQLNH.SaveChanges();
        }

        public NguyenLieu GetNguyenLieuByIDNguyenLieu(int ID)
        {
            return dALQLNH.NguyenLieus.Find(ID);
        }

        public bool checkTrungTenNL(string TenNL)
        {
            foreach (NguyenLieu i in GetAllNguyenLieu())
            {
                if (i.TenNguyenLieu == TenNL)
                {
                    return true;
                }
            }
            return false;
        }

        public void DelNguyenLieu(List<int> listIDNguyenLieuDel)
        {
            foreach (int i in listIDNguyenLieuDel)
            {
                NguyenLieu nl = dALQLNH.NguyenLieus.Find(i);
                dALQLNH.NguyenLieus.Remove(nl);
                dALQLNH.SaveChanges();

            }
        }
        public NguyenLieu GetNguyenLieuByTenNguyenLieu(string name)
        {
            return dALQLNH.NguyenLieus.Where(p => p.TenNguyenLieu == name).FirstOrDefault();
        }
    }
}