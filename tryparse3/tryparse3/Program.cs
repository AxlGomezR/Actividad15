int estudiantes;
bool continuar;
do
{
    Console.WriteLine("Cuántos estudiantes hay en el curso?");
    continuar = int.TryParse(Console.ReadLine(), out estudiantes);
    Console.Clear();
    if(continuar && (estudiantes > 0))
    {
        Console.WriteLine("La cantidad ingresada es válida");
    }
    else
    {
        Console.WriteLine("La cantidad ingresada no es válida");
        continuar = false;
    }
} while (!continuar);