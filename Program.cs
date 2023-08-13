string[] arrIN = new string[4] {"hello", "2", "world", ":-)"};
string[] arrOUT = new string[arrIN.Length];

void SecondArrayWithIF(string[] arrIN, string[] arrOUT, int limit)
{
    int count = 0;
    for (int i = 0; i < arrIN.Length; i++)
    {
    if(arrIN[i].Length <= limit)
        {
        arrOUT[count] = arrIN[i];
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

SecondArrayWithIF(arrIN, arrOUT, 3);
PrintArray(arrOUT);