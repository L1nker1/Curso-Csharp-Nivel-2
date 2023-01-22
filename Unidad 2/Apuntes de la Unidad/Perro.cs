using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Apuntes_de_la_Unidad
{
    internal class Perro
    {
        public Perro(string nombre, string color, string origen) // .4 constructor con parametros, si lo utilizo no puedo crear perros sin atributos, a menos que utilize el sobrecarga de constructor
        {
            this.nombre = nombre;
            this.color = color;
            this.origen = origen;
        }
        //sobrecarga de metodos
        //Sobrecarga de constructor. si queremos poder crear perros con parametros iniciales, o sin parametros podemos crear otro constructor vacio, al momento de utilizar el ocnstructor podemos elegir cual.
       
        //Destructor, va a ser ejecutado cuando el garbage colector lo remueva del programa. alt + 126
         ~Perro()
         {
            //logica que sera ejecutada cuando el garbage colector destruya este destructor.
         }
         
         
   
        public Perro() { }

        string nombre;
        string color;
        string origen;

        public void setNombre(string n)//metodos
        {
            nombre = n;
        }

        public string getNombre() //metodos
        {
            Console.WriteLine(nombre);
            return nombre;
        }
        public string Color //propiedad
        {
            get { return color; }
            set { color = value; }

        }
        public string Origen //propiedad, forma de C#
        {
            get { return origen; }
            set { origen = value; }
        }
        public int Lifespan { get; set; } // vercion corta 
    }
}
