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
    public partial class OverViewUC : UserControl
    {
        private static OverViewUC _Instance;
        public static OverViewUC Instance
        {
            get { if (_Instance == null) _Instance = new OverViewUC(); return _Instance; }
        }
        private OverViewUC()
        {
            InitializeComponent();
        }
    }
}
