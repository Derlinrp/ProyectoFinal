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
    public partial class NuevaCuenta : Form
    {
        public NuevaCuenta()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
        }

        private void volverAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            InicioDeSesion Abrir = new InicioDeSesion();
            Abrir.Show();
            this.Hide();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtConfirmar.Text)
            {
                if (UsuarioDal.CrearCuentas(txtUsuario.Text, txtContraseña.Text) > 0)
                {
                    MessageBox.Show("Su cuenta ha sido creada");
                }
                else
                    MessageBox.Show("Su Cuenta no ha sido creada");

                InicioDeSesion abrir = new InicioDeSesion();
                abrir.Show();
                this.Hide();
            }
        }
    }
       
        }
    

