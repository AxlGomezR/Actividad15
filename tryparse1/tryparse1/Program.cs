int edad;
bool continuar;
do
{
    Console.WriteLine("Ingrese su edad:");
    continuar = int.TryParse(Console.ReadLine(), out edad );
    Console.Clear();
    if(continuar && (edad>=0 && edad <= 120))
    {
        Console.WriteLine($"La edad {edad} es válida");
    }
    else
    {
        Console.WriteLine("Edad inválida");
        continuar = false;
    }
} while (!continuar);