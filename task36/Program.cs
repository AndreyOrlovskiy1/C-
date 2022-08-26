// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Write($"Введи кол-во целых элементов массива: ");
int numberElem = Convert.ToInt32(Console.ReadLine());

int RandomNumb(int numberElem, int min, int max)
{
    Random rnd = new Random();
    int[] rndNum = new int[numberElem];
    int sumElements = 0;
    for (int i = 0; i < rndNum.Length; i++)
    {
        rndNum[i] = rnd.Next(min, max);

        Console.Write(rndNum[i] + " ");

        if (i % 2 != 1)
        {
            sumElements = sumElements + rndNum[i];
        }
       
    }
    return sumElements;
}

int randomNumbers = RandomNumb(numberElem, 1, 100);

Console.WriteLine($"  Сумма элементов с нечетным индексом = {randomNumbers}");
