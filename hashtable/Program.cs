using System;
using System.Collections;

namespace hashtable
{
    class Program
    {

        static int[] a = { 1, 2, 3 };
        static int[] b = { 10, 20, 30, 40 };
        static int v = 42;
        static void Main(string[] args)
        {
            SumOfTwoHash(a, b, v);
        }
        //brute force Array 
        //algorythm spee = n*n = n²
        public static bool SumOfTwoBf(int[]a, int[]b, int v)
        {
            for(int i=0; i< a.Length; i++)
            {
                int searchedValue = v - a[i];
                for(int j = 0;j<b.Length; j++)
                {
                    if (searchedValue == b[j])
                    {
                        Console.WriteLine(searchedValue + "==" + b[j]);
                        return true;
                    }
                }
            
            }
            return false;
        }
        //hashtable
        public static bool SumOfTwoHash(int[] a, int[] b, int v) {
            Hashtable values = new Hashtable();

            for(int i = 0; i< a.Length; i++)
            {
                int searchedValue = v - a[i];
                values.Add(i, searchedValue);
            }

            foreach(int value in values.Values)
            {
                Console.WriteLine(value);
            }

            for (int i = 0; i < b.Length; i++)
            {
                if (values.ContainsValue(b[i])) 
                {
                    Console.WriteLine(b[i]);
                    return true;
                }
            }
            Console.WriteLine("nothing found");
            return false;

        }
    }
}
