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
    }
}
