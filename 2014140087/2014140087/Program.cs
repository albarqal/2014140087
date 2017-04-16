using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2014140087.Entities;

namespace _2014140087
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====CAJERO FIA USMP=====");
            GenerateCuentas gen = new GenerateCuentas();
            Console.WriteLine();
            ATM atm = new ATM();
            Console.WriteLine("Cuentas disponibles (Información para Login)");
            List<Cuenta> listaCuentas = gen.getListaCuentas();
            BaseDatos bd = new BaseDatos();
            bd.listaCuenta = listaCuentas;

            gen.ImprimirCuentas(listaCuentas);
            Console.WriteLine();
            atm.login(bd);
        }
    }
}
