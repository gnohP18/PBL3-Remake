using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI.frmGUIUCForManager
{
    public partial class SalaryManageUC : UserControl
    {
        #region Instance
        private static SalaryManageUC _Instance;
        public static SalaryManageUC Instance
        {
            get { if (_Instance == null) _Instance = new SalaryManageUC(); return _Instance; }
        }
        public SalaryManageUC()
        {
            InitializeComponent();
            SetupDataGridView();
            SetupComboBox();
        }
        #endregion
        #region Local Variable
        private int ID_User { get; set; }
        private List<string> NamePositionCBB = new List<string>();
        private List<DayChart_view> DC_v = new List<DayChart_view>();
        private SalaryEmployee_view salaryEmployee { get; set; }
        #endregion
        #region Function
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void SetupDataGridView()
        {
            //dgvSalaryEmployee.DataSource = BLL.NhanVienBLL.Instance.GetAllSalaryEmployee_view();
            dgvSalaryEmployee.DataSource = BLL.NhanVienBLL.Instance.GetAllSalaryEmployee_view();
            //dgvSalaryEmployee.Columns[0].Width = 50;
        }
        private void SetupComboBox()
        {
            foreach (ChucVu i in BLL.NhanVienBLL.Instance.GetAllPosition())
            {
                NamePositionCBB.Add(i.TenChucVu);
                cbbPosition.Items.Add(i.TenChucVu);
            }
        }
        private void SetupInforEmployee(int ID_User)
        {

            lblID_User.Text = salaryEmployee.ID_User.ToString();
            lblNameUser.Text = salaryEmployee.Name_User;
            lblPosition.Text = salaryEmployee.Name_Position;
            lblDayWork.Text = BLL.NhanVienBLL.Instance.GetNumberDayWorkFormDayStartWorkByID_User(ID_User).ToString();
            lblTotalDayWork.Text = BLL.NhanVienBLL.Instance.GetNumberOfTotalDayWorkByID_User(ID_User).ToString();
            lblCoefficientsSalary.Text = salaryEmployee.CoefficientsSalary.ToString();
            lblPercentWorkHard.Text = salaryEmployee.PerCentDayWorkAndDayAbsent.ToString();
            pBUserPicture.Image = byteArrayToImage(BLL.NhanVienBLL.Instance.GetNhanVienByID(ID_User).AnhUser);
            if (salaryEmployee.PerCentDayWorkAndDayAbsent >= 80)
            {
                pBCondition.Image = GUI.Properties.Resources.checkedGreen;
                cbbPosition.Visible = true;

            }
            else
            {
                pBCondition.Image = GUI.Properties.Resources.uncheckedRed;
                cbbPosition.Visible = false;
            }

        }
        private void SetupDayWorkChart()
        {
            DayWorkChart.Series[0].Points.Clear();
            DC_v.Clear();
            DC_v.Add(new DayChart_view { Date = DateTime.Now, Value = salaryEmployee.TotalDayWork, Text = "Total Day Work" });
            DC_v.Add(new DayChart_view { Date = DateTime.Now, Value = BLL.NhanVienBLL.Instance.GetNumberOfTotalDayWorkByID_User(ID_User), Text = "Date anttendance" });
            DC_v.Add(new DayChart_view { Date = DateTime.Now, Value = salaryEmployee.TotalDayWork - BLL.NhanVienBLL.Instance.GetNumberOfTotalDayWorkByID_User(ID_User), Text = "Date Absent" });
            foreach (DayChart_view i in DC_v)
            {
                Console.WriteLine(i.Text + " " + i.Value);
            }
            DayWorkChart.DataSource = DC_v;
            DayWorkChart.Series[0].YValueMembers = "Value";
            DayWorkChart.Series[0].XValueMember = "Text";
        }
        #endregion
        #region Event UC
        private void dgvSalaryEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvSalaryEmployee.CurrentCell.RowIndex;
            ID_User = Convert.ToInt32(dgvSalaryEmployee.Rows[index].Cells[0].Value.ToString());
            salaryEmployee = BLL.NhanVienBLL.Instance.GetSalaryEmployee_viewByID_User(ID_User);
            SetupInforEmployee(ID_User);
            SetupDayWorkChart();
        }
        #endregion


    }
}
