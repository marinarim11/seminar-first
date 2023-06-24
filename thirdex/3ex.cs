// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
if(num1 % 2 == 0) {
    Console.WriteLine(" Число четное");
}
else {
    Console.WriteLine(" Число нечетное");
}