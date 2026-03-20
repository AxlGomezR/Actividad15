bool continuar;
int cantidad;
do
{
    Console.WriteLine("Ingrese la cantidad de productos que desea comprar");
    continuar = int.TryParse(Console.ReadLine(), out cantidad);
    Console.Clear();
    if(continuar && cantidad > 0)
    {

    }
    else
    {
        Console.WriteLine("La cantidad ingresada no es válida");
    }
} while (!continuar);