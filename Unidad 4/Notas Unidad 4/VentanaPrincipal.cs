using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas_Unidad_4
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms) //OpenForms contiene todos los forms creados
            {
                if (item.GetType() == typeof(Form1)) //busco y comparo si existe el Form1
                { 
                    MessageBox.Show("la ventana ya se encuentra abierta.");
                    return; 
                }
            }
            Form1 pestaña = new Form1();
            pestaña.Show();                //show permite abrir tantas pestañas iguales como querramos
            //pestaña.ShowDialog();        //showdialog solo permite tener  pestaña abierta, y
                                           //no podemos volver a la ventana principal hasta cerrar la otra
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
