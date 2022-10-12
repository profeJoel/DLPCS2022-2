// See https://aka.ms/new-console-template for more information
Console.WriteLine("Utilizando Excepciones");

Console.WriteLine("Ingrese un valor");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese un valor");
int d = Convert.ToInt32(Console.ReadLine());

//int resultado = n / d;
//Console.WriteLine($"El resultado es {resultado}");

/*Crear Excepcion
 * try{
 *      //código a probar
 * }catch (Exception e){
 *      //Código en caso de que el código original falle
 * }finally{
 *      //Indicar que el código de captura de excepciones ha terminado
 * }
 * * */


try
{
    int resultado = n / d;
    Console.WriteLine($"El resultado es {resultado}");
}
catch (Exception e)
{
    Console.WriteLine($"El resultado no se puede calcular, porque el denominador es 0. Por lo tanto, operacion inválida...");
}


