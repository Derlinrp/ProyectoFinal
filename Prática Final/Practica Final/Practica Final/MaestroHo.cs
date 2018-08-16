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
    public partial class MaestroHo : Form
    {
        public MaestroHo()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            

            }

        private void administraciónDeEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            
           
            
          
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ContHo Abrir = new ContHo();
            Abrir.MdiParent = this;
            Abrir.Show();
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            IngHo Abrir = new IngHo();
            Abrir.MdiParent = this;
            Abrir.Show();
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
          
         
            
        }

        private void administracionDeEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void contabilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContHo Abrir = new ContHo();
        
            Abrir.Show();
        }

        private void ingenieriaCivilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngHo Abrir = new IngHo();
           
            Abrir.Show();

        }

        private void ingenieriaEnSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            IngSis Abrir = new IngSis();
            Abrir.Show();
            this.Hide();
        }
    }
    }

