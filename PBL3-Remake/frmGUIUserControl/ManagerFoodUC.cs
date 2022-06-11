using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class ManagerFoodUC : UserControl
    {
        private static ManagerFoodUC _Instance;
        public static ManagerFoodUC Instance
        {
            get { if (_Instance == null) _Instance = new ManagerFoodUC(); return _Instance; }
        }
        private ManagerFoodUC()
        {
            InitializeComponent();
        }
        private Button CurrentButton;
        private void SetUIForButton(object button)
        {

            var btn = (Button)button;
            //highlight button
            btn.BackColor = Color.FromArgb(66, 134, 244);
            btn.ForeColor = Color.White;
            //btn.RightToLeft = RightToLeft.Yes;
            //Unhighlight button
            if (CurrentButton != null && CurrentButton != btn)
            {
                //btn.RightToLeft = RightToLeft.No;
                CurrentButton.BackColor = Color.FromArgb(17, 21, 37);
                CurrentButton.ForeColor = Color.White;
            }
            CurrentButton = btn;
        }
        private void RemoveFood()
        {
            pnFood.Controls.Clear();
        }
        private void ManagerFoodUC_Load(object sender, EventArgs e)
        {
            pnFood.AutoScroll = true;
        }
        private void SetFoodView(Panel pn, CoursesInWareHouse food, int x, int y)
        {
            pn.Controls.Add(food);
            food.Location = new System.Drawing.Point(x, y);
            food.Width = 200;
            food.Height = 150;
        }
        private void ShowAllFood(int ID_LoaiMonAn)
        {
            List<MonAn> listMonAn = null;
            if (ID_LoaiMonAn == 0)
            {
                listMonAn = MonAnBLL.Instance.GetAllMonAn();
            }
            else listMonAn = MonAnBLL.Instance.GetAllMonAnByIDLoaiMonAn(ID_LoaiMonAn);
            int somon = listMonAn.Count;
            CoursesInWareHouse[] food = new CoursesInWareHouse[somon];
            int dem1 = 0;
            foreach (MonAn i in listMonAn)
            {
                food[dem1] = new CoursesInWareHouse(i);
                dem1++;
            }
            if (somon != 0)
            {
                int Lx = 0, Ly = 0;
                for (int i = 0; i < food.Length; i++)
                {
                    if (i % 5 == 0) Lx = 20;
                    else if (i % 5 == 1)
                    {
                        Lx = 230;
                    }
                    else if (i % 5 == 2)
                    {
                        Lx = 450;
                    }
                    else if (i % 5 == 3)
                    {
                        Lx = 670;
                    }
                    else if (i % 5 == 4)
                    {
                        Lx = 890;
                    }
                    int thuong = Convert.ToInt32(i / 5);
                    Ly = 20 + 200 * thuong;
                    SetFoodView(pnFood, food[i], Lx, Ly);
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            RemoveFood();
            SetUIForButton(sender);
            ShowAllFood(0);
        }

        private void btnAppetizer_Click(object sender, EventArgs e)
        {
            RemoveFood();
            SetUIForButton(sender);
            ShowAllFood(1);
        }

        private void btnMainDish_Click(object sender, EventArgs e)
        {
            RemoveFood();
            SetUIForButton(sender);
            ShowAllFood(2);
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            RemoveFood();
            SetUIForButton(sender);
            ShowAllFood(3);
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
            RemoveFood();
            SetUIForButton(sender);
            ShowAllFood(4);
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            AddNewCourseToWareHouse frm = new AddNewCourseToWareHouse(-1);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
