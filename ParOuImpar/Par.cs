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
                bool primo = true;
                for (int i = 2; i < valor; i++)
                {
                    if (valor % 1 == 0) primo = false;
                }
                if (primo) return "Par " + valor + " é par";
                else return "Ímpar " + valor + " é ímpar";
            }         
        }
    }
}
