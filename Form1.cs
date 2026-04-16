using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi_Elife_KILIÇ
{
    public partial class form1 : Form
    {
        char _islem;
        bool _ekranTemizlenecekMi;
        double _ilkSayi;
        double _hafiza = 0;
        bool _hafizadaSayiVarMi = false;
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rakam1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";
            ekranlbl.Text += "1";
        }

        private void rakam2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";
            ekranlbl.Text += "2";
        }

        private void rakam3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";
            ekranlbl.Text += "3";
        }

        private void rakam4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";
            ekranlbl.Text += "4";
        }

        private void rakam5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";
            ekranlbl.Text += "5";
        }

        private void rakam6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";
            ekranlbl.Text += "6";
        }

        private void rakam7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";
            ekranlbl.Text += "7";
        }

        private void rakam8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";
            ekranlbl.Text += "8";
        }

        private void rakam9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";
            ekranlbl.Text += "9";
        }

        private void rakam0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";
            ekranlbl.Text += "0";
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToDouble(ekranlbl.Text);

        }
        private void cıkarma_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToDouble(ekranlbl.Text);
        }
        private void carpma_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToDouble(ekranlbl.Text);
        }
        private void bolme_Click(object sender, EventArgs e)
        { 
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToDouble(ekranlbl.Text);
        }

        private void sonuc_Click(object sender, EventArgs args)
        {
            double ikinciSayi = Convert.ToDouble(ekranlbl.Text);
            double sonuc = 0;
            

            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                case 'A':
                    sonuc = (_ilkSayi + ikinciSayi) / 2;
                    break;
            }
            ekranlbl.Text = Convert.ToString(sonuc);
        }

        private void silbutonu_Click(object sender, EventArgs e)
        {
            ekranlbl.Text = "0";
        }

        private void floatsayı_Click(object sender, EventArgs e)
        {
            if (!ekranlbl.Text.Contains(","))
            {
                ekranlbl.Text += ",";
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            _ilkSayi = Convert.ToDouble(ekranlbl.Text); 
            _islem = 'A';                             
            _ekranTemizlenecekMi = true;

        }

        private void yüzde_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(ekranlbl.Text);
            sayi = sayi / 100;
            ekranlbl.Text = sayi.ToString();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {

            if (!_hafizadaSayiVarMi)
            {
                _hafiza = Convert.ToDouble(ekranlbl.Text);
                ekranlbl.Text = "";
                _hafizadaSayiVarMi = true;
            }
            else
            {
                ekranlbl.Text = _hafiza.ToString();
                _hafizadaSayiVarMi = false;
            }
        }
    }

        
}
