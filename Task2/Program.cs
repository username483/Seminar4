// Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.WriteLine("Введите число A ");
int A = int.Parse(Console.ReadLine());
// string a = Convert.ToString(A); // первый способ
// Console.WriteLine(a.Length);

int count = 0;
A = Math.Abs(A);
while(A !=0)
{
    A=A/10;
    count++;
}
Console.WriteLine(count);