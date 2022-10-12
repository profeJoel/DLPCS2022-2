using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGatos
{
    internal class Perro : Animal
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { this.Nombre = value; }
        }

        private string color;
        public string Color
        {
            get { return color; }
            set { this.color = value; }
        }

        public Perro(string specie, string breed, string nombre, string color) : base(specie, breed)
        {
            this.color = color;
            this.nombre = nombre;
        }

        //polimorfismo
        public override void makeSound() => Console.WriteLine($"{this.nombre} hace GUAU...");


    }
}
