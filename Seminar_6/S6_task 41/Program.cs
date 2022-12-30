// task 41

int InputArray (int [] array) {
    int countPositive = 0;
for (int i = 0; i < array.Length; i++)
 if (array[i] > 0)  ++countPositive;
return countPositive;
}

Console.Clear();
Console.WriteLine("Введите числа: ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
InputArray(array);
Console.WriteLine($"Количество чисел больше 0 - {InputArray(array)}");