using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGatoAbstracto
{
    public class Gato : Animal, IAnimal
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }
        private string color;
        public string Color { get { return color; } set { color = value; } }

        public Gato(string specie, string breed, string name, string color)
        {
            Specie = specie;
            Breed = breed;
            Name = name;
            Color = color;
        }

        public void makeSound()
        {
            Console.WriteLine($"{Name} está maullando...");
        }
        public string getName()
        {
            return name;
        }


    }
}
