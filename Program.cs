void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void SortingArray(string[] array)
{

    string[] Newarray = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Newarray[i] = array[i];
            Console.Write(Newarray[i] + " ");
        }
    }
}

string[] Myarray = new string[] { "Hi", "city", "old", "24", "mouse", "friend" };

ShowArray(Myarray);

Console.Write("--> ");

SortingArray(Myarray);