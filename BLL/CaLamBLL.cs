using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BLL
{
    public class CaLamBLL : BLL
    {
        private static CaLamBLL _Instance;
        public static CaLamBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new CaLamBLL();
                return _Instance;
            }
            private set { }
        }
        private CaLamBLL()
        {

        }
        public Dictionary<CaLam, bool> GetAllCaLamByID_NhanVien(int ID_NhanVien)
        {
            Dictionary<CaLam, bool> data = new Dictionary<CaLam, bool>();
            if (NhanVienBLL.Instance.GetEmployeeByID_Employee(ID_NhanVien) == null)
            {
                foreach (CaLam i in dALQLNH.CaLams.ToList()) data.Add(i, false);
            }
            else
            {
                foreach (CaLam i in dALQLNH.CaLams.ToList())
                {
                    if (i.ChiTietCaLams.Where(s => s.ID_User == ID_NhanVien).FirstOrDefault() != null) data.Add(i, true);
                    else data.Add(i, false);
                }
            }
            return data;
        }
        public string GetStringCaLamTheoSangChieuByIDCalam(int ID_Calam, bool isSang)
        {
            string result = "";
            CaLam calam = dALQLNH.CaLams.Find(ID_Calam);
            string LichCaLam = calam.LichCaLam;
            if (isSang == true)
            {
                result += "Morning shift :";
                for (int i = 0; i < LichCaLam.Length; i++)
                {
                    if (i % 2 == 0 && LichCaLam[i] == '1')
                    {
                        if (result != "Morning shift :") result += ", ";
                        result += (DayOfWeek)(i / 2);
                        Console.WriteLine(result);
                    }
                }
                return result;
            }
            else
            {
                result += "Afternool shift :";
                for (int i = 0; i < LichCaLam.Length; i++)
                {
                    if (i % 2 != 0 && LichCaLam[i] == '1')
                    {
                        if (result != "Afternool shift :") result += ", ";
                        result += (DayOfWeek)(i / 2);
                    }
                }
                return result;
            }
        }
    }
}
