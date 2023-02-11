// Написать программу вычисления произведения чисел от 1 до N

Console.Clear();
Console.WriteLine("Enter number N");
int N = int.Parse(Console.ReadLine()!);
int result = 0;
for (int i = 1; i <= N; i++)
{
result*=i*i;

}
Console.WriteLine(result);