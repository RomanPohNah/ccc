int[,] array = {
    {3,5,6},
    {9,6,7},
    {3,7,2}
};
Console.WriteLine("ввод");
PrintArray(array);
SwapRows(array, 0, array.GetLength(0) - 1);
Console.WriteLine("после обмена");
PrintArray(array);
void SwapRows(int[,] array, int row1, int row2)
{
    int cols = array.GetLength(1);
    for (int i = 0; i < cols; i++)
    {
        int temp = array[row1, i];
        array[row1, i] = array[row2, i];
        array[row2, i] = temp;
    }
}
void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int J = 0; J < cols; J++)
        Console.WriteLine(array[i,J] + " ");
    }
    Console.WriteLine();
}