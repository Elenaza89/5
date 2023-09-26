// Задача 34 Урок 5
Console.WriteLine("Задайте массив, заполненный случайными 3х-значными числами через пробелл. Например: 345 789 542 ");

string? str = Console.ReadLine();
string[] strArr = str.Split(' ');

//Если все числа трехзначные, то находим количество четных чисел
if (CheckArrayByCountNumbers(strArr, out List<int> lst))
{

    Console.WriteLine($"Количество четных чисел = {GetChetnCounts(lst)} ");
}
else 
{
    Console.WriteLine("Не все числа трехзначные");
}

// Подсчет количества четных чисел
int GetChetnCounts(List<int> lst)
{
   int count = lst.Where(x =>  x % 2 == 0 ).ToList().Count;
   return count; 
}

// Проверка на корректность введенных 3х-значных чисел, и возврат массива чисел
bool CheckArrayByCountNumbers(string[] arr, out List<int> lst)
{
    lst = new();
    foreach (var s in arr)
    {
        if (!Int32.TryParse(s, out int number))
        {
            Console.WriteLine($"Было введено не число, а набор символов {s}");            
            return false;
        };
        if (number >= 100 && number < 1000)
        {
            lst.Add(number);
        }
        else
        {
            return false;
        }
    }
    return true; 
    
}
