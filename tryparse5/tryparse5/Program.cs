bool continuar;
int numero;
do
{
    Console.WriteLine("Ingrese un número");
    continuar = int.TryParse(Console.ReadLine(), out numero);
} while (!continuar);