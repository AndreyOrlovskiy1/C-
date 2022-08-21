// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] resilt = FillArray(8, 1, 100);
PrintArr(resilt);

int[] FillArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    if (i==0) Console.Write("[");
    if (i< array.Length -1) Console.Write(array[i]+ ",");
    else Console.Write(array[i]+ "]");
    }
}