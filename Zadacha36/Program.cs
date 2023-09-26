using System.Diagnostics.CodeAnalysis;

//Задача 36 Урок 5
Console.WriteLine(" Задать одномерный массив, заполнены   случайными числами . Задать через пробелл. Найти сумму чисел на нечетных позициях.");
string? str = Console.ReadLine();
string[] strArr = str.Split(' ');

if (CheckArrayByNumbers(strArr, out List<int> lst))
{
    int sum = 0;
    for (int i = 0; i < lst.Count; i++)
    {
        if (i % 2 != 0)
        {
            sum += lst[i];
        }
    }
    Console.WriteLine($" Сумма чисел на нечетных позициях=  {sum}");
}

// Проверка на корректность введенных 3х-значных чисел, и возврат массива чисел
bool CheckArrayByNumbers(string[] arr, out List<int> lst)
{
    lst = new();
    foreach (var s in arr)
    {
        if (!Int32.TryParse(s, out int number))
        {
            Console.WriteLine($"Было введено не число, а набор символов {s}");

            return false;
        };
        lst.Add(number);
    }
    return true;
}