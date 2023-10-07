namespace Final;

class Program
{
    static void Main(string[] args)
    {
        MainManu();
    }
    private static bool MainManu()
    {
        Console.Clear();
        Console.WriteLine("1) Natural Numbers;");
        Console.WriteLine("2) Natural Numbers 2;");
        Console.WriteLine("3) Ackerman function;");
        Console.WriteLine("4) Exit.");
        Console.Write("\nSelect: ");
        switch (Console.ReadLine())
        {
            case "1":
                Console.Clear();
                Console.Write("Enter the first number: ");
                int firstNumb = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int secondNumb = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write($"{firstNumb}; {secondNumb}/ => '");
                for (int i = firstNumb; i <= secondNumb; i++)
                {
                    if (i == secondNumb) Console.Write($"{i}.'");
                    else
                    {
                        Console.Write($"{i}, ");
                    }
                }
                return true;
            case "2":
                Console.Write("Enter the first number: ");
                firstNumb = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                secondNumb = int.Parse(Console.ReadLine());
                int res = 0;
                Console.WriteLine();
                Console.Write($"{firstNumb}; {secondNumb} => ");
                for (int i = firstNumb; i <= secondNumb; i++)
                {
                    res += i;
                }
                Console.Write($"{res}");
                return true;
            case "3":
                Console.Write("Enter the first number: ");
                firstNumb = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                secondNumb = int.Parse(Console.ReadLine());
                Console.WriteLine($"{firstNumb}, {secondNumb} -> {Ackerman(firstNumb, secondNumb)}");
                return true;
            case "4":
                return false;
            default:
                return false;
        }
    }
    private static int Ackerman(int n, int m)
    {
        if (n == 0)
            return m + 1;
        else
          if ((n != 0) && (m == 0))
            return Ackerman(n - 1, 1);
        else
            return Ackerman(n - 1, Ackerman(n, m - 1));
    }
}
