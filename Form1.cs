using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace idle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Application.Idle += Application_Idle;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        private void Application_Idle(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            sayac++;
            textBox1.Text = "\r\n" + "İdle = " + sayac.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stop = 0;
            sayac = 0;
            for (int i = 0; i < 500; i++)
            {
                Thread.Sleep(100);
                textBox2.Text += "\r\n" + "For Looping";
                Application.DoEvents();
                if (stop == 1)
                {
                    break;
                }
            }
        }
        int stop = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            stop = 1;
        }
    }
}
