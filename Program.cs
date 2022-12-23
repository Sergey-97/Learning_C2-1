Console.WriteLine("Введите трёхзначное число: ");
int num1 = int.Parse(Console.ReadLine());

int num2 = (num1 % 100) / 10;

Console.WriteLine("\nВ числе "
+ num1 + "\nВторое число -> " + num2 + "\n\n");