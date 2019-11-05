using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WFA_SayisalLoto
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) timer1.Stop();
            else timer1.Start();

            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    Controls[i].Text = "0";
                }
            }
            i = 0;
            Array.Clear(sayilar, 0, sayilar.Length);
        }

        Random rnd = new Random();
        int i = 0;
        int[] sayilar = new int[6];
        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayi = rnd.Next(1, 50); // max 49 gelir
            if (i < 10)
            {
                sayilar[0] = sayi;
                t1.Text = sayilar[0].ToString();
            }
            else if (i < 20)
            {
                if (sayilar.Contains(sayi) && i == 19)
                {
                    i--;
                    t2.BackColor = Color.Tomato;
                }
                sayilar[1] = sayi;
                t2.Text = sayilar[1].ToString();
            }
            else if (i < 30)
            {
                if (sayilar.Contains(sayi) && i == 29)
                {
                    i--;
                    t3.BackColor = Color.Tomato;
                }
                sayilar[2] = sayi;
                t3.Text = sayilar[2].ToString();
            }
            else if (i < 40)
            {
                if (sayilar.Contains(sayi) && i == 39)
                {
                    i--;
                    t4.BackColor = Color.Tomato;
                }
                sayilar[3] = sayi;
                t4.Text = sayilar[3].ToString();
            }
            else if (i < 50)
            {
                if (sayilar.Contains(sayi) && i == 49)
                {
                    i--;
                    t5.BackColor = Color.Tomato;
                }
                sayilar[4] = sayi;
                t5.Text = sayilar[4].ToString();
            }
            else if (i < 60)
            {
                if (sayilar.Contains(sayi) && i == 59)
                {
                    i--;
                    t6.BackColor = Color.Tomato;
                }
                sayilar[5] = sayi;
                t6.Text = sayilar[5].ToString();
            }
            if (i == 80)
            {
                timer1.Stop();
                Array.Sort(sayilar);
                //t1.Text = sayilar[0].ToString();
                //t2.Text = sayilar[1].ToString();
                //t3.Text = sayilar[2].ToString();
                //t4.Text = sayilar[3].ToString();
                //t5.Text = sayilar[4].ToString();
                //t6.Text = sayilar[5].ToString();

                for (int i = 0; i < Controls.Count; i++)
                {
                    if (Controls[i] is TextBox)
                    {
                        Controls[i].Text = sayilar[Controls[i].TabIndex].ToString();
                        Controls[i].BackColor = default;
                        //TextBox txt = (TextBox)Controls[i]; // cast işlemi 
                        //txt.Text = sayilar[txt.TabIndex].ToString(); 
                    }
                }
            }
            i++;
        }
    }
}

