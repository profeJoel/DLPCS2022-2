// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculo del IMC");

/*
 IMC = masa(kg)/altura(mts)^2
delgadez < 18,5
18,5 < normal < 25 
sobrepeso > 25
*/

Console.WriteLine("ingrese su peso (kg):");
double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("ingrese su altura (Mts):");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / (altura * altura);
Console.WriteLine($"El imc es {imc}");

int casoImc;

if (imc < 18.5) {
    Console.WriteLine("Está en delgadez");
    casoImc = 0;
}
else if (imc < 25) {
    Console.WriteLine("Está normal");
    casoImc = 1;
}
else {
    Console.WriteLine("Está con sobrepeso");
    casoImc = 2;
}


//switch

switch (casoImc)
{
    case 0:
        Console.WriteLine("Está en delgadez con switch");
        break;
    case 1:
        Console.WriteLine("Está normal con switch");
        break;
    case 2:
        Console.WriteLine("Está con Sobrepeso con switch");
        break;
}

