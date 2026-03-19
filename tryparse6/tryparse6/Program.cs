bool continuar;
DateTime fecha;
do
{
    Console.WriteLine("Ingrese una fecha");
    continuar = DateTime.TryParse(Console.ReadLine(), out fecha);
    Console.Clear();
    if (continuar)
    {
        Console.WriteLine($"La fecha ingresada es: {fecha.Day} {fecha.Month} {fecha.Year}");
    }
    else
    {
        Console.WriteLine("Dato inválido");
    }
} while (!continuar);