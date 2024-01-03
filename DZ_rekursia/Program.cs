    Console.WriteLine("Введите M:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите N:");
    int n = Convert.ToInt32(Console.ReadLine());
    PrintNaturalNumbers(m, n);
    Console.ReadLine();
static void PrintNaturalNumbers(int m, int n)
{
    if (m <= n)
    {
        Console.WriteLine(m);
        PrintNaturalNumbers(m + 1, n);
    }

}