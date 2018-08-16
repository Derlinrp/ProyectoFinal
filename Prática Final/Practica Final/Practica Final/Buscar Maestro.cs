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
    public partial class BuscarMaestro : Form
    {

        SqlConnection connect = new SqlConnection("Data Source=DERLIN-PC\\SQLEXPRESS;Initial Catalog=registro;Integrated Security=True");
        public BuscarMaestro()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta volveratras = new Consulta();
            volveratras.Show();
            this.Hide();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Cerrar Sesion", "Maestro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            InicioDeSesion cerrarsesion = new InicioDeSesion();
            cerrarsesion.Show();
            this.Hide();
        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal Volveralmenuprincipal = new frmMenuPrincipal();
            Volveralmenuprincipal.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Salir del Programa", "Maestro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            Close();
        }

        private void txtnombres_KeyUp(object sender, KeyEventArgs e)
        {
            connect.Open();

            SqlCommand CMD = connect.CreateCommand();

            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "SELECT * FROM tblmaestro where Nombres like ('" + txtnombres.Text + "%')";
            CMD.ExecuteNonQuery();

            DataTable Table = new DataTable();
            SqlDataAdapter Data = new SqlDataAdapter(CMD);

            Data.Fill(Table);

            dataGridView1.DataSource = Table;

            connect.Close();
        }

        private void cbedades_KeyUp(object sender, KeyEventArgs e)
        {
            connect.Open();
            SqlCommand CMD = connect.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "SELECT * FROM tblmaestro where Edad like ('" + cbedades.Text + "%')";
            CMD.ExecuteNonQuery();
            DataTable Table = new DataTable();
            SqlDataAdapter Data = new SqlDataAdapter(CMD);
    
            Data.Fill(Table);

            dataGridView1.DataSource = Table;

            connect.Close();
        }

        public void disp_data()
        {
            connect.Open();
            SqlCommand CMD = connect.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "select * from tblmaestro";
            CMD.ExecuteNonQuery();
            DataTable datos = new DataTable();
            SqlDataAdapter tableadapter = new SqlDataAdapter(CMD);
            tableadapter.Fill(datos);
            dataGridView1.DataSource = datos;

            connect.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand CMD = connect.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "delete from tblmaestro where Nombres = '" + txtnombres.Text + "'";
            CMD.ExecuteNonQuery();
            connect.Close();
            disp_data();
            MessageBox.Show("Los Datos se han Borrado correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand CMD = connect.CreateCommand();
            SqlCommand C = connect.CreateCommand();
            CMD.CommandType = CommandType.Text;
            C.CommandType = CommandType.Text;
            CMD.CommandText = "update tblmaestro set Nombres = '" + txtcambiar.Text + "' where Nombres ='" + txtnombres.Text + "'";
            C.CommandText = "update tblmaestro set Edad = '" + cbcambiarE.Text + "' where Edad ='" + cbedades.Text + "'";      
            txtnombres.Text = "";
            txtcambiar.Text = "";
            cbcambiarE.Text = "";
            cbedades.Text = "";       
            CMD.ExecuteNonQuery();
            C.ExecuteNonQuery();
          
            connect.Close();
            disp_data();
            MessageBox.Show("Los Datos se ha Modificado correctamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MaestroHorario abrir = new MaestroHorario();
            abrir.Show();
            this.Hide();
        }
    }
}
