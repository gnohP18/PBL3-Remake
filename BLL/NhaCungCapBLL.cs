using Entity;
using System.Collections.Generic;
using DTO;
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

    }
}
