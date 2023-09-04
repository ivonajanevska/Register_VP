using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class Кеш : Form
    {
        public bool kopce1klik = false;
        public bool kopce2klik = false;
        public bool kopce3klik = false;
        public bool ep1 = false;
        
        public Кеш()
        {
            InitializeComponent();
        }
        private void Кеш_Load(object sender, EventArgs e)
        {
            Naplata n = new Naplata();

        }

        public decimal Kusur (decimal total, decimal dadeno)
        {
            return  dadeno-total;
        }
        private void btnKes1_Click(object sender, EventArgs e)
        {
            kopce1klik = true;
        }

        private void tbKes_TextChanged(object sender, EventArgs e)
        {
            if(tbKes.Text.Length>0)
            {
                string inputKes = tbKes.Text;
                if(inputKes.All(char.IsDigit))
                {
                    errorProvider1.SetError(tbKes, "");
                    ep1 = true;
                }
                else
                {
                    errorProvider1.SetError(tbKes, "Внесете сума само во цифри!");
                }
            }
        }
        private void btnKes2_Click(object sender, EventArgs e)
        {
            kopce2klik = true;
        }

        private void btnKes3_Click(object sender, EventArgs e)
        {
            kopce3klik = true;
        }

        private void btnNaplati_Click(object sender, EventArgs e)
        {
            Fiskalna fiskalna = new Fiskalna();
            string sumata = lbTotal.Text;
            string sumaCifri = sumata.Split(' ')[0];
            decimal totalnaSuma = decimal.Parse(sumaCifri);
            if (tbKes.Text.Length>0)
            {
                
                if(ep1)
                {
                    string vnesenaS = tbKes.Text;
                    decimal vnesenaSuma = decimal.Parse(vnesenaS);

                    if (vnesenaSuma < totalnaSuma)
                    {
                        errorProviderPomalaSuma.SetError(tbKes, $"Недостасуваат уште {Kusur(totalnaSuma,vnesenaSuma)*-1} денари");

                    }
                    else
                    {
                        errorProviderPomalaSuma.SetError(tbKes, "");
                        string kusur = $"За враќање: {Kusur(totalnaSuma, vnesenaSuma)}";
                        lbKusur.Text = kusur;
                        fiskalna.ShowDialog();
                    }
                }
                
            }
            else if (kopce1klik || kopce2klik || kopce3klik)
            {
                if (kopce1klik)
                {
                    decimal kesBtn1 = decimal.Parse(btnKes1.Text);
                    lbKusur.Text = "За враќање:" +" "+Kusur(totalnaSuma, kesBtn1).ToString();
                    fiskalna.Show();
                }
                else if (kopce2klik)
                {
                    decimal kesBtn2 = decimal.Parse(btnKes2.Text);
                    lbKusur.Text = "За враќање:" + " " + Kusur(totalnaSuma, kesBtn2 ).ToString();
                    fiskalna.Show();
                }
                else if (kopce3klik)
                {
                    decimal kesBtn3 = decimal.Parse(btnKes3.Text);
                    lbKusur.Text = "За враќање:" + " " + Kusur(totalnaSuma, kesBtn3 ).ToString();
                    fiskalna.Show();
                }
                tbKes.Text = "";

            }
            
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
