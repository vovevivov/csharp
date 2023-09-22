Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB & numberA > numberC)
{
    Console.WriteLine($"Наибольшим числом из {numberA}, {numberB} и {numberC} является {numberA}.");
}
else if (numberB > numberA & numberB > numberC)
{
    Console.WriteLine($"Наибольшим числом из {numberA}, {numberB} и {numberC} является {numberB}.");
}
else
{
    Console.WriteLine($"Наибольшим числом из {numberA}, {numberB} и {numberC} является {numberC}.");
}