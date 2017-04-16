using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140087.Entities
{
    public class DispensadorEfectivo
    {

        private int contador = 500;

        public void disminuir()
        {
            contador--;
        }

        public void incrementar()
        {
            contador++;
        }

        public int getContador()
        {
            return contador;
        }
    }
}
