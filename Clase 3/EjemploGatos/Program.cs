// See https://aka.ms/new-console-template for more information
using EjemploGatos;

Console.WriteLine("Ejemplo Gatos...");
Gato oscar = new Gato("Felino", "Angora","Óscar","macho",7,"marrón","rayado"); //Declaración del objeto
Gato luna = new Gato("Felino","Romano","Luna","hembra",5,"gris","lisa"); //Declaración del objeto


oscar.eat();
oscar.move();
oscar.meaw();
oscar.purr();

luna.eat();
luna.move();
luna.meaw();
luna.purr();

//oscar.color = "verde"; // esta accion es prohibitiva
//oscar.setColor("verde");
//Console.WriteLine($"{oscar.getName()} es de color {oscar.getColor()}");

oscar.Color = "verde";
Console.WriteLine($"{oscar.Name} es de color {oscar.Color}");


//Efectos de aplicar herencia
Console.WriteLine($"{oscar.Name} es de raza {oscar.Breed}");

Animal otroAnimal = new Animal("canino", "Poodle");
Console.WriteLine($"El {otroAnimal.Specie} es de raza {otroAnimal.Breed}");

Perro rocky = new Perro("Canino", "Pastor Alemán", "Rocky", "marrón y negro");
Console.WriteLine($"{rocky.Nombre} es de raza {rocky.Breed}");

//Operación generalizada
/*otroAnimal.makeSound();
otroAnimal.makeSound("mmuuuu");
oscar.makeSound("miau");
rocky.makeSound("guau");
*/

/*otroAnimal.makeSound();
oscar.makeSound();
rocky.makeSound();
*/

//Efectos de la generalización
Animal[] animales = {otroAnimal, oscar, rocky };
foreach (Animal a in animales)
    a.makeSound();