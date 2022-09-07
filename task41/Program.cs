// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write($"Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

void Input(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int Positive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

Input(n);
Console.WriteLine($"Чисел больше нуля : {Positive(array)} ");
