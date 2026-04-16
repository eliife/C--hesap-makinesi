namespace HesapMakinesi_Elife_KILIÇ
{
    partial class form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ekranlbl = new System.Windows.Forms.Label();
            this.bolme = new System.Windows.Forms.Button();
            this.sonuc = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.yüzde = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.carpma = new System.Windows.Forms.Button();
            this.silbutonu = new System.Windows.Forms.Button();
            this.floatsayı = new System.Windows.Forms.Button();
            this.rakam0 = new System.Windows.Forms.Button();
            this.rakam9 = new System.Windows.Forms.Button();
            this.cıkarma = new System.Windows.Forms.Button();
            this.rakam8 = new System.Windows.Forms.Button();
            this.rakam7 = new System.Windows.Forms.Button();
            this.rakam6 = new System.Windows.Forms.Button();
            this.rakam5 = new System.Windows.Forms.Button();
            this.toplama = new System.Windows.Forms.Button();
            this.rakam4 = new System.Windows.Forms.Button();
            this.rakam3 = new System.Windows.Forms.Button();
            this.rakam2 = new System.Windows.Forms.Button();
            this.rakam1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekranlbl
            // 
            this.ekranlbl.BackColor = System.Drawing.Color.White;
            this.ekranlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ekranlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekranlbl.Location = new System.Drawing.Point(12, 9);
            this.ekranlbl.Name = "ekranlbl";
            this.ekranlbl.Size = new System.Drawing.Size(349, 67);
            this.ekranlbl.TabIndex = 0;
            this.ekranlbl.Text = "0";
            this.ekranlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bolme
            // 
            this.bolme.BackColor = System.Drawing.Color.Gold;
            this.bolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolme.Location = new System.Drawing.Point(285, 348);
            this.bolme.Name = "bolme";
            this.bolme.Size = new System.Drawing.Size(60, 60);
            this.bolme.TabIndex = 40;
            this.bolme.Text = "/";
            this.bolme.UseVisualStyleBackColor = false;
            this.bolme.Click += new System.EventHandler(this.bolme_Click);
            // 
            // sonuc
            // 
            this.sonuc.BackColor = System.Drawing.Color.Gold;
            this.sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuc.Location = new System.Drawing.Point(219, 348);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(60, 60);
            this.sonuc.TabIndex = 39;
            this.sonuc.Text = "=";
            this.sonuc.UseVisualStyleBackColor = false;
            this.sonuc.Click += new System.EventHandler(this.sonuc_Click);
            // 
            // buttonM
            // 
            this.buttonM.BackColor = System.Drawing.Color.Gold;
            this.buttonM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonM.Location = new System.Drawing.Point(153, 348);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(60, 60);
            this.buttonM.TabIndex = 38;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = false;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // yüzde
            // 
            this.yüzde.BackColor = System.Drawing.Color.Gold;
            this.yüzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yüzde.Location = new System.Drawing.Point(87, 348);
            this.yüzde.Name = "yüzde";
            this.yüzde.Size = new System.Drawing.Size(60, 60);
            this.yüzde.TabIndex = 37;
            this.yüzde.Text = "%";
            this.yüzde.UseVisualStyleBackColor = false;
            this.yüzde.Click += new System.EventHandler(this.yüzde_Click);
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.Gold;
            this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonA.Location = new System.Drawing.Point(21, 348);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(60, 60);
            this.buttonA.TabIndex = 36;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // carpma
            // 
            this.carpma.BackColor = System.Drawing.Color.Gold;
            this.carpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carpma.Location = new System.Drawing.Point(285, 266);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(60, 60);
            this.carpma.TabIndex = 35;
            this.carpma.Text = "*";
            this.carpma.UseVisualStyleBackColor = false;
            this.carpma.Click += new System.EventHandler(this.carpma_Click);
            // 
            // silbutonu
            // 
            this.silbutonu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.silbutonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbutonu.Location = new System.Drawing.Point(219, 266);
            this.silbutonu.Name = "silbutonu";
            this.silbutonu.Size = new System.Drawing.Size(60, 60);
            this.silbutonu.TabIndex = 34;
            this.silbutonu.Text = "C";
            this.silbutonu.UseVisualStyleBackColor = false;
            this.silbutonu.Click += new System.EventHandler(this.silbutonu_Click);
            // 
            // floatsayı
            // 
            this.floatsayı.BackColor = System.Drawing.Color.CornflowerBlue;
            this.floatsayı.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floatsayı.Location = new System.Drawing.Point(153, 266);
            this.floatsayı.Name = "floatsayı";
            this.floatsayı.Size = new System.Drawing.Size(60, 60);
            this.floatsayı.TabIndex = 33;
            this.floatsayı.Text = ",";
            this.floatsayı.UseVisualStyleBackColor = false;
            this.floatsayı.Click += new System.EventHandler(this.floatsayı_Click);
            // 
            // rakam0
            // 
            this.rakam0.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rakam0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam0.Location = new System.Drawing.Point(87, 266);
            this.rakam0.Name = "rakam0";
            this.rakam0.Size = new System.Drawing.Size(60, 60);
            this.rakam0.TabIndex = 32;
            this.rakam0.Text = "0";
            this.rakam0.UseVisualStyleBackColor = false;
            this.rakam0.Click += new System.EventHandler(this.rakam0_Click);
            // 
            // rakam9
            // 
            this.rakam9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rakam9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam9.Location = new System.Drawing.Point(21, 266);
            this.rakam9.Name = "rakam9";
            this.rakam9.Size = new System.Drawing.Size(60, 60);
            this.rakam9.TabIndex = 31;
            this.rakam9.Text = "9";
            this.rakam9.UseVisualStyleBackColor = false;
            this.rakam9.Click += new System.EventHandler(this.rakam9_Click);
            // 
            // cıkarma
            // 
            this.cıkarma.BackColor = System.Drawing.Color.Gold;
            this.cıkarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cıkarma.Location = new System.Drawing.Point(285, 175);
            this.cıkarma.Name = "cıkarma";
            this.cıkarma.Size = new System.Drawing.Size(60, 60);
            this.cıkarma.TabIndex = 30;
            this.cıkarma.Text = "-";
            this.cıkarma.UseVisualStyleBackColor = false;
            this.cıkarma.Click += new System.EventHandler(this.cıkarma_Click);
            // 
            // rakam8
            // 
            this.rakam8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rakam8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam8.Location = new System.Drawing.Point(219, 175);
            this.rakam8.Name = "rakam8";
            this.rakam8.Size = new System.Drawing.Size(60, 60);
            this.rakam8.TabIndex = 29;
            this.rakam8.Text = "8";
            this.rakam8.UseVisualStyleBackColor = false;
            this.rakam8.Click += new System.EventHandler(this.rakam8_Click);
            // 
            // rakam7
            // 
            this.rakam7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rakam7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam7.Location = new System.Drawing.Point(153, 175);
            this.rakam7.Name = "rakam7";
            this.rakam7.Size = new System.Drawing.Size(60, 60);
            this.rakam7.TabIndex = 28;
            this.rakam7.Text = "7";
            this.rakam7.UseVisualStyleBackColor = false;
            this.rakam7.Click += new System.EventHandler(this.rakam7_Click);
            // 
            // rakam6
            // 
            this.rakam6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rakam6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam6.Location = new System.Drawing.Point(87, 175);
            this.rakam6.Name = "rakam6";
            this.rakam6.Size = new System.Drawing.Size(60, 60);
            this.rakam6.TabIndex = 27;
            this.rakam6.Text = "6";
            this.rakam6.UseVisualStyleBackColor = false;
            this.rakam6.Click += new System.EventHandler(this.rakam6_Click);
            // 
            // rakam5
            // 
            this.rakam5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rakam5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam5.Location = new System.Drawing.Point(21, 175);
            this.rakam5.Name = "rakam5";
            this.rakam5.Size = new System.Drawing.Size(60, 60);
            this.rakam5.TabIndex = 26;
            this.rakam5.Text = "5";
            this.rakam5.UseVisualStyleBackColor = false;
            this.rakam5.Click += new System.EventHandler(this.rakam5_Click);
            // 
            // toplama
            // 
            this.toplama.BackColor = System.Drawing.Color.Gold;
            this.toplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplama.Location = new System.Drawing.Point(285, 89);
            this.toplama.Name = "toplama";
            this.toplama.Size = new System.Drawing.Size(60, 60);
            this.toplama.TabIndex = 25;
            this.toplama.Text = "+";
            this.toplama.UseVisualStyleBackColor = false;
            this.toplama.Click += new System.EventHandler(this.toplama_Click);
            // 
            // rakam4
            // 
            this.rakam4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rakam4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam4.Location = new System.Drawing.Point(219, 89);
            this.rakam4.Name = "rakam4";
            this.rakam4.Size = new System.Drawing.Size(60, 60);
            this.rakam4.TabIndex = 24;
            this.rakam4.Text = "4";
            this.rakam4.UseVisualStyleBackColor = false;
            this.rakam4.Click += new System.EventHandler(this.rakam4_Click);
            // 
            // rakam3
            // 
            this.rakam3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rakam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam3.Location = new System.Drawing.Point(153, 89);
            this.rakam3.Name = "rakam3";
            this.rakam3.Size = new System.Drawing.Size(60, 60);
            this.rakam3.TabIndex = 23;
            this.rakam3.Text = "3";
            this.rakam3.UseVisualStyleBackColor = false;
            this.rakam3.Click += new System.EventHandler(this.rakam3_Click);
            // 
            // rakam2
            // 
            this.rakam2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rakam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam2.Location = new System.Drawing.Point(87, 89);
            this.rakam2.Name = "rakam2";
            this.rakam2.Size = new System.Drawing.Size(60, 60);
            this.rakam2.TabIndex = 22;
            this.rakam2.Text = "2";
            this.rakam2.UseVisualStyleBackColor = false;
            this.rakam2.Click += new System.EventHandler(this.rakam2_Click);
            // 
            // rakam1
            // 
            this.rakam1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rakam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam1.Location = new System.Drawing.Point(21, 89);
            this.rakam1.Name = "rakam1";
            this.rakam1.Size = new System.Drawing.Size(60, 60);
            this.rakam1.TabIndex = 21;
            this.rakam1.Text = "1";
            this.rakam1.UseVisualStyleBackColor = false;
            this.rakam1.Click += new System.EventHandler(this.rakam1_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.Controls.Add(this.bolme);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.yüzde);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.carpma);
            this.Controls.Add(this.silbutonu);
            this.Controls.Add(this.floatsayı);
            this.Controls.Add(this.rakam0);
            this.Controls.Add(this.rakam9);
            this.Controls.Add(this.cıkarma);
            this.Controls.Add(this.rakam8);
            this.Controls.Add(this.rakam7);
            this.Controls.Add(this.rakam6);
            this.Controls.Add(this.rakam5);
            this.Controls.Add(this.toplama);
            this.Controls.Add(this.rakam4);
            this.Controls.Add(this.rakam3);
            this.Controls.Add(this.rakam2);
            this.Controls.Add(this.rakam1);
            this.Controls.Add(this.ekranlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "23410051061-Elife KILIÇ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ekranlbl;
        private System.Windows.Forms.Button bolme;
        private System.Windows.Forms.Button sonuc;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button yüzde;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button carpma;
        private System.Windows.Forms.Button silbutonu;
        private System.Windows.Forms.Button floatsayı;
        private System.Windows.Forms.Button rakam0;
        private System.Windows.Forms.Button rakam9;
        private System.Windows.Forms.Button cıkarma;
        private System.Windows.Forms.Button rakam8;
        private System.Windows.Forms.Button rakam7;
        private System.Windows.Forms.Button rakam6;
        private System.Windows.Forms.Button rakam5;
        private System.Windows.Forms.Button toplama;
        private System.Windows.Forms.Button rakam4;
        private System.Windows.Forms.Button rakam3;
        private System.Windows.Forms.Button rakam2;
        private System.Windows.Forms.Button rakam1;
    }
}

