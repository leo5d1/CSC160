using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Cont : Form
    {
        public Cont()
        {
            InitializeComponent();
        }

        private void gBox1_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int r = random.Next(1, 11);
            lblMsg.Text = r.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
