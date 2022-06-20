using DTO;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BLL
{
    public class BLL
    {
        protected static DALQLNH dALQLNH;
        protected BLL()
        {
            dALQLNH = new DALQLNH();
        }
    }
}
