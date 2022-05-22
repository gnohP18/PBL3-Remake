using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace BLL
{
    public class BLL
    {
        protected DALQLNH dALQLNH;
        protected BLL()
        {
            dALQLNH = new DALQLNH();
        }
        public void UpdateTrangThaiMonAn(List<MonAn_View> ListMonAnViewLayRa = null)
        {
            Dictionary<int, float> listThongTinLuongNguyenLieu = new Dictionary<int, float>();
            foreach (NguyenLieu i in dALQLNH.NguyenLieus)
            {
                listThongTinLuongNguyenLieu.Add(i.ID_NguyenLieu, 0);
            }
            var parentGroupKho = dALQLNH.Khoes.GroupBy(s => s.ID_NguyenLieu);
            foreach (var childGroupKho in parentGroupKho)
            {
                int ID_NguyenLieu = childGroupKho.Key;
                foreach (Kho i in childGroupKho)
                {
                    if (i.NgayHetHan > DateTime.Now)
                    {
                        listThongTinLuongNguyenLieu[ID_NguyenLieu] += i.LuongTonKho;
                    }
                }
            }
            if (ListMonAnViewLayRa == null || ListMonAnViewLayRa.Count == 0)
            {
                var parentGroupCTMA = dALQLNH.ChiTietMonAns.GroupBy(s => s.ID_MonAn);
                foreach(var childGroupCTMA in parentGroupCTMA)
                {
                    MonAn monAn = dALQLNH.MonAns.Find(childGroupCTMA.Key);
                    foreach (ChiTietMonAn i in childGroupCTMA)
                    {
                        if(i.Luong > listThongTinLuongNguyenLieu[i.ID_NguyenLieu])
                        {
                            monAn.TrangThai = 0;
                            break;
                        }
                        monAn.TrangThai = 1;
                    }
                }
                
            }
            else
            {
                foreach(MonAn_View monAn_View in ListMonAnViewLayRa)
                {
                    List<ChiTietMonAn> list = dALQLNH.ChiTietMonAns.Where(s => s.ID_MonAn == monAn_View.ID_MonAn).ToList();
                    foreach(ChiTietMonAn i in list)
                    {
                        listThongTinLuongNguyenLieu[i.ID_NguyenLieu] -= i.Luong*monAn_View.SoLuong;
                        List<ChiTietMonAn> chiTietMonAns = dALQLNH.ChiTietMonAns.Where(s => s.ID_NguyenLieu == i.ID_NguyenLieu).ToList();
                        foreach (ChiTietMonAn j in chiTietMonAns)
                        {
                            if(j.Luong > listThongTinLuongNguyenLieu[i.ID_NguyenLieu])
                            {
                                dALQLNH.MonAns.Find(j.ID_MonAn).TrangThai = 0; 
                            }
                        }
                    }
                }
            }
            dALQLNH.SaveChanges();
        }
    }
}
