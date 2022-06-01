using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class HelpUC : UserControl
    {
        private static HelpUC _Instance;
        public static HelpUC Instance
        {
            get { if (_Instance == null) _Instance = new HelpUC(); return _Instance; }
        }
        private HelpUC()
        {
            InitializeComponent();
        }
    }
}
