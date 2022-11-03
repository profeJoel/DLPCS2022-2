using EjemploEnums;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Utilizando Enums");


Direccion brujula = Direccion.Sur;
Console.WriteLine($"El valor de la Brujula es {brujula}");

if (brujula == Direccion.Sur)
{
    Console.WriteLine("La brujula apunta a Sur");
}

