namespace BLL
{
    public class ThongKeBLL : BLL
    {
        private static ThongKeBLL _Instance;
        public static ThongKeBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new ThongKeBLL();
                return _Instance;
            }
            private set { }
        }
        private ThongKeBLL()
        {

        }
    }
}
