// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummAll(int m, int n)
{
    if (n == (m - 1)) return 0;
    return n + SummAll(m, n - 1);
}

Console.WriteLine("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1<num2) 
{
    int first = num1;
    int second = num2;
    Console.WriteLine(SummAll(first, second));
}
else if (num1>num2) 
{
    int first = num2;
    int second = num1;
    Console.WriteLine(SummAll(first, second));
}
else Console.WriteLine(num1);

// Console.WriteLine(SummAll(4, 4));