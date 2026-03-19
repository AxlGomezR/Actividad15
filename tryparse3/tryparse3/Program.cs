int estudiantes;
bool continuar;
do
{
    Console.WriteLine("Cuántos estudiantes hay en el curso?");
    continuar = int.TryParse(Console.ReadLine(), out estudiantes);
} while (!continuar);