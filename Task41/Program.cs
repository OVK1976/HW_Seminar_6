/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Какое количество чисел Вы хотите ввести?: ");
int m = int.Parse(Console.ReadLine());
int[] array = CreateArray(m);
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i + 1} число: ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine($"Ввод завершен");

Console.WriteLine($"Введены значения: {ArrayToString(array)} ");
Console.WriteLine($"Количество чисел больше 0: {CountPozitivNamber(array)} ед.");

#region Вывод на печать
string ArrayToString(int[] array)
{
    string result = "[";

    foreach (int item in array)
    {
        result += $"{item}, ";
    }

    result.Trim(',');
    result += "]";

    return result;
}
#endregion


#region Создание массива чисел
int[] CreateArray(int size)
{
    int[] array = new int[size];
    return array;
}
#endregion

#region Подсчет значений больше 0
int CountPozitivNamber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) count++;
    }
    return count;
}
#endregion

