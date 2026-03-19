bool continuar;
DateTime fecha;
do
{
    Console.WriteLine("Ingrese su fecha de nacimiento");
    continuar = DateTime.TryParse(Console.ReadLine(), out fecha);
    Console.Clear();
    if(continuar && (fecha.Year >= 1900 && fecha.Year <= 2026)){
        Console.WriteLine("La fecha de nacimiento es válida");
    }
    else
    {
        Console.WriteLine("La fecha de nacimiento no es válida");
        continuar = false;
    }
} while (!continuar);