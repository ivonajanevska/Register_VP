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
    public partial class Fiskalna : Form
    {
        //Naplata n = new Naplata();
        string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
        public Fiskalna()
        {
            InitializeComponent();
        }
        
        
        private void Fiskalna_Load(object sender, EventArgs e)
        {
            lbDate.Text = currentDate;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
