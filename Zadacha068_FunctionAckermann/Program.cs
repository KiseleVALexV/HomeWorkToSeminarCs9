// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckFunction(int m, int n)
{
    if ((m > 0) && (n > 0))
    {
        return AckFunction(m-1, AckFunction(m, n-1));
    }
    if ((m > 0) && (n == 0))
    {
        return AckFunction(m-1, 1);
    }
    return n+1;
}

Console.WriteLine("Введите неотрицательное целое число М :");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное целое число N :");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({M},{N}) = {AckFunction(M,N)}");
Console.ReadKey();
