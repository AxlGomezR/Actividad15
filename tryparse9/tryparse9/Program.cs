bool continuar;
double nota;
do
{
    Console.WriteLine("Ingrese la nota del estudiante");
    continuar = double.TryParse(Console.ReadLine(), out nota);
    Console.Clear();
    if(continuar && (nota>=0 && nota <= 100))
    {
        if (nota <= 60)
        {
            Console.WriteLine("El estudiante reprobó");
        }
        else
        {
            Console.WriteLine("El estudiante aprobó");
        }
    }
    else
    {
        Console.WriteLine("La nota ingresada no es válida");
        continuar = false;
    }
} while (!continuar);