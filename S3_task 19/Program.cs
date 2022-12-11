// S3 task 19

Console.Clear();

Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] && number[1]==number[3]){
    Console.WriteLine($"Число {number} - палиндром.");
  }
  else Console.WriteLine($"Число {number} - не палиндром.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Введите пятизначное число");