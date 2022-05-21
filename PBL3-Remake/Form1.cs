using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Ban> data = new List<Ban>();
            data.AddRange(new Ban[]
            {
                new Ban{ID_Ban = 1,TenBan = "Ban T01-1",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 2,TenBan = "Ban T01-2",Tang = 1,TinhTrangBan =2},
                new Ban{ID_Ban = 3,TenBan = "Ban T01-3",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 4,TenBan = "Ban T01-4",Tang = 1,TinhTrangBan =0},
                new Ban{ID_Ban = 5,TenBan = "Ban T01-5",Tang = 1,TinhTrangBan =5},
                new Ban{ID_Ban = 6,TenBan = "Ban T01-6",Tang = 1,TinhTrangBan =6},
            });
            dataGridView1.DataSource = data;
        }
    }
}
