using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace BLL
{
    public class ExtensionBLL
    {
        private static ExtensionBLL _Instance;
        public static ExtensionBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new ExtensionBLL();
                return _Instance;
            }
            private set { }
        }
        private ExtensionBLL()
        {

        }
        public byte[] ImgToByte(Image img)
        {
            var ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            byte[] imgbyte = ms.ToArray();
            return imgbyte;
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
