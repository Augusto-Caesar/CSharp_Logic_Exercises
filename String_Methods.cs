/*Console.WriteLine("Hello, Augusto!");

string firstName = "           Augusto";
firstName = firstName.TrimStart(); //removes empty spaces at the start of the string
string middleName = "Cesar         ";
middleName = middleName.TrimEnd(); //removes empty spaces at the end of the string
string lastName = "        Silva         ";
lastName = lastName.Trim(); //removes empty spaces on both ends
System.Console.WriteLine($"My full name is: {firstName} {middleName} {lastName}");

string firstLanguage = "Angular";
string secondLanguage = "Nest.js";
string thirdLanguage = "JAVA";
string programmingLanguages = $"I'm currently learning {firstLanguage} and {secondLanguage}";
//System.Console.WriteLine(programmingLanguages.Replace("Angular", "C#")); //this usage of the method will return an equivalent string
//without actually overwriting the variable, useful for debugging
//if you want to rewrite the variable, simply assign the replace method directly to the variable, instead of a Console.Write
programmingLanguages = programmingLanguages.Replace("Angular", "C#");
programmingLanguages = programmingLanguages.Replace("Nest.js", "ASP.NET-Core");
System.Console.WriteLine(programmingLanguages);//note that this only replaced the variables inside the programmingLanguages string
//System.Console.WriteLine("I'm unchanged: " + firstLanguage);

//the following method is useful for verifying the contents of a string, the output is a boolean
System.Console.WriteLine(programmingLanguages.Contains("C#"));
System.Console.WriteLine(secondLanguage.ToUpper());//this method makes all the letters in uppercase, doesn't change the variable unless explicitly called
System.Console.WriteLine(thirdLanguage.ToLower());//same as above, but lowercase
System.Console.WriteLine(programmingLanguages.Length);//simply outputs the length of the variable
System.Console.WriteLine(firstLanguage.StartsWith("J"));//checks the beginning of a string to see if the start matches the parameter
System.Console.WriteLine(firstLanguage.EndsWith("r"));//checks the End of a string to see if the end matches the parameter

A verbatim string literal will keep all whitespace and characters without the need to escape the backslash. 
To create a verbatim string, use the @ directive before the literal string.
Console.Write(@"C:\source\repos\     this is my repository folder!"); //this will output exactly what was typed, without any errors.
*/

public class Strings
{
    public static void StringMethods(string word)
    {   /*
        System.Console.WriteLine(word.ToUpper());
        System.Console.WriteLine(word.ToLower());
        
        var names = new List<string>{"Taynara", "Augusto", "Ayla"};
        names.Add(word);
        names.Sort();
        
        foreach (var name in names)//you can also use an interval like (name in names[2..4])
        {
            System.Console.WriteLine($"Family Member: {name}");
            //System.Console.WriteLine(names[^1]);//this operand [^number] will get a number from the back of the list
            //if it's [^3] it's the third from the back
        }
        */
    }

}