// Задача: Написать программу,
// которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.WriteLine("Введите слова через пробел");
string s = Console.ReadLine();
string[] splittedStrings = s.Split(" ");
string[] finalArray;

string FilterString(string[] inputArray)
{
    string filteredString = "";
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            if (i != inputArray.Length - 1)
            {
                filteredString = filteredString + inputArray[i] + " ";
            }
            else
            {
                filteredString = filteredString + inputArray[i];
            }
        }
    }
    return filteredString;
}

finalArray = FilterString(splittedStrings).Split(" ");

foreach (string i in finalArray)
{
    System.Console.WriteLine(i);
}








