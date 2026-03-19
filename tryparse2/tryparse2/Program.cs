double precio;
bool continuar;
do
{
    Console.WriteLine("Ingrese el precio de un producto");
    continuar = double.TryParse(Console.ReadLine(), out precio);
    Console.Clear();
    if(continuar && precio > 0)
    {
        Console.WriteLine("El precio ingresado es válido");
    }
    else
    {
        Console.WriteLine("El precio ingresado no es válido");
        continuar = false;
    }
} while (!continuar);