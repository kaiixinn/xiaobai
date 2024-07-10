// See https://aka.ms/new-console-template for more information
using System;




namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入金额:");
            float x = Single.Parse(Console.ReadLine());
            float d;
            if (x < 1000)
            {
                d = 0f;
            }
            else if (x < 2000)
            {
                d = 0.1f;
            }
            else
            {
                d = 0.2f;
            }
            Console.WriteLine("折扣率：" + d);
            Console.WriteLine("折后金额:");
            float y = x - x * d;
            Console.WriteLine(y);
        }
        



        }
    }

