// task 66

Console.Clear();

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(PrintNumbers(m, n));

int PrintNumbers(int start, int end)
{
    if (start == end)
        return end;
    return (start + PrintNumbers(start + 1, end));
}