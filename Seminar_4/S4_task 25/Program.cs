// task 25

Console.Clear();

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()), exponentiation = 1;

for (int i = 0; i < b; i++)
{
    exponentiation *= a;
}
Console.WriteLine($"Натуральная степень первого числа - {exponentiation}");