using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140087.Entities
{
    public class Operaciones
    {

        public void iniciarRetiro(BaseDatos bd, int nroCuenta)
        {
            int numberException = 0;
            decimal monto = 0;
            decimal saldo;
            Console.WriteLine();
            Console.WriteLine("Ingresar el monto a retirar y presionar enter");
            while (true)
            {
                String data = Console.ReadLine();
                if (int.TryParse(data, out numberException))
                {
                    monto = int.Parse(data);
                    saldo = bd.ObtenerSaldoDisponible(nroCuenta);
                    Console.WriteLine("Saldo antes de la operación:".PadRight(31) + " S/." + saldo);
                    if (saldo.CompareTo(monto) <= 0)
                    {
                        Console.WriteLine("Saldo insuficiente");
                        Console.WriteLine("Ingresar monto menor al saldo: S/." + saldo + " para retirar");
                    }
                    else
                    {

                        bd.Debitar(nroCuenta, monto);
                        saldo = bd.ObtenerSaldoDisponible(nroCuenta);
                        Console.WriteLine("Nuevo saldo disponible:".PadRight(31) + " S/." + saldo);
                        Console.WriteLine();
                        Console.WriteLine("Operación terminada, puede retirar la tarjeta");
                        break;

                    }


                }
                else
                {
                    Console.WriteLine("Debe ingresar un número válido");
                }
            }


        }

        public void iniciarDeposito(BaseDatos bd, int nroCuenta)
        {

            int numberException = 0;
            decimal monto = 0;
            decimal saldo;
            Console.WriteLine();
            Console.WriteLine("Ingresar el monto a depositar y presionar Enter");
            while (true)
            {
                String data = Console.ReadLine();
                if (int.TryParse(data, out numberException))
                {
                    monto = int.Parse(data);
                    saldo = bd.ObtenerSaldoDisponible(nroCuenta);
                    Console.WriteLine("Saldo antes de la operación:".PadRight(31) + " S/." + saldo);

                    bd.Acreditar(nroCuenta, monto);
                    saldo = bd.ObtenerSaldoDisponible(nroCuenta);
                    Console.WriteLine("Nuevo saldo disponible:".PadRight(31) + " S/." + saldo);
                    Console.WriteLine();
                    Console.WriteLine("Operación terminada, puede retirar la Tarjeta");
                    break;
                }
                else
                {
                    Console.WriteLine("Debe ingresar un número válido");
                }
            }

        }
    }
}
