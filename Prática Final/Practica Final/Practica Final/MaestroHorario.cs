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
    public partial class MaestroHorario : Form
    {
        public MaestroHorario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContHo abrir = new ContHo();
            abrir.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IngHo abrir = new IngHo();
            abrir.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IngSis abrir = new IngSis();
            abrir.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            AdminHo abrir = new AdminHo();
            abrir.Show();
            this.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ContHo abrir = new ContHo();
            abrir.Show();
            this.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            IngHo abrir = new IngHo();
            abrir.Show();
            this.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            IngSis abrir = new IngSis();
            abrir.Show();
            this.Hide();
        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void volverAlRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro abrir = new Registro();
            abrir.Show();
            this.Hide();
        }

        private void volverAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioDeSesion abrir = new InicioDeSesion();
            abrir.Show();
            this.Hide();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscarMaestro abrir = new BuscarMaestro();
            abrir.Show();
            this.Hide();
        }
    }
}
