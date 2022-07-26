string[] array = {"Final", "verification", "vork", ":-)"};

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

int count = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j].Length <= 3) count++;
}

string[] newArray = new string[count];
int countNew = 0;
for (int k = 0; k < array.Length; k++)
{
    if(array[k].Length <= 3)
    {
        newArray[countNew] = array[k];
        countNew++;
    }
}