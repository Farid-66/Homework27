using System;
using System.Text.RegularExpressions;

namespace Task27
{
    class Program
    {
        #region Task1 Method
        static decimal DecimaltoBinary(int number)
        {
            decimal bin = 0;
            int i = 1;
            while (number > 0)
            {
                int mod = number % 2;
                number = (number - mod) / 2;
                bin = bin + mod * i;
                i = i * 10;
            }
            return bin;
        }
        #endregion

        #region Task2 Method
        static int Cube(int number)
        {
            int cube = number;
            for(int i = 1; i < 3; i++)
            {
                number = number * cube;
            }
            return number;
        }
        #endregion

        #region Task3 Method
        static int CountNumber(int number)
        {
            int count = 0;
            while (number > 0)
            {
                int mod = number % 2;
                number = (number - mod) / 10;
                count++;
            }
            return count;
        }
        #endregion

        #region Task4 Method
        static int SumTwo(int number)
        {
            string str = "";
            int sum = 0;
            for(int i = 0; i < number; i++)
            {
                str += "2";
                Console.WriteLine(str);
                sum = sum + Convert.ToInt32(str);
            }

            return sum;
        }
        #endregion

        #region Task5 Method
        static string Pattern(int number)
        {
            string str = "";
            string str1 = "";

            for(int i = 0; i <= (number - 1) / 2; i++)
            {
                for(int j=0; j <= i; j++)
                {
                    str += "*";
                }
                str += "\n";

                for (int j = i; j < (number-1)/2; j++)
                {
                    str1 += "*";
                }
                str1 += "\n";
            }

            return str + str1;
        }
        #endregion

        #region Task6 Method
        static int CountSpaces(string str)
        {

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]==' ')
                {
                    count++;
                }
            }
            return count;
        }
        #endregion


        static void Main(string[] args)
        {
            #region Task1

            /*Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            decimal result = DecimaltoBinary(number);
            Console.WriteLine("Binary: " + result);*/

            #endregion

            #region Task2

            /*Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            decimal result = Cube(number);
            Console.WriteLine("Cube: " + result);*/

            #endregion

            #region Task3

            /*Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            decimal result = CountNumber(number);
            Console.WriteLine("Count: " + result);*/

            #endregion

            #region Task4

            /*Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            decimal result = SumTwo(number);
            Console.WriteLine("Sum: " + result);*/

            #endregion

            #region Task5

            /*Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = Pattern(number);
            Console.WriteLine(result);*/

            #endregion

            #region Task6

            
            /*Console.Write("Please input words: ");
            string str = Console.ReadLine();

            int result = CountSpaces(str);
            Console.WriteLine(result);*/

            #endregion

        }
    }
}
