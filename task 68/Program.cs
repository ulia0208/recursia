// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

 Console.Clear();
 Console.Write("Введите  первое число ");
 int n = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите второе число ");
 int m = Convert.ToInt32(Console.ReadLine());

 int Ankerman(int n, int m)
 {
    if(n==0)
    {
        return (m+1);
    }
    else if (m==0)
    {
        return(Ankerman(n-1,1));
    }
    else
    {
        return(Ankerman(n-1 , Ankerman(n,m-1)));
    }

 }
Console.WriteLine(Ankerman(n,m));