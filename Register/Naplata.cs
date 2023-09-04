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
    public partial class Naplata : Form
    {
        Fiskalna f = new Fiskalna();
        public Naplata()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            Кеш kes = new Кеш();
            kes.Show();
            kes.lbTotal.Text = tbTotal.Text + " " + "денари";
            kes.btnKes1.Text = tbTotal.Text;
            decimal kopce2 = 0;
            //decimal kesCustomer = 0;
            decimal totalCena = decimal.Parse(tbTotal.Text);
            if (10 >= totalCena)
                kopce2 = 10;
            else if (100 >= totalCena)
                kopce2 = 100;
            else if (200 >= totalCena)
                kopce2 = 200;
            else if (500 >= totalCena)
                kopce2 = 500;
            else if (1000 >= totalCena)
                kopce2 = 1000;
            else if (2000 >= totalCena)
                kopce2 = 2000;
            kes.btnKes2.Text = kopce2.ToString(); 
            

            //Трето копче
            decimal kopce3 = 0;
            if (10 > kopce2)
                kopce3 = 10;
            else if (100 > kopce2)
                kopce3 = 100;
            else if (200 > kopce2)
                kopce3 = 200;
            else if (500 > kopce2)
                kopce3 = 500;
            else if (1000 > kopce2)
                kopce3 = 1000;
            else if (2000 > kopce2)
                kopce3 = 3000;
            kes.btnKes3.Text = kopce3.ToString();

           
        }

        private void btnGift_Click(object sender, EventArgs e)
        {
            GIFT g = new GIFT();
            g.lbVkupno.Text = tbTotal.Text;
            g.ShowDialog();
            if (g.DialogResult == DialogResult.OK)
            {
                tbTotal.Text = "0";
                Fiskalna f = new Fiskalna();
                f.ShowDialog();
            }
            if (g.DialogResult ==DialogResult.Cancel)
            {
                g.Close();
                decimal nSostojba = decimal.Parse(g.tbDoplata.Text);
                tbTotal.Text = nSostojba.ToString();
            }
            

        }

        private void Naplata_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in lbProizvodiNaplata.Items)
                {
                    f.lbProizvodi.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnKarticka_Click(object sender, EventArgs e)
        {
            Картичка k = new Картичка();
            k.totalna = decimal.Parse(tbTotal.Text);
            k.Show();
        }

        private void lbProizvodiNaplata_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
