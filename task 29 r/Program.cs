
int[] FillArrRandom(int size)
{
    int[] arr = new int[size];
    int index = 0;

    Random rnd = new Random();
    while (index < arr.Length)
    {
        arr[index] = rnd.Next();
        index++;
    }
    return arr;
}

void PrintArr(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"[{arr[i]}");
    }
    Console.Write("]");
}


int[] result = FillArrRandom(8);
PrintArr(result);
