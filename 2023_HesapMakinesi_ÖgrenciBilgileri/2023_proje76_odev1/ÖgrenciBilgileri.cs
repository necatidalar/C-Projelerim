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
    public partial class ÖgrenciBilgileri : Form
    {
        public ÖgrenciBilgileri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, sinif = "";
            ad = textBox1.Text;
            soyad = textBox2.Text;
            if (radioButton1.Checked) { sinif = "9"; }
            if (radioButton2.Checked) { sinif = "10"; }
            if (radioButton3.Checked) { sinif = "11"; }
            if (radioButton4.Checked) { sinif = "12"; }
            MessageBox.Show(ad+" "+soyad+" "+sinif+". Sınıfta okumaktadır.");
        }
    }
}
