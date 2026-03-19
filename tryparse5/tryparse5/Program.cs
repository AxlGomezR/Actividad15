bool continuar;
int numero;
do
{
    Console.WriteLine("Ingrese un número");
    continuar = int.TryParse(Console.ReadLine(), out numero);
    Console.Clear();
    if (continuar)
    {

    }
    else
    {
        Console.WriteLine("Dato inválido");
    }
} while (!continuar);