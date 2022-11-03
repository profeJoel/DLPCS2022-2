// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese la edad de la persona: ");
int edad = Convert.ToInt32(Console.ReadLine());

if (edad > 0 && edad < 130)
{
    if (edad >= 18)
        Console.WriteLine("la persona es mayor de edad");
    else
        Console.WriteLine("La persona es menor de edad");
}
else
    Console.WriteLine("La edad no es aceptada");