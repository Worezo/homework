//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число М");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Result, S = {akkerman(M, N)}");
Console.ReadLine();


int akkerman(int M, int N)
{
if (M == 0) return N + 1;
else if (N == 0) return akkerman(M - 1, 1);
else return akkerman(M - 1, akkerman(M, N - 1));
}

Console.Write($"Функция Аккермана равно {akkerman(M, N)}");

