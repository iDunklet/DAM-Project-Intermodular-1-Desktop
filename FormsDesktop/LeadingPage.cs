using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDesktop
{
    public partial class LeadingPage : Form
    {
        public LeadingPage()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            flowLayoutPanel1.Left = (this.ClientSize.Width - flowLayoutPanel1.Width) / 2;
            flowLayoutPanel1.Top = (this.ClientSize.Height - flowLayoutPanel1.Height) / 2;
        }

        private void LeadingPage_Load(object sender, EventArgs e)
        {

        }

        private void LeadingPage_Resize(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
