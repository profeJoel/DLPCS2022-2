using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploMVCConsola
{
    public class ModeloCuenta
    {
        private double monto;
        public double Monto { get { return monto; } set { monto = value; } }
        private double porcentPropina;
        public double PorcentPropina { get { return porcentPropina; } set { porcentPropina = value; } }

        public ModeloCuenta(double monto, double porcentPropina)
        {
            Monto = monto;
            PorcentPropina = porcentPropina;
        }

        public double calcularPropina()
        {
            if(PorcentPropina > 0)
                return Monto * (PorcentPropina / 100);
            return 0;
        }

        public double calcularMontoTotal()
        {
            return Monto + calcularPropina();
        }
    }
}
