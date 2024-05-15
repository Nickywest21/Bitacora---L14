class Program
{
    static void Main(string[] args)
    {
        string nombre;

        Console.WriteLine("Ingrese su nombre");
        nombre = Console.ReadLine();
        Console.WriteLine("Hola " + nombre);

        int primer;
        int segundo;

        Console.WriteLine("Parte 2: Ej 1");
        Console.WriteLine("Ingrese un número");
        primer = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número");
        segundo = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine("Los resultados de las operaciones son: ");
        int suma = primer + segundo;
        Console.WriteLine(primer + "+" + segundo + "=" + suma);
        
        int resta = primer - segundo;
        Console.WriteLine(primer + "-" + segundo + "=" + resta);

        int multiplicación = primer * segundo;
        Console.WriteLine(primer + "*" +  segundo + "=" + multiplicación);

        int división = primer / segundo;
        Console.WriteLine(primer + "/" + segundo + "=" + división);

        int mod = primer % segundo;
        Console.WriteLine(primer + "%" + segundo + "=" + mod);



        Console.WriteLine("Ejercicio 2: operaciones booleanas");

        bool mayor = primer > segundo;
        Console.WriteLine(primer + ">" + segundo + "=" + mayor);

        bool menor = primer < segundo;
        Console.WriteLine(primer + "<" + segundo + "=" + menor);

        bool igualdad = primer == segundo;
        Console.WriteLine(primer + "==" + segundo + "=" + igualdad);


        int a;
        int b;
        int c;

        Console.WriteLine("Ejercicio 3: jerarquía de operaciones");
        Console.WriteLine("Ingrese un numero que sea diferente a 0");
        a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número diferente a 0");
        b = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un último número diferente a 0");
        c = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Los resultados de las operaciones son: ");
        int uno = a * b + c;
        Console.WriteLine("La expresión a*b+c es: " + uno);

        int dos = a * (b + c);
        Console.WriteLine("La expresión a * (b + c) es: " + dos);

        int tres = a / (b + c);
        Console.WriteLine("La expresión a / (b * c) es: " + tres);

        int cuatro = ((3*a) + (2*b)) / (c*c);
        Console.WriteLine("La expresión ((3*a) + (2*b)) / (c*c): " + cuatro);

        double formula = (-b + (Math.Sqrt((b*b) - (4*a*c)))) / (2*a);
        Console.WriteLine("La expresión de la fórmula cuadrática positiva es: " + formula);

        double formula2 = (-b - (Math.Sqrt((b*b) - (4*a*c)))) / (2*a);
        Console.WriteLine("La expresión de la fórmula cuadrática negativa es: " + formula2);

    }
}
