// See https://aka.ms/new-console-template for more information
Console.WriteLine("Arreglos");

//Vectores
double[] pesos = { 0.5, 1.5, 2.5};
Console.WriteLine($"La primera posición es {pesos[1]}");

for(int i = 0; i < pesos.Length; i++)
    Console.WriteLine($"En la posición {i} valor {pesos[i]}");

char[] palabra = { 'h', 'o', 'l', 'a' };
Console.WriteLine(palabra);
foreach(char letra in palabra)
    Console.Write(letra);

string cadena = "lenguaje";
foreach (char letra in cadena)
    Console.Write(letra);

char[] letras = cadena.ToArray();

string p1, p2;
p1 = "Hola ";
p2 = "Mundo!";

//string p3 = p1 + p2;
string p3 = string.Concat(p1,p2);

Console.WriteLine(p3);
Console.WriteLine(p3.ToLower());
Console.WriteLine(p3.ToUpper());
Console.WriteLine($"La letra l esta en la posición {p3.IndexOf('l')}");
Console.WriteLine($"Reemplazar la o por x {p3.Replace('o','x')}");


//Matrices

int[,] matriz;
matriz = new int[3, 3];

matriz[0, 0] = 1;
for(int i=0; i < matriz.Length/3; i++)
{
    for(int j=0; j < matriz.Length/3; j++)
    {
        Console.WriteLine("Ingrese un valor: ");
        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

for (int i = 0; i < matriz.Length / 3; i++)
{
    for (int j = 0; j < matriz.Length / 3; j++)
    {
        Console.Write($"{matriz[i,j]}, ");
    }
    Console.WriteLine();
}
