/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Введите число: ");
int i = int.Parse(Console.ReadLine() ?? "");
int summ = 0;
while (i > 0)
{
    int num = i % 10;
    i = i / 10;
    summ = summ + num;
}
Console.WriteLine($"Сумма всех цифр в числе равна: {summ}");