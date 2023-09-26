
// Задача 38

Console.WriteLine(" Задать одномерный массив, заполнены   случайными числами . Задать через пробелл. Найти сумму чисел на нечетных позициях.");
string? str = Console.ReadLine();
string[] strArr = str.Split(' ');

if (CheckArrayByNumbers(strArr, out List<float> lst))
{    
    float delta2 = lst.Max() - lst.Min();

    float delta = GetMax(lst) - GetMin(lst);

    Console.WriteLine($" Разница между максимальным и минимальным элементом =  {delta}   LINQ = {delta2}");
}

float GetMin(List<float> lst)
{
    float min = lst[0];
    for (int i = 1; i < lst.Count; i++)
    {
        if (min > lst[i])
            min = lst[i];
    }
    return min;
    
}

float GetMax(List<float> lst)
{
    float max = lst[0];
    for (int i = 1; i < lst.Count; i++)
    {
        if (max < lst[i])
            max = lst[i];
    }
    return max;

}

// Проверка на корректность введенных вещественых чисел, и возврат массива чисел
bool CheckArrayByNumbers(string[] arr, out List<float> lst)
{
    lst = new();
    foreach (var s in arr)
    {
        float number = 0;
        try
        {
            number = float.Parse(s);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Было введено не число, а набор символов {s} ");
            Console.WriteLine($"Возникло исключение {ex.Message} ");

            return false;
        }                       
        
        lst.Add(number);
    }
    return true;
}

