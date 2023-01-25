using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas_Unidad_4
{
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
            Application.Run(new VentanaPrincipal());
        }
    }
}



// 1- Introduccion a winForms

// cosas a tener en cuenta 
// - partial class ---> permite crear distintas partes de clases que conforman a una sola (revisar en Form1) --> hay una clase Form1 y dentro contiene otra clase form1
// ambas son parte de la misma clase.

// "Form1" hereda de la clase Form (que es lo que permite que se muestre el cuadro o ventana de la interfaz .

// Dentro del Form1.Designer podemos extender una parte marcada como "cod generado por diseñador de windform", dentro de esta seccion nos encontramos con toda la informacion
// que contiene la ventana, en forma de codigo.

// para abrir la toolbox con los componentes visuales para agregar alt + w + x
// o desde la pestaña de Ver.


// 2- Controles basicos y eventos
// explicacion de eventos, como crearlos, que son, 

//evento ---> es un metodo asociado a un determinado contexto. ej: al hacer click en un boton --> ejecutar el metodo Saludar();
//al borrar un evento desde form1, hay que tener en cuenta que tambien se debe borrar la linea del evento generada en form1.designer. esto genera un error.


//tarea 
// crear clase objeto persona ---> 


// 3- controles varios y operador ternario

//4- menúes y navegacion entre ventanas

// menu clasico --> menuStrip en la toolbar
// barra de tareas --> toolStrip 

//para agregar distintas ventanas, debemos crear otro formulario y añadir un evento dentro del principal que instancie la ventana del formulario que queramos mostrar
//exactamente igual a la linea de codigo que vemos..

/* dentro del evento
 
 * Form1 pestaña = new Form1();
   pestaña.Show();
 */

//show permite abrir tantas pestañas iguales como querramos
//pestaña.ShowDialog();  //showdialog solo permite tener 1 pestaña abierta, no podemos volver a la ventana principal hasta cerrar la otra.



// 6- Ventana Contenedora
// isMdiContainer = true --> es para hacer que las ventanas que abramos desde la principal, se mantengan dentro de la misma.
// pero ademas debemos limitar la cantidad de ventanas de un mismo tipo, es decir que una ventana no pueda ser abierta mas de una vez
// para eso le aplicamos una validacion al evento que abre la pestaña
//
 /*
  foreach(let item in Application.OpenForms){
      if(item.GetType() == typeof(Form1))
      return;
     }
 */

// 7- Tipo DateTime

//Nota Importante:
//cuando haya que manipular fechas y base de datos, por lo general se intenta trabajar con fechas convertidas en strings
//lo que nos recomienda, es que guardemos la fecha como valor puro en una variable y la enviaemos tal cual a la DB

