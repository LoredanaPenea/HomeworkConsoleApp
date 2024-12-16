using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.Homework2
{
    public class Person
    { 
        public string firstName;
        public string lastName;    
        public int age;
        public string gender;

        public void IsOld()
        {
            if (age >= 100)
            {
                Console.WriteLine("You are ancient!");
            }
            else if (age >= 50)
            {
                Console.WriteLine("You are old!");
            }
            else Console.WriteLine("You are still young!");
        }

        public void ShowGender()
        {
            if (gender.Equals("Male") || gender.Equals("male"))
            {
                Console.WriteLine("You are a man!");
            }
            else if (gender.Equals("Female") || gender.Equals("female") )
                Console.WriteLine("You are a woman!");
            else Console.WriteLine("You haven't specified you gender!");
        }

        public void DisplayPersonDetails()
        {
            Console.WriteLine($"Person details are as follows: \n" +
                    $"- First Name: {firstName} \n" +
                    $"- Last Name: {lastName} \n" +
                    $"- Age: {age} \n" +
                    $"- Gender: {gender}");
        }

    }

}
