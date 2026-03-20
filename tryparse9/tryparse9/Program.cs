bool continuar;
double nota;
do
{
    Console.WriteLine("Ingrese la nota del estudiante");
    continuar = double.TryParse(Console.ReadLine(), out nota);
} while (!continuar);