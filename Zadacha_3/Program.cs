﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Enter meaning M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter meaning N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int AckermannFunction (int numberM, int numberN) // Dычисление функции Аккермана. (Метод)
{
    if (numberM == 0)
    { 
        return numberN + 1;
    }
    if (numberM != 0 && numberN == 0)
    {
        return AckermannFunction(numberM - 1, 1);
    }
    if (numberM > 0 && numberN > 0) 
    {
        return AckermannFunction(numberM - 1, AckermannFunction (numberM,numberN - 1));
    }
    return AckermannFunction(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");