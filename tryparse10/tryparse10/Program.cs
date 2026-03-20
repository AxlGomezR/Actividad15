bool continuar;
int cantidad;
do
{
    Console.WriteLine("Ingrese la cantidad de productos que desea comprar");
    continuar = int.TryParse(Console.ReadLine(), out cantidad);
    Console.Clear();
    if(continuar && cantidad > 0)
    {
        double total=0;
        for(int i =0; i<cantidad; i++)
        {
            Console.WriteLine($"Producto {i+1}");
            Console.WriteLine("Nombre del producto: ");
            Console.ReadLine();
            Console.WriteLine("Precio del producto");
            total += double.Parse(Console.ReadLine());
            Console.Clear();
        }
        Console.WriteLine($"El total a pagar es = {total}");
    }
    else
    {
        Console.WriteLine("La cantidad ingresada no es válida");
        continuar = false;
    }
} while (!continuar);