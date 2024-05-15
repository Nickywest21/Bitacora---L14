class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio No.1");

        int numeroMes; 
        string entradaMes;
        string mesCadena;

        Console.WriteLine("Ingrese un número del 1 al 12 para mostrar del mes");
        entradaMes = Console.ReadLine();

        if(int.TryParse(entradaMes, out numeroMes))
        {
            Console.WriteLine($"se convirtió '{entradaMes}' a '{numeroMes}'");
        }
       else
        {
            Console.WriteLine("Error: Ingrese un número del 1 al 12");
        }
            Console.WriteLine(numeroMes);

        switch (numeroMes)
        {
            case 1:
                mesCadena = "Enero";
                break;

            case 2:
                mesCadena = "Febrero";
                break;

            case 3:
                mesCadena = "Marzo";
                break;

            case 4:
                mesCadena = "Abril";
                break;
                               
            case 5:
                mesCadena = "Mayo";
                break;

            case 6:
                mesCadena = "Junio";
                break;
               
            case 7:
                mesCadena = "Julio";
                break;
               
            case 8:
                mesCadena = "Agosto";
                break;
               
            case 9:
                mesCadena = "Septiembre";
                break;
               
            case 10:
                mesCadena = "Octubre";
                break;
               
            case 11:
                mesCadena = "Noviembre";
                break;
               
            case 12:
                mesCadena = "Diciembre";
                break;

            default:
                mesCadena = "";
                Console.WriteLine("Error: debe ingresar números del 1 al 12");
                break;

            
        }
        Console.WriteLine($"Mes: '{mesCadena}'");


        Console.WriteLine("Ejercicio No.2");

        int numeroA;
        int numeroB;
        int numeroC;

        Console.Write("Ingrese un primer número diferente a 0: ");
        numeroA = int.Parse(Console.ReadLine());

        Console.Write("Ingrese un segundo número diferente a 0: ");
        numeroB = int.Parse(Console.ReadLine());

        Console.Write("Ingrese un tercer número diferente a 0: ");
        numeroC = int.Parse(Console.ReadLine());

        if (numeroA > numeroB)
        {
            if (numeroA > numeroC)
            {
                Console.WriteLine("El número A es mayor que B y C");
            }
            else
            {
                Console.WriteLine("A no es el número mayor");
            }
        }
        else if (numeroA == numeroB)
        {
            if (numeroA > numeroC)
            {
                Console.WriteLine("Los números A y B son mayores a C");
            }
            else
            {
                Console.WriteLine("Los tres números son iguales");
            }
        }
        else if (numeroB > numeroC)
        {
            if (numeroB > numeroA)
            {
                Console.WriteLine("El número B es mayor que A y C");
            }
            else
            {
                Console.WriteLine("El número B no es el mayor");
            }
        }
        else if (numeroB == numeroC)
        {
            if (numeroC > numeroA)
            {
                Console.WriteLine("Los números B y C son mayores a A");
            }
            else if (numeroC > numeroB)
            {
                Console.WriteLine("EL número C es mayor a A y B");
            }
        }

        if (numeroC > numeroA)
        {
            if (numeroC > numeroB)
            {
                Console.WriteLine("El número C es mayor que A y B");
            }
        }
        else
        {
            Console.WriteLine("Ninguno de los casos posibles se cumple");
        }

        Console.WriteLine("Tarea 1");

        Console.WriteLine("Ingresar su año de nacimiento");
        int año = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresar su mes de nacimiento");
        string mesIngresado = Console.ReadLine();

        Console.WriteLine("Ingresar su día de nacimiento");
        int dia = int.Parse(Console.ReadLine());

        int mes = nombresMes(mesIngresado);

        switch (mes)
        {
            case 1:
                if (dia >= 20)
                {
                    Console.WriteLine("Su signo Zodíacal es: Acuario");
                }
                else
                {
                    Console.WriteLine("Su signo Zodíacal es: Capricornio");
                }
                break;

            case 2:
                if (dia >= 20)
                {
                    Console.WriteLine("Su signo Zodíacal es: Piscis");
                }
                else
                {
                    Console.WriteLine("Su signo Zodíacal es: Acuario");
                }
                break;

            case 3:
                if (dia >= 21)
                {
                    Console.WriteLine("Su signo Zodiacal es: Aries");
                }
                else
                {
                    Console.WriteLine("Su signo Zodiacal es: Piscis");
                }
            break;

            case 4:
                if (dia >= 20)
                {
                    Console.WriteLine("Su signo Zodiacal es: Tauro");
                }
                else
                {
                    Console.WriteLine("Su signo Zodiacal es: Aries");
                }
            break;
            case 5:
                if (dia >= 21)
                {
                    Console.WriteLine("Su signo Zodiacal es: Géminis");
                }
                else
                {
                    Console.WriteLine("Su signo Zodiacal es: Tauro");
                }
            break;
        
            case 6:
                if (dia >= 21)
                {
                    Console.WriteLine("Su signo Zodiacal es: Cáncer");
                }
                else
                {
                    Console.WriteLine("Su signo Zodiacal es: Géminis");
                }
            break;

            case 7:
                if (dia >= 23)
                {
                    Console.WriteLine("Su signo Zodiacal es: Leo");
                }
                else
                {
                    Console.WriteLine("Su signo Zodiacal es: Cáncer");
                }
            break;

            case 8:
                if (dia >= 23)
                {
                    Console.WriteLine("Su signo Zodiacal es: Virgo");
                }
                else
                {
                    Console.WriteLine("Su signo Zodiacal es: Leo");
                }
            break;

            case 9:
                if (dia >= 21)
                {
                    Console.WriteLine("Su signo Zodiacal es: Libra");
                }
                else
                {
                    Console.WriteLine("Su signo Zodiacal es: Virgo");
                }
            break;

            case 10:
                if (dia >= 23)
                {
                    Console.WriteLine("Su signo Zodiacal es: Escorpio");
                }
                else
                {
                    Console.WriteLine("Su signo Zodiacal es: Libra");
                }
            break;

            case 11:
                if (dia >= 22)
                {
                    Console.WriteLine("Su signo Zodiacal es: Sagitario");
                }
                else
                {
                    Console.WriteLine("Su signo Zodiacal es: Escorpio");
                }
            break;

            case 12:
                if (dia >= 22)
                {
                    Console.WriteLine("Su signo Zodiacal es: Capricornio");
                }
                else
                {
                    Console.WriteLine("Su signo Zodiacal es: Sagitario");
                }
            break;

            default:
                Console.WriteLine("Ninguna");
                break;
        }
    }

    static int nombresMes (string nombreMes)
    {
        switch (nombreMes)
        {
            case "enero": return 1;
            case "febrero": return 2;
            case "marzo": return 3;
            case "abril": return 4;
            case "mayo": return 5;
            case "junio": return 6;
            case "julio": return 7;
            case "agosto": return 8;
            case "septiembre": return 9;
            case "octubre": return 10;
            case "noviembre": return 11;
            case "diciembre": return 12;
            default: return 0;
        }
    }

}

