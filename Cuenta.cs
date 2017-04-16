using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140087.Entities
{
    public class Cuenta
    {
        private int numCuenta;
        private int pin;
        private decimal saldo;

        public Cuenta(int numCuenta, int pin, decimal saldo)
        {
            this.numCuenta = numCuenta;
            this.pin = pin;
            this.saldo = saldo;
        }

        public void DebitarMonto(decimal monto)
        {
            this.saldo = saldo - monto;
        }

        public void AcreditarMonto(decimal monto)
        {
            this.saldo = saldo + monto;
        }

        public int getPin()
        {
            return pin;
        }

        public int getNroCuenta()
        {
            return numCuenta;
        }

        public decimal getSaldo()
        {
            return saldo;
        }
    }
}
