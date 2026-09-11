
Console.WriteLine("----- FIGURAS GEOMETRICAS -----");
Console.WriteLine("1. Cuadrado");
Console.WriteLine("2. Circulo");
Console.WriteLine("3. Rombo");
Console.WriteLine("4. Trapecio");
Console.WriteLine("5. Triangulo");

Console.WriteLine("Elige una figura:");
int figura = Convert.ToInt32(Console.ReadLine());

switch (figura)
{
    case 1:
        Console.WriteLine("----- CUADRADO -----");
        Console.WriteLine("1. Area");
        Console.WriteLine("2. Perimetro");
        Console.WriteLine("3. Ambos");
        int opc = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa el lado:");
        double lado = Convert.ToDouble(Console.ReadLine());

        double area = lado * lado;
        double perimetro = lado * 4;

        if (opc == 1)
        {
            Console.WriteLine($"El area es: {area}");
        }
        else if (opc == 2)
        {
            Console.WriteLine($"El perimetro es: {perimetro}");
        }
        else if (opc == 3)
        {
            Console.WriteLine($"El area es: {area}");
            Console.WriteLine($"El perimetro es: {perimetro}");
        }
        else
        {
            Console.WriteLine("La opcion no es correcta");
        }
        break;

        case 2:
        Console.WriteLine("----- Circulo -----");
        Console.WriteLine("1. Area");
        Console.WriteLine("2. Perimetro");
        Console.WriteLine("3. Ambos");
        int opc2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa el radio");
        double radio = Convert.ToDouble(Console.ReadLine());

        double area2 = 3.1416 * radio * radio;
        double perimetro2 = 2 * 3.1416 * radio;

        if (opc2 == 1)
        {
          Console.WriteLine($"El area es: {area2}");  
        }

        else if (opc2 == 2)
        {
            Console.WriteLine($"El perimetro es: {perimetro2}");
        }

         else if (opc2 == 3)
        {
            Console.WriteLine($"El area es: {area2}");
            Console.WriteLine($"El perimetro es: {perimetro2}");
        }

        else
        {
            Console.WriteLine("La opcion no es correcta");
        }
        break;

        case 3:
        Console.WriteLine("----- Rombo -----");
        Console.WriteLine("1. Area");
        Console.WriteLine("2. Perimetro");
        Console.WriteLine("3. Ambos");
        int opc3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa la diagonal mayor");
        double D_Mayor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa la diagonal menor");
        double D_Menor = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Ingresa el lado:");
        double Lado_R = Convert.ToDouble(Console.ReadLine());

        double area3 = D_Mayor * D_Menor / 2;
        double perimetro3 =Lado_R * 4;

        if (opc3 == 1)
        {
          Console.WriteLine($"El area es: {area3}");  
        }

        else if (opc3 == 2)
        {
            Console.WriteLine($"El perimetro es: {perimetro3}");
        }

         else if (opc3 == 3)
        {
            Console.WriteLine($"El area es: {area3}");
            Console.WriteLine($"El perimetro es: {perimetro3}");
        }

        else
        {
            Console.WriteLine("La opcion no es correcta");
        }
        break;

        case 4:
        Console.WriteLine("----- Trapecio -----");
        Console.WriteLine("1. Area");
        Console.WriteLine("2. Perimetro");
        Console.WriteLine("3. Ambos");
        int opc4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa la base mayor");
        double B_Mayor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa la base menor");
        double B_Menor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa la altura");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa el lado 1");
        double L1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa el lado 2");
        double L2 = Convert.ToDouble(Console.ReadLine());

        double area4 = ((B_Mayor + B_Menor ) * altura) / 2;
        double perimetro4 = B_Mayor + B_Menor + L1 + L2;

        if (opc4 == 1)
        {
          Console.WriteLine($"El area es: {area4}");  
        }

        else if (opc4 == 2)
        {
            Console.WriteLine($"El perimetro es: {perimetro4}");
        }

         else if (opc4 == 3)
        {
            Console.WriteLine($"El area es: {area4}");
            Console.WriteLine($"El perimetro es: {perimetro4}");
        }

        else
        {
            Console.WriteLine("La opcion no es correcta");
        }
        break;

        case 5:
        Console.WriteLine("----- Triangulo -----");
        Console.WriteLine("1. Area");
        Console.WriteLine("2. Perimetro");
        Console.WriteLine("3. Ambos");
        int opc5 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa la base:");
        double base_T = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa la altura:");
        double altura_T = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa el lado 1:"); 
        double L1_T = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa el lado 2:"); 
        double L2_T = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa el lado 3:"); 
        double L3_T = Convert.ToDouble(Console.ReadLine());

        double area5 = (base_T * altura_T) / 2;
        double perimetro5 = L1_T + L2_T + L3_T;

        if (opc5 == 1)
        {
          Console.WriteLine($"El area es: {area5}");  
        }

        else if (opc5 == 2)
        {
            Console.WriteLine($"El perimetro es: {perimetro5}");
        }

         else if (opc5 == 3)
        {
            Console.WriteLine($"El area es: {area5}");
            Console.WriteLine($"El perimetro es: {perimetro5}");
        }

        else
        {
            Console.WriteLine("La opcion no es correcta");
        }
        break;

        default: 

        Console.WriteLine("La opcion ingresada no es correcta");
        break;      

}