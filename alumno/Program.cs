
Console.WriteLine("-----DATOS DEL ALUMNO-----");

Console.WriteLine("Ingresa tu nombre completo");
string nombre = Console.ReadLine()!;

Console.WriteLine("Ingresa tu matricula");
string matricula = Console.ReadLine()!;

Console.WriteLine("Ingresa tu plantel");
string plantel = Console.ReadLine()!;

Console.WriteLine("Ingresa tu semestre");
string semestre = Console.ReadLine()!;

double[] calif = new double[5];

Console.WriteLine("Ingresa la calificacion 1");
calif[0] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingresa la calificacion 2");
calif[1] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingresa la calificacion 3");
calif[2] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingresa la calificacion 4");
calif[3] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingresa la calificacion 5");
calif[4] = Convert.ToDouble(Console.ReadLine());

double promedio = (calif[0] + calif[1] + calif[2] + calif[3] + calif[4]) / 5;

Console.WriteLine("-----INFORMACION DEL ALUMNO-----");

Console.WriteLine($"Nombre: {nombre}");
Console.WriteLine($"Matricula: {matricula}");
Console.WriteLine($"Plantel: {plantel}");
Console.WriteLine($"Semestre: {semestre}");

Console.WriteLine($"Calificacion 1: {calif[0]}");
Console.WriteLine($"Calificacion 2: {calif[1]}");
Console.WriteLine($"Calificacion 3: {calif[2]}");
Console.WriteLine($"Calificacion 4: {calif[3]}");
Console.WriteLine($"Calificacion 5: {calif[4]}");

Console.WriteLine($"Promedio: {promedio}");


