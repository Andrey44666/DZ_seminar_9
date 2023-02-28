// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Enter meaning M: ");
int meaning_M = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter meaning N: ");
int meaning_N = Convert.ToInt32(Console.ReadLine());

void TheAmountNaturalElements(int meaning_M, int meaning_N)
{
int begin = meaning_M;
int end = meaning_N;
	if(meaning_M > meaning_N)
	{
		begin = meaning_N;
		end = meaning_M;
	}
	for(int i = begin; i <= end; i++)
	{
		i = (end + begin)*(end - begin + 1)/2;
		System.Console.WriteLine(i);
	}  
}

Console.Write("Amounts natural numbers from M to N: ");
TheAmountNaturalElements(meaning_M,meaning_N);
