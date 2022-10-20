//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int a = Convert.ToInt32(Console.ReadLine());
int b = a/2;
int [] arr = new int[a];
int n = 0;
int m = Convert.ToInt32(Console.ReadLine()); // Числовой диапазон
for( int i = 0; i < a; i++)
{
 arr[i] = new Random().Next(1, m);
 Console.Write(arr[i] + " ");
}
Console.WriteLine(" ");
Console.Write("Произведение пар чисел: ");
for (int i = 0; i < b; i++)
{
    for (int j = a - 1; j > b; j--)
{
    n = arr[i] * arr[j];
}
    
    Console.Write(n + " ");
}
