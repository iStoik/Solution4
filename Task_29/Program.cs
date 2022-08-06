Console.Write("Введите размер массива: ");
string len = Console.ReadLine();

void ExceptionHandling(string enterA)
{
    bool yesInt = int.TryParse(enterA, out int result);

    if (yesInt && result > 0)
    {
        int[] rndNum = new int[result];
        FillArray(rndNum);
        PrintArray(rndNum);
    }
    else
    {
        Console.WriteLine("{0} -> Некорректный ввод!", len);
    }
}

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

void PrintArray(int[] arr)
{
    string str = "[";
    foreach (int i in arr)
    {
        str += $", {i}";
    }
    str = str.Remove(1, 2);
    str += "]";
    Console.Write($"Массив из {arr.Length} элементов: {str}");
}

ExceptionHandling(len);
