// task 27

Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()), sum = 0;
while (num > 0)
{
    sum = sum + num % 10;
    num /= 10;
}
Console.WriteLine($"Сумма цифр в чсиле - " + sum);