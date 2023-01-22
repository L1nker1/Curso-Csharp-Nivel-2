using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Apuntes_de_la_Unidad
{
    internal class Botella
    {
        public Botella(string material, string color) 
        {
            this.material = material;
            this.color = color;

        }
        private string materiales;
        private string colores;
        private int capacidadMaxima = 100;
        private int capacidadActual = 0;

        public string color { //propiedad
            get { return colores; }
            set { colores = value; }
        }
        public string material //propiedad
        {
            get { return materiales; }
            set { materiales = value; }
        }
        public int cargar
        {
            get { return capacidadActual;}
            set { capacidadActual = value;}
        }
        public int contenido { get { return capacidadActual; } } //propiedad solo lectura

        public float recargar() //metodo sobrecargado
        {
            float monto;
            if(capacidadActual > 0)
            {
                int dif =  100 - capacidadActual;
                Console.WriteLine("La botella no está completamente vacia, cuenta con " +dif+ "ml");
                monto = dif * 50 / 100;
                capacidadActual += dif;
                Console.WriteLine("recargar la botella junto con su capacidad actual costara "+ monto+ "$");
                return monto;
            }
            capacidadActual = 100;
            Console.WriteLine("La botella fue recargada a su maxima capacidad, el coste de la recarga es de ");
            return 50; //coste de la recarga
        }
        public float recargar(int cantidad) //sobrecarga de metodo
        {
            float monto;
            monto = cantidad * 50 / 100;
            capacidadActual += cantidad;
            Console.Write("El monto de la recarga es de ");
            return monto;
        }
    }
}
