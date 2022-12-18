// task 13

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int third_num = 1;
if (number > 99)
{
    while (number > 1000)
    {
        number = number / 10;
    }
    third_num = number % 10;
        Console.WriteLine($"Третья цифра - {third_num}");
}
else
    Console.WriteLine("Третьей цифры нет");