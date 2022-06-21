using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class TimeSheetUC : UserControl
    {
        public TimeSheetUC()
        {
            InitializeComponent();
            LoadDateTimeSheet();
            AddNumberIntoMatrixByDate(DateTime.Now);

        }
        #region Local Variable
        private List<List<DateTimeSheetUC>> MaTrix { get; set; }
        private List<string> dateOfWeek = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        private List<List<string>> Sheet { get; set; }
        private List<string> DateState = new List<string>();
        #endregion
        #region Function
        private void SetupDataForTimeSheet()
        {
            string sheet1 = "0A0A01010101010101010101010101010101010101010101010101010101";
            char[] chars1 = sheet1.ToCharArray();
            //for (int i = 0; i < chars1.Length; i++)
            //{
            //    DateState.Add(chars1[i].ToString());
            //}
            //DateState.Add("");
            foreach (var c in chars1)
            {
                DateState.Add(c.ToString());
            }
            foreach (string c in DateState)
            {
                Console.WriteLine(c);
            }

        }
        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30; ;
            }
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
            //int Index = 0;
            for (int i = 0; i < 6; i++)
            {
                MaTrix.Add(new List<DateTimeSheetUC>());
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(Defaultdts.Location.X + Defaultdts.Width + Margin + " " + Defaultdts.Location.Y + "   ");
                    DateTimeSheetUC dts = new DateTimeSheetUC();
                    //SetupDateTimeSheet(dts, useDate.Date.Day.ToString(), DateState[Index], DateState[Index + 1]);
                    dts.Location = new System.Drawing.Point(Defaultdts.Location.X + Defaultdts.Width + Margin, Defaultdts.Location.Y);
                    pnMain.Controls.Add(dts);
                    MaTrix[i].Add(dts);
                    Defaultdts = dts;
                }
                LocationY = Defaultdts.Location.Y;
                Console.WriteLine();
                Defaultdts = new DateTimeSheetUC();
                Defaultdts.Width = 0;
                Defaultdts.Height = 0;
                Defaultdts.Location = new System.Drawing.Point(-Margin, LocationY + DefaultSize + Margin);
            }
        }
        void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            SetupDataForTimeSheet();
            int Index = 0;
            DateTime useDate = new DateTime(date.Year, date.Month, 5);
            lblMonth.Text = useDate.Month.ToString() + "/" + useDate.Year.ToString();
            int line = 0;
            for (int i = 1; i <= DayOfMonth(date); i++)
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
    }
}
