using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_ForEachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
                                           //0   1  2   3   4   5
            int[] lottoNumbers = new int[] { 15, 4, 16, 23, 43, 7 };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(lottoNumbers[5]);

            string[] names = new string[] { "James", "Jeremiah", "Cliff" };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            foreach (int LottoNumber in lottoNumbers)
            {
                Console.WriteLine(LottoNumber);
            }
            foreach (string name in names.Take(3))
            {
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
