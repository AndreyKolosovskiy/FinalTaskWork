// Написать программу, которая из имеющегося масива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.  
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []



string[] array1 = new string[5] { "hello", "2", "world", ":-)","5" };
string[] array2 = new string[array1.Length];

void SecondArray(string[] arrayIn, string[] arrayOut)
{
    int count = 0;
    for (int i = 0; i < arrayIn.Length; i++)
    {
        if (arrayIn[i].Length <= 3)
        {
            arrayOut[count] = arrayIn[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(array1, array2);
PrintArray(array2);