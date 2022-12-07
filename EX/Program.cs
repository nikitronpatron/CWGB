// Написать программу, которая из имеющегося 
// массива строк формирует массив из строк
// длина которых меньше либо равна 3.

string[] myArray = {"Hello", "234", "21", "win", "eh", "326", "-2"};

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void ProcessedArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        string temp = array[i];
        if(temp.Length < 4)
        {
            Console.Write($"{temp} ");
        }
    }
}

ShowArray(myArray);
ProcessedArray(myArray);