using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGatos
{
    internal class Gato : Animal
    {
        //atributos
        //Declaraciones de variables
        private string name;
        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }

        private string sex;
        private int age;
        private int weight;
        private string color;
        public string Color
        {
            get { return this.color; }
            set 
            {
                string[] colores = { "blanco", "marrón", "gris", "negro", "naranjo" };
                foreach (string c in colores)
                {
                    if (c == value)
                        this.color = value;
                }
            }
        }
        private string texture;

        //métodos
        //son funciones que implementan el comportamiento de la clase

        //primer método -> Constructor -> permite crear el objeto de la clase (tiene el mismo nombre de la clase)
        public Gato(string specie, string breed, string name, string sex, int weight, string color, string texture) :
        base(specie, breed)
        {
            //Usar atributos heredados
            //this.specie = specie;
            //this.breed = breed;

            //this hace referencia a los atributos propios de los objetos
            this.name = name;
            this.sex = sex; //this.sex es diferente a sex
            this.age = 0;
            this.weight = weight;
            this.color = color;
            this.texture = texture;
        }

        public Gato(string specie, string breed) : base(specie, breed)
        {
        }


        /*void eat()
        {
            Console.WriteLine($"{this.name} esta comiendo...");
        }*/
        public void eat() => Console.WriteLine($"{this.name} esta comiendo...");
        public void move() => Console.WriteLine($"{this.name} se mueve...");
        public void meaw() => Console.WriteLine($"{this.name} esta maullando...");
        public void purr() => Console.WriteLine($"{this.name} esta ronrroneando...");

        /*
        //Método Getters permiten obtener la información
        public string getName() => this.name;
        public string getColor() => this.color;

        //Método Setters permiten modificar la información
        public void setColor(string color)
        {
            string[] colores = { "blanco", "marrón", "gris", "negro", "naranjo" };
            foreach (string c in colores)
            {
                if(c == color)
                    this.color = color;
            }
        }
        */

        //Polimorfismo
        public override void makeSound() => this.meaw();

    }
}
