internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 0 || age > 110)
                Console.WriteLine("Invalid age");
            else
                Console.WriteLine($"Hello, {name}. You will be {age + 5} in 5 years");

            String stage = "";
            if (age < 13)
                stage = "child";
            else if (age < 20)
                stage = "teenager";
            else
                stage = "adult";


            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Negative");
            }
            else if (number == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Positive");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            throw;
        }

        Console.WriteLine("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        if (year < 0)
        {
            Console.WriteLine("Invalid year");
        }
        else if (year % 4 == 0 && year % 100 != 0)
        {
            Console.WriteLine("Leap year");
        }
        else
        {
            Console.WriteLine("Not a leap year");
        }

        Console.WriteLine("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}