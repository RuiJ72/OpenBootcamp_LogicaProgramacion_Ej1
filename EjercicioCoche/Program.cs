using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System;
using System.Collections;

namespace EjercicioCoche
{   

    class Program
    {   
        

        static void Main(string[] args)
        {
            ArrayList puertas = new ArrayList();

            puertas.Add("1");
            

            for (int i = 0; i < puertas.Count; i++)
            {
                Console.WriteLine("Fué añadida {0} puerta al coche", puertas[i]);
            }


        }
    }
}

