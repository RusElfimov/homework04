//Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
int sum_min = 0;
int sum_max = 0;
for (int i = 0; i < a; i++)
{
    arr[i] = new Random().Next(-9, 9);
    Console.Write(arr[i] + " ");
    if (arr[i] < 0)
    {
        sum_min = sum_min + arr[i];
    }
    else if (arr[i] > 0)
    {
        sum_max = sum_max + arr[i];
    }
}
Console.WriteLine("Сумма максимальных значений " + sum_max);
Console.WriteLine("Сумма минимальных значений " + sum_min);