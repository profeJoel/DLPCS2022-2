// See https://aka.ms/new-console-template for more information
using EjemploMVCConsola;

/*Console.WriteLine("Caso normal sin MVC");

Cuenta c1 = new Cuenta(100000, 20);
Console.WriteLine($"La cuenta es {c1.Monto} con propina de {c1.PorcentPropina}% y da un total de {c1.calcularMontoTotal()}");
*/

Console.WriteLine("Usando MVC");
ControladorCuenta cajero = new ControladorCuenta();
// De ingresar los datos a través de la vista
// conectar los datos ingresados al modelo
// Procesar los datos en el modelo y mostrarlo en la vista
