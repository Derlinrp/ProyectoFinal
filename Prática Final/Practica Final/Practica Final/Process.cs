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
    public partial class Process : Form
       
    {
        public Process()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Proceso();
        }

        private void Process_Load(object sender, EventArgs e)
        {
            label2.Parent = groupBox1;
            label2.BackColor = Color.Transparent;
          
        }
        public void Proceso()
        {
            progressBar1.Increment(2);
            label2.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
