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
    public partial class Картичка : Form
    {
        public decimal totalna { get; set; }
        public Картичка()
        {
            InitializeComponent();
        }

        private void Картичка_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //NAPRAVI DA TECE TAJMEROT
            
                button1.Enabled = false;
                progressBar1.Value = 0;
                timer1.Start();
                //if (progressBar1.Value==progressBar1.Maximum)
                


            //SE OSTANATO

            

            //label1.Text = mesec;

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if(progressBar1.Value==progressBar1.Maximum)
            {
                timer1.Stop(); //STOPIRAJ GO TAJMEROT AKO SE NAPOLNE
                button1.Enabled = true; //OVOZMOZI GO KOPCETO
                
                КартичкаМуштерија km = new КартичкаМуштерија();
                km.Show();


                 //EXPdate 01/2023  -> godinata
                 decimal mesec = decimal.Parse(km.lbEXPdate.Text.Split('/')[0]); //mesec
                                                                                    //textBox1.Text = mesec.ToString();

                 decimal godina = decimal.Parse(km.lbEXPdate.Text.Split('/')[1]);//godina
                 //textBox2.Text = godina.ToString();

                 decimal currentYear = DateTime.Now.Year;
                 //textBox3.Text = currentYear.ToString();

                 decimal currentMonth = DateTime.Now.Month;
                 //textBox4.Text = currentMonth.ToString();
                 decimal currSostojba = decimal.Parse(km.lbSostojba.Text);
                 if (godina >= currentYear)
                 {
                     if (mesec >= currentMonth && godina==currentYear || mesec>0)
                     {
                         if (currSostojba >= totalna)
                         {
                            //USPESNA TRANSAKCIJA
                            Fiskalna f = new Fiskalna();
                            f.Show();
                         }
                         else
                         {
                             MessageBox.Show("Корисникот нема доволно средства на сметката", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         }
                     }
                     else
                     {
                            MessageBox.Show("Рокот на картичката на купувачот1 е истечена ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                 }
                 else
                 {
                        MessageBox.Show("Рокот на картичката на купувачот1 е истечена ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                
            }
        }

        
    }
}
