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
    public partial class MagazaProgrami : Form
    {
        public MagazaProgrami()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double toplam, ogrenci, indirim,odenecekTutar;
            toplam = double.Parse(textBox1.Text);
            if (checkBox1.Checked)
                ogrenci = toplam / 20;
            else
                ogrenci=0;
            if (toplam >= 100)
                indirim = toplam / 10;
            else
                indirim = 0;
            odenecekTutar = toplam - indirim - ogrenci;

            richTextBox1.Text = "";
            richTextBox1.Text += "Toplam Tutar = " + toplam +  " TL"+"\n";
            richTextBox1.Text += "İndirim Tutarı = " + indirim + " TL" + "\n";
            richTextBox1.Text += "Öğrenci İndirimi= " + ogrenci + " TL" + "\n";
            richTextBox1.Text += "________________________\n";
            richTextBox1.Text += "Ödenecek Tutar = " + odenecekTutar + "\n";
        } 


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "")
                label6.Text = "0";
            else if (listBox1.Text == "Uzun Kol")
                label6.Text = "100";
            else if (listBox1.Text == "Kısa Kol")
                label6.Text = "80";
            else if (listBox1.Text == "Hakim Yaka")
                label6.Text = "90";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.Text == "")
                label7.Text = "0";
            else if (listBox2.Text == "Keten")
                label7.Text = "100";
            else if (listBox2.Text == "Kot")
                label7.Text = "90";
            else if (listBox2.Text == "Kumaş")
                label7.Text = "120";
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.Text == "")
                label8.Text = "0";
            else if (listBox3.Text == "Kot")
                label8.Text = "100";
            else if (listBox3.Text == "Deri")
                label8.Text = "110";
            else if (listBox3.Text == "Kumaş")
                label8.Text = "120";
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox4.Text == "")
                label9.Text = "0";
            else if (listBox4.Text == "Spor")
                label9.Text = "110";
            else if (listBox4.Text == "Deri")
                label9.Text = "130";
            else if (listBox4.Text == "Suni Deri")
                label9.Text = "140";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam;
            listBox5.Items.Clear();

            if (listBox1.Text != "")
                listBox5.Items.Add("Gömlek " + listBox1.Text + " " + label6.Text);

            if (listBox2.Text != "")
                listBox5.Items.Add("Pantolon " + listBox2.Text + " " + label7.Text);

            if (listBox3.Text != "")
                listBox5.Items.Add("Ceket " + listBox3.Text + " " + label8.Text);
            
            if (listBox4.Text != "")
                listBox5.Items.Add("Ayakkabı " + listBox4.Text + " " + label9.Text);
            toplam = int.Parse(label6.Text) +
                int.Parse(label7.Text) +
                int.Parse(label8.Text) +
                int.Parse(label9.Text);
            textBox1.Text = toplam.ToString();


        }
    }
}
