using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GUI.frmGUIManager;
namespace GUI.frmGUIUCForManager
{
    public partial class ManagerFoodUC : UserControl
    {
        private static ManagerFoodUC _Instance;
        public static ManagerFoodUC Instance
        {
            get { if (_Instance == null) _Instance = new ManagerFoodUC(); return _Instance; }
        }
        public ManagerFoodUC()
        {
            InitializeComponent();
        }
        private Button CurrentButton;
        private void SetUIForButton(object button)
        {

            var btn = (Button)button;
            btn.BackColor = Color.FromArgb(66, 134, 244);
            btn.ForeColor = Color.White;
            if (CurrentButton != null && CurrentButton != btn)
            {
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
        private void SetFoodView(Panel pn, FoodInWareHouse food, int x, int y)
        {
            food.Location = new Point(x, y);
            food.Width = 200;
            food.Height = 150;
            pn.Controls.Add(food);
            
        }
        private void ShowAllFood(int ID_LoaiMonAn)
        {
            RemoveFood();
            List<MonAn> listMonAn;
            if (ID_LoaiMonAn == 0)
            {
                listMonAn = MonAnBLL.Instance.GetAllMonAn();
            }
            else listMonAn = MonAnBLL.Instance.GetAllMonAnByIDLoaiMonAn(ID_LoaiMonAn);
            int somon = listMonAn.Count;
            FoodInWareHouse[] food = new FoodInWareHouse[somon];
            int dem1 = 0;
            foreach (MonAn i in listMonAn)
            {
                food[dem1] = new FoodInWareHouse(i);
                food[dem1].d = new DetailFood.Mydel(ShowAllFood);
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
            SetUIForButton(sender);
            ShowAllFood(0);
        }

        private void btnAppetizer_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            ShowAllFood(1);
        }

        private void btnMainDish_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            ShowAllFood(2);
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            ShowAllFood(3);
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
            ShowAllFood(4);
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            DetailFood frm = new DetailFood(-1);
            frm.d = new DetailFood.Mydel(ShowAllFood);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
