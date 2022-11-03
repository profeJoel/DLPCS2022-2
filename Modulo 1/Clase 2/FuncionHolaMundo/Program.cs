// See https://aka.ms/new-console-template for more information

//funcionHolaMundo();
int a = 10; // local
Console.WriteLine(stringHolaMundo());
Console.WriteLine($"La suma corresponde a {sumarDosEnteros(6,4)}");
Console.WriteLine($"El mayor corresponde a {valorMayor(6,4)}");


static void funcionHolaMundo()
{
    Console.WriteLine("Hola Mundo!");
}

static string stringHolaMundo()
{
    return $"Hola Mundo!";
}

static int sumarDosEnteros(int n1, int n2)
{
    return n1 + n2;
}

static int valorMayor(int n1, int n2)
{
    //return n1 > n2 ? n1 : n2; //forma abreviada de if

    if (n1 > n2)
        return n1;
    return n2;
}
