using System;
using System.Collections;

namespace FirstRecurringCharacter
{
    class Program
    {
        static string s = "abcdefga";
        static void Main(string[] args)
        {
            Console.Write(FirstRecurringCharacterBf(s));
        }

        static char FirstRecurringCharacter(String s)
        {
            Hashtable chars = new Hashtable();
            
            foreach(char character in s)
            {
                if (chars.Contains(character))
                {
                    return character;
                }
                chars.Add(character, 1);
            }
            return ' ';
        }

        static char FirstRecurringCharacterBf(String s)
        {
            for(int i = 0; i< s.Length; i++)
            {
                char comparedChar = s[i];
                
                for(int j = 1; j < s.Length; j++)
                {
                    if(comparedChar == s[j])
                    {
                        return s[j];
                    }
                }
            }
            return ' ';
        }
    }
}
