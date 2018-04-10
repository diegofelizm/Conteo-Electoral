using System;

namespace golden_boys_Program
{
    class Program
    { 
        static void Main(string[] args)
        {
           
           Console.WriteLine("************** Team Golden Boys ****************");
           Console.WriteLine("***** George Mendez          17-EIIT-1-058 *****");
           Console.WriteLine("***** Lleison Estrella       17-EIIT-1-001 *****");
           Console.WriteLine("***** Diego Feliz            17-EIIT-1-024 *****");
           Console.WriteLine("***** Julio Geraldo          17-EIIT-1-023 *****");
           Console.WriteLine("***** Luis Guirado           17-EIIT-1-052 *****");              
           Console.WriteLine("************************************************");    
           
            int candidato1, candidato2, candidato3;
           
            Console.Write("ingrese los votos para el 1.er candidato");
            candidato1 = Convert.ToInt32(Console.ReadLine()); 
           
            Console.Write("ingrese los votos para el 2.do candidato");
            candidato2 = Convert.ToInt32(Console.ReadLine()); 
            
            Console.Write("ingrese los votos para el 3.er candidato");
            candidato3 = Convert.ToInt32(Console.ReadLine());

            if (candidato1 > candidato2 && candidato1 > candidato3)
            {
                Console.WriteLine("La mayor cantidad de votos es: {0}" , candidato1);
            }
            else
            {
                if (candidato2 > candidato1 && candidato2 > candidato3)
                {
                    Console.WriteLine("La mayor cantidad de votos es: {0}" , candidato2);
                }
                else
                {
                    Console.WriteLine("La mayor cantidad de votos es: {0}" , candidato3);
                }

            }
            Console.ReadKey();
            

         //********* Team Golden Boys *********
         //George Mendez          17-EIIT-1-058
         //Lleison Estrella       17-EIIT-1-001 
         //Diego Feliz            17-EIIT-1-024 
         //Julio Geraldo          17-EIIT-1-023 
         //Luis Guirado           17-EIIT-1-052 
        }
    }
}