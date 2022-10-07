// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero: ");
//Convertir un texto en un numero: Convert.ToInt32(string)
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"El valor ingresado es: {num}");

// El problema es convertir un numero = 12345 e invertirlo = 54321

//IF
/*if (num > 0)
{
    Console.WriteLine("El valor es positivo");
    num = num * (-1);
}
else
    Console.WriteLine("El valor es Negativo");
*/

// modulo o resto: ej: 3/2=1 -> resto:1
int cocienteEntero = num / 10; // 12345 -> 1234,5 (solo la parte entera)
int resto = num % 10; // 12345 -> 5
//Console.WriteLine($"Cociente Entero es {cocienteEntero} y resto es {resto}");

int resultado = 0;
while(num > 0)
{
    cocienteEntero = num / 10; 
    resto = num % 10;
    resultado = (resultado*10) + resto;
    num = num / 10; 
}

Console.WriteLine($"El numero es {resultado}");