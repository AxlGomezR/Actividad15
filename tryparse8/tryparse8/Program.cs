bool continuar;
double raiz;
do
{
    Console.WriteLine("Ingrese un número");
    continuar = double.TryParse(Console.ReadLine(), out raiz);
} while (!continuar);