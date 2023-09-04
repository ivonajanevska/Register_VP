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
    public partial class Declined : Form
    {
        public Declined()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Naplata np = new Naplata();
            np.Show();
        }
    }
}
