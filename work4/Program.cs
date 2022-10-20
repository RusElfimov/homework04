//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
int n = 0;
int m = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    arr[i] = new Random().Next(0, m);
    Console.Write(arr[i] + " ");
    if (arr[i] > 10 & arr[i] < 99)
    {
        n = n + 1;
    }
}
Console.WriteLine(" ");
Console.WriteLine(n);