using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayi1,sayi2,sonuc;
        string islem,sonkarakter;

        private void btn2_Click(object sender, EventArgs e)
        {
            if(txtSayi.Text=="0"&& txtSayi.Text==null)
            {
                txtSayi.Text = "2"; 
            }
            else
            {
                txtSayi.Text = txtSayi.Text + "2";

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtSayi.Text == "0" && txtSayi.Text == null)
            {
                txtSayi.Text = "3";
            }
            else
            {
                txtSayi.Text = txtSayi.Text + "3";

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtSayi.Text == "0" && txtSayi.Text == null)
            {
                txtSayi.Text = "4";
            }
            else
            {
                txtSayi.Text = txtSayi.Text + "4";

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtSayi.Text == "0" && txtSayi.Text == null)
            {
                txtSayi.Text = "5";
            }
            else
            {
                txtSayi.Text = txtSayi.Text + "5";

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtSayi.Text == "0" && txtSayi.Text == null)
            {
                txtSayi.Text = "6";
            }
            else
            {
                txtSayi.Text = txtSayi.Text + "6";

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtSayi.Text == "0" && txtSayi.Text == null)
            {
                txtSayi.Text = "7";
            }
            else
            {
                txtSayi.Text = txtSayi.Text + "7";

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtSayi.Text == "0" && txtSayi.Text == null)
            {
                txtSayi.Text = "8";
            }
            else
            {
                txtSayi.Text = txtSayi.Text + "8";

            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtSayi.Text == "0" && txtSayi.Text == null)
            {
                txtSayi.Text = "9";
            }
            else
            {
                txtSayi.Text = txtSayi.Text + "9";

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtSayi.Text == "0" && txtSayi.Text == null)
            {
                txtSayi.Text = "0";
            }
            else
            {
                txtSayi.Text = txtSayi.Text + "0";

            }
        }

        private void btnvirgul_Click(object sender, EventArgs e)
        {
            txtSayi.Text = txtSayi.Text + ",";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtSayi.Text == "0" && txtSayi.Text == null) 
            {
                txtSayi.Text = "1";
            }
            else
            {
                txtSayi.Text = txtSayi.Text + "1";
            }

        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            sayi1=Convert.ToDouble(txtSayi.Text);
            txtSayi.Text=null;
            islem = "+";
        }

        private void btnCıkart_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(txtSayi.Text);
            txtSayi.Text = null;
            islem = "-";
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(txtSayi.Text);
            txtSayi.Text = null;
            islem = "*";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtSayi.Text=txtSayi.Text.Substring(0, txtSayi.Text.Length - 1);

        }

        private void btnBöl_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(txtSayi.Text);
            txtSayi.Text = null;
            islem = "/";
        }

        private void btnİslem_Click(object sender, EventArgs e)
        {
            sayi2=Convert.ToDouble(txtSayi.Text);

            if(islem=="+")
            {
                sonuc = (sayi1 + sayi2);
                txtSayi.Text = Convert.ToString(sonuc);
                sayi1=sonuc;
            }
            if (islem == "-")
            {
                sonuc = (sayi1 - sayi2);
                txtSayi.Text = Convert.ToString(sonuc);
                sayi1 = sonuc;
            }
            if (islem == "*")
            {
                sonuc = (sayi1 * sayi2);
                txtSayi.Text = Convert.ToString(sonuc);
                sayi1 = sonuc;
            }
            if (islem == "/")
                if (sayi2==0)
            {
                    txtSayi.Text = "uygulanamaz";
            }
            else
                {
                    sonuc = (sayi1 / sayi2);
                    txtSayi.Text = Convert.ToString(sonuc);
                    sayi1 = sonuc;
                }
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            txtSayi.Text = null;
        }
    }
}
