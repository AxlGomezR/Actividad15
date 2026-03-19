bool continuar;
int numero;
do
{
    Console.WriteLine("Ingrese un número");
    continuar = int.TryParse(Console.ReadLine(), out numero);
    Console.Clear();
    if (continuar)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine($"El número {numero} es par");
        }
        else
        {
            Console.WriteLine($"El número {numero} es impar");
        }
    }
    else
    {
        Console.WriteLine("Dato inválido");
    }
} while (!continuar);