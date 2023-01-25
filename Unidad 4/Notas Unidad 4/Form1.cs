using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas_Unidad_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido al programa.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola");
            string text = text_nombre.Text;
            Label_Saludo.Text = "Bienvenido, " + Label_Saludo.Text;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {



        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 pestaña2 = new Form1();
            pestaña2.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CheckLider_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = text_nombre.Text;
            DateTime fecha = FormFecha.Value;
            string ocupation;
            if (rbtnLider.Checked)
                ocupation = "Lider";
            else if (rbtnDeveloper.Checked)
                ocupation = "Developer";
            else
                ocupation = "Tester";

            MessageBox.Show("Nombre: "+nombre+", Fecha: "+fecha+", Ocupacion: "+ocupation);
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
