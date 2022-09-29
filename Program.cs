void ArrayFilling(string[] arraysub)
{
    for (int i = 0; i < arraysub.GetLength(0); i++)
    {
        Console.Write($" input element of array with index {i} ");
        arraysub[i] = (Console.ReadLine());
    }
}


void ArrayShowing(string[] arraysub)
{
    Console.Write("[");
    for (int i = 0; i < arraysub.GetLength(0) - 1; i++)
    {
        Console.Write($"{arraysub[i]}, ");
    }
    Console.WriteLine($"{arraysub[arraysub.GetLength(0) - 1]}]");
}

int NumberOfShortStrings(string[] arraysub)
{
    int number = 0;
    for (int i = 0; i < arraysub.GetLength(0); i++)
    {
        if (arraysub[i].Length < 4)
        {
            number++;
        }
    }
    return number;
}

void NewArrayOfShortsFilling(string[] arraysub, string[] newarraysub)
{
    int j = 0;
    for (int i = 0; i < arraysub.GetLength(0); i++)
    {
        if (arraysub[i].Length < 4)
        {
            newarraysub[j] = arraysub[i];
            j++;
        }
    }
}

Console.Write(" input size of array ");
int size = Convert.ToInt32(Console.ReadLine());
string[] OriginArray = new string[size];
ArrayFilling(OriginArray);
if (NumberOfShortStrings(OriginArray) > 0)
{
    string[] NewArray = new string[NumberOfShortStrings(OriginArray)];
    NewArrayOfShortsFilling(OriginArray, NewArray);
    ArrayShowing(OriginArray);
    ArrayShowing(NewArray);
}
else
{
    ArrayShowing(OriginArray);
    Console.Write("[]");
}
