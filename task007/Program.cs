// написать программу которое на вход принимает значение, а на выходе показывает обратное згачение
// 1 -> 1
// 2 -> 0,5
// 0,25 -> 4

System.Console.WriteLine("введите число");
string inputString = Console.ReadLine();
double number = Convert. ToDouble(inputString);
double ReversNumber = 1 / number;
System.Console.WriteLine(ReversNumber);
