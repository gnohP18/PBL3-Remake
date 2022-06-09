using Entity;
using System.Collections.Generic;
using System.Linq;
namespace BLL
{
    public class KhoBLL : BLL
    {
        private static KhoBLL _Instance;
        public static KhoBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new KhoBLL();
                return _Instance;
            }
            private set { }
        }
        private KhoBLL()
        {

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
        public Kho GetChiTietNguyenLieuByIDChiTietNguyenLieu(int iD_ChiTietNguyenLieu)
        {
            return dALQLNH.Khoes.Find(iD_ChiTietNguyenLieu);
        }
    }
}
