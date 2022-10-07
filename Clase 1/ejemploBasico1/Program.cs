// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int x = 10;
while(x>0){
    Console.WriteLine($"El valor es: {x}");
    x--;
}

Console.WriteLine(despedir(x));

String despedir(int n)
{
    return $"Fin del programa con valor x = {n}";
}