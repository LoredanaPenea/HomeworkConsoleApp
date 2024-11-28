// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");

Console.WriteLine("Please type in your name:");
string name = Console.ReadLine();
Console.WriteLine("Please type in your age:");
var age = Console.ReadLine();
Console.WriteLine("Your name is: " + name + " and you are " + age + " years old");
Console.WriteLine($"Your name is {name} and you have {age} years");
int age20 = int.Parse(age) + 20;
Console.WriteLine($"You will be {age20} years old in 20 years");