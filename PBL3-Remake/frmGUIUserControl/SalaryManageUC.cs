using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class SalaryManageUC : UserControl
    {
        #region Instance
        private static SalaryManageUC _Instance;
        public static SalaryManageUC Instance
        {
            get { if (_Instance == null) _Instance = new SalaryManageUC(); return _Instance; }
        }
        private SalaryManageUC()
        {
            InitializeComponent();
        }
        #endregion
        #region Local Variable

        #endregion
        #region Function

        #endregion
    }
}
