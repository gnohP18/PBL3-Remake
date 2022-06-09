using Entity;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class MonAnBLL : BLL
    {
        private static MonAnBLL _Instance;
        public static MonAnBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new MonAnBLL();
                return _Instance;
            }
            private set { }
        }
        private MonAnBLL()
        {

        }
        public List<MonAn> GetMonAn(int ID_LoaiMonAn, string txt, int TrangThai)
        {
            return dALQLNH.MonAns.Where(p => p.ID_LoaiMonAn == ID_LoaiMonAn && p.TrangThai == TrangThai && p.TenMonAn.Contains(txt)).ToList();
        }
        public List<MonAn_View> GetListMonAnByIDBan(int ID_Ban)
        {
            List<MonAn_View> data = new List<MonAn_View>();
            var groupMonAn = dALQLNH.ChiTietBans.GroupBy(s => s.ID_Ban).Where(g => g.Key == ID_Ban);
            foreach (var childGroup in groupMonAn)
            {
                foreach (ChiTietBan i in childGroup)
                {
                    MonAn monAn = dALQLNH.MonAns.Find(i.ID_MonAn);
                    bool checkMonAnExisted = false;
                    foreach (MonAn_View j in data)
                    {
                        if (j.ID_MonAn == monAn.ID_MonAn)
                        {
                            j.SoLuong += i.SoLuong;
                            j.ThanhTien = j.SoLuong * monAn.ThanhTien;
                            checkMonAnExisted = true;
                            continue;
                        }
                    }
                    if (!checkMonAnExisted)
                        data.Add(new MonAn_View { ID_MonAn = monAn.ID_MonAn, TenMonAn = monAn.TenMonAn, SoLuong = i.SoLuong, ThanhTien = monAn.ThanhTien });
                }
            }
            return data;
        }
        public void ChangeStatusDishByID(int id)
        {
            foreach (ChiTietBan i in dALQLNH.ChiTietBans)
            {
                if (i.ID_ChiTietBan == id)
                {
                    i.TinhTrang = 1;
                    break;
                }
            }
            dALQLNH.SaveChanges();
        }
    }
}
