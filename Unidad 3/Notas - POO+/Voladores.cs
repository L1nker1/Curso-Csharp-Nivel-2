using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas___POO_
{
    internal class Aguila : Flyable //flyable es la interface que creamos
    {
        private int lifespan = 20;
        public int lifeSpan 
        { 
            get { return lifespan; }
            set { lifespan = value; }
        }

        public string volar() //el metodo volar que solicita la interface, 
        {
            return "puede volar";
        }
    }
}
