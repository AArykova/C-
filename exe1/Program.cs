// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{
    System.Console.WriteLine("Первое число " + number1 + " больше второго числа " + number2);
}
else System.Console.WriteLine("Второе число " + number2 + " больше первого числа " + number1);
