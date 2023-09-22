Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine($"Наибольшим числом из {numberA} и {numberB} является {numberA}.");
}
else
{
    Console.WriteLine($"Наибольшим числом из {numberA} и {numberB} является {numberB}.");
}