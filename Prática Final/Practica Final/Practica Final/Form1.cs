﻿using System;
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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Registro abrir = new Registro();
            abrir.Show();
            this.Hide();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Cerrar Sesion", "Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            InicioDeSesion cerrarsesion = new Practica_Final.InicioDeSesion();
            cerrarsesion.Show();
            this.Hide();
            
                
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {


        
            Consulta abrir = new Consulta();
            abrir.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
