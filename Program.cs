string[] FillArray(int count)
{
    string[] array = new string[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] Example()
{
    string[] array = new string[4];
    array[0] = "hello";
    array[1] = "2";
    array[2] = "world";
    array[3] = ":-)";
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int inputCount;
string [] inputArray;

Console.WriteLine("Если вы хотите самостоятельно заполнить массив, нажмите 0");
Console.WriteLine("Если нет - нажмите Enter");

if(Console.ReadLine() == String.Empty) 
{
    Console.WriteLine("Пример:");
    inputArray = Example();
    PrintArray(inputArray);
}
else
{
    Console.WriteLine("Введите количество элементов массива:");
    inputCount = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите элементы массива:");
    inputArray = FillArray(inputCount);
}

int resultCount = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3) resultCount += 1;
}
Console.WriteLine();

string[] resultArray = new string[resultCount];
int j = 0; 
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3) 
    {
        resultArray[j] = inputArray[i];
        j++;
    }
}

Console.WriteLine("Элементы с длиной строки в пределах трех символов:");
PrintArray(resultArray); 