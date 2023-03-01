using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            int[] omas = { -5, 6, 1, 3, 0, -2 };
            //            for (int i = 0; i < omas.Length - 1; i++)
            //            {
            //                for (int j = i + 1; j < omas.Length; j++)
            //                    if (omas[i] > omas[j])
            //                    {
            //                        {
            //                            int p = omas[i];
            //                            omas[i] = omas[j];
            //                            omas[j] = p;
            //                        }
            //                    }
            //                foreach (int el in omas)
            //                {
            //                    Console.Write($"{el} \t");
            //                }
            //            }
            //        }
            //    } 
            Random rnd = new Random();
            double sum = 0;
            double[] array = new double[31];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 61 + 4 * rnd.NextDouble();
                Console.WriteLine($"array[{i}]={array[i]:f2}");
                sum += array[i];
            }
            Console.WriteLine($"Ср.зн.валюты={(double)sum / array.Length:f2}"); 
            

        }      
    }
}      