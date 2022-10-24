// Задача 2: Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.
// Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int number = new Random().Next(100, 1000);
int ThirdDigit = number % 10;
int SecondDigit = (number / 10) % 10;
int FirstDigit = (number / 100) % 10; // Лишняя строчка, сохранил себе, для наглядности
int FinalDigit = (FirstDigit * 10) + ThirdDigit;
System.Console.WriteLine($"число  {number} равна => {FinalDigit}");

