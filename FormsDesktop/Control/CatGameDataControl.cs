using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsDesktop.Classes;

namespace FormsDesktop.Control
{
    public partial class CatGameDataControl : UserControl
    {
        public CatGameDataControl()
        {
            InitializeComponent();
        }
        public void SetDatos(CatUserGameData gameData)
        {
            labelDificultad.Text = gameData.Dificulty;
            labelTiempo.Text = $"{gameData.GameTime}s";
            labelErrores.Text = $"{gameData.Errors}";
            labelPuntos.Text = $"{gameData.Points}";
            labelFecha.Text = DateTime.Parse(gameData.Date).ToString("dd/MM/yyyy HH:mm");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelTiempo_Click(object sender, EventArgs e)
        {

        }

        private void labelDificultad_Click(object sender, EventArgs e)
        {

        }
    }
}
