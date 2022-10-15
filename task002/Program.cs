// Напишите программу, которая на вход принимает 
// два числа и проверяет, является ли первое число квадратом второго.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

System.Console.WriteLine("Введите первое число >");

String number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);

System.Console.WriteLine("Введите второе число >");

String number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);

if(a * a == b)
{
    System.Console.WriteLine("второе число является квадратом первого");
}
else
{
    System.Console.WriteLine("Второе число не является квадратом первого");
}