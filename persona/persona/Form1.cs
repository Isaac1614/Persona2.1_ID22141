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
    }
}
