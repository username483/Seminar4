//  Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
Console.Clear();
Console.WriteLine("Введите число N ");
int n = int.Parse(Console.ReadLine());
int result = 1;
for (int i = 1; i <= n; i++)
{
    result*=i;
}
Console.WriteLine(result);