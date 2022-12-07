using System;

public class Program
{
    public static string Indent(int count)
    {
        return "".PadLeft(count);
    }
    public static void Main()
    {
        Boolean loop = true;
        do
        {
            //user input - ask for amount of people
            Console.WriteLine("How many people are we making PB&J sandwiches for?");
            int people = int.Parse(Console.ReadLine());

            //calculate amount of each ingredient needed assuming 1 sandwich per person - Each sandwich requires 2 slices of bread, 2 tablespoons of peanut butter, and 4 teaspoons of jelly
            //display blank line
            Console.WriteLine(" ");
            Console.WriteLine("You need:");
            Console.WriteLine(" ");
            double totalSlicesNeeded = (2 * people);
            double totalTablespoonsNeeded = (2 * people);
            double totalTeaspoonsNeeded = (4 * people);
            //output how many individual items are needed of each ingredient
            Console.WriteLine(Indent(3) + totalSlicesNeeded + " slices of bread");
            Console.WriteLine(Indent(3) + totalTablespoonsNeeded + " tablespoons of peanut butter");
            Console.WriteLine(Indent(3) + totalTeaspoonsNeeded + " teaspoons of jelly");

            Console.WriteLine(" ");
            Console.WriteLine(Indent(3) + "which is...");
            Console.WriteLine(" ");

            //calculate how many whole items are needed (rounding up) for the following: 1 loaf of bread contains exactly 28 slices, 1 jar of peanut butter contains exactly 32 tablespoons, 1 jar of jelly contains exactly 48 teaspoons
            double slicesPerLoaf = 28;
            double TablespoonsPerJar = 32;
            double TeaspoonsPerJar = 48;
            double totalLoavesNeeded = totalSlicesNeeded / slicesPerLoaf;
            double totalPJarsNeeded = totalTablespoonsNeeded / TablespoonsPerJar;
            double totalJJarsNeeded = totalTeaspoonsNeeded / TeaspoonsPerJar;
            //output how many whole items are needed of each ingredient				  
            Console.WriteLine(Indent(3) + Math.Round(totalLoavesNeeded, MidpointRounding.ToPositiveInfinity) + " loaves of bread");
            Console.WriteLine(Indent(3) + Math.Round(totalPJarsNeeded, MidpointRounding.ToPositiveInfinity) + " jars of peanut butter");
            Console.WriteLine(Indent(3) + Math.Round(totalJJarsNeeded, MidpointRounding.ToPositiveInfinity) + " jars of jelly");

            //user input - ask if they would like to start the program over
            Console.WriteLine(" ");
            Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
            string answer = Console.ReadLine();

            //determine to loop depending on user's answer
            if (answer == "y" || answer == "yes")
            {
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Goodbye!");
                loop = false;
            }
        } while (loop == true);
    }
}