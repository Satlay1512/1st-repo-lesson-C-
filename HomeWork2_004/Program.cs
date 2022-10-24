// Задача 4:
// Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
 
bool ValidateNunber(int number)
{
    if(number < 0 || number > 7)
    {
        System.Console.WriteLine("Введенное число ен соответствует дням недели");
        return false;
        }
        return true;
    
}
int number = Prompt("Введите число соответствующему дню недели ");
if (ValidateNunber (number))
{
        if (number > 0 && number < 6)
        {
            System.Console.WriteLine($"{number} не является выходным днем");
        }
   
    else
    {
        System.Console.WriteLine($"{number}  является выходным днем");
    }

    
}



