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
    public partial class AdminHo : Form
    {

        SqlConnection conexion = new SqlConnection("Data Source=DERLIN-PC\\SQLEXPRESS;Initial Catalog=registro;Integrated Security=True");
        public AdminHo()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaestroHorario cerrar = new MaestroHorario();
            cerrar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand CMD = conexion.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "delete from AdminEmpresa where Nombres = '" + txtname.Text + "'";
            CMD.ExecuteNonQuery();
            conexion.Close();
            disp_data();
            MessageBox.Show("Los Datos se han Borrado correctamente");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand CMD = conexion.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "insert into AdminEmpresa values('" + txtname.Text + "','" + txtlast.Text + "','" + cbEdi.Text + "','" + cbsec.Text + "','" + cbcua.Text + "','" + cbAi.Text + "','" + cbAula.Text + "','" + cbdias.Text + "', '" + cbasig.Text + "', '" + ctanda.Text + "','" + cbprimera.Text + "')";
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
            MessageBox.Show("Los Datos se han guardado correctamente", "Maestro de Administracion de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void disp_data()
        {
            conexion.Open();
            SqlCommand CMD = conexion.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "select * from AdminEmpresa";
            CMD.ExecuteNonQuery();
            DataTable datos = new DataTable();
            SqlDataAdapter tableadapter = new SqlDataAdapter(CMD);
            tableadapter.Fill(datos);
            dataGridView1.DataSource = datos;
            
            conexion.Close();

        }

        private void AdminHo_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand CMD = conexion.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "update AdminEmpresa set Nombres ='" + textBox1.Text + "' where Nombres ='"+ txtname.Text + "'";
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
            CMD.CommandText = "select * from AdminEmpresa where Nombres = '"+txtname.Text+"'";
            CMD.ExecuteNonQuery();
            DataTable datos = new DataTable();
            SqlDataAdapter tableadapter = new SqlDataAdapter(CMD);
            tableadapter.Fill(datos);
            dataGridView1.DataSource = datos;
            conexion.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
