bool continuar;
DateTime fecha;
do
{
    Console.WriteLine("Ingrese su fecha de nacimiento");
    continuar = DateTime.TryParse(Console.ReadLine(), out fecha);
} while (!continuar);