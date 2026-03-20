bool continuar;
double salario;
do
{
    Console.WriteLine("Ingrese el salario de un empleado");
    continuar = double.TryParse(Console.ReadLine(), out salario);
} while (!continuar);