//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int a = Convert.ToInt32(Console.ReadLine());
double [] arr = new double[a];
for( int i = 0; i < a; i++)
{
 arr[i] = new Random().NextDouble();
 Console.Write(arr[i] + " ");
}
double max = arr[0];
double min = arr[0];
for( int i = 1; i < a; i++)
{
if (arr[i] > max)
{
    max = arr[i];
}
else if (arr[i] < min)
{
    min = arr[i];
}
}
Console.WriteLine(" ");
Console.WriteLine(max);
Console.WriteLine(min);
Console.Write("Разница между максимальным и минимальным значением = ");
Console.Write(max - min);