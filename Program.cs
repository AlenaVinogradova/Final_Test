
string[] aarf = new string[5];

aarf[0] = "wow";
aarf[1] = "2";
aarf[2] = "set";
aarf[3] = "?";
aarf[4] = "90";

void PrintArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

PrintArray(aarf);