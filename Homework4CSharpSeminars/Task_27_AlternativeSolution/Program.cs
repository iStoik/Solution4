try
{
    Console.Write("Введите целое число: ");
    int numbers = int.Parse(Console.ReadLine());

    int SumNumbersInNumber(int number)
    {
        int sum = 0;
        int resNum = GetCountNumbers(number);
        for (int i = 0; i < resNum; i++)
        {
            sum = sum + (number % 10);
            number = number / 10;
        }
        return sum;
    }

    int GetCountNumbers(int num)
    {
        int count = 0;
        while (num != 0)
        {
            num = num / 10;
            count++;
        }
        return count;
    }

    int sumResult = SumNumbersInNumber(numbers);
    Console.WriteLine("Сумма цифр числа {0} = {1}", numbers, sumResult);
}
catch
{
    Console.WriteLine("Некорректный ввод!");
}
