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
            if((dice1 == dice2) && (dice1 == dice3)){
                bonus += 6;
            }
            else{
                bonus += 2;
            }
        }
        int total = dice1 + dice2 + dice3 + bonus;

        if(total >= win)
        {
            System.Console.WriteLine($"You WON! With {total} points.");
            System.Console.WriteLine($"First Dice: {dice1}\nSecond Dice: {dice2}\nThird Dice: {dice3}\nBonus for equal dices: {bonus}");
        }else
        {
            System.Console.WriteLine($"You lost... with {total} points.");
            System.Console.WriteLine($"First Dice: {dice1}\nSecond Dice: {dice2}\nThird Dice: {dice3}\nBonus for equal dices: {bonus}");
        }
    }

    public static void MockSubscriptionExpire()
    {
        Random expirationDate = new Random();
        int daysUntilExpiration = expirationDate.Next(12);
        int discountPercentage = 0;

        if(daysUntilExpiration <= 10){
            System.Console.WriteLine($"Your subscription will expire in {expirationDate} days! Renew now!");
        }else if(daysUntilExpiration <= 5){
            System.Console.WriteLine($"Your subscription will expire in {expirationDate} days!");
            discountPercentage = 10;
        }else if(daysUntilExpiration == 1){
            System.Console.WriteLine("Your subscription will expire in a day!");
            discountPercentage = 20;
        }
        else if(daysUntilExpiration > 10){}
        else{
            System.Console.WriteLine("Your subscription has expired.");
        }
        if(discountPercentage > 0)
        {
            System.Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }
    }

    public static void MockFraudulentOrders()
    {
        string[] fraudulentOrderIDs = ["B123", "B456", "C789", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
        //the array can also be initialized withou values, as in
        //string[] frauds = new string[3];
        fraudulentOrderIDs[2] = "F000";//reassigning
        int numID = 0;
        foreach(string ID in fraudulentOrderIDs)
        {
            if (fraudulentOrderIDs[numID].StartsWith('B'))
            {
                System.Console.WriteLine($"Fraudulent order detected at position: {numID} - with ID = {ID}");
            }
            numID++;
        }
    }
}