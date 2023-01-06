// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PrintArray(int[] array, string[] string1)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse (string1[i]);
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

Console.Write("Введите числа через запятую: ");
string numbers = Console.ReadLine();
string[] newNumbers = new string[numbers.Length];
int j = 0;
for (int i = 0; i < newNumbers.Length; i++)
{
    if (numbers[i] == ',')
    {
        j++;
    }
    else
    {
        newNumbers[j] = newNumbers[j] + numbers[i];
    }
}
j++;
int[] resultNumbers = new int[j];
PrintArray(resultNumbers, newNumbers);
int positiv = 0;
for (int i = 0; i < j; i++)
{
    if (resultNumbers[i] > 0)
    {
        positiv++;
    }
}
Console.WriteLine("Количество чисел больше 0: " + positiv);