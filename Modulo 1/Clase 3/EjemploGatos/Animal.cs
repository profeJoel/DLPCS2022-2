using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGatos
{
    internal class Animal
    {
        protected string specie;
        public string Specie {
            get { return specie; }
            set { this.specie = value; }
        }

        protected string breed;
        public string Breed { 
            get { return breed; }
            set { this.breed = value; } 
        }

        public Animal(string specie, string breed)
        {
            this.specie = specie;
            this.breed = breed;
        }

        public virtual void makeSound() => Console.WriteLine($"El Animal hace un sonido...");
        public void makeSound(string sound) => Console.WriteLine($"El Animal hace el siguiente sonido {sound}");
    }
}
