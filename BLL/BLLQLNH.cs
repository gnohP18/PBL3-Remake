using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace BLL
{
    public class BLLQLNH
    {
        private DALQLNH dALQLNH;
        private BLLQLNH _Instance;
        public BLLQLNH Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLLQLNH();
                return _Instance;
            }
            private set { }
        }
        private BLLQLNH()
        {
            dALQLNH = new DALQLNH();
        }
    }
}
