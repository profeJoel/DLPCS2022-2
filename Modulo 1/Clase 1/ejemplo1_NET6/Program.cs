// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Bienvenidos a la clase de C#");
/*
Console.Write("Este Texto");
Console.Write("+Este Texto");
*/

// Entrada de texto
Console.WriteLine("\nIngrese un Texto: ");
string var1 = Console.ReadLine();

Console.WriteLine("El texto ingresado es: " + var1);

//Creación de la Variable
//<nombre del tipo de dato> <nombre variable>; // declaración de variable
//ej:
//int a;


//Inicialización de la Variable
//< nombre del tipo de dato> <nombre variable> = 10; // inicialización de variable
//ej:
int a = 10;

a = 'a';

Console.WriteLine(a);

//Probar más variables
//Las variables son sensibles a las minusculas y mayusculas

int num = 10;
long Eetensos = 10000000000;
float dec = 0.5F; //F indica que es un tipo flotante 
double frac = 0.5D; //D indica que es double
bool condicion = true; // false
bool esMayorEdad = a >= 18;
char letra = 'b';
string texto = "cualquier texto";

Console.WriteLine(num + dec + texto);

// Tipos de convensiones para nombrar variables
//contador de personas
// camelCase -> contadorDePersonas
// snake_case -> contador_de_personas
// SCREAMING_SNAKE_CASE -> CONTADOR_DE_PERSONAS
// kebab-case -> contador-de-personas

Console.WriteLine($"Estas son las variables : num = {num}, dec = {dec}, texto = {texto}");