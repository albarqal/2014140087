using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140087.Entities
{
    public class ATM
    {

        public RanuraDeposito ranuradeposito { set; get; }
        public Teclado teclado { set; get; }
        public DispensadorEfectivo dispensadorEfectivo { set; get; }
        public Pantalla pantalla { set; get; }


        public void login(BaseDatos bd)
        {
            int numCuenta;
            int pin;
            String nCuenta, spin;

            while (true)
            {


                Console.WriteLine("Ingresar el número de cuenta y presionar enter");
                nCuenta = Console.ReadLine();
                //validar q sea numero
                //if (nCuenta.)
                int numberException = 0;
                if (int.TryParse(nCuenta, out numberException))
                { numCuenta = int.Parse(nCuenta); }
                else
                { numCuenta = 0; }

                Console.WriteLine("Ingresar el pin y presionar enter");
                spin = Console.ReadLine();
                if (int.TryParse(spin, out numberException))
                { pin = int.Parse(spin); }
                else
                { pin = 0; }


                if (bd.AutenticarUsuario(numCuenta, pin))
                {
                    Start(bd, numCuenta);
                    break;
                }
                else
                {
                    Console.WriteLine("Información de la cuenta incorrecta");
                    // break;
                }


            }
        }



        public void Start(BaseDatos bd, int nroCuenta)
        {
            String data;
            Operaciones lib = new Operaciones();
            Console.WriteLine("Que operacion desea Realizar");
            Console.WriteLine("1.Deposito");
            Console.WriteLine("2.Retiro");
            Console.WriteLine("9.Salir");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Ingrese El numero de la Opcion y Presione Enter");
                data = Console.ReadLine();
                if (data.CompareTo("9") == 0)
                {
                    break;
                }
                else if (data.CompareTo("1") == 0)
                {
                    lib.iniciarDeposito(bd, nroCuenta);
                    break;
                }
                else if (data.CompareTo("2") == 0)
                {
                    lib.iniciarRetiro(bd, nroCuenta);
                    break;
                }

            }
        }

    }
}
