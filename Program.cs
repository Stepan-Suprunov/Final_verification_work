void PrintArray(string[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
    Console.WriteLine();
}

string[] array = { "Final", "verification", "vork", ":-)" };

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) count++;
}

string[] newArray = new string[count];
int countNew = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j].Length <= 3)
    {
        newArray[countNew] = array[j];
        countNew++;
    }
}

PrintArray(array);
Console.WriteLine("----------");
PrintArray(newArray);