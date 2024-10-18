public class Fundament : IFundament
{
    public void CheckOddOrEven(double a)
    {
        throw new NotImplementedException();
    }

    public string GetAInterestingFact(string fact)
    {
        throw new NotImplementedException();
    }

    public void SumTwoNumbers()
    {
        throw new NotImplementedException();
    }

    public double SumTwoNumbersOfGivenType(double a, double b)
    {
        throw new NotImplementedException();
    }


    // Extra challenges

    public void PrintFibonnaciSeries()
    {
        // TODO: Implement the Fibonacci sequence
        int a = 0;
        int b = 1;
        int c;

        
        c = a + b;
        a = b;
        b = c;
        
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
