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
    public partial class NecatiDalarÖdev : Form
    {
        public NecatiDalarÖdev()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HesapMakinesi form2 = new HesapMakinesi();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÖgrenciBilgileri form3 = new ÖgrenciBilgileri();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GirilenSayiKadarCmtalYazdir form4 = new GirilenSayiKadarCmtalYazdir();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MagazaProgrami form5 = new MagazaProgrami();
            form5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.Show();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapMakinesi form2 = new HesapMakinesi();
            form2.Show();
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÖgrenciBilgileri form3 = new ÖgrenciBilgileri();
            form3.Show();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GirilenSayiKadarCmtalYazdir form4 = new GirilenSayiKadarCmtalYazdir();
            form4.Show();
        }
    }
}
