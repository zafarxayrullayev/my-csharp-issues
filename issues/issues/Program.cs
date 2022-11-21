using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Даны положительные числа A и B(A > B). На отрезке длины A размещено максимально
            //возможное количество отрезков длины B(без наложений).
            //Не используя операции умножения и деления, найти длину незанятой части отрезка A.

            //int a, b;
            //a = Convert.ToInt32(Console.ReadLine());    
            //b = Convert.ToInt32(Console.ReadLine());
            //int sumB = 0;
            //int shart = b;
            //while (shart < a)
            //{
            //    sumB += b;
            //    shart += b;
            //}
            //Console.WriteLine(a - sumB);



            // 'while'dan 4-masla  START

            //int n;
            //n = Convert.ToInt32(Console.ReadLine());
            //int daraja= 1, counter = 0;
            //while (daraja < n)
            //{
            //    daraja *= 3;
            //    counter++;
            //}

            //// 3 

            //if(daraja == n)
            //{
            //    Console.WriteLine("3 ning darajasi");
            //}
            //else
            //{
            //    Console.WriteLine("emas");
            //}


            // 'while'dan 4-masla  END

            // 'while' dan 30-misol START

            //int a, b, c;
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            //c = Convert.ToInt32(Console.ReadLine());
            //int countEni = 0, countBoyi = 0;
            //int shart = c;
            //while (shart < a)
            //{
            //    countEni++;
            //    shart += c;
            //}
            //shart = c;
            //while (shart < b)
            //{
            //    countBoyi++;
            //    shart += c;
            //}
            //Console.WriteLine($"{countBoyi} * {countEni} = {countEni * countBoyi}");


            // 'while' dan 30-misol END

            // 'while' dan 7-misol START

            int n, k;
            n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i * i < n)
            {
                i++;
            }
            Console.WriteLine(i);
            // 20, 5

        }
    }
}
