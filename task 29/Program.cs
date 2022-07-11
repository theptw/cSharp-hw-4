// Не понимаю в чём проблема


int[] FillArrRandom(int size)
{
    int[] arr = new int[size];
    
    

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next();
    }
    return arr;
}


void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"[{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] result = FillArrRandom(8);

PrintArr(result);