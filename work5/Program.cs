// Найти сумму чисел одномерного массива стоящих на нечетной позиции.
int a = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[a];
int sum = 0;
int m = Convert.ToInt32(Console.ReadLine()); // Числовой диапазон
for( int i = 0; i < a; i++)
{
 arr[i] = new Random().Next(0, m);
 Console.Write(arr[i] + " ");
 if (i % 2 != 0 )
 {
   sum = sum + arr[i]; 
 }
}
Console.WriteLine(" ");
Console.WriteLine(sum);
