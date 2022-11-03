using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploMVCConsola
{
    public class ControladorCuenta
    {
        private ModeloCuenta cuenta;
        private VistaCuenta vista;

        public ControladorCuenta()
        {
            vista = new VistaCuenta();
            cuenta = new ModeloCuenta(vista.Monto, vista.PorcentPropina); // se conecta los valores de la vista con el modelo
            vista.Propina = cuenta.calcularPropina();
            vista.TotalCuenta = cuenta.calcularMontoTotal();
            // La vista cuenta con toda la información para mostrar

            vista.MostrarInfoCuenta();
        }
    }
}
