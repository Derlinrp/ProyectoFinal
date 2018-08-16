using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Final
{
    public partial class RegistroEstudiante : Form
    {
        public RegistroEstudiante()
        {
            InitializeComponent();
        }

        private void volverAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumno VolverAtras = new Alumno();
            VolverAtras.Show();
            this.Hide();

            Registro Salir = new Registro();
            Salir.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
