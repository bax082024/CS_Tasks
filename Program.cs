


namespace CS_Tests;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Greeting class
        Greetings greetings = new Greetings();
        // English greeting
        greetings.SayHello();
        // Japanese greeting
        greetings.YoiTsuitachi();

        Fundament fundament = new Fundament();

        fundament.SumTwoNumbers(5.5, 10.2);
        double result = fundament.SumTwoNumbersOfGivenType(7.5, 2.3);
        Console.WriteLine($"The result of SumTwoNumbersOfGivenType is: {result}");

        fundament.CheckOddOrEven(7);

        string fact = fundament.GetAInterestingFact("Bergen is surrounded by 7 mountains! and we dont like things like javascript!")


    }
}
