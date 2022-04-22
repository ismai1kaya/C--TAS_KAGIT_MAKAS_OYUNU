using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEODEVİ
{
    public partial class Form1 : Form
    {
        int tur = 3;
        int turBasinaSure = 6;
        Boolean oyunDurumu = false;
        String[] BilgisayarSecimList = { "tas", "kagit", "makas" };
        int sayi = 0;
        Random rnd = new Random();
        string bilgisayarSecimi, oyuncuSecimi;
        int oyuncuSkor, bilgisayarSkor;

        public Form1()
        {
            InitializeComponent();
            zamanSay.Enabled = true;
            oyuncuSecimi = "none";
            lblGeriSay.Text = "5";
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            oyuncuSkor = 0;
            bilgisayarSkor = 0;
            lblGeriSay.Text = "5";
            int turBasinaSure = 6;
            tur = 3;
            lblSkor.Text = "Oyuncu:" + oyuncuSkor.ToString() + "-" + "Bilgisayar: " + bilgisayarSkor.ToString();
            oyuncuSecimi = "none";
            zamanSay.Enabled = true;
            picOyuncu.Image = Properties.Resources.qq;
            picBilgisayar.Image = Properties.Resources.qq;
            oyunDurumu = false;

        }

        private void btnTas_Click(object sender, EventArgs e)
        {
            picOyuncu.Image = Properties.Resources.taş;
            oyuncuSecimi = "tas";
        }

        private void btnKagit_Click(object sender, EventArgs e)
        {
            picOyuncu.Image = Properties.Resources.paper;
            oyuncuSecimi = "kagit";
        }

        private void btnMakas_Click(object sender, EventArgs e)
        {
            picOyuncu.Image = Properties.Resources.scissors;
            oyuncuSecimi = "makas";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void zamanSayaEvent(object sender, EventArgs e)
        {
            turBasinaSure -= 1;
            lblGeriSay.Text = turBasinaSure.ToString();
            lblTur.Text = "Tur " + tur;

            if (turBasinaSure < 1) 
                zamanSay.Enabled = false;

            sayi = rnd.Next(0, 3);
            bilgisayarSecimi = BilgisayarSecimList[sayi];

            switch (bilgisayarSecimi) {

                case "tas":
                    picBilgisayar.Image = Properties.Resources.taş;
                break;


                case "kagit":
                    picBilgisayar.Image = Properties.Resources.paper;
                break;


                case "makas":
                    picBilgisayar.Image = Properties.Resources.scissors;
                break;
            }
            if (tur > 0) {
                oyunKontrolu();
            }
            else
            {
                if (oyuncuSkor > bilgisayarSkor) {
                    MessageBox.Show("OYUNUN KAZANANI OYUNCU");
                }
                if (oyuncuSkor < bilgisayarSkor)
                {
                    MessageBox.Show("OYUNUN KAZANANI BİLGİSAYAR");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblTur_Click(object sender, EventArgs e)
        {

        }

        private void oyunKontrolu() {

            //bilgisayar için kazanma
            if (oyuncuSecimi == "tas" && bilgisayarSecimi == "kagit")
            {
                bilgisayarSkor += 1;
                tur -= 1;
                MessageBox.Show("Bilgisayar Kazandı");
            }
            else if (oyuncuSecimi == "makas" && bilgisayarSecimi == "tas")
            {
                bilgisayarSkor += 1;
                tur -= 1;
                MessageBox.Show("Bilgisayar Kazandı");
            }
            else if (oyuncuSecimi == "kagit" && bilgisayarSecimi == "makas")
            {
                bilgisayarSkor += 1;
                tur -= 1;
                MessageBox.Show("Bilgisayar Kazandı");
            }
            //oyuncu için kazanma
            else if (oyuncuSecimi == "kagit" && bilgisayarSecimi == "tas")
            {
                oyuncuSkor += 1;
                tur -= 1;
                MessageBox.Show("Oyuncu Kazandı");
            }
            else if (oyuncuSecimi == "tas" && bilgisayarSecimi == "makas")
            {
                oyuncuSkor += 1;
                tur -= 1;
                MessageBox.Show("Oyuncu Kazandı");
            }
            else if (oyuncuSecimi == "makas" && bilgisayarSecimi == "kagit")
            {
                oyuncuSkor += 1;
                tur -= 1;
                MessageBox.Show("Oyuncu Kazandı");
            }
            else if (oyuncuSecimi == "none") {
                MessageBox.Show("Seçim Yapın");
            }
            else
            {
                MessageBox.Show("Berabere");
            }
            yeniTur();
        }

        private void yeniTur() { 
            if(oyunDurumu == true)
            {
                return;
            }
            lblSkor.Text = "Oyuncu:" + oyuncuSkor.ToString() + "-" + "Bilgisayar: " + bilgisayarSkor.ToString();
            oyuncuSecimi = "none";
            zamanSay.Enabled = true;
            picOyuncu.Image = Properties.Resources.qq;
            picBilgisayar.Image = Properties.Resources.qq;
        
        }
    }
}
