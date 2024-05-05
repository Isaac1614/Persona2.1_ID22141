using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace persona
{
    class Persona //clase padre
    {
        //variables
        //atributos
        protected string nombre;
        protected string edad;
        protected string fechaNac;
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
        //aqui va el constructor para cargar datos en las cajas de memoria
        //nombre, edad, fecha de nacimiento(es un tipo cadena!!!!! string)
        public string Nombre
        {
            get { return nombre; } //Vamos por el valor en la caja de texto
            set { Nombre = value; }//Se guarda en memoria 
        }
        public string Edad
        {
            get { return edad; }//Vamos por el valor en la caja de texto
            set { Edad = value; }//Se guarda en memoria 
        }
        public string FechaNac
        {
            get { return fechaNac; }//Vamos por el valor en la caja de texto
            set { FechaNac = value; }//Se guarda en memoria 
        }
    }

    class Alumno : Persona //clase hija alumno
    {
        //variables
        //atributos
        protected string matricula;
        protected string carrera;
        //metodos
        public string Matricula
        {
            get { return matricula; }//Vamos por el valor en la caja de texto
            set { Matricula = value; }//Se guarda en memoria 
        }
        protected string Carrera
        {
            get { return carrera; }//Vamos por el valor en la caja de texto
            set { Carrera = value; }//Se guarda en memoria 
        }
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
    }
    class Empleado : Persona //clase hija
    {

        //variables
        //atributos
        protected string dni;
        protected string puesto;
        protected int sueldo;
        //metodos
        public string DNI
        {
            get { return dni; }//Vamos por el valor en la caja de texto
            set { DNI = value; }//Se guarda en memoria 
        }
        public string Puesto
        {
            get { return puesto; }//Vamos por el valor en la caja de texto
            set { Puesto = value; }//Se guarda en memoria 
        }
        public int Sueldo
        {
            get { return sueldo; }//Vamos por el valor en la caja de texto
            set { Sueldo = value; }//Se guarda en memoria 
        }
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
    }

    class Docente : Persona //clase Hija
    {
        //variables
        //atributos
        protected string matriculaDocente;
        protected string carreraDocente;
        protected int sueldoDocente;
        //metodos
        public string MatriculaDocente
        {
            get { return matriculaDocente; }
            set { MatriculaDocente = value;}
        }
        public string CarreraDocente
        {
            get { return carreraDocente; }
            set { CarreraDocente = value;}
        }
        public int SueldoDocente 
        {
            get { return sueldoDocente; }
            set { SueldoDocente = value; }
        }
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
    }
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
