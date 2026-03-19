public class LinqMethods
{   
    public static void LinqNumbers()
    {
        List<int> scores = [97, 92, 81, 60, 65];
        // IEnumerable<int> scoresQuery =
        //     from score in scores
        //     where score > 80 && score < 95
        //     orderby score ascending
        //     select score;
        //below is the same code as above, but with a Lambda query (arrow function in JS or ternary operators)

        var scoresQuery = scores.Where(s => s > 80 && s < 95).OrderBy(s => s); //it's so simple even the Select is implied

        //System.Console.WriteLine(scoresQuery.Count());//shows the number of occurences
        List<int> highScores = scoresQuery.ToList();//stores the query results into a list of same Type
        foreach (var i in scoresQuery)
        {
           System.Console.WriteLine(i);
        }
    }
    public static void LinqStrings()
    {
        List<string> cars = ["Voyage", "March", "Celta", "Sentra", "Civic", "Corolla", "Chevette", "Pampa", "Prisma"];
        /*IEnumerable<string> carsQuery =
            from car in cars
            where car.StartsWith("C")
            orderby car ascending
            select $"This is the car you want: {car}";
        */
        var carsQuery = cars.Where(car => car.StartsWith("C")).OrderBy(car => car);
        List<string> carsStartsWithC = carsQuery.ToList();//a list of cars that only starts with C
        foreach (var i in carsStartsWithC)
        {
           System.Console.WriteLine(i);
        }
    }
}
