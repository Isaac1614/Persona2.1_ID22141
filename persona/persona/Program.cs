using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.IO;
//Comentario de guardado
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
            set { nombre = value; }//Se guarda en memoria 
        }
        public string Edad
        {
            get { return edad; }//Vamos por el valor en la caja de texto
            set { edad = value; }//Se guarda en memoria 
        }
        public string FechaNac
        {
            get { return fechaNac; }//Vamos por el valor en la caja de texto
            set { fechaNac = value; }//Se guarda en memoria 
        }
        /*public void guardar_info_persona()
        {
            try
            {
                string fileName = @"C:\Users\Licenciaturas\source\repos\Isaac1614\Persona2.1_ID22141\persona\persona\archivostxt\RegistroPersona.txt";
                StreamWriter writer = File.AppendText(fileName);
                writer.WriteLine("Nombre: " + Nombre);
                writer.WriteLine("Edad: " + Edad);
                writer.WriteLine("Fecha de nacimiento: " + FechaNac);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar datos en el archivo: Archivo: RegistroAlumnos.txt", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
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
            set { matricula = value; }//Se guarda en memoria 
        }
        protected string Carrera
        {
            get { return carrera; }//Vamos por el valor en la caja de texto
            set { carrera = value; }//Se guarda en memoria 
        }
        public Alumno(string nombre,string edad,string fechaNac,string matricula,string carera)
        {
            Nombre = nombre; 
            Edad=edad;
            FechaNac = fechaNac;
            Carrera = carera;
            Matricula = matricula;
        }
        public void guardar_info_alumnos()
        {
            try
            {
                string fileName = @"C:\Users\Licenciaturas\source\repos\Isaac1614\Persona2.1_ID22141\persona\persona\archivostxt\RegistroAlumnos.txt";
                StreamWriter writer=File.AppendText(fileName);
                writer.WriteLine("Nombre: "+Nombre);
                writer.WriteLine("Edad: " + Edad);
                writer.WriteLine("Fecha de nacimiento: " + FechaNac);
                writer.WriteLine("Carrera: " + Carrera);
                writer.WriteLine("Matricula: " + Matricula);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar datos en el archivo: Archivo: RegistroAlumnos.txt","Error 404",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
    }
    class Empleado : Persona //clase hija
    {

        //variables
        //atributos
        protected string puesto;
        protected float sueldo;
        protected string dni;
        //metodos
        public string DNI
        {
            get { return dni; }//Vamos por el valor en la caja de texto
            set { dni = value; }//Se guarda en memoria 
        }
        public string Puesto
        {
            get { return puesto; }//Vamos por el valor en la caja de texto
            set { puesto = value; }//Se guarda en memoria 
        }
        public float Sueldo
        {
            get { return sueldo; }//Vamos por el valor en la caja de texto
            set { sueldo = value; }//Se guarda en memoria 
        }
        public Empleado(string nombre, string edad, string fechaNac,string dni, string puesto, float sueldo)
        {
            Nombre = nombre;
            Edad = edad;
            FechaNac = fechaNac;
            DNI = dni;
            Puesto=puesto;
            Sueldo = sueldo;
        }
        public void guardar_info_empleado()
        {
            try
            {
                string fileName = @"C:\Users\Licenciaturas\source\repos\Isaac1614\Persona2.1_ID22141\persona\persona\archivostxt\RegistroEmpleados.txt";
                StreamWriter writer = File.AppendText(fileName);
                writer.WriteLine("Nombre: " + Nombre);
                writer.WriteLine("Edad: " + Edad);
                writer.WriteLine("Fecha de nacimiento: " + FechaNac);
                writer.WriteLine("DNI: " + DNI);
                writer.WriteLine("Puesto: " + Puesto);
                writer.WriteLine("Sueldo: " + Sueldo);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar datos en el archivo: Archivo: RegistroEmpleados.txt", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
    }

    class Docente : Persona //clase Hija
    {
        //variables
        //atributos
        protected string puesto;
        protected float sueldo;
        protected string matricula;
        //metodos
        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }//Se guarda en memoria 
        }
        public float Sueldo 
        {
            get { return sueldo; }
            set { sueldo = value; }//Se guarda en memoria 
        }
        public string Matricula
        {
            get { return matricula; }//Vamos por el valor en la caja de texto
            set { matricula = value; }//Se guarda en memoria 
        }
        public Docente(string nombre, string edad, string fechaNac,string matricula, string puesto, float sueldo)
        {
            Nombre = nombre;
            Edad = edad;
            FechaNac = fechaNac;
            Matricula = matricula;
            Puesto = puesto;
            Sueldo = sueldo;
        }
        public void guardar_info_docente()
        {
            try
            {
                string fileName = @"C:\Users\Licenciaturas\source\repos\Isaac1614\Persona2.1_ID22141\persona\persona\archivostxt\RegistroDocentes.txt";
                StreamWriter writer = File.AppendText(fileName);
                writer.WriteLine("Nombre: " + Nombre);
                writer.WriteLine("Edad: " + Edad);
                writer.WriteLine("Fecha de nacimiento: " + FechaNac);
                writer.WriteLine("Matricula: " + Matricula);
                writer.WriteLine("Puesto: " + Puesto);
                writer.WriteLine("Sueldo: " + Sueldo);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar datos en el archivo: Archivo: RegistroDocentes.txt", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
