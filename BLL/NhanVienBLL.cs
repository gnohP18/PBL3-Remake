using DTO;
using System.Linq;
namespace BLL
{
    public class NhanVienBLL : BLL
    {
        private static NhanVienBLL _Instance;
        public static NhanVienBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new NhanVienBLL();
                return _Instance;
            }
            private set { }
        }
        private NhanVienBLL()
        {

        }
        public User GetEmployeeByID_Employee(int ID_Employee)
        {
            return dALQLNH.Users.Where(p => p.ID_User == ID_Employee).FirstOrDefault();
        }

    }
}
