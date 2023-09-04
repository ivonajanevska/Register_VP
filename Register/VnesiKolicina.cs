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
    public partial class VnesiKolicina : Form
    {
        public VnesiKolicina()
        {
            InitializeComponent();
        }

        public string getCena 
        {
            get { return tbCena.Text; }
            //get; set; 
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void VnesiKolicina_Load(object sender, EventArgs e)
        {

        }

        public void tbArtikl_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.btnPotvrdi.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
