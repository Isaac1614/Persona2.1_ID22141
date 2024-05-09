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
            MessageBox.Show("Datos guardodos correctamente","Guardar");
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_validar_Click(object sender, EventArgs e)
        {
            if (radioButton_empleado.Checked)
            {
                Empleado emple1 = new Empleado();
            }
            else 
            {
                if (radioButton_alumno.Checked)
                {
                    Alumno alum1 = new Alumno();
                }
                else
                {
                    if (radioButton_docente.Checked)
                    {
                        Docente docente1 = new Docente();
                    }
                    else
                    {
                        if (radioButton_persona.Checked)
                        {
                            Persona per1 = new Persona(string Nombre,string Edad,string FechaNac);
                        }
                    }
                }
            }

        }
    }
}
