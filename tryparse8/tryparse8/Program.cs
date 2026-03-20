bool continuar;
double raiz;
do
{
    Console.WriteLine("Ingrese un número");
    continuar = double.TryParse(Console.ReadLine(), out raiz);
    Console.Clear();
    if(continuar && raiz >= 0)
    {
        Console.WriteLine($"La raiz de {raiz} es = {Math.Sqrt(raiz)}");
    }
    else
    {
        Console.WriteLine("El número ingresado no es válido");
        continuar = false;
    }
} while (!continuar);