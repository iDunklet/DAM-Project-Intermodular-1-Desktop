using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsDesktop.Control;

namespace FormsDesktop
{
    public partial class LeadingPage : Form
    {
        public LeadingPage()
        {
            InitializeComponent();
            UsuarioControl control = new UsuarioControl();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            flowLayoutPanel1.Left = (this.ClientSize.Width - flowLayoutPanel1.Width) / 2;
            flowLayoutPanel1.Top = (this.ClientSize.Height - flowLayoutPanel1.Height) / 2;
        }

        private void LeadingPage_Load(object sender, EventArgs e)
        {
            var uc = new UsuarioControl();
            uc.Location = new Point(20, 20);

            uc.EditarClick += (s, ev) => MessageBox.Show("EDITAR desde el Form");
            uc.EliminarClick += (s, ev) => MessageBox.Show("ELIMINAR desde el Form");

            Controls.Add(uc);
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
