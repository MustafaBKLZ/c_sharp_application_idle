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
            Application.Idle += Application_Idle; // event atamasını yapıyoruz. Başka türlü atama yapılamıyor.
        }

        int sayac = 0;
        private void Application_Idle(object sender, EventArgs e)
        {
            Thread.Sleep(100); // 100 ms bekledik
            sayac++; // sayacı +1 arttırdık
            textBox1.Text = "İdle = " + sayac.ToString(); // idle durumunda olduğunu göstermek için textbox'a birşeyler yazdık.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stop = 0; // durdurmayı iptal ettik
            sayac = 0; // sayacı sıfırladık ki sayı çok büyümesin
            for (int i = 0; i < 500; i++)
            { 
                Thread.Sleep(100); // 100 ms beklettik
                textBox2.Text += "\r\n" + "For Looping "; // döngünün çalıştrığını göstermek için textbox'a birşeyler yazdık
                Application.DoEvents(); //döngünün bitmesini bekledem yapılan işlemi anında göster dedik.
                if (stop == 1) // eğer döngü durdurulmak istenmiş ise döngüyü kırıyoruz
                {
                    break;
                }
            }
        }
        int stop = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            stop = 1; // döngüyü kır
        }
    }
}
