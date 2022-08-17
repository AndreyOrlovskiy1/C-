// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = coordinates("X", "A");
int y1 = coordinates("Y", "A");
int z1 = coordinates("Z", "A");
int x2 = coordinates("X", "B");
int y2 = coordinates("Y", "B");
int z2 = coordinates("Z", "B");

int coordinates(string coordinatesname, string pointName)
{
    Console.Write($"Введите координату {coordinatesname} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Decision(double X1, double X2,
                double Y1, double Y2,
                double Z1, double Z2)
{
    return Math.Sqrt(Math.Pow((X2 - X1), 2) +
                     Math.Pow((Y2 - Y1), 2) +
                     Math.Pow((Z2 - Z1), 2));
}

double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"Длина {segmentLength}");
