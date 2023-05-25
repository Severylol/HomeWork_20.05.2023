Console.Clear();
{
Console.Write("Введите любое число, и я вам скажу четное оно или нет: ");
    int number = Convert.ToInt32(Console.ReadLine());
    bool isEven = number % 2 == 0;
if (isEven)
{
Console.WriteLine("Чётное.");
}
else
{
Console.WriteLine("Не чётное.");
}
Console.ReadLine();
}