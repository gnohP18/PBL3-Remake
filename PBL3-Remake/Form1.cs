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
            DALQLNH dALQLNH = new DALQLNH();
            dataGridView1.DataSource = dALQLNH.Bans.ToList();
        }
    }
}
