// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число");

int a = Convert.ToInt32(Console.ReadLine());
//int a = new Random().Next(1, 10);

Console.WriteLine("Введите второе число");

int b = Convert.ToInt32(Console.ReadLine());

if (a > b) {
    Console.WriteLine("max=");
    Console.WriteLine(a);
}
else {
    Console.WriteLine("max=");
    Console.WriteLine(b);
}