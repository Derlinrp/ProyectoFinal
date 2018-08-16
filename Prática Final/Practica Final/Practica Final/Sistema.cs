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
    public partial class Sistema : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=DERLIN-PC\\SQLEXPRESS;Initial Catalog=registro;Integrated Security=True");
        public Sistema()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand CMD = conexion.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "insert into tblsistema values('" + txtnombre.Text + "','" + txtapellido.Text + "','" + txtdireccion.Text + "','" + mtxtfecha.Text + "','" + cbedad.Text + "','" + cbsexo.Text + "','" + mtxttelefono.Text + "','" + mtxtcelular.Text + "', '" + mtxtcedula.Text + "', '" + cbaño.Text + "','" + cbmes.Text + "','" + cbcarrera.Text + "','" + txtmatricula.Text + "','" + cbedificio.Text + "','" + cbtanda.Text + "','" + cbcuatrimestre.Text + "','" + cbsec.Text + "','" + cbAula.Text + "')";
            CMD.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Los Datos se han guardado correctamente", "Alumno de Ingenieria en Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string a = null;
            string m = null;
            string c = null;
            string t = null;
            string n = null;

            a = cbaño.Text;
            m = cbmes.Text;
            c = cbcarrera.Text;
            t = cbtanda.Text;
            n = txtnumero.Text;

            if (c == "SISTEMA")
            {
                c = "IS";
            }

            txtmatricula.Text = String.Format(a, 4, 3) + "-" + String.Format(m, 0, 1) + String.Format(c, 2, 3) + String.Format(t, 0, 1) + "-" + "1" + "-" + n;

            if (a == "2017")
            {
                a = "17";
            }
            else if (a == "2018")
            {
                a = "18";
            }
            else if (a == "2019")
            {
                a = "19";
            }
            else if (a == "2020")
            {
                a = "20";
            }
        
            txtmatricula.Text = String.Format(a, 3, 4) + "-" + String.Format(m, 0, 1) + String.Format(c, 2, 3) + String.Format(t, 0, 1) + "-" + "1" + "-" + n;
            txtmatricula.Text = String.Format(a, 3, 4) + "-" + String.Format(m, 0, 1) + String.Format(c, 2, 3) + String.Format(t, 0, 1) + "-" + "1" + "-" + n;
            txtmatricula.Text = String.Format(a, 3, 4) + "-" + String.Format(m, 0, 1) + String.Format(c, 2, 3) + String.Format(t, 0, 1) + "-" + "1" + "-" + n;
            txtmatricula.Text = String.Format(a, 3, 4) + "-" + String.Format(m, 0, 1) + String.Format(c, 2, 3) + String.Format(t, 0, 1) + "-" + "1" + "-" + n;

            if (m == "Enero")
            {
                m = "E";
            }
            else if (m == "Mayo")
            {
                m = "M";
            }
            else if (m == "Septiembre")
            {
                m = "S";
            }

            txtmatricula.Text = String.Format(a, 3, 4) + "-" + String.Format(m, 1, 1) + String.Format(c, 2, 3) + String.Format(t, 0, 1) + "-" + "1" + "-" + n;
            txtmatricula.Text = String.Format(a, 3, 4) + "-" + String.Format(m, 1, 1) + String.Format(c, 2, 3) + String.Format(t, 0, 1) + "-" + "1" + "-" + n;
            txtmatricula.Text = String.Format(a, 3, 4) + "-" + String.Format(m, 1, 1) + String.Format(c, 2, 3) + String.Format(t, 0, 1) + "-" + "1" + "-" + n;

            if (t == "Mañana")
            {
                t = "M";
            }
            else if (t == "Tarde")
            {
                t = "T";
            }
            else if (t == "Noche")
            {
                t = "N";
            }

            txtmatricula.Text = String.Format(a, 3, 4) + "-" + String.Format(m, 1, 1) + String.Format(c, 2, 3) + String.Format(t, 1, 1) + "-" + "1" + "-" + n;
            txtmatricula.Text = String.Format(a, 3, 4) + "-" + String.Format(m, 1, 1) + String.Format(c, 2, 3) + String.Format(t, 1, 1) + "-" + "1" + "-" + n;
            txtmatricula.Text = String.Format(a, 3, 4) + "-" + String.Format(m, 1, 1) + String.Format(c, 2, 3) + String.Format(t, 1, 1) + "-" + "1" + "-" + n;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alumno cerrar = new Alumno();
            cerrar.Show();
            this.Hide();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarAlumno abrir = new BuscarAlumno();
            abrir.Show();
            this.Hide();
        }
    }
}
