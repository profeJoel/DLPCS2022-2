// See https://aka.ms/new-console-template for more information
using EjemploGatos;

Console.WriteLine("Ejemplo Gatos...");
Gato oscar = new Gato("Óscar","macho",7,"marrón","rayado"); //Declaración del objeto
Gato luna = new Gato("Luna","hembra",5,"gris","lisa"); //Declaración del objeto


oscar.eat();
oscar.move();
oscar.meaw();
oscar.purr();

luna.eat();
luna.move();
luna.meaw();
luna.purr();

//oscar.color = "verde"; // esta accion es prohibitiva
oscar.setColor("verde");
Console.WriteLine($"{oscar.getName()} es de color {oscar.getColor()}");