
namespace PROJEODEVİ
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnTas = new System.Windows.Forms.Button();
            this.btnKagit = new System.Windows.Forms.Button();
            this.btnMakas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblGeriSay = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTekrarBaslat = new System.Windows.Forms.Button();
            this.zamanSay = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBilgisayar = new System.Windows.Forms.PictureBox();
            this.picOyuncu = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBilgisayar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOyuncu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTas
            // 
            this.btnTas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTas.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTas.Location = new System.Drawing.Point(225, 272);
            this.btnTas.Name = "btnTas";
            this.btnTas.Size = new System.Drawing.Size(147, 77);
            this.btnTas.TabIndex = 0;
            this.btnTas.Text = "TAŞ";
            this.btnTas.UseVisualStyleBackColor = false;
            this.btnTas.Click += new System.EventHandler(this.btnTas_Click);
            // 
            // btnKagit
            // 
            this.btnKagit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnKagit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKagit.Location = new System.Drawing.Point(225, 371);
            this.btnKagit.Name = "btnKagit";
            this.btnKagit.Size = new System.Drawing.Size(147, 77);
            this.btnKagit.TabIndex = 1;
            this.btnKagit.Text = "KAĞIT";
            this.btnKagit.UseVisualStyleBackColor = false;
            this.btnKagit.Click += new System.EventHandler(this.btnKagit_Click);
            // 
            // btnMakas
            // 
            this.btnMakas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMakas.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMakas.Location = new System.Drawing.Point(225, 464);
            this.btnMakas.Name = "btnMakas";
            this.btnMakas.Size = new System.Drawing.Size(147, 77);
            this.btnMakas.TabIndex = 2;
            this.btnMakas.Text = "MAKAS";
            this.btnMakas.UseVisualStyleBackColor = false;
            this.btnMakas.Click += new System.EventHandler(this.btnMakas_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(406, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "OYUNCU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSkor
            // 
            this.lblSkor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSkor.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(679, 272);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(343, 63);
            this.lblSkor.TabIndex = 5;
            this.lblSkor.Text = "Oyuncu:0 - Bilgisayar:0";
            this.lblSkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSkor.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblGeriSay
            // 
            this.lblGeriSay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblGeriSay.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGeriSay.Location = new System.Drawing.Point(683, 371);
            this.lblGeriSay.Name = "lblGeriSay";
            this.lblGeriSay.Size = new System.Drawing.Size(339, 56);
            this.lblGeriSay.TabIndex = 6;
            this.lblGeriSay.Text = "5";
            this.lblGeriSay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTur
            // 
            this.lblTur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTur.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTur.Location = new System.Drawing.Point(683, 493);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(339, 48);
            this.lblTur.TabIndex = 7;
            this.lblTur.Text = "Tur: 3";
            this.lblTur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTur.Click += new System.EventHandler(this.lblTur_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1100, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "BİLGİSAYAR";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTekrarBaslat
            // 
            this.btnTekrarBaslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTekrarBaslat.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTekrarBaslat.Location = new System.Drawing.Point(1106, 553);
            this.btnTekrarBaslat.Name = "btnTekrarBaslat";
            this.btnTekrarBaslat.Size = new System.Drawing.Size(229, 77);
            this.btnTekrarBaslat.TabIndex = 10;
            this.btnTekrarBaslat.Text = "TEKRAR BAŞLAT";
            this.btnTekrarBaslat.UseVisualStyleBackColor = false;
            this.btnTekrarBaslat.Click += new System.EventHandler(this.button1_Click);
            // 
            // zamanSay
            // 
            this.zamanSay.Interval = 7000;
            this.zamanSay.Tick += new System.EventHandler(this.zamanSayaEvent);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(158, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 141);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(389, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 74);
            this.label2.TabIndex = 2;
            this.label2.Text = "TAŞ KAĞIT MAKAS OYUNU";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PROJEODEVİ.Properties.Resources.stock_photo_rock_paper_scissors;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(326, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROJEODEVİ.Properties.Resources.stock_photo_close_clash_rock_paper_scissors;
            this.pictureBox1.Location = new System.Drawing.Point(842, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picBilgisayar
            // 
            this.picBilgisayar.Image = global::PROJEODEVİ.Properties.Resources.qq;
            this.picBilgisayar.Location = new System.Drawing.Point(1104, 263);
            this.picBilgisayar.Name = "picBilgisayar";
            this.picBilgisayar.Size = new System.Drawing.Size(229, 269);
            this.picBilgisayar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBilgisayar.TabIndex = 8;
            this.picBilgisayar.TabStop = false;
            // 
            // picOyuncu
            // 
            this.picOyuncu.Image = global::PROJEODEVİ.Properties.Resources.qq;
            this.picOyuncu.Location = new System.Drawing.Point(410, 272);
            this.picOyuncu.Name = "picOyuncu";
            this.picOyuncu.Size = new System.Drawing.Size(229, 269);
            this.picOyuncu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOyuncu.TabIndex = 3;
            this.picOyuncu.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJEODEVİ.Properties.Resources.images__1_;
            this.ClientSize = new System.Drawing.Size(1637, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTekrarBaslat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picBilgisayar);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblGeriSay);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picOyuncu);
            this.Controls.Add(this.btnMakas);
            this.Controls.Add(this.btnKagit);
            this.Controls.Add(this.btnTas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBilgisayar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOyuncu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTas;
        private System.Windows.Forms.Button btnKagit;
        private System.Windows.Forms.Button btnMakas;
        private System.Windows.Forms.PictureBox picOyuncu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblGeriSay;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.PictureBox picBilgisayar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTekrarBaslat;
        private System.Windows.Forms.Timer zamanSay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}

