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
    public partial class Form1 : Form
    {
        public decimal totalPrice = 0;
        VnesiKolicina vk = new VnesiKolicina();
        DodadenProizvod dp = new DodadenProizvod();
        
        public Form1()
        {
            InitializeComponent();
            
        }
        
        

        private void presmetki()
        {
            
            //int cena = 250; // ostanuva 
            int cena = int.Parse(vk.tbCena.Text);
            decimal totalProizvod = 0;
            //ova e KLASA

            //VnesiKolicina vk = new VnesiKolicina();    //ova e FORMA
            Naplata n = new Naplata();
            Fiskalna f = new Fiskalna();

            //vk.tbArtikl.Text = l1.Text; //p
            vk.cenaKGparce.Text = cena.ToString();//p
            

            vk.ShowDialog();
            totalProizvod += cena * vk.nudKolicina.Value;
            vk.tbCena.Text = totalProizvod.ToString();
            dp.Kolicina = vk.nudKolicina.Value;
            if (vk.DialogResult == DialogResult.OK)
            {
                dp.Cena = totalProizvod;
                lbProizvodi.Items.Add(dp.ToString());
                f.lbProizvodi.Items.Add(dp.ToString());
                
            }
            totalPrice += totalProizvod;
            tbTotal.Text = totalPrice.ToString();
            vk.nudKolicina.Value = 1;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l1.Text;
            vk.tbCena.Text = "350";
            presmetki();
            

        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {   
            
            Naplata naplata = new Naplata();
            naplata.Show();
            foreach (var item in lbProizvodi.Items)
            {
                naplata.lbProizvodiNaplata.Items.Add(item);
            }
           
            naplata.tbTotal.Text = tbTotal.Text;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l1.Text;
            presmetki();
        }

        private void l2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {
                
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l2.Text;
            vk.tbCena.Text = "400";
            dp.Artikl = l2.Text;
            presmetki();
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l3.Text;
            vk.tbCena.Text = "700";
            dp.Artikl = l3.Text;
            presmetki();
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l4.Text;
            vk.tbCena.Text = "525";
            dp.Artikl = l4.Text;
            presmetki();
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l5.Text;
            vk.tbCena.Text = "240";
            dp.Artikl = l5.Text;
            presmetki();
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l6.Text;
            vk.tbCena.Text = "199";
            dp.Artikl = l6.Text;
            presmetki();
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l7.Text;
            vk.tbCena.Text = "229";
            dp.Artikl = l7.Text;
            presmetki();
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l8.Text;
            vk.tbCena.Text = "250";
            dp.Artikl = l8.Text;
            presmetki();
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l9.Text;
            vk.tbCena.Text = "79";
            dp.Artikl = l9.Text;
            presmetki();
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l10.Text;
            vk.tbCena.Text = "59";
            dp.Artikl = l10.Text;
            presmetki();
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l11.Text;
            vk.tbCena.Text = "49";
            dp.Artikl = l11.Text;
            presmetki();
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l12.Text;
            vk.tbCena.Text = "180";
            dp.Artikl = l12.Text;
            presmetki();
        }

        private void pb13_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l13.Text;
            vk.tbCena.Text = "40";
            dp.Artikl = l13.Text;
            presmetki();
        }

        private void pb14_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l14.Text;
            vk.tbCena.Text = "39";
            dp.Artikl = l14.Text;
            presmetki();
        }

        private void pb15_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l15.Text;
            vk.tbCena.Text = "79";
            dp.Artikl = l15.Text;
            presmetki();
        }

        private void pb16_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l16.Text;
            vk.tbCena.Text = "899";
            dp.Artikl = l16.Text;
            presmetki();
        }

        private void pb17_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l17.Text;
            vk.tbCena.Text = "549";
            dp.Artikl = l17.Text;
            presmetki();
        }

        private void pb18_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l18.Text;
            vk.tbCena.Text = "259";
            dp.Artikl = l18.Text;
            presmetki();
        }

        private void pb19_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l19.Text;
            vk.tbCena.Text = "99";
            dp.Artikl = l19.Text;
            presmetki();
        }

        private void pb20_Click(object sender, EventArgs e)
        {
            vk.tbArtikl.Text = l20.Text;
            vk.tbCena.Text = "399";
            dp.Artikl = l20.Text;
            presmetki();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(lbProizvodi.SelectedIndex!=-1)
            {
                lbProizvodi.Items.RemoveAt(lbProizvodi.SelectedIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
