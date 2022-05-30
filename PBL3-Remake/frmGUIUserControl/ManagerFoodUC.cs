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
        public ManagerFoodUC()
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
        private void ShowAllFood()
        {
            RemoveFood();

            List<MonAn> listMonAn = BLLNVNH.Instance.GetAllMonAn();
            int somon = listMonAn.Count;
            Console.WriteLine("So mon an " + somon);
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
                    //food[i].SetLocation(Lx, Ly);
                    SetFoodView(pnFood, food[i], Lx, Ly);
                    Console.WriteLine("ten mon " + food[i].mon.TenMonAn + " Lx,Ly=" + Lx + "," + Ly);
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            RemoveFood();
            ShowAllFood();
            SetUIForButton(sender);
        }

        private void btnAppetizer_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            RemoveFood();
        }

        private void btnMainDish_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            RemoveFood();
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            RemoveFood();
            SetUIForButton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            RemoveFood();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {

            AddNewCourseToWareHouse frm = new AddNewCourseToWareHouse();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
