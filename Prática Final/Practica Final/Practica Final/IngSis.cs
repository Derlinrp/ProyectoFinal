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
    public partial class IngSis : Form
    {

        SqlConnection conexion = new SqlConnection("Data Source=DERLIN-PC\\SQLEXPRESS;Initial Catalog=registro;Integrated Security=True");
        public IngSis()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MaestroHorario cerrar = new MaestroHorario();
            cerrar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand CMD = conexion.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "insert into IngSistema values('" + txtname.Text + "','" + txtlast.Text + "','" + cbEdi.Text + "','" + cbsec.Text + "','" + cbcua.Text + "','" + cbAi.Text + "','" + cbAula.Text + "','" + cbdias.Text + "', '" + cbasig.Text + "', '" + ctanda.Text + "','" + cbprimera.Text + "')";
            CMD.ExecuteNonQuery();
            txtname.Text = "";
            txtlast.Text = "";
            cbEdi.Text = "";
            cbsec.Text = "";
            cbAi.Text = "";
            ctanda.Text = "";
            cbasig.Text = "";
            cbAula.Text = "";
            cbcua.Text = "";
            cbdias.Text = "";
            cbprimera.Text = "";
            conexion.Close();
            disp_data();
            MessageBox.Show("Los Datos se han guardado correctamente", "Maestro de Ingenieria en Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
    }
        public void disp_data()
        {
            conexion.Open();
            SqlCommand CMD = conexion.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "select * from IngSistema";
            CMD.ExecuteNonQuery();
            DataTable datos = new DataTable();
            SqlDataAdapter tableadapter = new SqlDataAdapter(CMD);
            tableadapter.Fill(datos);
            dataGridView1.DataSource = datos;
            conexion.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand CMD = conexion.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "update IngSistema set Nombres = '" + textBox1.Text + "' where Nombres = '" + txtname.Text + "'";
            CMD.ExecuteNonQuery();
            conexion.Close();
            disp_data();
            MessageBox.Show("Los Datos se ha Modificado correctamente");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand CMD = conexion.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "select * from IngSistema where Nombres = '" + txtname.Text + "'";
            CMD.ExecuteNonQuery();
            DataTable datos = new DataTable();
            SqlDataAdapter tableadapter = new SqlDataAdapter(CMD);
            tableadapter.Fill(datos);
            dataGridView1.DataSource = datos;
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand CMD = conexion.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "delete from IngSistema where Nombres = '" + txtname.Text + "'";
            CMD.ExecuteNonQuery();
            conexion.Close();
            disp_data();
            MessageBox.Show("Los Datos se han Borrado correctamente");
        }

        private void IngSis_Load(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
