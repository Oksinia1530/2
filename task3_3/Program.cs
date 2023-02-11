// Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();
Console.WriteLine("Enter number N");
int N = int.Parse(Console.ReadLine()!);
int cube = N*N*N;
if (cube % 2== 0)
{
    Console.WriteLine(cube);
}
else
{
    Console.WriteLine("Enter nuw number");
}