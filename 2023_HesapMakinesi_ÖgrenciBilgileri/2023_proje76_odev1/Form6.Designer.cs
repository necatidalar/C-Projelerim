namespace _2023_proje76_odev1
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girilenSayiKadarCmtalYazdirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mağazaProgramıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinesiToolStripMenuItem,
            this.öğrenciBilgileriToolStripMenuItem,
            this.girilenSayiKadarCmtalYazdirToolStripMenuItem,
            this.mağazaProgramıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            this.hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            this.hesapMakinesiToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            this.hesapMakinesiToolStripMenuItem.Click += new System.EventHandler(this.hesapMakinesiToolStripMenuItem_Click);
            // 
            // öğrenciBilgileriToolStripMenuItem
            // 
            this.öğrenciBilgileriToolStripMenuItem.Name = "öğrenciBilgileriToolStripMenuItem";
            this.öğrenciBilgileriToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.öğrenciBilgileriToolStripMenuItem.Text = "Öğrenci Bilgileri";
            this.öğrenciBilgileriToolStripMenuItem.Click += new System.EventHandler(this.öğrenciBilgileriToolStripMenuItem_Click);
            // 
            // girilenSayiKadarCmtalYazdirToolStripMenuItem
            // 
            this.girilenSayiKadarCmtalYazdirToolStripMenuItem.Name = "girilenSayiKadarCmtalYazdirToolStripMenuItem";
            this.girilenSayiKadarCmtalYazdirToolStripMenuItem.Size = new System.Drawing.Size(180, 20);
            this.girilenSayiKadarCmtalYazdirToolStripMenuItem.Text = "Girilen Sayi Kadar Cmtal Yazdir";
            this.girilenSayiKadarCmtalYazdirToolStripMenuItem.Click += new System.EventHandler(this.girilenSayiKadarCmtalYazdirToolStripMenuItem_Click);
            // 
            // mağazaProgramıToolStripMenuItem
            // 
            this.mağazaProgramıToolStripMenuItem.Name = "mağazaProgramıToolStripMenuItem";
            this.mağazaProgramıToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.mağazaProgramıToolStripMenuItem.Text = "Mağaza Programı";
            this.mağazaProgramıToolStripMenuItem.Click += new System.EventHandler(this.mağazaProgramıToolStripMenuItem_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 240);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form6";
            this.Text = "Form6";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girilenSayiKadarCmtalYazdirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mağazaProgramıToolStripMenuItem;
    }
}