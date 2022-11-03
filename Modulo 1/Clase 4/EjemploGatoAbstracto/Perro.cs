using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGatoAbstracto
{
    //La clase Perro <implementa> la interface IAnimal
    public class Perro : IAnimal
    {
        private string name;
        public string Name { get { return name; }    set { name = value; } }

        public Perro(string name)
        {
            Name = name;
        }

        public void makeSound()
        {
            Console.WriteLine($"{Name} esta ladrando...");
        }

        public string getName()
        {
            return name;
        }

    }
}
