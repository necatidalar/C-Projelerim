using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _2023_FlappyBird_Oyunu
{
    public partial class Form1 : Form
    {
        int boruHizi = 8;
        int gravity = 15;
        int skor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            BoruAlt.Left -= boruHizi;
            BoruUst.Left -= boruHizi;
            skorText.Text = "Skor: " + skor;
            if (BoruAlt.Left < -150)
            {
                BoruAlt.Left = 800;
                skor++;
            }
            if (BoruUst.Left < -180)
            {
                BoruUst.Left = 950;
                skor++;
            }
            if (flappyBird.Bounds.IntersectsWith(BoruAlt.Bounds)
                || flappyBird.Bounds.IntersectsWith(BoruUst.Bounds)
                || flappyBird.Bounds.IntersectsWith(zemin.Bounds))
            {
                endGame();
            }
            if (skor > 5)
               
            {
                boruHizi = 10;
            }
            if (skor > 15)
            {
                boruHizi = 15;
            }
            if (skor > 20)
            {
                boruHizi = 20;
            }
            if (skor > 25)
            {
                boruHizi = 25;
            }
            if (skor > 30)
            {
                boruHizi = 30;
            }
            if (skor > 40)
            {
                boruHizi = 35;
            }
            if (skor > 50)
            {
                boruHizi = 40;
            }
            if (skor > 60)
            {
                boruHizi = 50;
            }
            if (skor >= 250)
            {
                MessageBox.Show("Tebrikler! Oyunu Sonuna Ulaştınız! @necatidalar_ instagram adresimize ulaşarak ödülünüzü talep edebilirsiniz.", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (flappyBird.Top < -25)
            {
                endGame();
            }
        }


        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                gravity = -12;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 12;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            DialogResult result=
            MessageBox.Show("Oyun Bitti! Yeniden Başlamak İstermisin?  Oyunun Sonunda Sana Bir Ödülümüz Var! @necatidalar_", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result==DialogResult.Yes)
            {
                Application.Restart();
            }
            else if (result==DialogResult.No)
            {
                this.Close();
            }
        }
    }
}




