using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "LVIII";

            Console.WriteLine(RomanToInt(S));
        }
        public static int RomanToInt(string s)
        {
            int number = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I' && ((i + 1) < s.Length) && (s[i + 1] == 'V' || s[i + 1] == 'X'))
                    number = number - GetIntValue(s[i]);
                else if (s[i] == 'I')
                    number = number + GetIntValue(s[i]);
                if (s[i] == 'V')
                    number = number + GetIntValue(s[i]);
                if (s[i] == 'X' && ((i + 1) < s.Length) && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                    number = number - GetIntValue(s[i]);
                else if (s[i] == 'X')
                    number = number + GetIntValue(s[i]);
                if (s[i] == 'L')
                    number = number + GetIntValue(s[i]);
                if (s[i] == 'C' && ((i + 1) < s.Length) && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                    number = number - GetIntValue(s[i]);
                else if (s[i] == 'C')
                    number = number + GetIntValue(s[i]);
                if (s[i] == 'D')
                    number = number + GetIntValue(s[i]);
                if (s[i] == 'M')
                    number = number + GetIntValue(s[i]);
            }
            return number;
        }

        private static int GetIntValue(char s)
        {
            switch (s)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
            return 0;
        }
    }

}