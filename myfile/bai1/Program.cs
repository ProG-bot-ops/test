// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
a = int.TryParse(Console.ReadLine(), out a) ? a : 0;
Console.WriteLine(a);