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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapMakinesi form2 = new HesapMakinesi();
            form2.Show();
        }

        private void öğrenciBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÖgrenciBilgileri form3 = new ÖgrenciBilgileri();
            form3.Show();
        }

        private void girilenSayiKadarCmtalYazdirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GirilenSayiKadarCmtalYazdir form4 = new GirilenSayiKadarCmtalYazdir();
            form4.Show();
        }

        private void mağazaProgramıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MagazaProgrami form5 = new MagazaProgrami();
            form5.Show();
        }
    }
}
