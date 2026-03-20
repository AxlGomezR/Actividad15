bool continuar;
double nota;
do
{
    Console.WriteLine("Ingrese la nota del estudiante");
    continuar = double.TryParse(Console.ReadLine(), out nota);
    Console.Clear();
    if(continuar && (nota>=0 && nota <= 100))
    {

    }
    else
    {
        Console.WriteLine("La nota ingresada no es válida");
        continuar = false;
    }
} while (!continuar);