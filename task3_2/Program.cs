// Написать программу вычисления произведения чисел от 1 до N

Console.Clear();
Console.WriteLine("Enter number N");
int N = int.Parse(Console.ReadLine()!);
int result = 0;
for (int i = 0; i <= N; i++)
{
result*=i;

}
Console.WriteLine($"{result}");