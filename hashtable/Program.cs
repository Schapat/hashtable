using System;
using System.Collections;

namespace hashtable
{
    class Program
    {
        static string name = "Nuttun";
        static int[] a = { 1, 2, 3 };
        static int[] b = { 10, 20, 30, 40 };
        static int v = 42;
        static void Main(string[] args)
        {
            SumOfTwoHash(a, b, v);
            Palindrome(name);
            Console.WriteLine(Fibo(7));
        }
        //brute force Array 
        //algorythm spee = n*n = O(n²)
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
        //hashtable with O(n+n)
        public static bool SumOfTwoHash(int[] a, int[] b, int v) {
            Hashtable values = new Hashtable();

            for(int i = 0; i< a.Length; i++)
            {
                int searchedValue = v - a[i];
                values.Add(i, searchedValue);
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
        public static bool Palindrome(string name) {
            string reverse = "";
            for(int i = 0; i<name.Length; i++)
            {
                reverse = name[i] + reverse;

            }
            Console.WriteLine(reverse);
            if (string.Equals(reverse,name, StringComparison.CurrentCultureIgnoreCase)) 
            { 
                Console.WriteLine("TRUE"); 
                return true; 
            }
            else
            {
                Console.WriteLine("FALSE");
                return false;
            }
            
        
        }
        static int i = 0;
        public static int Fibo(int n)
        {
            if (n== 1 || n == 2) return 1;
            else return Fibo(n - 1) + Fibo(n - 2);
        }
    }
    
}
