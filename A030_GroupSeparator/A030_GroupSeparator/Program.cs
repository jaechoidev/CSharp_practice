using System;

namespace A030_GroupSeparator
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Enter number(Finish:-1): ");
                string s = Console.ReadLine();
                double v = double.Parse(s);
                if (v == -1)
                    break;
                Console.WriteLine(NumberWithGroupSeparator(s));
            }
        }
        private static string NumberWithGroupSeparator(string s)
        {
            int pos = 0;
            double v = double.Parse(s);

            if (s.Contains("."))
            {
                pos = s.Length - s.IndexOf('.');
                string formatStr = "{0:N" + (pos - 1) + "}";
                s = string.Format(formatStr, v);
            }
            else
            {
                s = string.Format("{0:N0}", v);
            }
            return s;
        }

    }

}
