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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarRegistro abrir = new BuscarRegistro();
            abrir.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarAlumno abrir = new BuscarAlumno();
            abrir.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuscarMaestro abrir = new BuscarMaestro();
            abrir.Show();
            this.Hide();
        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal volverAlMenuPrincipal = new frmMenuPrincipal();
            volverAlMenuPrincipal.Show();
            this.Hide();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Cerrar Sesiom", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            InicioDeSesion cerrarsesion = new InicioDeSesion();
            cerrarsesion.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Salir del Programa", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            Close();
        }
    }
}
