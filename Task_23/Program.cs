// Задача 23. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void ShowResult(int value) // Выводит результат
{
    for (int i = 1; i <= value; i++)
    {
        Console.Write(CubeOfNum(i) + " ");
    }
}

int CubeOfNum(int number) // возведение в куб
{
    int cube = (int) Math.Pow(number, 3); // явное преобразование double в int
    return cube;
}

int GetInput(string text) // запрос на ввод данных
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInput("Введите число: ");
ShowResult(num);
