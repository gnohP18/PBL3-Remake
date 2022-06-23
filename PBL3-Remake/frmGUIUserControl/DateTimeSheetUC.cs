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
                pn.BackColor = Color.FromArgb(87, 209, 255);
            }
            if (status == "2")
            {
                pn.BackColor = Color.Red;
            }
            if (status == "1")
            {
                pn.BackColor = Color.Green;
            }
            if (check(status))
            {
                pn.BackColor = Color.Orange;
            }
        }
        public void SetupUC()
        {
            CheckStatus(pnMorning, Morning_State);
            CheckStatus(pnAfternoon, Afternoon_State);
            lblDate.Text = Text;
        }
        #endregion
        #region Event UC
        private void pnMorning_Click(object sender, EventArgs e)
        {
            NoticeBox box;
            if (Morning_State == "0")
            {
                box = new NoticeBox("Dont work");
                box.ShowDialog();
            }
            else if (Morning_State == "1")
            {
                box = new NoticeBox("Work on time");
                box.ShowDialog();
            }
            else
            {
                char c = Morning_State[0];
                Console.WriteLine(c);
                int late = (c - 64) * 15;
                box = new NoticeBox("Work late " + late + " minute");
                box.ShowDialog();
            }
        }

        private void pnAfternoon_Click(object sender, EventArgs e)
        {
            NoticeBox box;
            if (Afternoon_State == "0")
            {
                box = new NoticeBox("Dont work");
                box.ShowDialog();
            }
            else if (Afternoon_State == "1")
            {
                box = new NoticeBox("Work on time");
                box.ShowDialog();
            }
            else
            {
                char c = Afternoon_State[0];
                int late = (c - 64) * 15;
                box = new NoticeBox("Work late " + late + " minute");
                box.ShowDialog();
            }
        }
        #endregion
    }
}
