using System.Reflection.Emit;
Console.WriteLine("-----Calculadora Basica-----");
Console.WriteLine("Ingresar un numero");
int num_1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresa el numero 2");
int num_2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-----Menu de operaciones-----");
Console.WriteLine("1.Suma");
Console.WriteLine("2.Resta");
Console.WriteLine("3.Multiplicacion");
Console.WriteLine("4.Division");
Console.WriteLine("5.Residuo");
Console.WriteLine("6.Binomio al Cuadrado Perfecto");
int opc=Convert.ToInt32(Console.ReadLine());

switch (opc)
{
    case 1:
    Console.WriteLine($"El resulado de la suma es:{num_1 + num_2}");
    break;
    case 2:
    Console.WriteLine($"El resulado de la resta es:{num_1 - num_2}");
    break;
    case 3:
    Console.WriteLine($"El resulado de la Multiplicacion es:{num_1 * num_2}");
    break;
    case 4:
    Console.WriteLine($"El resulado de la Division es:{num_1 / num_2}");
    break;
    case 5:
    Console.WriteLine($"El resulado de la Modulo es:{num_1 % num_2}");
    break;
    case 6:
    int resultado=((num_1*num_1)+ 2*(num_1*num_2)+(num_2*num_2));
    Console.WriteLine($"El resultado del Binomio es:{resultado}");
    break;

    default:
    Console.WriteLine("La opcion ingresada no es correcta");
    break;
}
