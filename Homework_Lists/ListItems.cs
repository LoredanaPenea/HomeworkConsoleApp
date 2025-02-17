using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.Homework_Lists
{
    class ListItems
    {
        public void CreateLists()
        {
            Console.WriteLine("Please input the size of your list:");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size))
                Console.WriteLine("Please input a positive integer!");
       
            List<int> listNumbers = new List<int>();

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Please input a number for list[{i}]: ");
                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                    Console.WriteLine("Please input a positive integer!");
                listNumbers.Add(number);
            }

            listNumbers.Sort();
            Console.Write("Your list contains the following items: ");
            foreach (var number in listNumbers)
                Console.Write($"{number}; ");

        }
    }
}
