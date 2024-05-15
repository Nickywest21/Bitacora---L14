using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        int NFibonnacci;
        bool conversionAInt = false;
        bool nPositivo = false;

       do
        {
            Console.WriteLine("Ingrese un númeor mayor a o");
            conversionAInt = int.TryParse(Console.ReadLine(), out NFibonnacci);
            if(conversionAInt)
            {
                if(NFibonnacci > 0)
                {
                    nPositivo = true;
                }
            }
        }
        while(!conversionAInt || !nPositivo);



        Console.WriteLine("Ejercicio 2 ");
            int A= 0;
            int B= 1;
            int C= 0;
            int i =2;
            bool n;
            int nsi;
            bool resultadoN = false;
            int resultado;

            Console.WriteLine("Ingresar el valor de n");
            n = int.TryParse(Console.ReadLine(), out nsi);
            resultadoN = int.TryParse(Console.ReadLine(), out resultado);


            if(nsi>0)
            {
                    
                    Console.WriteLine("Su secuencia es:");
                    resultado = A;
                    Console.WriteLine(resultado);
                    if (nsi > 1)
                    {
                        resultado += B;
                        Console.WriteLine(resultado);
                        
                        while(i<nsi)
                        {
                            C=A+B;
                            resultado = C;
                            A = B;
                            B = C;
                            i = i+1;
                            Console.WriteLine(resultado);
                            
                        }
                
                    }
                    else
                    {
                      Console.WriteLine(resultado);
                  
                    }


            }
            else
            {
                Console.WriteLine(resultado); 
            }


        Console.WriteLine("Tarea");

        int contador = 1;
        double resultado1 = 0;

        Console.WriteLine("Ingrese un valor: ");
        int N = Convert.ToInt32(Console.ReadLine());
       
        while(contador <= N)
        {
        
         resultado1 += 1.0 / contador;
         contador++;
        }
        Console.WriteLine($"Su resultado de la operación 1/serie A es: '{resultado1}'");

        double resultado2 = 0;
        int contador1 = 1;
        while(contador1 <= N)
        {
            resultado2 += 1.0 / Math.Pow(2, contador1);
            contador1++;
        }
        Console.WriteLine($"Su resultado de la operación 2/serie B es: '{resultado2}'");

        Console.WriteLine("Ingrese un valor para la variable x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese un valor para la variable a: ");
        int a = Convert.ToInt32((Console.ReadLine()));
        Console.WriteLine("Ingrese un valor para la variable k: ");
        int num = Convert.ToInt32(Console.ReadLine());

        double resultado3 = 0;
        int k = 0;
        while(k<=num)
        {
            resultado3 += Math.Pow(x,k) * Math.Pow(a, (num - k));
            k++;
        }
        Console.WriteLine($"Su resultado de la operación 3/serie C: '{resultado3}'");

    }   
}
