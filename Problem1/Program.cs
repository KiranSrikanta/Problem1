using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        /****************************************************************
         * DO NOT MODIFY
         * Write Answer in Problem1.cs
         * *************************************************************/
        static void Main(string[] args)
        {
            Console.Write("Number Array(Enter numbers seperated by space): ");
            string input = Console.ReadLine();
            int K = 0;
            
            List<int> A = new List<int>();
            try
            {
                foreach (var sNum in input.Split(' '))
                {
                    A.Add(int.Parse(sNum));
                }

                Console.Write("Repeat count value: ");
                K = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error in input!");
                Console.ReadKey();
                return;
            }

            Problem1 p = new Problem1();
            var output = p.WriteSonutionHere(A.ToArray(), K);

            Console.Write("Output: ");
            foreach (var sNum in output)
            {
                Console.Write(sNum);
                Console.Write(' ');
            }

            Console.ReadKey();
        }
    }
}
