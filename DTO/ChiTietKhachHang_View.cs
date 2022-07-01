using System;

namespace DTO
{
    public class ChiTietKhachHang_View
    {
        public int ID_Guest { get; set; }
        public string Name_Guest { get; set; }
        public int ID_Receipt { get; set; }
        public DateTime Date_Create { get; set; }
        public int Total { get; set; }
        public int MoneyConvertFormPoint { get; set; }
    }
}
