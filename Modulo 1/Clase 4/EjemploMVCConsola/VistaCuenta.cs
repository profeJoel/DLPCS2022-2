using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploMVCConsola
{
    public class VistaCuenta
    {
        private double monto;
        public double Monto { get; set; }
        private double porcentPropina;
        public double PorcentPropina { get; set; }
        private double propina;
        public double Propina { get; set; }
        private double totalCuenta;
        public double TotalCuenta { get; set; }

        public VistaCuenta()
        {
            InteraccionUsuario();
        }

        public void InteraccionUsuario()
        {
            try
            {
                Console.WriteLine("Ingrese el valor de la cuenta");
                Monto = Convert.ToDouble(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine("Valor mal ingresado");
            }

            try { 
                Console.WriteLine("Ingrese porcentaje de propina?");
                PorcentPropina = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Valor mal ingresado");
            }
        }

        public void MostrarInfoCuenta()
        {
            Console.WriteLine($"La cuenta es de {Monto} con porcentaje de propina {PorcentPropina}% con un total de {TotalCuenta}");
        }


    }
}
