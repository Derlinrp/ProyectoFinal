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
    public partial class BuscarAlumno : Form
    {

       
        public BuscarAlumno()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmMenuPrincipal volveratras = new frmMenuPrincipal();
            volveratras.Show();
            this.Hide();
        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta volveralmenuprincipal = new Consulta();
            volveralmenuprincipal.Show();
            this.Hide();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Cerrar Sesion", "Alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            InicioDeSesion cerrarsesion = new InicioDeSesion();
            cerrarsesion.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Salir del Programa", "Alumno", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            Close();
        }

        SqlConnection connect = new SqlConnection("Data Source=DERLIN-PC\\SQLEXPRESS;Initial Catalog=registro;Integrated Security=True");

        private void txtopciones_TextChanged(object sender, EventArgs e)
        {
                        }

        private void dgvbuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtnombre_KeyUp(object sender, KeyEventArgs e)
        {
            connect.Open();

            SqlCommand CMD = connect.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "SELECT * FROM tbladministracion where Nombres like ('" + txtnombres.Text + "')";
            CMD.ExecuteNonQuery();
            DataTable Table = new DataTable();
            SqlDataAdapter Data = new SqlDataAdapter(CMD);
            Data.Fill(Table);
            dataGridView1.DataSource = Table;


            SqlCommand CONTA = connect.CreateCommand();
            CONTA.CommandType = CommandType.Text;
            CONTA.CommandText = "SELECT * FROM tblcontabilidad where Nombres like ('" + txtnombres.Text + "')";
            CONTA.ExecuteNonQuery();
            DataTable BILI = new DataTable();
            SqlDataAdapter DAD = new SqlDataAdapter(CONTA);
            DAD.Fill(BILI);
            dataGridView2.DataSource = BILI;

            SqlCommand INGE = connect.CreateCommand();
            INGE.CommandType = CommandType.Text;
            INGE.CommandText = "SELECT * FROM tblcivil where Nombres like ('" + txtnombres.Text + "')";
            INGE.ExecuteNonQuery();
            DataTable NIERIA = new DataTable();
            SqlDataAdapter CIVIL = new SqlDataAdapter(INGE);
            CIVIL.Fill(NIERIA);
            dataGridView3.DataSource = NIERIA;

            SqlCommand SIS = connect.CreateCommand();
            SIS.CommandType = CommandType.Text;
            SIS.CommandText = "SELECT * FROM tblsistema where Nombres like ('" + txtnombres.Text + "')";
            SIS.ExecuteNonQuery();
            DataTable TEMA = new DataTable();
            SqlDataAdapter COMPU = new SqlDataAdapter(SIS);
            COMPU.Fill(TEMA);
            dataGridView4.DataSource = TEMA;

            connect.Close();

        }

        private void cbedad_KeyUp(object sender, KeyEventArgs e)
        {
            connect.Open();
            SqlCommand CMD = connect.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "SELECT * FROM tbladministracion where Edad like ('" + cbedades.Text + "')";
            CMD.ExecuteNonQuery();
            DataTable Table = new DataTable();
            SqlDataAdapter Data = new SqlDataAdapter(CMD);
            Data.Fill(Table);
            dataGridView1.DataSource = Table;

            SqlCommand CONTA = connect.CreateCommand();
            CONTA.CommandType = CommandType.Text;
            CONTA.CommandText = "SELECT * FROM tblcontabilidad where Edad like ('" + cbedades.Text + "')";
            CONTA.ExecuteNonQuery();
            DataTable BILI = new DataTable();
            SqlDataAdapter DAD = new SqlDataAdapter(CONTA);
            DAD.Fill(BILI);
            dataGridView2.DataSource = BILI;

            SqlCommand INGE = connect.CreateCommand();
            INGE.CommandType = CommandType.Text;
            INGE.CommandText = "SELECT * FROM tblcivil where Edad like ('" + cbedades.Text + "')";
            INGE.ExecuteNonQuery();
            DataTable NIERIA = new DataTable();
            SqlDataAdapter CIVIL = new SqlDataAdapter(INGE);
            CIVIL.Fill(NIERIA);
            dataGridView3.DataSource = NIERIA;

            SqlCommand SIS = connect.CreateCommand();
            SIS.CommandType = CommandType.Text;
            SIS.CommandText = "SELECT * FROM tblsistema where Edad like ('" + cbedades.Text + "')";
            SIS.ExecuteNonQuery();
            DataTable TEMA = new DataTable();
            SqlDataAdapter COMPU = new SqlDataAdapter(SIS);
            COMPU.Fill(TEMA);
            dataGridView4.DataSource = TEMA;

            connect.Close();
        }

        private void cbcarrera_KeyUp(object sender, KeyEventArgs e)
        {
            connect.Open();
            SqlCommand CMD = connect.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "SELECT * FROM tbladministracion where Carrera like ('" + cbcarreras.Text + "')";
            CMD.ExecuteNonQuery();
            DataTable Table = new DataTable();
            SqlDataAdapter Data = new SqlDataAdapter(CMD);
            Data.Fill(Table);
            dataGridView1.DataSource = Table;

            SqlCommand CONTA = connect.CreateCommand();
            CONTA.CommandType = CommandType.Text;
            CONTA.CommandText = "SELECT * FROM tblcontabilidad where Carrera like ('" + cbcarreras.Text + "')";
            CONTA.ExecuteNonQuery();
            DataTable BILI = new DataTable();
            SqlDataAdapter DAD = new SqlDataAdapter(CONTA);
            DAD.Fill(BILI);
            dataGridView2.DataSource = BILI;

            SqlCommand INGE = connect.CreateCommand();
            INGE.CommandType = CommandType.Text;
            INGE.CommandText = "SELECT * FROM tblcivil where Carrera like ('" + cbcarreras.Text + "')";
            INGE.ExecuteNonQuery();
            DataTable NIERIA = new DataTable();
            SqlDataAdapter CIVIL = new SqlDataAdapter(INGE);
            CIVIL.Fill(NIERIA);
            dataGridView3.DataSource = NIERIA;

            SqlCommand SIS = connect.CreateCommand();
            SIS.CommandType = CommandType.Text;
            SIS.CommandText = "SELECT * FROM tblsistema where Carrera like ('" + cbcarreras.Text + "')";
            SIS.ExecuteNonQuery();
            DataTable TEMA = new DataTable();
            SqlDataAdapter COMPU = new SqlDataAdapter(SIS);
            COMPU.Fill(TEMA);
            dataGridView4.DataSource = TEMA;
            connect.Close();
        }
        public void disp_data()
        {
            connect.Open();
            SqlCommand CMD = connect.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "select * from tbladministracion";
            CMD.ExecuteNonQuery();
            DataTable datos = new DataTable();
            SqlDataAdapter tableadapter = new SqlDataAdapter(CMD);
            tableadapter.Fill(datos);
            dataGridView1.DataSource = datos;

            
            SqlCommand C = connect.CreateCommand();
            C.CommandType = CommandType.Text;
            C.CommandText = "select * from tblcontabilidad";
            C.ExecuteNonQuery();
            DataTable co = new DataTable();
            SqlDataAdapter c = new SqlDataAdapter(C);
            c.Fill(co);
            dataGridView2.DataSource = co;

            SqlCommand M = connect.CreateCommand();
            M.CommandType = CommandType.Text;
            M.CommandText = "select * from tblcivil";
            M.ExecuteNonQuery();
            DataTable ta = new DataTable();
            SqlDataAdapter TA = new SqlDataAdapter(M);
            TA.Fill(ta);
            dataGridView3.DataSource = ta;

            SqlCommand D = connect.CreateCommand();
            D.CommandType = CommandType.Text;
            D.CommandText = "select * from tblsistema";
            D.ExecuteNonQuery();
            DataTable si = new DataTable();
            SqlDataAdapter table = new SqlDataAdapter(D);
            table.Fill(si);
            dataGridView4.DataSource = si;

            connect.Close();

        }

        private void cbcarreras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand CMD = connect.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "delete from tbladministracion where Nombres = '" + txtnombres.Text+ "'";
            CMD.ExecuteNonQuery();

            SqlCommand C = connect.CreateCommand();
            C.CommandType = CommandType.Text;
            C.CommandText = "delete from tblcontabilidad where Nombres = '" + txtnombres.Text + "'";
            C.ExecuteNonQuery();

            SqlCommand M = connect.CreateCommand();
            M.CommandType = CommandType.Text;
            M.CommandText = "delete from tblcivil where Nombres = '" + txtnombres.Text + "'";
            M.ExecuteNonQuery();

            SqlCommand D = connect.CreateCommand();
            D.CommandType = CommandType.Text;
            D.CommandText = "delete from tblsistema where Nombres = '" + txtnombres.Text + "'";
            D.ExecuteNonQuery();

            connect.Close();
            disp_data();
            MessageBox.Show("Los Datos se han Borrado correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand CMD = connect.CreateCommand();
            SqlCommand C = connect.CreateCommand();
            SqlCommand M = connect.CreateCommand();
            CMD.CommandType = CommandType.Text;
            C.CommandType = CommandType.Text;
            M.CommandType = CommandType.Text;
            CMD.CommandText = "update tbladministracion set Nombres = '" + txtcambiar.Text + "' where Nombres ='" + txtnombres.Text + "'";
            C.CommandText = "update tbladministracion set Edad = '" + cbcambiarE.Text + "' where Edad ='" + cbedades.Text + "'";
            M.CommandText = "update tbladministracion set Carrera = '" + cbCambiar.Text + "' where Carrera ='" + cbcarreras.Text + "'";
            txtnombres.Text = "";
            txtcambiar.Text = "";
            cbcambiarE.Text = "";
            cbedades.Text = "";
            cbCambiar.Text = "";
            cbcarreras.Text = "";
            CMD.ExecuteNonQuery();
            C.ExecuteNonQuery();
            M.ExecuteNonQuery();

            SqlCommand cmd = connect.CreateCommand();
            SqlCommand c = connect.CreateCommand();
            SqlCommand m = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            c.CommandType = CommandType.Text;
            m.CommandType = CommandType.Text;
            cmd.CommandText = "update tblcontabilidad set Nombres = '" + txtcambiar.Text + "' where Nombres ='" + txtnombres.Text + "'";
            c.CommandText = "update tblcontabilidad set Edad = '" + cbcambiarE.Text + "' where Edad ='" + cbedades.Text + "'";
            m.CommandText = "update tblcontabilidad set Carrera = '" + cbCambiar.Text + "' where Carrera ='" + cbcarreras.Text + "'";
            txtnombres.Text = "";
            txtcambiar.Text = "";
            cbcambiarE.Text = "";
            cbedades.Text = "";
            cbCambiar.Text = "";
            cbcarreras.Text = "";
            cmd.ExecuteNonQuery();
            c.ExecuteNonQuery();
            m.ExecuteNonQuery();

            SqlCommand IN = connect.CreateCommand();
            SqlCommand CI = connect.CreateCommand();
            SqlCommand inci = connect.CreateCommand();
            IN.CommandType = CommandType.Text;
            CI.CommandType = CommandType.Text;
            inci.CommandType = CommandType.Text;
            IN.CommandText = "update tblcivil set Nombres = '" + txtcambiar.Text + "' where Nombres ='" + txtnombres.Text + "'";
            CI.CommandText = "update tblcivil set Edad = '" + cbcambiarE.Text + "' where Edad ='" + cbedades.Text + "'";
            inci.CommandText = "update tblcivil set Carrera = '" + cbCambiar.Text + "' where Carrera ='" + cbcarreras.Text + "'";
            txtnombres.Text = "";
            txtcambiar.Text = "";
            cbcambiarE.Text = "";
            cbedades.Text = "";
            cbCambiar.Text = "";
            cbcarreras.Text = "";
            IN.ExecuteNonQuery();
            CI.ExecuteNonQuery();
            inci.ExecuteNonQuery();

            SqlCommand ING = connect.CreateCommand();
            SqlCommand SI = connect.CreateCommand();
            SqlCommand ingsi = connect.CreateCommand();
            ING.CommandType = CommandType.Text;
            SI.CommandType = CommandType.Text;
            ingsi.CommandType = CommandType.Text;
            ING.CommandText = "update tblsistema set Nombres = '" + txtcambiar.Text + "' where Nombres ='" + txtnombres.Text + "'";
            SI.CommandText = "update tblsistema set Edad = '" + cbcambiarE.Text + "' where Edad ='" + cbedades.Text + "'";
            ingsi.CommandText = "update tblsistema set Carrera = '" + cbCambiar.Text + "' where Carrera ='" + cbcarreras.Text + "'";
            txtnombres.Text = "";
            txtcambiar.Text = "";
            cbcambiarE.Text = "";
            cbedades.Text = "";
            cbCambiar.Text = "";
            cbcarreras.Text = "";
            ING.ExecuteNonQuery();
            SI.ExecuteNonQuery();
            ingsi.ExecuteNonQuery();

            connect.Close();
            disp_data();
            MessageBox.Show("Los Datos se ha Modificado correctamente");
        }

        private void txtnombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void irARegistroDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumno abrir = new Alumno();
            abrir.Show();
            this.Hide();
        }
    }
    }


