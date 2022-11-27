// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int m, int n)
{
    if (n < m) (m, n) = (n, m);
    
    if (m == n)
    {
        return m;
    }   
    return m + SumNumbers(m+1, n);
}

Console.WriteLine("Введите число М :");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N :");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных чисел в промежутке между M и N : {SumNumbers(M, N)}");
Console.ReadKey();
