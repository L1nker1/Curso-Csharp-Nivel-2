using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Notas___POO_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}


// 1. Herencia.  --> se lee como "es" ---> Programador es Persona
/*
la herencia es una relacion entre clases, esta relacion nos permite crear familia de clases, gerarquia de clases,
la herencia define que una clase hija va a heredar o adquerir las particularidades de una clase padre.
Por ejemplo las clases que creamos, heredan de la clase padre Object ciertas caracteristicas, en este caso es una herencia implicita, ya que no es algo que nosotros decidamos.

Al crear una familia de clases por ejemlo:
Persona --> Lider --> Tester --> developer
donde yo tenga que mantener los mismos atributos para todos los integrantes, es entonces cuando ya podria considerar aplicar herencia, entonces, deberia aplicar una gerarquia,
esto seria crear una clase base de donde se desprenderan otras clases miembros de la familia.
en el ejemplo la clase base seria persona, ya que el resto de las clases son personas.
*/


// 2. Tipos de valor  y de referencia
//los tipos valor son las variables que ya conocemos, es decir variables que tienen un valor asignado (int, float, string, etc), elementos valor.

//Las referencias, van a ser las relaciones entre variables y el objeto, por ejemplo
//string auto = new vehiculo();  auto va a ser la variable que va a albergar el objeto, el objeto se genera fuera de la variable auto,
//pero se relacionan mediante una referencia, que la otorga la palabra reservada new, en caso de no colocar el new, se va a establecer una referencia null,
//lo que causaria que la variable apunte a la nada misma.
//para redondear, las referencias van a ser las relaciones entre la variable auto y el objeto.


// 3. Colecciones

//Las colecciones son como los vectores, solo que aun mejor, ya que las colecciones son dinamicas, lo que quiere decir que no debo definir un tamaño,
//cuando asigne valores a la coleccion , o los quite, el tamaño se actualizara dinamicamente.

// hay mas de 10 tipos de listas y sublistas, con sus restricciones. Para eso consultar la documentacion.
//La coleccion de tipo list, es la mas utilzada. 

//si yo tengo una lista, con objetos dentro y yo modifico los objetos directamente, la lista tambien modificara ese valor cambiado, ya que ambos,
//el valor en la lista, como la variable directa al objeto, apuntan por referencia al valor original como hablamos en la seccion anteriror de tipos de referencia.

//como armar una lista:
// List<Camioneta> listaCamionetas = new List<Camioneta>();

//como agregar a la lista:
//listaCamionetas.Add(c1)

//remover:
//listaCamionetas.Remove(c1);
// metodo foreach + tab

// 4. sobreescritura de metodos.
//sobreescritura de metodos es cuando tenemos herencia de clases por ejemplo Animal -> domestico -> salvaje -> perro --> gato --> tigre
//suponiendo que animal, la clase padre del resto tenga el metodo emitir sonido, que devuelve un sonido, pero yo quiero crear un perro y que ese mismo metodo devuelva un "guau guau"
//entonces deberia sobreescribir el metodo heredado de la clase animal. Para esto el metodo de la clase paddre debe estar en virtual, ejemplo
// public virtual string comunicarse(){}
//luego el metodo heredado en la clase que recive la herencia debe sobreescribirlo mediante la siguiente sintaxys, ej:
//public override y preciono tab sobre el metodo que quiero sobbreescribir.

//polimorfismo
//es la caracteristica que tienen los objetos que frente a un mismo estimulo responden de manera distinta.
//invoco el metodo comunicar, en una lista de animales, y las respuestas varian, ya que algunos animales tienen el metodo sobreescrito. entonces el estimulo es el metodo comunicar.

// 5. Interfaces.
//las interfaces son contratos que establecen condiciones para 2 o mas partes, deben cumplirse para la correcta relacion entre las partes, 
//se podria pensar de esta manera, ya que la interface declara los metodos que otras clases deben tener declarados para poder inplementar ducha interfaz. *ver ejemplo

//para crear una interface hay que agregarla desde el explorador de soluciones, una vez creado el archivo, puedo determinar que metodos
//van a tener que tener las clases que quieran utilizar dicha interfaz

// 6. Asociación o Composicion.  la relacion de composicion se lee como "Tiene" ---> un Auto tiene un Motor.

//por ejemplo tenemos dos clases, Persona y direccion.
//dentro de la definicion de la clase persona, incluimos la clase direccion, con todos los atributos relacionados a la misma para no ponerlos por separado. de esto se trata la asociacion
//es decir, utilizamos una clase dentro de la definicion de otra. Esto se llama Composicion y es un tipo de asociacion. el otro tipo es agregacion.
//agregacion es cuando la clase que estamos incluyendo no viene en el constructor de la clase que lo utiliza, es decir se podria añadir despues de la creacion de la clase.
//composicion es cuando el constructor de la clase hace uso de la clase asociada al momento de la creacion.

// basicamente, la asociacion , varia en 2 formas ---> Composicion y Agregacion.
// cuando la asociacion se da desde un inicio, por medio de un constructor, por ejemplo, en caso de crear un auto, si a la clase auto le asocio
// una clase "Estructura" dentro del constructor, estoy usado la asociacion Composicion.
// si el auto es creado en principio sin un motor, pero luego planeo agregarlo, es Agregacion 


//7.

// 8.Tipos de clases
//abstract --> hace que las clases no sean instanciables, es decir no puedo crear instancias con new
// ej : abstract class Person{}  

// sealed --> no permite que la clase que sea sealed sea heredable por otra
// sealed class Person{}
//class Lider : Person ---> va a tirar error ya que la clase Person es del tipo sealed
// puede servir para marcar el final de la jerarquia de clases, para poner un limite a lo heredable 

//static --> una clase estatica no nesecita/puede ser estanciada, de hecho los metodos que contenga van a poder ser invocados de manera directa sin una instancia previa.
//por ejemplo con el metodo Console.writeLine() -->  Console es la clase estatica que contiene el metodo WriteLine()

//static class Console{ static Saludar{ return "hola"} }

// Console.Saludar();

//es posible tener una clase que no sea estatica pero que contenga metodos estaticos, estos  casos no son comunes, y no serian ideales, pero puede suceder, que lo hagamos para incluir
//un metodo que utilicemos constantemente como uuna verificacion, en estos casos primero debo instanciar la clase para luego poder llamar al metodo.
