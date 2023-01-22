using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apuntes_de_la_Unidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Perro galgo = new Perro();
            galgo.setNombre("toto");
            galgo.getNombre();

            galgo.Color = "marron";
            string color = galgo.Color;
            galgo.Origen = "Aleman";
            string origen = galgo.Origen;
            galgo.Lifespan = 5;
           
            Console.WriteLine("El perro galgo, es de color " + color);
            Console.WriteLine("Esta raza es de origen "+ origen + " y tiene una esperanza de vida de "+ galgo.Lifespan + " años");
           */
            Perro lupita = new Perro("lupe", "gris", "arg"); //constructor con parametros
            Perro axel = new Perro(); //constructor sin parametros 
            axel.Origen = "Argentina";
            Console.WriteLine("el origen de lupe es: "+lupita.Origen); //arg
            Console.WriteLine("el origen de axel es: "+axel.Origen);

            Botella coca = new Botella("plastico", "roja");
            coca.cargar = 50;
            Console.WriteLine("La botella es de color "+coca.color);
            Console.WriteLine("la botella cuenta con una capacidad actual de "+ coca.contenido + " ml." );
            Console.WriteLine(coca.recargar(50));
            Console.WriteLine("la botella cuenta con una capacidad actual de " + coca.contenido + " ml." );

        }
    }
}

//Introduccion
// vamos a trabajar con la POO 
// POO es un paradigma, algunos conceptos escenciales son las clases, los objetos y las herencias.
// POO trae como ventaja la posibilidad de reutilizar codigo 
//Principalmente La Poo nos propone abordar problematicas mas amplias, mas grandes, o de presentar distintas soluciones o proipuestas para aplicar
//a distintos escenarios con mayor alcance.

//Que es una clase?
//creacion de un nuevo tipo de dato, es una devolucion que nos va a permitir manejar el conportamiento
//una clase me va a permitir tomar algo de la realidad, diseñarlo a lo digital para poder manipular esa info en las aplicaciones.

//attributos o miembro
//son las variables que componen la clase, los atributos pueden ser declarados con su accesibilidad po rejemplo, private int edad, o public string name.
//a los atributos podemos añadiles funciones en public, que van a permitir la modificacion o lectura de los atributos.

//encapsulamiento
//define que un miembro de una clase no tendria que ser accedido de ninguna manera desde el exterior
// lo que no significa que no podamos contar con mecanismos para leer o modificar esos atributos, por medio funciones dentro de las clases, a las que llamamos metodos.

//metodos
//son funciones que se encuentran dentro de las clases, por ejemplo asignan valores a los atributos, los leen, entre otras cosas

//propiedades
//Esta es la forma de C# de manejar los atributos, tambien se pueden usar la forma de los metodos, pero está es la propuesta de C#. 

//public int Lifespan { get; set; } //esta es otra forma, más corta de escribir una propiedad. escribimos prop y presionamos tab 2 veces. 
//la contra de este metodo es que no se puede hacer nada mas que el get y set.  
//en la forma completa podemos por ejemplo hacer validaciones antes de settear un valor, por ejemplo:

/* 
public int Edad {
  get { return edad; }
  set {
 *  if(value > 18 && value < 50){
 *    edad = value
 *      }
   } 
}
*/

// 4. Constructores y Destructores.
// un constructor y destructor son funciones que se van a ejecutar en distintas instancias, del ciclo de vida del objeto.
// el constructor, se encarga de generar la instancia de las clases de manera inicial.
//existe una clase Object que es la clase padre de toda clase creada, a lo que vamos es que estas clases que son hijas de object, por ser hijas,
//van a heredar ciertas caracteristicas de base. (se va a explicar en otra clase).

//5. metodos
//actualizamos la definicion de metodo --> comportamiento a partir de la info de los atributos

//crear constructor de botella (color,material, capacidad, capacidadactual)
//crear metodo recargar

//6 Sobrecarga de Metodos
//como vimos con la sobrecarga de constructores, la idea es la misma, puedo crear varios metodos con el mismo nombre,
//pero que recivan parametros, o no, o que recivan más, cuando intente utilizar ese metodo sobrecargado visual estudio me va a sugerir las distintas verciones de ese metodo

//7 imformacion, comportamiento , estado, identidad
//informacion:
//una clase tiene atributos, ahora bien cuando esa clase se instancie en un objeto, esos atributos pasan a ser informacion real.
//esa informacion hace a lo que se denomina el estado de un objeto. El estado es la informacion que tiene el objeto en detemrminado momento,
//hay objetos con mismo estado, pero que son objetos distintos.
//Identidad:
//O puedo hablar de objetos identicos, concepto de identidad, dado por la unicidad del objeto, cada obj es unico, no puede haber dos objetos exactamente iguales.
//ya que serian el mismo objeto. GetHashCode() devuelve un codigo unico del objeto.

//comportamiento:
//es una caracteristica que aplica cuando hablamos de objetos.
//una clase tiene metodos, un objeto tiene comportamientos mediante esos metodos que hereda de la clase

//8 String
//length
//toUpper()
//Replace("a", "e"). cambia caracteres a por e.