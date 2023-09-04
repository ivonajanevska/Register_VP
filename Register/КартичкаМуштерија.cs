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
    public partial class КартичкаМуштерија : Form
    {
        public КартичкаМуштерија()
        {
            InitializeComponent();
        }

        private string generateKarticka ()
        {
            Random r = new Random();
            string brKarticka = null;
            for (int i = 0; i < 16; i++)
            {
                brKarticka += r.Next(10).ToString();
            }
            return brKarticka;
        }
        private string generateDatum()
        {
            Random r = new Random();

            int den = r.Next(1, 13);
            int godina = DateTime.Now.Year + r.Next(-2, 5);
            return $"{den}/{godina}";
        }

        private int generateSostojba()
        {
            Random r = new Random();
            int sostojba = r.Next(-10, 40000);
            return sostojba;
        }
        public void КартичкаМуштерија_Load(object sender, EventArgs e)
        {
            lbBrKarticka.Text = generateKarticka().ToString();
            lbEXPdate.Text = generateDatum().ToString();
            lbSostojba.Text = generateSostojba().ToString();
        }

        
    }
}
