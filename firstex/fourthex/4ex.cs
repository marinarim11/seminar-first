// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

int count = 1;

while (count <= num1)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }


    count = count + 1;
}