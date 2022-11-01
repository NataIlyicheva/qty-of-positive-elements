// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2    1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через запятую");
string str = Console.ReadLine()!;
string[] array = str.Split(",");

int[] resultArray = new int[array.Length];
for (int i = 0; i < resultArray.Length; i++) 
resultArray[i] = int.Parse(array[i]);

int CountValLargerThanZero(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > 0)
        counter++;
        return counter;
}
int quantity = CountValLargerThanZero(resultArray);
Console.WriteLine($"Количество чисел больше 0: {quantity}");