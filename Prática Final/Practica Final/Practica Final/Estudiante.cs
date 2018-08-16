using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practica_Final
{
     class Estudiante
    {

        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Direccion { get; set; }
        public String FechaDeNacimiento { get; set; }
        public String Edad { get; set; }
        public String Sexo { get; set; }
        public String Telefono { get; set; }
        public String Celular { get; set; }
        public String AñoDeIngreso { get; set; }
        public String MesDeIngreso { get; set; }
        public String Carrera { get; set; }
        public String Matricula { get; set; }
        public String Edificio { get; set; }
        public String Tanda { get; set; }
        public String Cuatrimestre { get; set; }
        public String Seccion { get; set; }
        public String Aula { get; set; }

        public Estudiante() { }

        public Estudiante(String Nombre, String Apellido, String Direccion, String FechaDeNacimiento, String Edad, String Sexo, String Telefono, String Celular,
        String AñoDeIngreso, String MesDeIngreso, String Carrera, String Matricula, String Edificio, String Tanda, String Cuatrimestre, String Seccion, String Aula)
        {
          
            this.Nombre = Nombre;
            this.Apellido= Apellido;
            this.Direccion = Direccion;
            this.FechaDeNacimiento = FechaDeNacimiento;
            this.Edad = Edad;
            this.Sexo = Sexo;
            this.Telefono = Telefono;
            this.Celular = Celular;
            this.AñoDeIngreso = AñoDeIngreso;
            this.MesDeIngreso = MesDeIngreso;
            this.Carrera = Carrera;
            this.Matricula = Matricula;
            this.Edificio = Edificio;
            this.Tanda = Tanda;
            this.Cuatrimestre = Cuatrimestre;
            this.Seccion = Seccion;
            this.Aula = Aula;

        }
    }
}
