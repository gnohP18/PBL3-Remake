using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class TimeSheetUC : UserControl
    {
        public TimeSheetUC(string TimeSheet, DateTime date)
        {
            _TimeSheet = TimeSheet;
            InitializeComponent();
            LoadDateTimeSheet();
            DateCustom = new DateTime(date.Year, date.Month, 5);
            AddNumberIntoMatrixByDate();

        }
        #region Local Variable
        public delegate void Mydel(object o, EventArgs e);
        public Mydel dNext { get; set; }
        public Mydel dPre { get; set; }
        private string _TimeSheet { get; set; }
        private List<List<DateTimeSheetUC>> MaTrix { get; set; }
        private List<string> dateOfWeek = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        private List<List<string>> Sheet { get; set; }
        private DateTime DateCustom { get; set; }
        private List<string> DateState = new List<string>();
        #endregion
        #region Function
        private void SetupDataForTimeSheet(string TimeSheet)
        {
            //Console.WriteLine(TimeSheet);
            char[] chars1 = TimeSheet.ToCharArray();
            foreach (var c in chars1)
            {
                DateState.Add(c.ToString());
            }
        }

        private int NumberOfDay(DateTime dt)
        {
            DateTime newmonth = new DateTime(dt.Year, dt.Month, 5);
            newmonth = newmonth.AddMonths(1);
            int num = 0;
            while (dt <= newmonth)
            {
                num++;
                dt = dt.AddDays(1);
            }
            return num;
        }

        private void SetupDateTimeSheet(DateTimeSheetUC dts, string text, string Morning_state, string Afternoon_state)
        {
            dts.Morning_State = Morning_state;
            dts.Afternoon_State = Afternoon_state;
            dts.Text = text;
            dts.SetupUC();
        }

        public void LoadDateTimeSheet()
        {
            MaTrix = new List<List<DateTimeSheetUC>>();
            int DefaultSize = 50;
            int LocationY = 0;
            int Margin = 6;
            DateTimeSheetUC Defaultdts = new DateTimeSheetUC();
            Defaultdts.Width = 0;
            Defaultdts.Height = 0;
            Defaultdts.Location = new System.Drawing.Point(-Margin, 0);
            for (int i = 0; i < 6; i++)
            {
                MaTrix.Add(new List<DateTimeSheetUC>());
                for (int j = 0; j < 7; j++)
                {
                    //Console.Write(Defaultdts.Location.X + Defaultdts.Width + Margin + " " + Defaultdts.Location.Y + "   ");
                    DateTimeSheetUC dts = new DateTimeSheetUC();
                    dts.Location = new System.Drawing.Point(Defaultdts.Location.X + Defaultdts.Width + Margin, Defaultdts.Location.Y);
                    pnMain.Controls.Add(dts);
                    MaTrix[i].Add(dts);
                    Defaultdts = dts;
                }
                LocationY = Defaultdts.Location.Y;
                //Console.WriteLine();
                Defaultdts = new DateTimeSheetUC();
                Defaultdts.Width = 0;
                Defaultdts.Height = 0;
                Defaultdts.Location = new System.Drawing.Point(-Margin, LocationY + DefaultSize + Margin);
            }
        }
        private void AddNumberIntoMatrixByDate()
        {
            ClearMatrix();
            SetupDataForTimeSheet(_TimeSheet);
            int Index = 0;
            DateTime useDate = new DateTime(DateCustom.Year, DateCustom.Month, 5);
            lblMonth.Text = useDate.Month.ToString() + "/" + useDate.Year.ToString();
            int line = 0;
            //Console.WriteLine(NumberOfDay(useDate));
            for (int i = 1; i <= NumberOfDay(DateCustom); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                DateTimeSheetUC dts = MaTrix[line][column];
                SetupDateTimeSheet(dts, useDate.Date.Day.ToString(), DateState[Index], DateState[Index + 1]);
                if (column >= 6)
                {
                    line++;
                }
                if (Index < DateState.Count)
                    Index += 2;
                useDate = useDate.AddDays(1);
            }
        }
        private void ClearMatrix()
        {
            for (int i = 0; i < MaTrix.Count; i++)
            {
                for (int j = 0; j < MaTrix[i].Count; j++)
                {
                    DateTimeSheetUC dts = MaTrix[i][j];
                    SetupDateTimeSheet(dts, "", "0", "0");
                }
            }
        }
        #endregion
        #region Event UC
        private void btnPerious_Click(object sender, EventArgs e)
        {
            dPre(sender, e);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dNext(sender, e);
        }
        #endregion
    }
}
