using Entity;
using System;
using System.Collections.Generic;
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
                data.Add(new ChiTietNguyenLieu_View { ID_ChiTietNguyenLieu = i.ID_ChiTietNguyenLieu,ID_NguyenLieu = i.ID_NguyenLieu, TenNguyenLieu = i.NguyenLieu.TenNguyenLieu, LuongTonKho = i.LuongTonKho, LuongNhapVao = i.LuongNhapVao ,NgayNhap = i.NgayNhap,NgayHetHan = i.NgayHetHan,ID_NhaCungCap = i.ID_NhaCungCap});
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
        public Kho GetChiTietNguyenLieuByIDChiTietNguyenLieu(int iD_ChiTietNguyenLieu)
        {
            return dALQLNH.Khoes.Find(iD_ChiTietNguyenLieu);
        }

        public List<NguyenLieu_View> GetListNguyenLieuTrongKhoByIdLoaiNguyenLieu(int ID_LoaiNguyenLieu)
        {
            List<NguyenLieu_View> data = new List<NguyenLieu_View>();
            var groupedResult = dALQLNH.Khoes.GroupBy(s => s.ID_NguyenLieu);
            foreach (var childGroup in groupedResult)
            {
                int ID_NguyenLieu = childGroup.Key;
                NguyenLieu nl = dALQLNH.NguyenLieus.Find(ID_NguyenLieu);
                if (nl.ID_LoaiNguyenLieu != ID_LoaiNguyenLieu) continue;
                float LuongTonKhoConHSD = 0;
                foreach (Kho s in childGroup)
                {
                    if(s.NgayHetHan > System.DateTime.Now)
                    {
                        LuongTonKhoConHSD += s.LuongTonKho;
                    }
                }
                data.Add(new NguyenLieu_View { ID_NguyenLieu = nl.ID_NguyenLieu,TenNguyenLieu = nl.TenNguyenLieu ,DonViTinh = nl.DonViTinh,TenLoaiNguyenLieu = nl.LoaiNguyenLieu.TenLoaiNguyenLieu ,LuongTonKho = LuongTonKhoConHSD});
            }
            return data;
        }

        public List<NguyenLieu> GetListNguyenLieuByIdLoaiNguyenLieu(int ID_LoaiNguyenLieu)
        {
            List<NguyenLieu> data = new List<NguyenLieu>();
            foreach(NguyenLieu i in dALQLNH.NguyenLieus)
            {
                if(i.ID_LoaiNguyenLieu == ID_LoaiNguyenLieu)
                {
                    data.Add(i); 
                }
            }
            return data;
        }

        public void DelChiTietNguyenLieu(List<int> listIDChiTietNguyenLieuDel)
        {
            foreach(int i in listIDChiTietNguyenLieuDel)
            {
                Kho kho = dALQLNH.Khoes.Find(i);
                if(kho.NgayHetHan < System.DateTime.Now)
                {
                    dALQLNH.Khoes.Remove(kho);
                    dALQLNH.SaveChanges();
                }
            }
        }

        public List<ChiTietNguyenLieu_View> getListNguyenLieuHetHan()
        {
            List<ChiTietNguyenLieu_View> list = new List<ChiTietNguyenLieu_View>();
            foreach(ChiTietNguyenLieu_View i in GetAllNguyenLieuTrongKho())
            {
                if(i.NgayHetHan < System.DateTime.Now)
                {
                    list.Add(i);
                }
            }

            return list;
        }

        public List<NhaCungCap> GetAllNhaCungCap()
        {
            List<NhaCungCap> list = new List<NhaCungCap>();
            foreach(NhaCungCap i in dALQLNH.NhaCungCaps)
            {
                list.Add(i);
            }
            return list;
        }
        public List<ChiTietNhaCungCap> GetTT(int id)
        {
            List<ChiTietNhaCungCap> list = new List<ChiTietNhaCungCap>();
            DALQLNH dALQLNH = new DALQLNH();
            foreach (ChiTietNhaCungCap i in dALQLNH.ChiTietNhaCungCaps)
            {
                if (i.ID_NguyenLieu == id)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public bool checkLoginManager(string username, string password)
        {
            User user = (User)(dALQLNH.Users.Where(p => (p.ID_ChucVu == 1 && p.Username == username && p.Password == password)).FirstOrDefault());
            if (user == null) return false;
            else return true;
        }
        public List<LoaiNguyenLieu> GetAllLoaiNguyenLieu()
        {
            List<LoaiNguyenLieu> list = new List<LoaiNguyenLieu>();
            DALQLNH dALQLNH = new DALQLNH();
            foreach(LoaiNguyenLieu i in dALQLNH.LoaiNguyenLieus)
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

        public int GetNewIDNhaCungCap()
        {
            int ID = 1;
            foreach (NhaCungCap i in dALQLNH.NhaCungCaps)
            {
                if (ID != i.ID_NhaCungCap)
                {
                    return ID;
                }
                ID++;
            }
            return ID;
        }

        public void AddNewNhaCungCap(NhaCungCap ncc)
        {
            dALQLNH.NhaCungCaps.Add(ncc);
            dALQLNH.SaveChanges();
        }

        public List<Kho> GetAllKho()
        {
            return dALQLNH.Khoes.ToList();
        }

        public void UpdateLuongNhapVaoVaLuongTonKho(Kho kho, float count)
        {
            kho.LuongNhapVao += count;
            kho.LuongTonKho += count;
            dALQLNH.SaveChanges();
        }
        public void AddMaterialToWareHouse(Kho i)
        {
            dALQLNH.Khoes.Add(i);
            dALQLNH.SaveChanges();
        }
       public void AddNewMaterial(NguyenLieu i)
        {
            dALQLNH.NguyenLieus.Add(i);
            dALQLNH.SaveChanges();
        }

       public NguyenLieu GetNguyenLieuByIDNguyenLieu(int ID)
        {
            return dALQLNH.NguyenLieus.Find(ID);
        }
    }
}

