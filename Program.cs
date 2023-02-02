//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int count = 0;
Console.WriteLine("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine());

for   (int i = 0; i <m; i++)  
{
    Console.WriteLine("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    if (num >= 0)
    {
        count++;
    }
}
Console.WriteLine($"Здесь {count} чисел больше 0.");
*/
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k2 * x + b2;

x = Math.Round(x, 2);
y = Math.Round(y, 2);

Console.WriteLine($"The lines will intersect at the point with the coordinates {x};{y}.");
