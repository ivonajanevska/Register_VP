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
    public partial class GiftCard : Form
    {
        public bool plakjanje = false;
        public bool doplati = false;
        public GiftCard()
        {
            InitializeComponent();
        }

        //private void btnNaplati_Click(object sender, EventArgs e)
        //{
        //    plakjanje = true;
        //    this.btnNaplati.DialogResult = System.Windows.Forms.DialogResult.OK;
        //    Close();
        //}

        //private void btnDoplati_Click(object sender, EventArgs e)
        //{
        //    //doplakjanje = true;
        //    Fiskalna ff = new Fiskalna();
        //    ff.Show();
            
        //}

        private void GiftCard_Load(object sender, EventArgs e)
        {
           if(plakjanje)
            {
                AcceptButton = btnNaplati;
            }
           else if (doplati)
            {
                AcceptButton = btnPlatiSi;
            }
                    

        }

        private void btnPlatiSi_Click(object sender, EventArgs e)
        {
            Naplata n = new Naplata();
            textBox1.Text = n.tbTotal.Text;
            //doplati = true;
            //Naplata n = new Naplata();

            //n.tbTotal.Text = tbDoplata.Text;
            ////this.btnNaplati.DialogResult = System.Windows.Forms.DialogResult.OK;
            
        }
    }
}
