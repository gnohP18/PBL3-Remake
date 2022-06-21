using System.Drawing;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class DateTimeSheetUC : UserControl
    {
        public DateTimeSheetUC()
        {
            InitializeComponent();
        }
        #region Local Variable
        public string Text { get; set; }
        public string Morning_State { get; set; }
        public string Afternoon_State { get; set; }
        #endregion
        #region Function
        private void CheckStatus(Panel pn, string status)
        {
            if (status == "0") pn.BackColor = Color.Red;
            else if (status == "1") pn.BackColor = Color.Green;
            else if (status == "A") pn.BackColor = Color.Orange;
        }
        public void SetupUC()
        {
            CheckStatus(pnMorning, Morning_State);
            CheckStatus(pnAfternoon, Afternoon_State);
            lblDate.Text = Text;
        }
        #endregion
    }
}
