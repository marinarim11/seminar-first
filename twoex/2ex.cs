// See https://aka.ms/new-console-template for more information

int[] arr = new int[3];
Console.WriteLine("Введите число");
arr[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
arr[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
arr[2] = Convert.ToInt32(Console.ReadLine());

int count = 3;

int max = arr[0];

while(count > 0) {
    if(max < arr[count - 1]) {
        max = arr[count - 1];
    }
    count=count-1;
}
Console.WriteLine("Макcимальное число");
Console.WriteLine(max);