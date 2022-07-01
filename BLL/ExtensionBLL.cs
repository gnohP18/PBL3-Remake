using System;
using System.Collections.Generic;
using System.Data;
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
        public DataSet ToDataSet<PrintReceipt_View>(List<PrintReceipt_View> list)
        {
            Type elementType = typeof(PrintReceipt_View);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);

            //add a column to table for each public property on T
            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                t.Columns.Add(propInfo.Name, ColType);
            }

            //go through each property on T and add each value to the table
            foreach (PrintReceipt_View item in list)
            {
                DataRow row = t.NewRow();

                foreach (var propInfo in elementType.GetProperties())
                {
                    row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                }

                t.Rows.Add(row);
            }

            return ds;
        }

    }
}
