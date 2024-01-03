int[] Array = { 1, 2, 3, 4, 5, 6, 7 };
Console.WriteLine(" массив в обратном порядке:");
PrintArrayReverse(Array, Array.Length - 1);
Console.ReadLine();

static void PrintArrayReverse(int[] array, int index)
{
    if (index >= 0)
    {
        Console.WriteLine(array[index]);
        PrintArrayReverse(array, index - 1);
    }
}
