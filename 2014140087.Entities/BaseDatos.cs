using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140087.Entities
{
    public class BaseDatos
    {
        public List<Cuenta> listaCuenta { set; get; }

        //aquí definimos autenticar el usuario mediante una búsqueda secuencial del número de cuenta y el número de pin
        public bool AutenticarUsuario(int numCuenta, int pin)
        {
            for (int i = 0; i < listaCuenta.Count; i++)
            {
                if (listaCuenta[i].getNroCuenta() == numCuenta && listaCuenta[i].getPin() == pin)
                {
                    return true;
                }
            }
            return false;
        }

        public void agregarCuenta(Cuenta cuenta)
        {
            this.listaCuenta.Add(cuenta);
        }
        //aquí obtenemos el saldo previamente realizando una búsqueda

        public decimal ObtenerSaldoDisponible(int numCuenta)
        {
            for (int i = 0; i < listaCuenta.Count; i++)
            {
                if (listaCuenta[i].getNroCuenta() == numCuenta)
                {
                    return listaCuenta[i].getSaldo();
                }
            }
            return 0;
        }


        //aquí debitamos el monto de la cuenta, previamente debemos haber validado que haya saldo disponible

        public void Debitar(int numCuenta, decimal monto)
        {
            for (int i = 0; i < listaCuenta.Count; i++)
            {
                if (listaCuenta[i].getNroCuenta() == numCuenta)
                {
                    listaCuenta[i].DebitarMonto(monto);
                }
            }
        }

        //aqué se acredita el monto a la cuenta
        public void Acreditar(int numCuenta, decimal monto)
        {
            for (int i = 0; i < listaCuenta.Count; i++)
            {
                if (listaCuenta[i].getNroCuenta() == numCuenta)
                {
                    listaCuenta[i].AcreditarMonto(monto);
                }
            }
        }

    }
}
