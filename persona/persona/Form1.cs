using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton_alumno.Checked)
            {
                MessageBox.Show("Datos guardados" + "\nNombre: " + textBox_nombre.Text + "\nFecha de nacimiento: " + textBox_fechaNac.Text + "\nEdad: " + textBox_edad.Text + "\nMatricula: " + textBox_DNIMAT.Text + "\nCarrera: " + textBox_CarPues.Text, "Guardado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (radioButton_docente.Checked || radioButton_empleado.Checked)
                {
                    MessageBox.Show("Datos guardados" + "\nNombre: " + textBox_nombre.Text + "\nFecha de nacimiento: " + textBox_fechaNac.Text + "\nEdad: " + textBox_edad.Text + "\nMatricula: " + textBox_DNIMAT.Text + "\nPuesto: " + textBox_CarPues.Text + "\nSueldo: " + textBox_Sueldo.Text, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Datos guardados" + "\nNombre: " + textBox_nombre.Text + "\nFecha de nacimiento: " + textBox_fechaNac.Text + "\nEdad: " + textBox_edad.Text, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            textBox_nombre.Clear();
            textBox_fechaNac.Clear();
            textBox_edad.Clear();
            textBox_CarPues.Clear();
            textBox_DNIMAT.Clear();
            textBox_Sueldo.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_validar_Click(object sender, EventArgs e)
        {
            if (radioButton_alumno.Checked)
            {
                string nom = textBox_nombre.Text;
                string fech = textBox_fechaNac.Text;
                string edad = textBox_edad.Text;
                string mat = textBox_DNIMAT.Text;
                string carrera = textBox_CarPues.Text;
                Alumno alumno = new Alumno(nom, fech, edad, mat, carrera);
            }
            else 
            {
                if (radioButton_empleado.Checked)
                {
                    string nom = textBox_nombre.Text;
                    string fech = textBox_fechaNac.Text;
                    string edad = textBox_edad.Text;
                    string mat = textBox_DNIMAT.Text;
                    string puesto = textBox_CarPues.Text;
                    float sueldo = Convert.ToSingle(textBox_Sueldo.Text);
                    Empleado empleado = new Empleado(nom, fech, edad, puesto, sueldo);
                }
                else
                {
                    if (radioButton_docente.Checked)
                    {
                        string nom = textBox_nombre.Text;
                        string fech = textBox_fechaNac.Text;
                        string edad = textBox_edad.Text;
                        string mat = textBox_DNIMAT.Text;
                        string puesto = textBox_CarPues.Text;
                        float sueldo = Convert.ToSingle(textBox_Sueldo.Text);
                        Docente docente = new Docente(nom, fech, edad, puesto, sueldo);
                    }
                    else
                    {
                        string nom = textBox_nombre.Text;
                        string fech = textBox_fechaNac.Text;
                        string edad = textBox_edad.Text;
                    }
                }
            }
        }

        private void radioButton_alumno_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\arsek\\Source\\Repos\\Isaac1614\\Persona2.1_ID22141\\persona\\persona\\imagenes\\alumno.jpg";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label6.Visible = false;
            textBox_Sueldo.Visible = false;
        }

        private void radioButton_persona_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\arsek\\Source\\Repos\\Isaac1614\\Persona2.1_ID22141\\persona\\persona\\imagenes\\alumno2.jpg";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = false;
            textBox_DNIMAT.Visible = false;
            label5.Visible = false;
            textBox_CarPues.Visible = false;
            label6.Visible = false;
            textBox_Sueldo.Visible = false;
        }

        private void radioButton_docente_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\arsek\\Source\\Repos\\Isaac1614\\Persona2.1_ID22141\\persona\\persona\\imagenes\\DOCENTE.jpg";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = true;
            textBox_DNIMAT.Visible = true;
            label5.Visible = true;
            textBox_CarPues.Visible = true;
            label6.Visible = true;
            textBox_Sueldo.Visible = true;
        }

        private void radioButton_empleado_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\arsek\\Source\\Repos\\Isaac1614\\Persona2.1_ID22141\\persona\\persona\\imagenes\\EMPLEADO.jpg";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = true;
            textBox_DNIMAT.Visible = true;
            label5.Visible = true;
            textBox_CarPues.Visible = true;
            label6.Visible = true;
            textBox_Sueldo.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\arsek\\Source\\Repos\\Isaac1614\\Persona2.1_ID22141\\persona\\persona\\imagenes\\Capturadebolaamarilla.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
        }
    }
}
