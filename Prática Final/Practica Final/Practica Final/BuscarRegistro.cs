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
    public partial class BuscarRegistro : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=DERLIN-PC\\SQLEXPRESS;Initial Catalog=registro;Integrated Security=True");
        public BuscarRegistro()
        {
            InitializeComponent();
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand CMD = conexion.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "SELECT * from tblregistro where Nombre ='" + txtbuscarRegistro.Text + "'";
            CMD.ExecuteNonQuery();
            DataTable Table = new DataTable();
            SqlDataAdapter Data = new SqlDataAdapter(CMD);
            Data.Fill(Table);
            dataGridViewRegistro.DataSource = Table;
            conexion.Close();
        }
        

        private void volverAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta volveratras = new Consulta();
            volveratras.Show();
            this.Hide();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Cerrar Sesion", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            InicioDeSesion cerrarsesion = new InicioDeSesion();
            cerrarsesion.Show();
            this.Hide();
            
        }
        public void disp_daa()
        {
            conexion.Open();
            SqlCommand CMD = conexion.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "select * from tblregistro";
            CMD.ExecuteNonQuery();
            DataTable Table = new DataTable();
            SqlDataAdapter Data = new SqlDataAdapter(CMD);
            Data.Fill(Table);
            dataGridViewRegistro.DataSource = Table;
            conexion.Close();


        }

        private void BuscarRegistro_Load(object sender, EventArgs e)
        {
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand CMD = conexion.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "delete from tblregistro where Nombre = '" + txtbuscarRegistro.Text + "'";
            CMD.ExecuteNonQuery();
            conexion.Close();
            disp_daa();
            MessageBox.Show("Los Datos se han Borrado correctamente");
        }
    }
}
