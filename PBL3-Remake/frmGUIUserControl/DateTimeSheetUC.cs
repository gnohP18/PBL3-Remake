using System;
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
        public string text { get; set; }
        public string Morning_State { get; set; }
        public string Afternoon_State { get; set; }
        #endregion
        #region Function
        private bool check(string st)
        {
            char[] c = st.ToCharArray();
            if ('A' <= c[0] && c[0] <= 'Z')
                return true;
            else return false;
        }
        private void CheckStatus(Panel pn, string status)
        {
            if (status == "0")
            {
                pn.BackColor = Color.Red;
                Console.WriteLine("Red");
            }
            if (status == "1")
            {
                pn.BackColor = Color.Green;
                Console.WriteLine("Green");
            }
            if (check(status))
            {
                pn.BackColor = Color.Orange;
                Console.WriteLine("Orange");
            }
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
