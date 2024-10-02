using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int total;
        public Form1()
        {
            InitializeComponent();
     
            List<int> degerler = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9,};
            
            Random rnd = new Random();
            degerler = degerler.OrderBy(x => rnd.Next()).ToList();  

            
            Button[] butonlar = { bt_1, bt_2, bt_3, bt_4, bt_5, bt_6, bt_7, bt_8, bt_9 };

            
            for (int i = 0; i < butonlar.Length; i++)
            {
                butonlar[i].Tag = degerler[i];  
            }

        }

        private void number(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;  // Tıklanan butonu al
            int gizliDeger = (int)clickedButton.Tag;  // Gizli değeri Tag'den al

            total = total + gizliDeger;
            txt_total.Text += gizliDeger.ToString();
        }


        private void bt_1_Click(object sender, EventArgs e)
        {
            number(sender, e);
            bt_1.Enabled = false;
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            number(sender, e);
            bt_2.Enabled = false;
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            number(sender, e);
            bt_3.Enabled = false;
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            number(sender, e);
            bt_4.Enabled = false;
        }

        private void bt_5_Click(object sender, EventArgs e)
        {          
            number(sender, e);
            bt_5.Enabled = false;
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            number(sender, e);
            bt_6.Enabled = false;
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            number(sender, e); 
            bt_7.Enabled = false;
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            number(sender, e);
            bt_8.Enabled = false;   
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            number(sender, e);
            bt_9.Enabled = false;   
        }


        private void button11_Click(object sender, EventArgs e)
        {
            total = 0;
            label1.Text = "0";
            txt_total.Text = "";
            bt_1.Enabled = true;
            bt_2.Enabled = true;
            bt_3.Enabled = true;
            bt_4.Enabled = true;
            bt_5.Enabled = true;
            bt_6.Enabled = true;
            bt_7.Enabled = true;
            bt_8.Enabled = true;
            bt_9.Enabled = true;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_esittir_Click(object sender, EventArgs e)
        {
            label1.Text = total.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_total.Text += "+";
        }
    }
}
