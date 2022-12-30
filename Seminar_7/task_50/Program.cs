// task 50

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void PositionNumMatrix(int[,] matrix, int[] position)
{
    if (position[0] < matrix.GetLength(0) || position[1] < matrix.GetLength(1))
    {
    Console.Write("Значение текущей ячейки равно: ");
    Console.Write($"{matrix[position[0], position[1]]}");
    }
    else Console.WriteLine($"[{string.Join(", ", position)}] -> Такой позиции нет в массиве ");
}

Console.Clear();

int[,] matrix = new int[5, 5];
Console.Write("Введите позицию в матрице: ");
int[] position = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
InputMatrix(matrix);
PositionNumMatrix(matrix, position);