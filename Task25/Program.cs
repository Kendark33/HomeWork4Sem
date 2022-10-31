/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
 */

Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine(("Введите натуральную степень "));
int b = int.Parse(Console.ReadLine() ?? "");
int CycleNumber(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
        result = result * a;
    {
        /*  int result = Math.Pow(a, b);  Не могу понять почему не могу использовать данный метод */
    }
    return result;
}
int ExitNumber = CycleNumber(a, b);
Console.WriteLine($"Число {ExitNumber} является {a} в степени {b}");
