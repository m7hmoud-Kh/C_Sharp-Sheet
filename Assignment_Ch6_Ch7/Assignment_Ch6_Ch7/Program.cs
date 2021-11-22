using System;

namespace Assignment_Ch6_Ch7
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.11
            /*
            int counter,number,multiple=0,not_multiple=0;
            Console.WriteLine("Enter Counter of Number");
            counter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter {counter} Number");
            for(int i=0;i<counter;i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number % 5 == 0)
                    multiple++;
                else
                    not_multiple++;
            }

            Console.WriteLine($"multiple Number is:{multiple} And not multiple Number is: {not_multiple}");
            */


            //6.15
            // int h;
            // h = Convert.ToInt32(Console.ReadLine());

            //[a]
            /*
            for (int i = 0; i < h; i++)
            {
                for (int j = i; j >= 0; j--)
                    Console.Write("*");
                Console.WriteLine();
            }
            */

            //[b]
            /*
           for (int i = 0; i < h; i++)
           {
               for (int j = i; j < h; j++)
                   Console.Write("*");

               Console.WriteLine();
           }
            */
            //[c]
            /*
            for(int i=0;i<h;i++)
            {
                for(int k=h;k>h-i;k--)
                {
                    Console.Write(" ");
                }    
                for(int j=1;j<=h-i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */
            //[d]
            /*
           for(int i=1;i<=h;i++)
            {
                for(int j=1;j<=h-i;j++)
                {
                    Console.Write(' ');
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            */


            //6.21
            /*
            for(int side1=1;side1<=500;side1++)
            {
                for(int side2=1;side2<=500;side2++)
                {
                    for(int hypo=1; hypo<=500; hypo++)
                    {
                        double result,tenuse;
                        result = Math.Pow(side1, 2) + Math.Pow(side2, 2);
                        tenuse = Math.Pow(hypo, 2);
                        if (result == tenuse)
                            Console.WriteLine($"{side1} , {side2} =>  {hypo}");

                    }
                }
            }
            */

            //-----------------------------CH7----------------------------

            //7.22
            /*
            double f,c;
            Console.WriteLine("Enter Fahrenheit temperature");
            f = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The Celsius temperature is:  {5.0 / 9.0 * (f - 32)}");

            Console.WriteLine("Enter Celsius temperature");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The Fahrenheit temperature is:  {9.0 / 5.0 * c + 32}");
            
            */
            //7.25
            /*
            int n = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            
            for(int i=2;i<Math.Sqrt(n);i++) // or use n/2
            {
                if (n % i == 0)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
                Console.WriteLine("this is not prime");
            else
                Console.WriteLine("this is prime number");
            */

            
            int p = 0,f=0;
            bool flag = false;
            for(int i=1;i<=10;i++) // use 10000 instead of 10
            {
                for(int a=2;a<i;a++)
                {
                    if (i % a == 0)
                        flag = true;
                }
                if (!flag)
                    p++;
                else
                    f++;

                flag = false;
            }
            Console.WriteLine(p +" "+ f);
            

        }


    }
}
