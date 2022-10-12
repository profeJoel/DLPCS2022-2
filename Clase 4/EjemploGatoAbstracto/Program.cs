// See https://aka.ms/new-console-template for more information
using EjemploGatoAbstracto;

Console.WriteLine("Probando las clases abstractas...");

Gato minino = new Gato("Felino", "Angora", "Minino", "Gris");
minino.sleep();
minino.makeSound();


Perro firulais = new Perro("Firulais");

firulais.makeSound();
// firulais.sleep();

IAnimal[] mascotas = { minino, firulais };

foreach (IAnimal mascota in mascotas)
{
    Console.WriteLine($"La mascota se llama {mascota.getName()}");
}