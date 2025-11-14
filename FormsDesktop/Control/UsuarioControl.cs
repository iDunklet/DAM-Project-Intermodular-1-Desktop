using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDesktop.Control
{
    public partial class UsuarioControl : UserControl
    {
        public event EventHandler EditarClick;
        public event EventHandler EliminarClick;
        public UsuarioControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

            private void button1_Click(object sender, EventArgs e)
            {
                contextMenuStrip1.Show(button1, 0, button1.Height);
            }

            private void editarToolStripMenuItem_Click(object sender, EventArgs e)
            {
                EditarClick?.Invoke(this, EventArgs.Empty);
            }

            private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
            {
                EliminarClick?.Invoke(this, EventArgs.Empty);
            }
        }
}
