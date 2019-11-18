using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar
{
    class Par
    {
        private int valor;
        public string recebe
        {
            set
            {
                valor = Convert.ToInt32(value);
            }
        }

        public string enviar
        {
            get
            {
                if (valor % 2 == 0) return "Par";
                else return "Ímpar";
            }         
        }
    }
}
