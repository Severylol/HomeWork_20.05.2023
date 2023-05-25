Console.Clear();
{
Console.Write("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int max = Math.Max(a, b);
        int min = Math.Min(a, b);

Console.WriteLine("Максимальное число: " + max);
Console.WriteLine("Минимальное число: " + min);
Console.ReadLine();
}