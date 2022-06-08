using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;
using GUI.frmGUISeller;
using System.Threading;

namespace PBL3_Remake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //LoadBanByTinhTrangBanVaTang(-1, 1);
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        void LoadBanByTinhTrangBanVaTang(int st, int fl)
        {
            //if (!this.IsHandleCreated) return;
            Thread thread1 = new Thread(new ThreadStart(() => {
                for (int i = 0; i < 5; i++)
                {
                    Thread thread = new Thread(new ThreadStart(() => {
                        for (int j = 0; j < 5; j++)
                            Console.WriteLine(i + ": " + j + "");
                    }))
                    { IsBackground = true };
                    thread.Start();
                }
            }));
            thread1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 5; i++)
            {
                Task thread = new Task(() =>
                {
                    for (int j = 0; j < 5; j++)
                        Console.WriteLine(i + ": " + j + "");
                });
                thread.Start();
            }    
           
        }
    }
}
