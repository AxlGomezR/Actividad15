bool continuar;
DateTime fecha;
do
{
    Console.WriteLine("Ingrese una fecha");
    continuar = DateTime.TryParse(Console.ReadLine(), out fecha);
} while (!continuar);