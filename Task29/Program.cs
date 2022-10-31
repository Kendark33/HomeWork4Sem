/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
ввод элеменетов через консоль (через запятую. использовать метод string.Split()) */
Console.WriteLine("Введите числа через запятую");
string number = Console.ReadLine() ?? "";
string[] numberArray = number.Split(',');

int[] massArray = new int[numberArray.Length];

for (int i = 0; i < numberArray.Length; i++)
{
    massArray[i] = int.Parse(numberArray[i]);
}
Console.WriteLine("Результат: ");
for (int i = 0; i < massArray.Length; i++)
{
    if (i < massArray.Length - 1)
        Console.Write($"{massArray[i]}, ");
    else
        Console.Write($"{massArray[i]}");
}