using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number=0 ,number_one = 0,number_two=10;

            Console.WriteLine("while loop");
            while (number < 5)
            {
                Console.WriteLine(number);
                number++;
            }
            Console.WriteLine("do-while loop");
            do
            {
                Console.WriteLine(number_one);
                number_one++;
            } while (number_one < 5);
            Console.WriteLine("for loop");
            for (int i = 0; i < number_two; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("foreach loop");
            ArrayList friends = new ArrayList();
            friends.Add("Eric Schles");
            friends.Add("Mark Brown");
            friends.Add("Noam Lerer");

            foreach (string person in friends)
            {
                Console.WriteLine(person);
            }
            Console.ReadLine();
        }
    }
}
