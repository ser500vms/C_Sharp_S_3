﻿// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Если вы хотите вычислить квадратный корень в языке Си Шарп, то необходимо вызвать метод Sqrt:
// Math.Sqrt(5.25);
// Метод принимает значение с плавающей точкой и возвращает значение с плавающей точкой. Но если мы напишем целочисленное значение, или данный метод будет принимать значение переменной типа int, то ошибки не будет. 
// Но если мы возвращающее значение будем передавать целочисленной переменной, то будет ошибка, в данном случае нужно делать конвертацию:
// int i = Convert.ToInt32(Math.Sqrt(5.25));
// При написании отрицательного значения:
// Math.Sqrt(-1);
// Оно возвращает: NaN.
// Для дробного или значения с плавающей точкой:
// double d = Math.Sqrt(14.5);

// Для того, чтобы возвести в степень, нужно вызвать метод Pow, который находится в статическом классе, поэтому необходимо:

// Math.Pow(x, stepen);

// Обратите внимание, что метод принимает значения типа double, если мы объявим тип int, то ошибки не будет:

// int x = 5;
// int stepen = 4;
// Console.WriteLine("5^4 = " + Math.Pow(x, stepen));

// Если вам нужно получить целое число степени, то можете сделать так:

// int i = Convert.ToInt32(Math.Pow(5, 3));

// Если мы напишем:

// int i = Math.Pow(5, 3);

// То будет ошибка, поэтому нужно конвертация в целое число.

void ShowQuater(int ax, int ay, int bx, int by)
{
    double distance = Math.Sqrt(Math.Pow(ax-bx, 2) + Math.Pow(ay-by, 2));
    Console.WriteLine ($"Расстояние между двух точек: {Math.Round(distance, 3)}!"); 
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int ax = GetInput("Введите координаты Х1: ");
int ay = GetInput("Введите координаты Y1: ");
int bx = GetInput("Введите координаты Х2: ");
int by = GetInput("Введите координаты Y2: ");
ShowQuater(ax, ay, bx, by);