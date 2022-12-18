// task 10

Console.Clear();

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int dev = number / 10;
    int n2 = dev % 10;
    Console.WriteLine(n2);
}
else
    Console.WriteLine("Вы ввели не трехзначное число");