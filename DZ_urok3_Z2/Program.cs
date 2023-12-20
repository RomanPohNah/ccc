int[] array = {15, 8, 3, 17, 6,34, 42, 46, 22, 91};

int evenCount = 0;

for(int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        evenCount++;
    }
}
Console.WriteLine(evenCount);