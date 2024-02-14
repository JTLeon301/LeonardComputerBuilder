using static System.Console;
namespace ComputerBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Name: Jaiden Leonard
             * Class: .NET Programming
             * Date: February 13th, 2024
             * 
             * Program:
             * This program aims to let the user enter the components that they would like in their PC (processor, 
             * graphics card, ram size, and storage size) and gives the user back what they entered and also the
             * total cost of the PC based on average market pices for each component.
             * 
             * Struggles:
             * None really, the walkthrough in class made this assignment pretty simple.
             * 
             * NOTE:
             * If you notice anything I could improve on or change, feel free to leave a comment on the assignment
             * grading page. All feedback positive or negative is welcomed. Thank you!
             */

            //print application header
            WriteLine("*************************************");
            WriteLine("       Computer Builder V1.0");
            WriteLine("*************************************");

            //initialize variables
            string again;

            //do while loop to run the program
            do
            {
                WriteLine("\nWhat does your dream PC entail?");

                //ask the user what processor they want
                Write("What processor would you like?: ");
                string processorType = ReadLine();

                //ask the user what graphics card they want
                Write("What graphics card would you like?: ");
                string graphicsCard = ReadLine();

                //ask the user how many GBs of RAM they want
                Write("How many GB of RAM would you like?: ");
                double ramSize = double.Parse(ReadLine());

                //ask the user how many GBs of storage they want
                Write("How many GB of storage would you like?: ");
                double storageSize = double.Parse(ReadLine());

                Computer dreamBuild = new Computer(processorType, graphicsCard, ramSize, storageSize);

                //print the PC's specs to the user
                WriteLine("\nHere's what your dream PC's specs look like!");
                WriteLine(dreamBuild);

                //print the total cost of the build to the user
                WriteLine($"\nTotal build cost: {dreamBuild.CalculateCost():C}");

                //ask the user if they want to build another PC
                Write("Would you like to build another computer? (y/n): ");
                again = ReadLine().Trim().ToLower();
            } while (again == "y");

            //program termination message
            WriteLine("\nThank you for using ComputerBuilder!");
        }
    }
}
