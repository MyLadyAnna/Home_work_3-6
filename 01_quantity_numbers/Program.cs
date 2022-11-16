// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Введите количество чисел: ");
int quantity = int.Parse(Console.ReadLine() ?? "0");
int[] massive = new int[quantity];

void GetArrayOfNumbers(int quantity)           // ф-ция представляет введенные числа массивом
{
    for (int i = 0; i < quantity; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        massive[i] = int.Parse(Console.ReadLine() ?? "0");
    }
}

int CountingTheQuantityNumb(int[] array)            // подсчет кол-ва чисел > 0
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

GetArrayOfNumbers(quantity);
Console.WriteLine(CountingTheQuantityNumb(massive));