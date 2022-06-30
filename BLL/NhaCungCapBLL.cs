using Entity;
using System.Collections.Generic;
using DTO;
using System.Linq;

namespace BLL
{
    public class NhaCungCapBLL : BLL
    {
        private static NhaCungCapBLL _Instance;
        public static NhaCungCapBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new NhaCungCapBLL();
                return _Instance;
            }
            private set { }
        }
        private NhaCungCapBLL()
        {

        }
        public List<NhaCungCap> GetAllNhaCungCap()
        {
            List<NhaCungCap> list = new List<NhaCungCap>();
            foreach (NhaCungCap i in dALQLNH.NhaCungCaps)
            {
                list.Add(i);
            }
            return list;
        }
        public List<ChiTietNhaCungCap> GetTT(int id)
        {
            List<ChiTietNhaCungCap> list = new List<ChiTietNhaCungCap>();
            foreach (ChiTietNhaCungCap i in dALQLNH.ChiTietNhaCungCaps)
            {
                if (i.ID_NguyenLieu == id)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public NhaCungCap GetNCCByID(int id)
        {
            return dALQLNH.NhaCungCaps.Find(id);
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

        public List<ChiTietNhaCungCap_View> GetChiTietNhaCungCap_Views(int ID_NhaCungCap)
        {

            List<ChiTietNhaCungCap_View> data = new List<ChiTietNhaCungCap_View>();
            foreach(ChiTietNhaCungCap i in dALQLNH.ChiTietNhaCungCaps.Where(s=>s.ID_NhaCungCap == ID_NhaCungCap).ToList())
            {
                data.Add(new ChiTietNhaCungCap_View
                {   
                    ID_NguyenLieu = i.ID_NguyenLieu,
                    TenNguyenLieu = i.NguyenLieu.TenNguyenLieu,
                    DonGia = i.DonGia
                    
                });
            }
            return data;
            
        }

        public void AddNewChiTietNhaCungCap(ChiTietNhaCungCap ct)
        {
            dALQLNH.ChiTietNhaCungCaps.Add(ct);
            dALQLNH.SaveChanges();
        }
        public void DeleteNhaCungCap(int IDNCC)
        {
            NhaCungCap ncc = dALQLNH.NhaCungCaps.Find(IDNCC);
            dALQLNH.NhaCungCaps.Remove(ncc);
            dALQLNH.SaveChanges();
        }
        public void DeteleChiTietNhaCungCap(List<int> ctncc,int ID_NhaCungCap)
        {
            foreach(int i in ctncc)
            {
                ChiTietNhaCungCap ct = dALQLNH.ChiTietNhaCungCaps.Find(ID_NhaCungCap,i);
                dALQLNH.ChiTietNhaCungCaps.Remove(ct);
                dALQLNH.SaveChanges();
            }
        }
        public NhaCungCap GetNhaCungCapByID(int ID)
        {
            return dALQLNH.NhaCungCaps.Where(p => p.ID_NhaCungCap == ID).FirstOrDefault();
        }
        public void UpdateNhaCungCap(NhaCungCap ncc)
        {   NhaCungCap n = dALQLNH.NhaCungCaps.Where(p => p.ID_NhaCungCap == ncc.ID_NhaCungCap).FirstOrDefault();
            n.ID_NhaCungCap = ncc.ID_NhaCungCap;
            n.TenNhaCungCap = ncc.TenNhaCungCap;
            n.DiaChi = ncc.DiaChi;
            n.MaSoThue = ncc.MaSoThue;
            n.SoDienThoai = ncc.SoDienThoai;
            dALQLNH.SaveChanges();
        }
    }
}
