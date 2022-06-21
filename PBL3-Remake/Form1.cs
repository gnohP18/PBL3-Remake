using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //LoadBanByTinhTrangBanVaTang(-1, 1);
            Control.CheckForIllegalCrossThreadCalls = false;
            Test();
        }
        void LoadBanByTinhTrangBanVaTang(int st, int fl)
        {
            //if (!this.IsHandleCreated) return;
            Thread thread1 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread thread = new Thread(new ThreadStart(() =>
                    {
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

            //for (int i = 0; i < 5; i++)
            //{
            //    Task thread = new Task(() =>
            //    {
            //        for (int j = 0; j < 5; j++)
            //            Console.WriteLine(i + ": " + j + "");
            //    });
            //    thread.Start();
            //}    
            //Sheet = new List<List<string>>();

        }
        private void LoadDateTimeSheet()
        {

        }
        private void Test()
        {
            string sheet1 = "010101010101010A01010101010101010101010101010101010A0101010101";
            ////Console.WriteLine(sheet1);
            char[] chars1 = sheet1.ToCharArray();
            List<string> ngay = new List<string>();
            //int dem = 0;
            for (int i = 0; i < chars1.Length; i++)
            {
                ngay.Add(chars1[i].ToString());
            }
            //foreach (string s in ngay)
            //{
            //    Console.WriteLine(dem + " " + s);
            //    dem++;
            //}
            //foreach (char s in ngay[1])
            //{
            //    Console.WriteLine(s + "...");
            //}
        }
    }
}
