// See https://aka.ms/new-console-template for more information
Console.WriteLine("Cuenta regresiva del año nuevo");

int contador = 10;

//While

/*
while(contador > 0)
{
    Console.WriteLine(contador);
    contador--; // contador = contador - 1; // contador -= 1;
}
*/

//Do-While
/*
do
{
    Console.WriteLine(contador);
    contador--;
} while (contador > 0);
*/

/*Console.WriteLine("Ingresar edad: ");
int edad = Convert.ToInt32(Console.ReadLine());

while(edad < 0)
{
    Console.WriteLine("Ingresar edad: ");
    edad = Convert.ToInt32(Console.ReadLine());
}
*/
/*int edad;
do
{
    Console.WriteLine("Ingresar edad: ");
    edad = Convert.ToInt32(Console.ReadLine());
} while (edad < 0);

Console.WriteLine($"La edad es {edad}");*/


//FOR

//for (int i = contador; i > 0; i--)
//    Console.WriteLine(i);

//for ( ; contador > 0; contador--)
//    Console.WriteLine(contador);

//FOREACH

//requiere de una variable iterable
string[] frutas = {"manzana", "naranja", "pera", "uvas"};
//for (int i = 0; i < 4; i++)
//    Console.WriteLine(frutas[i]);

foreach(string fruta in frutas)
    Console.WriteLine(fruta);
