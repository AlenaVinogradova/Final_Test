
string[] inputArray = new string[5];

inputArray[0] = "wow";
inputArray[1] = "2";
inputArray[2] = "set";
inputArray[3] = "?";
inputArray[4] = "90";

void PrintArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

PrintArray(inputArray);

int count = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length < 3) count += 1;
}
Console.WriteLine(count);

string[] resultArray = new string[count];
int j = 0; 
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length < 3) 
    {
        resultArray[j] = inputArray[i];
        j++;
    }
}

PrintArray(resultArray);