// task 60

void InputMatrix(int[,,] matrix)
{
    int count = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = count;
                Console.WriteLine($"{matrix[i, j, k]} ({i}, {j}, {k})");
                count++;
            }
        }
    }
}

Console.Clear();
Console.Write("Введите размер матрицы 3х3х3: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
if (size[0] * size[1] * size[2] >= 90)
{
    Console.Write("Вы ошиблись. Введите размер матрицы 3х3х3: \n");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,,] matrix = new int[size[0], size[1], size[2]];
InputMatrix(matrix);