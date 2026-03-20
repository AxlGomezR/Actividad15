bool continuar;
double salario;
do
{
    Console.WriteLine("Ingrese el salario de un empleado");
    continuar = double.TryParse(Console.ReadLine(), out salario);
    Console.Clear();
    if(continuar && salario > 0)
    {
        Console.WriteLine("El salario ingresado es válido");
    }
    else
    {
        Console.WriteLine("El salario ingresado no es válido");
        continuar = false;
    }
} while (!continuar);