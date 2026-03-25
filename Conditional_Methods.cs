public class ConditionalMethods
{
    public static void IfElseGame()
    {   
        Random roll = new Random();
        int dice1 = roll.Next(1, 7);
        int dice2 = roll.Next(1, 7);
        int dice3 = roll.Next(1, 7);
        int win = 15;
        int bonus = 0;

        if((dice1 == dice2) || (dice2 == dice3) || (dice1 == dice3))
        {
            bonus += 2;
        }else if((dice1 == dice2) && (dice1 == dice3))
        {
            bonus += 6;
        }
        int total = dice1 + dice2 + dice3 + bonus;

        if(total < win)
        {   
            System.Console.WriteLine($"You lost... with {total} points.");
            System.Console.WriteLine($"First Dice: {dice1}");
            System.Console.WriteLine($"Second Dice: {dice2}");
            System.Console.WriteLine($"Third Dice: {dice3}");
            System.Console.WriteLine($"Bonus for equal dices: {bonus}");
        }else if(total >= win)
        {
            System.Console.WriteLine($"You WON! With {total} points.");
            System.Console.WriteLine($"First Dice: {dice1}");
            System.Console.WriteLine($"Second Dice: {dice2}");
            System.Console.WriteLine($"Third Dice: {dice3}");
            System.Console.WriteLine($"Bonus for equal dices: {bonus}");
        }
    }
}