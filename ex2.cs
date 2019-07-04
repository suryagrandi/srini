using System;

namespace ConsoleApp2
{
    class Class2
    {
        static void Main(string[] args)
        {
            string text = "HYD";
            char[] cArray = text.ToCharArray();

            for (int i = cArray.Length - 1; i > -1; i--)
            {

                if (cArray[i] % 2 == 0)
                {
                    char reverse = cArray[i];
                    Console.Write(reverse);
                }
                else
                {
                    char reverse1 = cArray[i];
                    Console.Write("_" + reverse1 + "_");

                }
            }
            Console.ReadLine();

        }

    }
}
