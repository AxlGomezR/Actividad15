bool continuar;
int cantidad;
do
{
    Console.WriteLine("Ingrese la cantidad de productos que desea comprar");
    continuar = int.TryParse(Console.ReadLine(), out cantidad);
} while (!continuar);