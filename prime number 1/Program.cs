class Project1
{


    public static void Main(string[] args)
    {

        // Declare the variables
        int n1, n2, i, j, flag;

        // Ask user to enter n1
        Console.WriteLine("Enter n1: ");
        n1 = int.Parse(Console.ReadLine());

        // Ask user to enter n2
        Console.WriteLine("Enter n2: ");
        n2 = int.Parse(Console.ReadLine());

        // Print display message
        Console.WriteLine($"\nPrime numbers between {n1} and {n2} are: ");


        for (i = n1; i <= n2; i++)
        {
            if (i == 1 || i == 0)
                continue;

            flag = 1;

            for (j = 2; j <= i / 2; ++j)
            {
                if (i % j == 0)
                {
                    flag = 0;

                    break;
                }
            }

            if (flag == 1)
                Console.WriteLine(i);
        }
    }
}
