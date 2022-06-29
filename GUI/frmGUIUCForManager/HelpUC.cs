using System.Windows.Forms;

namespace GUI.frmGUIUCForManager
{
    public partial class HelpUC : UserControl
    {
        private static HelpUC _Instance;
        public static HelpUC Instance
        {
            get { if (_Instance == null) _Instance = new HelpUC(); return _Instance; }
        }
        public HelpUC()
        {
            InitializeComponent();
        }
    }
}
