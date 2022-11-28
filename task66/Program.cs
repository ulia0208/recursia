// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// (НЕ ИСПОЛЬЗОВАТЬ РЕЗУЛЬТИРУЮЩУЮ ПЕРЕМЕННУЮ)
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите 1 число ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число ");
int m = Convert.ToInt32(Console.ReadLine());

int SumNum(int n, int m)
{
    if (m==0)
    {
        return (n*(n+1))/2;
    }
    else if (n==0)
    {
        return (m*(m+1))/2;
    }
    else if (m==n)
    {
        return m;
    }
    else if (m<n)
    {
        return n + SumNum(m,n-1);
    }
    else
    {
        return n + SumNum(m, n+1);
    }
}

Console.WriteLine(SumNum(n,m));












// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
