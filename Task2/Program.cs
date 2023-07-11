// Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).

void ShowRange(int quater)
{
    if (quater == 1) Console.WriteLine ("Диапазон будет : x > 0 & y > 0"); 
    if (quater == 2) Console.WriteLine ("Диапазон будет : x < 0 & y > 0"); 
    if (quater == 3) Console.WriteLine ("Диапазон будет : x < 0 & y < 0"); 
    if (quater == 4) Console.WriteLine ("Диапазон будет : x > 0 & y < 0"); 
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int quater = GetInput("Введите номер четверти: ");
ShowRange(quater);