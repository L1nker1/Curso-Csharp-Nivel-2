using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioUnidad2
{
    internal class Auto
    {
        public Auto(string marca, string modelo, int kilometraje, bool cero_km) {
            this.marca = marca;
            this.modelo = modelo;
            this.cero_km = cero_km;
            this.kilometraje = kilometraje;
        }
        public Auto()
        {

        }

        string marca;
        string modelo;
        int kilometraje;
        int Num_puertas;
        bool cero_km;

        public int puertas { get { return Num_puertas; } set { Num_puertas = value; } }

        public int kilometros
        {
            get { return kilometraje; }
            set { kilometraje = value; }
        }
        public bool cerokm { get {return cero_km;} }

        public bool comprobar_km()
        {
            if (cero_km == true && kilometraje == 0)
            {
                Console.WriteLine("El auto es 0km");
                return true;

            }else{
                Console.WriteLine("El auto es usado, tiene un kilometraje de "+ kilometraje +" km recorridos.");
                cero_km=false;
                return false;

            }

        }
    }
}
