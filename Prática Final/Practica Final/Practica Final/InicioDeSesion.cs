using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practica_Final
{
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void crearNuevaCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UsuarioDal.IniciarSesion(txtusuario.Text, txtcontraseña.Text) > 0)
                
            {
                Process abrir = new Process();
                abrir.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Ingrese los datos correctamente");
        }

        private void crearCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaCuenta InicioDeSesion = new NuevaCuenta();
            InicioDeSesion.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
