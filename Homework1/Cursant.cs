// See https://aka.ms/new-console-template for more information
using System.Reflection;
using TestConsoleApp.Homework2;


Console.WriteLine("Hello!");

//Console.WriteLine("Please type in your name:");
//string name = Console.ReadLine();
//Console.WriteLine("Please type in your age:");
//var age = Console.ReadLine();
//Console.WriteLine($"Your name is {name} and you have {age} years");
//int age20 = int.Parse(age) + 20;
//Console.WriteLine($"You will be {age20} years old in 20 years");

Person person1 = new Person();
Console.WriteLine("Type in your first name:");
person1.firstName = Console.ReadLine();
//Console.WriteLine($"Your first name is {person1.firstName}");

Console.WriteLine("Type in your last name:");
person1.lastName = Console.ReadLine();
//Console.WriteLine($"Your last name is {person1.lastName}");

Console.WriteLine("Please type in your age:");
var yourAge = Console.ReadLine();
person1.age = int.Parse(yourAge);

Console.WriteLine("Please type in your gender:");
person1.gender = Console.ReadLine();

person1.DisplayPersonDetails();
person1.IsOld();
person1.ShowGender();
       
