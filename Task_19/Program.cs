// Задача 19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Вариант 1. Введенное число обрабатывается как массив символов.
//            К строке можно обращаться как к массиву.
//            Работает для чисел и слов любой длины. Проверок на ошибки нет.
// Console.Write("Введите число: ");
// string input = Console.ReadLine();
// int n = input.Length;
// bool flag = true;
//
// for (int i = 0; i < n / 2; i++)
// {
//     if (input[i] != input[n - 1 - i])
//     {
//         flag = false;
//         break;
//     }
// }
//
// if (flag)
// {
//     Console.Write("да");
// }
// else
// {
//     Console.Write("нет");
// }

// Вариант 2. Это вариант 1 с функциями.
void ShowResult(bool value) // Выводит текстовое сообщение
{
    if (value)
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
        Console.WriteLine("Это не палиндром");
    }
}

bool isPalindrome(string number) // Определяет является ли число (слово) палиндромом
{
    for (int i = 0; i < number.Length / 2; i++)
    {
        if (number[i] != number[number.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}

string GetInput(string text) // Выдает запрос на ввод числа (слова)
{
    Console.Write(text);
    return Console.ReadLine();
}

string input = GetInput("Введите число или слово: ");
ShowResult(isPalindrome(input));