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
    public partial class HesapMakinesi : Form
    {
        public HesapMakinesi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2;
            if
                (double.TryParse(textBox1.Text, out sayi1) && double.TryParse(textBox2.Text, out sayi2))
            {
                double sonuc = 0;
                string secilenIslem = listBox1.SelectedItem.ToString();
                switch (secilenIslem)
                {
                    case "Toplama":
                        sonuc = sayi1 + sayi2;
                        break;
                    case "Çıkarma":
                        sonuc = sayi1 - sayi2;
                        break;
                    case "Çarpma":
                        sonuc = sayi1 * sayi2;
                        break;
                    case "Bölme":
                        if (sayi2 != 0)
                        {
                            sonuc = sayi1 / sayi2;
                        }
                        else
                        {
                            MessageBox.Show("Sıfıra bölemezsiniz!");
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("Bir işlem seçin.");
                        return;
                }


                textBox3.Text = sonuc.ToString();
            }
            else
            {
                MessageBox.Show("Geçerli sayılar girin.");
            }
        }
    }
}
