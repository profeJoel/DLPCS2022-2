using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGatoAbstracto
{
    public abstract class Animal
    {
        //abstract implica que la clase NO tiene constructor
        //atributos
        protected string specie;
        public string Specie { get { return specie; } set { specie = value; } }

        protected string breed;
        public string Breed { get { return breed; } set { breed = value; } }

        //Métodos

        public void sleep()
        {
            Console.WriteLine("Este animal está Duermiendo...");
        }

        //Método abstracto que no tiene desarrollo, solo declaración

        //public abstract void makeSound();
    }
}
