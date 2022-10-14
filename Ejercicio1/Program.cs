using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1
{
    public class Ejercicio1
    {   
        class Program
        {
           public class ClasseSuma
            {
                public int suma(int n1, int n2, int n3)
                {
                    int aux1;
                    int aux2;
                    int aux3;

                    int suma;

                    suma = n1 + n2 + n3;

                    return suma;
                }
            }

            static void Main(string[] args)
            {

            ClasseSuma miClasse = new ClasseSuma();

            int valor1;
            int valor2;
            int valor3;

            Console.WriteLine("Digite un número entero: ");
            string aux1 = Console.ReadLine();

            Console.WriteLine("Gigite el segudo número: ");
            string aux2 = Console.ReadLine();
            
            Console.WriteLine("Digite el tercero numero: ");
            string aux3 = Console.ReadLine();

                valor1 = Convert.ToInt32(aux1);
                valor2 = Convert.ToInt32(aux2);
                valor3 = Convert.ToInt32(aux3);

                Console.WriteLine("La suma ha sido: {0}",
                    miClasse.suma(valor1, valor2, valor3) + Environment.NewLine
                    );


            }
        }

    } 
}