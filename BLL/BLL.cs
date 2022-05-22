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
        public void UpdateTrangThaiMonAn(MonAn monAn = null)
        {
            if(monAn == null)
            {
                Dictionary<int,float> listThongTinLuongNguyenLieu = new Dictionary<int,float>();
                foreach(NguyenLieu i in dALQLNH.NguyenLieus)
                {
                    var groupResult = dALQLNH.Khoes.GroupBy(s => s.ID_NguyenLieu);
                }
                foreach (MonAn i in dALQLNH.MonAns)
                {
                    
                }
            }
        }
    }
}
