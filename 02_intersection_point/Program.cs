//  Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine() ?? "0");
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine() ?? "0");
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine() ?? "0");
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine() ?? "0");


void GetIntersectionPoint(double k1, double b1, double k2, double b2)
{
        if (b1==b2 & k1==k2)
    {
        Console.WriteLine($"Прямые y={k1}*x + {b1} и y={k2}*x + {b2} совпадают");
    }
    else if (k1 == k2)
    {
        Console.WriteLine($"Прямые y={k1}*x + {b1} и y={k2}*x + {b2} не пересекутся, так как k1 и k2 равны");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);             // вывела математически
        double y = k1 * x + b1;      

        x = Math.Round(x,4);
        y = Math.Round(y,4);

        Console.WriteLine($"Точка пересечения двух прямых имеет координаты: [{x}, {y}]");
    }
}


GetIntersectionPoint(k1, b1, k2, b2);