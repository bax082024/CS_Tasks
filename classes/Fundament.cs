

public class Fundament : IFundament
{
    public void CheckOddOrEven(double a)
    {
        if (a % 2 == 0)
        {
            Console.WriteLine($"{a} is even");
        }
        else 
        {
            Console.WriteLine($"{a} is odd");
        }

    }

    public string GetAInterestingFact(string fact)
    {
        return $"Interesting fact: {fact}";
    }

    public void SumTwoNumbers(double a, double b)
    {
        double sum = a + b ;
        Console.WriteLine($"The sum of {a} + {b} is {sum}");
    }

    public double SumTwoNumbersOfGivenType(double a, double b)
    {
        return a + b ;
    }


    // Extra challenges

    public void PrintFibonnaciSeries(int n)
    {
        // TODO: Implement the Fibonacci sequence
        int a = 0;
        int b = 1;
        int c;

        if (n > 0)
        {
            Console.WriteLine(a);
        }
        if (n > 1)
        {
            Console.WriteLine(b);
        }

        for (int i = 2; i< n; i++)
        { 
        c = a + b;
        Console.WriteLine(c);
        a = b;
        b = c;
        }
    }

    public string ReverseString(string str)
    {
        // TODO: reverse the given string
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string (charArray);
    }

    public int RecursiveFactorial(int n)
    {
        // Todo: Implement a recursive method(a method that calls itself within its own function scope)
        // To Check the factorial of a number(norsk: Fakultet) we look at n!, where n = n * 1 * 2 * 3...
        if (n <= 1)
        {
            return 1;
        }
        return n;
    }


}
