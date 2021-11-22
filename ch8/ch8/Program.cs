using System;

namespace ch8
{
    class Program
    {
        static void Main(string[] args)
        {



            //8.14

            /*
            int[] array = { 1, 2, 3, 4, 5, 6};
            Console.WriteLine(products(6,array));
            */



            //8.15
            /*
            int length = Convert.ToInt32(args[0]);
            int inital = Convert.ToInt32(args[1]);
            int step = Convert.ToInt32(args[2]);
            int total = 0;

            int[] arr = new int[length];
            arr[0] = inital;
            for(int i=1;i<arr.Length;i++)
            {
                arr[i] = arr[i - 1] + step;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }

            Console.WriteLine($"the average of array is:{total} / {length} = {total/length}");
            */



            //8.16

            /*
            int length = Convert.ToInt32(args[0]);
            double intial = Convert.ToDouble(args[1]);
            double step = Convert.ToDouble(args[2]);
            double total = 0;

            double[] array = new double[length];
            for(int i=0;i<length;i++)
            {
                array[i] = intial + (step * i);
            }

            foreach (double arr in array)
            {
                total += arr;
            }

            Console.WriteLine(total);
            */


            //8.30
            /*
            int[] array2 = { 40, 2, 30, 4, 5 };
            int[] array1 = { 6, 70, 8, 9, 10 };

            int[] arraymeraged = new int[10];
            int temp = 0;
            for(int i=0;i<array1.Length;i++)
            {
                arraymeraged[i] = array1[i];
            }
            for(int i=0;i<array2.Length;i++)
            {
                arraymeraged[i + array1.Length] = array2[i]; 
            }

            for(int i=0;i<arraymeraged.Length;i++)
            {
                for(int j=0;j<arraymeraged.Length;j++)
                {
                    if(arraymeraged[i] < arraymeraged[j])
                    {
                        temp = arraymeraged[i];
                        arraymeraged[i] = arraymeraged[j];
                        arraymeraged[j] = temp;
                    }
                }
            }

            for(int i=0;i<arraymeraged.Length;i++)
            {
                Console.WriteLine(arraymeraged[i]);
            }
            */



        }

        static int products(int l ,int[] arr)
        {
            int total = 1;
            for (int i = 0; i < l; i++)
                total *= arr[i];

            return total;
        }
    }
}
