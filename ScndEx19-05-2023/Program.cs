Console.Clear();
Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());

int b2 = Convert.ToInt32(Math.Pow(b, 2));

if(a==b2) 
{
    Console.WriteLine($"Число {a} является квадратом {b}");
}
else
{
    Console.WriteLine($"Число {a} НЕ является квадратом {b}");
}