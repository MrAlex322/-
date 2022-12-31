void Print(string[] WriteArray)
{
    int size = WriteArray.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{WriteArray[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] WriteArray = new string[size];
for (int i = 0; i < size; i++)
{
    Console.Write("Введите [{0}] элемент массива = ", i);
    WriteArray[i] = Convert.ToString(Console.ReadLine());
}

string [] MassArray = new string[size];
int count = 0;

for (int j = 0; j < size; j++)
{
    if (WriteArray[j].Length <= 3)
    {
        MassArray[count] = WriteArray[j];
        count++;
    }
}

Console.WriteLine();
Print(MassArray);