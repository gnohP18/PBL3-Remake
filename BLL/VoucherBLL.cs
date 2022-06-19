using Entity;
using System.Collections.Generic;
using System.Linq;
using DTO;
namespace BLL
{
    public class VoucherBLL : BLL
    {
        private static VoucherBLL _Instance;
        public static VoucherBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new VoucherBLL();
                return _Instance;
            }
            private set { }
        }
        private VoucherBLL()
        {

        }
        public List<Voucher> GetAllVoucher()
        {
            return dALQLNH.Vouchers.ToList();
        }
    }
}
