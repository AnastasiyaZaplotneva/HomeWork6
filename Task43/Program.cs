// // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

void IntersectionPointOfStraight (double a1, double c1, double a2, double c2, out double x, out double y)
{
	x = -(c1 - c2) / (a1 - a2);
   	y = a1 * x + c1;
}


Console.WriteLine("Вам необходимо ввести коэффициэнты уравнений двух прямых вида y = kx + b. \nУкажите коэффициэнт k для первой прямой");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Укажите коэффициэнт b для первой прямой");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Укажите коэффициэнт k для второй прямой");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Укажите коэффициэнт b для второй прямой");
double b2 = Convert.ToDouble(Console.ReadLine());

double x1;
double y1;
if (k1 == k2 && b1 != b2)
{
    Console.WriteLine("Эти прямые параллельны");
}	
else if (k1 == k2 && b1 == b2)
{
	Console.WriteLine("Эти прямые совпадают");
}
else 
{
	IntersectionPointOfStraight(k1, b1, k2, b2, out x1, out y1);
    Console.WriteLine($"Эти прямые пересекаются в точке [{x1} ; {y1}]");
}

