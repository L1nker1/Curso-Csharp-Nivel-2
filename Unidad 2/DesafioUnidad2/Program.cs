using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesafioUnidad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono Galaxy =new Telefono("Galaxy", "Movistar");
            Telefono phobox =new Telefono("Phobox", "Sony Ericson");

            Auto ferrari = new Auto("Ferrari","Italiano", 200, true);
            Auto toyota = new Auto();

            /* Console.WriteLine("La marca del telefono es: "+Galaxy.Marca);
             Console.WriteLine("El modelo del telefono es: "+Galaxy.Modelo);
             Galaxy.CodigoOp = 11;
             Console.WriteLine("El codigo de area es: "+Galaxy.CodigoOp);
             string llamar = Galaxy.llamar();
             Console.WriteLine(llamar);


             Console.WriteLine("La marca del telefono es: " + phobox.Marca);
             Console.WriteLine("El modelo del telefono es: " + phobox.Modelo);
             phobox.CodigoOp = 54;
             Console.WriteLine("El codigo de area es: " + phobox.CodigoOp);
             Console.WriteLine(phobox.llamar("Roberto")); */

            Console.WriteLine(ferrari.cerokm);
            ferrari.comprobar_km();
            Console.WriteLine(ferrari.kilometros);
            Console.WriteLine(ferrari.cerokm);
            Console.WriteLine(toyota);
        }
    }
}
/*
Vamos a trabajar con lo aprendido en ésta unidad.
Te voy a dejar una serie de instrucciones para que vayas siguiendo y construyendo con el fin de poner en práctica y ver funcionando lo visto hasta aquí.

Crear un proyecto de consola .Net Framework.
Crear la clase Telefono (recordemos que una clase va en un archivo nuevo; click derecho en el proyecto, agregar, class).
Agregale los siguientes atributos:
Modelo string.
Marca string.
NumeroTelefonico string.
CodigoOperador int(1, 2 o 3).
Agregale las propiedades correspondientes. Podés hacer el formato largo o el corto.
Modelo: solo lectura.Es decir, solo get.
Marca: solo lectura.
NumeroTelefonico: lectura y escritura.
CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero. //
Agregar Constructor que reciba Modelo y Marca.
Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.
Estas cosas son las que hicimos con los ejemplos de Persona, Botella, Ventas; intenta ponerlos en práctica y si hay dudas, repasate lo necesario. También podés consultar al foro de dudas.

Te propongo pensar alguna clase más, construirla y agregarle atributos, propiedades y métodos y hacer algunas pruebas; siempre teniendo en mente que la idea es representar la realidad en lo digital.

No te olvides de la importancia de la práctica.

*/