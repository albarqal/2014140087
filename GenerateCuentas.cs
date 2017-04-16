using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140087.Entities
{
    public class GenerateCuentas
    {

        public List<Cuenta> getListaCuentas()
        {
            List<Cuenta> listaCuentas = new List<Cuenta>();

            Cuenta cuenta1 = new Cuenta(2015222601, 4977, 1430);
            Cuenta cuenta2 = new Cuenta(2015231222, 5215, 2221);
            Cuenta cuenta3 = new Cuenta(2012321366, 2312, 5555);
            Cuenta cuenta4 = new Cuenta(2010679291, 6782, 565);
            Cuenta cuenta5 = new Cuenta(2015996786, 9696, 440);
            Cuenta cuenta6 = new Cuenta(2015659981, 5639, 120);

            listaCuentas.Add(cuenta1);
            listaCuentas.Add(cuenta2);
            listaCuentas.Add(cuenta3);
            listaCuentas.Add(cuenta4);
            listaCuentas.Add(cuenta5);
            listaCuentas.Add(cuenta6);


            return listaCuentas;
        }


        public void ImprimirCuentas(List<Cuenta> listacuentas)
        {
            Console.WriteLine("NroCuenta".PadRight(15) + "Pin".PadRight(10) + "Saldo".PadRight(10));
            for (int i = 0; i < listacuentas.Count; i++)
            {
                Console.WriteLine(listacuentas[i].getNroCuenta().ToString().PadRight(15) + listacuentas[i].getPin().ToString().PadRight(10) + listacuentas[i].getSaldo().ToString().PadRight(10));
            }
        }
    }
}
