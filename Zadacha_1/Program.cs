// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Enter natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

void ConclusionNatural(int number) // Вывода натуральных чисел. (Метод)
{
    if (number < 0) 
    {
        Console.Write($"{number} - a not natural number"); 
        return;
    }
    else if (number == 0) return;
    Console.Write(number + " ");
    ConclusionNatural(number - 1);
}
Console.Write("Natural numbers: ");
ConclusionNatural(number);
