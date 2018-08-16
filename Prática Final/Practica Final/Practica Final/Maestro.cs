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
    public partial class Maestro : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=DERLIN-PC\\SQLEXPRESS;Initial Catalog=registro;Integrated Security=True");
        public Maestro()
        {
            InitializeComponent();
        }

        private void volverAlPrincipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro VolverAlPrincipio = new Registro();
            VolverAlPrincipio.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioDeSesion cerrarsesion = new InicioDeSesion();
            cerrarsesion.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuscarMaestro abrir = new BuscarMaestro();
            abrir.Show();
            this.Hide(); 
        }

        private void volverAlMenuPrincipalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal volver = new frmMenuPrincipal();
            volver.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                connect.Open();
                SqlCommand Comando = connect.CreateCommand();
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = "insert into tblmaestro values('"+txtmnombre.Text+"','"+txtmapellido.Text+"','"+txtdireccion.Text+"','"+mtxtfecha.Text +"','"+ cbedad.Text +"','"+cbsexo.Text+"','"+mtxttelefono.Text+"','"+mtxtcelular.Text+"','"+mtxtcedula.Text+"','" + cbCcarrera.Text + "')";
                Comando.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Los Datos se han guardado correctamente", "Registro de Maestro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MaestroHorario abrir = new MaestroHorario();
                abrir.Show();
                this.Hide();

        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro volver = new Registro();
            volver.Show();
            this.Hide();
        }
    }
}
