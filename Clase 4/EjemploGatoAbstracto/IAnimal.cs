using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGatoAbstracto
{
    interface IAnimal
    {
        public abstract void makeSound();
        public abstract string getName();
    }
}
