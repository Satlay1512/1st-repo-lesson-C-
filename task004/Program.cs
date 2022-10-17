// 3. Напишите программу вычисления функции:
//  x = f(a)

Console.Write("Введите число ");
string inputString = Console.ReadLine();
int value = Convert.ToInt32(inputString);
int cube = value * value * value; 

System.Console.WriteLine(cube);