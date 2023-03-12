using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1

            Console.WriteLine("task 1");
            Console.WriteLine("enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = a; i < b; i++)
            {

                if ((i % 3) == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter+" integers divided by 3 without remainder");

            #endregion

            #region task 2

            Console.WriteLine("task 2");
            Console.WriteLine("enter text and yuo get evry second char");
            string text = Console.ReadLine();
            var s = text.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    Console.WriteLine(s[i]);
                }
            }
            #endregion

            #region task 3
            Console.WriteLine("task 3"); 
            Console.WriteLine("Select Drink coffee, tea, juice, water");
            text = Console.ReadLine();
            switch (text)
            {
                case "coffee":
                    Console.WriteLine("Coffee price 14");
                    break;
                case "tea":
                    Console.WriteLine("Tea price 300$");
                    break;
                case "juice":
                    Console.WriteLine("juice price 100");
                    break;
                case "water":
                    Console.WriteLine("water price 0");
                    break;
                default:
                    Console.WriteLine("no drink");
                    break;
            }
            #endregion

            #region task 4
            Console.WriteLine("task 4"); 
            Console.WriteLine("enter the sequence");
            List<int> numbers = new List<int>();
            a = 0;
            while (a >= 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a >= 0)
                {
                    numbers.Add(a);
                }
            }

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum = sum + numbers[i];
            }

            Console.WriteLine("arithmetic average is "+sum / numbers.Count);
            #endregion

            #region task 5

            Console.WriteLine("task 5");
            Console.WriteLine("Enter year");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 100 == 0 && year % 400 == 0)
            {

                Console.WriteLine(year + " year is leap");

            }
            else
            {
                Console.WriteLine(year + " year is`n leap");
            }
            #endregion


            #region task6

            Console.WriteLine("task 6");
            Console.WriteLine("enter number");
            var charsArray = Console.ReadLine().ToCharArray();
            sum = 0;
            foreach (char c in charsArray)
            {
                sum += short.Parse(c.ToString());
            }
            Console.WriteLine("sum the digits of number is"+sum);
            #endregion



            #region task7
            Console.WriteLine("task 7");
            Console.WriteLine("enter number");
            var charsArrayTask7 = Console.ReadLine().ToCharArray();
            bool isODD = true;
            foreach (var item in charsArrayTask7)
            {
                if (int.Parse(item.ToString()) % 2 != 0)
                {
                    isODD = false;
                }
            }
            if (isODD)
            {
                Console.WriteLine("odd digits");
            }
            else
            {
                Console.WriteLine("one ore more digits not the odd");
            }
            #endregion

            #region hw 1
            Console.WriteLine("home work 1");
            Console.WriteLine("enter text");
            string str = Console.ReadLine();
            var chars = str.ToCharArray();
            int aCount = 0;
            int oCount = 0;
            int iCount = 0;
            int eCount = 0;

            foreach (var item in chars)
            {
                if (item == 'a')
                {
                    aCount++;
                }
                else if (item == 'o')
                {
                    oCount++;
                }
                else if (item == 'i')
                {
                    iCount++;
                }
                else if (item == 'e')
                {
                    eCount++;
                }
            }
            Console.WriteLine("a count {0}, o count {1}, i count {2}, e count {3}", aCount, oCount, iCount, eCount);
            #endregion


            #region hw 2
            Console.WriteLine("home work 2");

            Console.WriteLine("enter month number");
            a = int.Parse(Console.ReadLine());
            int daysInMonth = System.DateTime.DaysInMonth(2023, a);
            Console.WriteLine("in {0} mont {1} days",a , daysInMonth);

            #endregion


            #region hw3
            Console.WriteLine("home work 3");

            bool isPositive = true;
            Console.WriteLine("Enter 10 numbers");
            sum = 0;
            a = 0;
            int[] ar = new int[10]; 
            for (int i = 0; i <= 9; i++)
            {
                a = int.Parse(Console.ReadLine());
                ar[i] = a;
                if (a<0)
                {
                    isPositive= false;
                }
            }
            if (isPositive)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum += ar[i];
                }
            }
            else
            {
                sum = 1;
                for (int i = 5; i <= 9; i++)
                {
                    sum *= ar[i];
                }
            }
            Console.WriteLine(sum+" First 5 element positive = "+isPositive);
            #endregion
            Console.ReadLine();
        }
    }
}
