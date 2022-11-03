using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploMVCConsola
{
    public class Cuenta
    {
        private double monto;
        public double Monto { get { return monto; } set { monto = value; } }
        private double porcentPropina;
        public double PorcentPropina { get { return porcentPropina; } set { porcentPropina = value; } }

        public Cuenta(double monto, double porcentPropina)
        {
            Monto = monto;
            PorcentPropina = porcentPropina;
        }

        public double calcularPropina()
        {
            return Monto * (PorcentPropina / 100);
        }

        public double calcularMontoTotal()
        {
            return Monto + calcularPropina();
        }
    }
}
