using System;
public class NumberMethods
{
    public static int NumMethods(int num1, int num2)
    {
        /*int number1 = 2100000000;//maximum allowed integer
        int number2 = number1 * 2;//results in an overflow, as the result would be bigger than the maximum allowed int
        long number3 = number1 *2;//still overflows, because the operation is done in an Integer, and the bad result is being stored in a Long variable
        long number4 = (long)number1 * 2;//casting the new data type is one way to fix it 
        long number5 = checked(number1 *2);//the "checked" will run the code, and instead of overflowing it
        //will throw an explanatory exception, which is very useful for debugging if something went wrong
        double a = 43.2;//natural type, the most used in a variety of cases
        float b = 23.4;//throws a warning because float should be used for cases where extreme precision matters
        decimal c = 45.6;//decimal has a smaller range than double, but is also much more precise

        Logic Operators works the same as other languages:
        && AND
        || OR
        ! NEGATION
        != DIFFERENT THAN
        == EQUAL TO
        === STRICTLY EQUAL TO
        */
        if ((num1 + num2) < 0)
        {
            System.Console.WriteLine("Negative number.");
        }
        int result = num1 + num2;
        return result;
    }

    public static void WhileLoop(double num)
    {
        int counter = 0;
        while (counter <= num)
        {
            System.Console.WriteLine(counter);
            counter++;
        }

        do
        {
            System.Console.WriteLine("This is a Do-While loop.");
            System.Console.WriteLine(counter);
        } while (counter < 0);
    }

    public static void ForLoop(double num)
    {
        for (int i = 0; i < num; i++)
        {
            System.Console.WriteLine(i);
        }
    }

    public static void NumArray(double num)
    {
        var salaries = new double[]{0.650, 2.200, 1.600};
        salaries = salaries.Append(num).ToArray();
        foreach (var salary in salaries)
        {
            System.Console.WriteLine($"The salary is: {salary:0.000}");
        }
    /*When formatting numbers to output, you can add several types of formatting such as:
    {number:F3} will set the number to a fixed 3 decimals, regardless of the original value
    {number:N3} will add 3 decimals but also a period to indicate it's in the thousands, so 1250.0 becomes 1.250,000
    {number:0.000} the number will be sent in the pre-formatted setting, regardless of the original value. So 1 become 1.000
    */
    }

    public static void DiceRoll(int num = 0)
    {
        Random dice = new();
        int roll = dice.Next(1, 7);
        System.Console.WriteLine("Dice: " + roll);
    }

    public static void LargerValue(int num = 0)
    {
        int firstNum = 500;
        int secondNum = 600;
        int largerValue = Math.Max(firstNum, secondNum);
        int smallerValue = Math.Min(firstNum, secondNum);
        System.Console.WriteLine("Smaller: " + smallerValue);
        System.Console.WriteLine("Larger: " + largerValue);
    }

    public static void CoinFlip()
    {
        Random coin = new();
        int flip = coin.Next(0,2);
        System.Console.WriteLine((flip == 0) ? "heads" : "tails");
    }

}
