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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioDeSesion CerrarSesion = new InicioDeSesion();
            CerrarSesion.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Maestro abrir = new Maestro();
            abrir.Show();
            this.Hide();

            
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarAlumno alumno = new BuscarAlumno();
            alumno.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal volverAlMenuPrincipal = new Practica_Final.frmMenuPrincipal();
            volverAlMenuPrincipal.Show();
            this.Hide();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Alumno abrir = new Alumno();
            abrir.Show();
            this.Hide();
        }
    }
}
