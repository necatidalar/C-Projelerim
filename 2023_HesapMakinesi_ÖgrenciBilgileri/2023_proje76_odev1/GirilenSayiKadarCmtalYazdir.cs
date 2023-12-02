using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023_proje76_odev1
{
    public partial class GirilenSayiKadarCmtalYazdir : Form
    {
        public GirilenSayiKadarCmtalYazdir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int girilenSayi;

            if (int.TryParse(textBox1.Text, out girilenSayi) && girilenSayi >= 1 && girilenSayi <= 50)
            {
                for (int i = 1; i <= girilenSayi; i++)
                {
                    listBox1.Items.Add(i + ".Cmtal");
                }
            }
            else
            {
                MessageBox.Show("Lütfen 1 ile 50 arasında geçerli bir sayı girin.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    

