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
    public partial class GIFT : Form
    {
        static string generiranjeID(Random random, int dolzina)
        {
            string id = "";

            for (int i = 0; i < dolzina; i++)
            {
                int cif = random.Next(10);
                id += cif.ToString();
            }
            return id;
        }
        public GIFT()
        {
            InitializeComponent();
        }

        private void GIFT_Load(object sender, EventArgs e)
        {
            Naplata n = new Naplata();
            Random random = new Random();
            string randomID = generiranjeID(random, 12);
            //decimal vknew = 0; //Promenliva koja cuva vrednost za vkupno po promena
            tbID.Text = randomID.ToString();
            int[] moznaSostojba = { 1000, 2000, 3000 };
            int randomStostojba = random.Next(0, moznaSostojba.Length);
            int randomGiftSostojba = moznaSostojba[randomStostojba];
            tbSostojba.Text = randomGiftSostojba.ToString();
            decimal vkupno = decimal.Parse(lbVkupno.Text);
            decimal novaSostojba = randomGiftSostojba - vkupno;
            if (novaSostojba>=0)
            {
                btnDoplati.Enabled = false;
                //NAPLATA POMINUVA
                tbNovaSostojba.Text = novaSostojba.ToString();
                tbDoplata.Text = "0";


            }
            else if (novaSostojba<0)
            {
                btnNaplati.Enabled = false;
                tbNovaSostojba.Text = "0";
                decimal doplata = vkupno - randomGiftSostojba;
                tbDoplata.Text = doplata.ToString();

            }
            //decimal doplata = vkupno - 2;
        }

        private void btnNaplati_Click(object sender, EventArgs e)
        {
            this.btnNaplati.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnDoplati_Click(object sender, EventArgs e)
        {
            this.btnDoplati.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
