// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите массив слов или символов, разделяя элементы массива между собой пробелами: ");
string[] array = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"[{string.Join(", ", array)}]");

string[] newArray = GetNewArray(array);

Console.WriteLine($" -> [{string.Join(", ", newArray)}]");

string[] GetNewArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int size = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[size] = array[i];
            size++;
        }
    }
    return newArray;
}