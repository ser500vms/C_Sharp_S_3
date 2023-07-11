// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


void Square (int n)
{
Console.WriteLine($"Квадраты чисел в промежутке от 0 до {n}:", n);
    
for (int i = 1; i <= n-1; i++)
{
    Console.Write(i*i + ", ");
}

Console.Write(n*n);
}

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
n = Math.Abs(n);

Square(n);