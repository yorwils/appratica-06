using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appratica_06
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("ingrese las 3 notas seoaradas ");
            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());
            double nota3 = double.Parse(Console.ReadLine());
            double promedio = (nota1 + nota2 + nota3) / 3;


            if (promedio >= 0)
            {
                if (promedio <= 5)
                {
                    Console.WriteLine("muy malo");
                }
                else if (promedio >= 6)
                {
                    if (promedio <= 10)
                    {
                        Console.WriteLine("malo");
                    }
                }
                else if (promedio >= 11)
                {
                    if (promedio <= 12)
                    {
                        Console.WriteLine("regular");
                    }
                    else if (promedio >= 13)
                    {
                        if (promedio <= 16)
                        {
                            Console.WriteLine("bueno");
                        }
                    }
                    else if (promedio >= 17)

                    {
                        if (promedio <= 20)
                        {
                            Console.WriteLine("muy bueno");
                        }

                    }
                    

                }
            } Console.Read();
        } 
        
    } 
}