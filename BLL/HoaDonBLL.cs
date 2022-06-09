namespace BLL
{
    public class HoaDonBLL : BLL
    {
        private static HoaDonBLL _Instance;
        public static HoaDonBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new HoaDonBLL();
                return _Instance;
            }
            private set { }
        }
        private HoaDonBLL()
        {

        }
    }
}
