using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023_Benzin_İstasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double D_Benzin95 = 0, D_Benzin97 = 0, D_Dizel = 0, D_EuroDizel = 0, D_Lpg = 0;
        double E_Benzin95 = 0, E_Benzin97 = 0, E_Dizel = 0, E_EuroDizel = 0, E_Lpg = 0;
        double F_Benzin95 = 0, F_Benzin97 = 0, F_Dizel = 0, F_EuroDizel = 0, F_Lpg = 0;
        double S_Benzin95 = 0, S_Benzin97 = 0, S_Dizel = 0, S_EuroDizel = 0, S_Lpg = 0;
        string[] depo_bilgileri;
        string[] fiyat_bilgileri;

        private void txt_depo_oku()
        {
            depo_bilgileri = System.IO.File.ReadAllLines(Application.StartupPath + "\\depo.txt");
            D_Benzin95 = Convert.ToDouble(depo_bilgileri[0]);
            D_Benzin97 = Convert.ToDouble(depo_bilgileri[1]);
            D_Dizel = Convert.ToDouble(depo_bilgileri[2]);
            D_EuroDizel = Convert.ToDouble(depo_bilgileri[3]);
            D_Lpg = Convert.ToDouble(depo_bilgileri[4]);
        }

        private void txt_depo_yaz()
        {
            label6.Text = D_Benzin95.ToString("N");
            label7.Text = D_Benzin97.ToString("N");
            label8.Text = D_Dizel.ToString("N");
            label9.Text = D_EuroDizel.ToString("N");
            label10.Text = D_Lpg.ToString("N");

        }

        private void txt_fiyat_oku()
        {
            fiyat_bilgileri = System.IO.File.ReadAllLines(Application.StartupPath + "\\fiyat.txt");
            F_Benzin95 = Convert.ToDouble(fiyat_bilgileri[0]);
            F_Benzin97 = Convert.ToDouble(fiyat_bilgileri[1]);
            F_Dizel = Convert.ToDouble(fiyat_bilgileri[2]);
            F_EuroDizel = Convert.ToDouble(fiyat_bilgileri[3]);
            F_Lpg = Convert.ToDouble(fiyat_bilgileri[4]);
        }

        private void txt_fiyat_yaz()
        {
            label16.Text = F_Benzin95.ToString("N");
            label17.Text = F_Benzin97.ToString("N");
            label18.Text = F_Dizel.ToString("N");
            label19.Text = F_EuroDizel.ToString("N");
            label20.Text = F_Lpg.ToString("N");

        }

        private void progressBar_guncelle()
        {
            progressBar1.Value = Convert.ToInt16(D_Benzin95);
            progressBar2.Value = Convert.ToInt16(D_Benzin97);
            progressBar3.Value = Convert.ToInt16(D_Dizel);
            progressBar4.Value = Convert.ToInt16(D_EuroDizel);
            progressBar5.Value = Convert.ToInt16(D_Lpg);
        }

        private void numericupdown_value()
        {
            numericUpDown1.Maximum = decimal.Parse(D_Benzin95.ToString());
            numericUpDown2.Maximum = decimal.Parse(D_Benzin97.ToString());
            numericUpDown3.Maximum = decimal.Parse(D_Dizel.ToString());
            numericUpDown4.Maximum = decimal.Parse(D_EuroDizel.ToString());
            numericUpDown5.Maximum = decimal.Parse(D_Lpg.ToString());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Akaryakıt Otomasyonu";
            txt_depo_oku();
            txt_depo_yaz();
            txt_fiyat_oku();
            txt_fiyat_yaz();
            progressBar_guncelle();
            numericupdown_value();

            string[] yakit_turleri = { "Benzin (95)", "Benzin (97)", "Dizel", "Euro Dizel", "Lpg" };
            comboBox1.Items.AddRange(yakit_turleri);

            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;
            numericUpDown5.Enabled = false;

            numericUpDown1.DecimalPlaces = 2;
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown4.DecimalPlaces = 2;
            numericUpDown5.DecimalPlaces = 2;

            numericUpDown1.Increment = 0.1M;
            numericUpDown2.Increment = 0.1M;
            numericUpDown3.Increment = 0.1M;
            numericUpDown4.Increment = 0.1M;
            numericUpDown5.Increment = 0.1M;

            numericUpDown1.ReadOnly = true;
            numericUpDown2.ReadOnly = true;
            numericUpDown3.ReadOnly = true;
            numericUpDown4.ReadOnly = true;
            numericUpDown5.ReadOnly = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                E_Benzin95 = Convert.ToDouble(textBox1.Text);
                if (1000 < D_Benzin95 + E_Benzin95 || E_Benzin95 <= 0)
                    textBox1.Text = "Hata!";
                else
                    depo_bilgileri[0] = Convert.ToString(D_Benzin95 + E_Benzin95);

            }
            catch (Exception)
            {
                textBox1.Text = "Hata!";
            }


            try
            {
                E_Benzin97 = Convert.ToDouble(textBox2.Text);
                if (1000 < D_Benzin97 + E_Benzin97 || E_Benzin97 <= 0)
                    textBox1.Text = "Hata!";
                else
                    depo_bilgileri[1] = Convert.ToString(D_Benzin97 + E_Benzin97);

            }
            catch (Exception)
            {
                textBox2.Text = "Hata!";
            }


            try
            {
                E_Dizel = Convert.ToDouble(textBox3.Text);
                if (1000 < D_Dizel + E_Dizel || E_Dizel <= 0)
                    textBox3.Text = "Hata!";
                else
                    depo_bilgileri[2] = Convert.ToString(D_Dizel + E_Dizel);

            }
            catch (Exception)
            {
                textBox3.Text = "Hata!";
            }


            try
            {
                E_EuroDizel = Convert.ToDouble(textBox4.Text);
                if (1000 < D_EuroDizel + E_EuroDizel || E_EuroDizel <= 0)
                    textBox4.Text = "Hata!";
                else
                    depo_bilgileri[3] = Convert.ToString(D_EuroDizel + E_EuroDizel);

            }
            catch (Exception)
            {
                textBox4.Text = "Hata!";
            }


            try
            {
                E_Lpg = Convert.ToDouble(textBox5.Text);
                if (1000 < D_Lpg + E_Lpg || E_Lpg <= 0)
                    textBox5.Text = "Hata!";
                else
                    depo_bilgileri[4] = Convert.ToString(D_Lpg + E_Lpg);

            }
            catch (Exception)
            {
                textBox5.Text = "Hata!";
            }


            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt", depo_bilgileri);
            txt_depo_oku();
            txt_depo_yaz();
            progressBar_guncelle();
            numericupdown_value();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                F_Benzin95 = F_Benzin95 + (F_Benzin95 * Convert.ToDouble
                    (textBox6.Text) / 100);
                fiyat_bilgileri[0] = Convert.ToString(F_Benzin95);
            }
            catch (Exception)
            {
                textBox6.Text = "Hata!";
            }


            try
            {
                F_Benzin97 = F_Benzin97 + (F_Benzin97 * Convert.ToDouble
                    (textBox7.Text) / 100);
                fiyat_bilgileri[1] = Convert.ToString(F_Benzin97);
            }
            catch (Exception)
            {
                textBox7.Text = "Hata!";
            }


            try
            {
                F_Dizel = F_Dizel + (F_Dizel * Convert.ToDouble
                    (textBox8.Text) / 100);
                fiyat_bilgileri[2] = Convert.ToString(F_Dizel);
            }
            catch (Exception)
            {
                textBox8.Text = "Hata!";
            }


            try
            {
                F_EuroDizel = F_EuroDizel + (F_EuroDizel * Convert.ToDouble
                    (textBox9.Text) / 100);
                fiyat_bilgileri[3] = Convert.ToString(F_EuroDizel);
            }
            catch (Exception)
            {
                textBox9.Text = "Hata!";
            }


            try
            {
                F_Lpg = F_Lpg + (F_Lpg * Convert.ToDouble
                    (textBox10.Text) / 100);
                fiyat_bilgileri[4] = Convert.ToString(F_Lpg);
            }
            catch (Exception)
            {
                textBox10.Text = "Hata!";
            }


            System.IO.File.WriteAllLines(Application.StartupPath + "\\fiyat.txt", fiyat_bilgileri);
            txt_fiyat_oku();
            txt_fiyat_yaz();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Benzin (95)")
            {
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "Benzin (97)")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "Dizel")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = true;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "Euro Dizel")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = true;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "Lpg")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = true;
            }
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            label29.Text = "_______";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            S_Benzin95 = double.Parse(numericUpDown1.Value.ToString());
            S_Benzin97 = double.Parse(numericUpDown2.Value.ToString());
            S_Dizel = double.Parse(numericUpDown3.Value.ToString());
            S_EuroDizel = double.Parse(numericUpDown4.Value.ToString());
            S_Lpg = double.Parse(numericUpDown5.Value.ToString());


            if (numericUpDown1.Enabled==true)
            {
                D_Benzin95 = D_Benzin95 - S_Benzin95;
                label29.Text = Convert.ToString(S_Benzin95 * F_Benzin95);
            }
            else if (numericUpDown2.Enabled == true)
            {
                D_Benzin97 = D_Benzin97 - S_Benzin97;
                label29.Text = Convert.ToString(S_Benzin97 * F_Benzin97);
            }
            else if (numericUpDown3.Enabled == true)
            {
                D_Dizel = D_Dizel - S_Dizel;
                label29.Text = Convert.ToString(S_Dizel * F_Dizel);
            }
            else if (numericUpDown4.Enabled == true)
            {
                D_EuroDizel = D_EuroDizel - S_EuroDizel;
                label29.Text = Convert.ToString(S_EuroDizel * F_EuroDizel);
            }
            else if (numericUpDown5.Enabled == true)
            {
                D_Lpg = D_Lpg - S_Lpg;
                label29.Text = Convert.ToString(S_Lpg * F_Lpg);
            }

            depo_bilgileri[0] = Convert.ToString(D_Benzin95);
            depo_bilgileri[1] = Convert.ToString(D_Benzin97);
            depo_bilgileri[2] = Convert.ToString(D_Dizel);
            depo_bilgileri[3] = Convert.ToString(D_EuroDizel);
            depo_bilgileri[4] = Convert.ToString(D_Lpg);

            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt", depo_bilgileri);

            txt_depo_oku();
            txt_depo_yaz();
            progressBar_guncelle();
            numericupdown_value();

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;

        }
    }
}

              
