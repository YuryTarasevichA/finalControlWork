// string [] array = new string[] {"string1", "string2", "string3"};

void PrintArrStr(string [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
void PrintNewArray(string [] arr)
{
    Console.Write("[");
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 2)
        {
            if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
            else Console.Write($"{arr[i]}");
            count++;
        }
    }
    Console.Write("]");
   
}
Console.WriteLine("Введите строки через пробел: ");
string input = Console.ReadLine();
string [] array = input.Split(' ');
PrintArrStr(array);
Console.WriteLine();
PrintNewArray(array);

