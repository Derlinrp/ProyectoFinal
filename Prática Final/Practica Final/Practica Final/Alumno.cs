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
    
    public partial class Alumno : Form
        
    {
        public Alumno()
        {
            InitializeComponent();
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            Registro abrir = new Registro();
            abrir.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void volverAlMenúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal VolverAlMenuPrincipal = new frmMenuPrincipal();
            VolverAlMenuPrincipal.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Cerrar Sesion", "Alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            InicioDeSesion salir = new InicioDeSesion();
            salir.Show();
            this.Hide();

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Salir del Programa", "Alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BuscarAlumno abrir = new BuscarAlumno();
            abrir.Show();
            this.Hide();

            }
        
        private void button1_Click_1(object sender, EventArgs e)
        
          {
               
            }

            

        private void cbsexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtmatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void Alumno_Load(object sender, EventArgs e)
        {

        }

        private void voverAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro volver = new Registro();
            volver.Show();
            this.Hide();
                
        }

        private void volverAlRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro volver = new Registro();
            volver.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Administracion_de_Empresa abrir = new Administracion_de_Empresa();
            abrir.Show();
            this.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            AContabilidad abrir = new AContabilidad();
            abrir.Show();
            this.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Civil abrir = new Civil();
            abrir.Show();
            this.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
          Sistema abrir = new Sistema();
            abrir.Show();
            this.Hide();
        }
    }
    }

