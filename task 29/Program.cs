//Напишите программу, которая задаёт массив из 8 элементов,
// заполненный псевдослучайными числами и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]



int[] FillArrRandom(int size)
{
    int[] arr = new int[size];
    
    

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,100);
    }
    return arr;
}


void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) Console.Write($"{arr[i]}");
        else
        Console.Write($"{arr[i]},");
    }
    Console.Write("]");
}

int[] result = FillArrRandom(8);

PrintArr(result);