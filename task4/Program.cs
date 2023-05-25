Console.Clear();
{
Console.Write("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
    int c = Convert.ToInt32(Console.ReadLine());
    int max = Math.Max(a, Math.Max(b, c));

Console.WriteLine("Максимальное число: " + max);
Console.ReadLine();
}