using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioUnidad2
{
    internal class Telefono
    {
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;

        }
        string modelo;
        string marca;
        string NumeroTelefonico;
        int CodigoOperador;

        public string Modelo { get { return modelo; } }
        public string Marca { get { return marca; } }

        public string NumeroTel {
            get { return NumeroTelefonico; }
            set { NumeroTelefonico = value; } 
        }
        public int CodigoOp {
            get { return CodigoOperador; }
            set { CodigoOperador = value; }
        }
        public string llamar()
        {
            return "Realizando llamada...";
        }
        public string llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }
    }
}
