// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double ShowDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double s = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return s;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = GetInput("Введите координату X1: ");
int y1 = GetInput("Введите координату Y1: ");
int z1 = GetInput("Введите координату Z1: ");
int x2 = GetInput("Введите координату X2: ");
int y2 = GetInput("Введите координату Y2: ");
int z2 = GetInput("Введите координату Z2: ");

Console.WriteLine(ShowDistance(x1, y1, z1, x2, y2, z2));