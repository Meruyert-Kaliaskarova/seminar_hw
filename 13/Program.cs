// task 13

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string any_number = Convert.ToString(number);
if (any_number.Length > 2){
  Console.WriteLine("Третья цифра - " + any_number[2]);
}
else {
  Console.WriteLine("- Третьей цифры нет");
}