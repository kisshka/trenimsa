using CoolApp;

int a;
int b;

Console.Write("Введите а: ");
a = int.Parse(Console.ReadLine());
Console.Write("Введите b: ");
b = int.Parse(Console.ReadLine());

Console.WriteLine(Plus.PlusMethod(a,b));