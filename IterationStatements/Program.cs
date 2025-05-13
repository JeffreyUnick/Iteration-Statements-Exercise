using System.Threading.Channels;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        static void PrintNumbers()
        {
            Console.Write("Here are all the numbers from 1000 to -1000 : ");
            for (int num = 1000; num <= 1000 && num >= -1000 ; num--)
            {
                Console.WriteLine(num);
            }
            
        }
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()

        static void PrintThirdNumbers()
        {
            Console.Write("Here are all the third numbers from 3 to 999 : ");
            for (int numer = 3; numer <= 999; numer += 3)
            {
                Console.WriteLine(numer);
            }
        }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        static bool AreNumbersEqual(int a, int b)
        {
            if (a == b) return true;
            else return false;
        }
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        static bool IsEven(int number)
        {
            if (number % 2 == 0) return true; 
            else return false;
        }
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        static bool IsPositive(int num)
        {
           if (num > 0) return true;
           else return false;
        }
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.

        static bool CanVote(int age)
        {
            if (age >= 18 )
            {
                return true;
            }
            else return false;
        }
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        static bool IsInrange(int number)
        {
            return number >= -10 && number <= 10;
        }
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        static void DisplayMultiplicationTable (int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {number} = {number * i}");
            }
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            PrintNumbers();
            
            PrintThirdNumbers();
            
            AreNumbersEqual(10, 20);
            Console.WriteLine($"The answer is: {AreNumbersEqual(10, 20)}");
            
            IsEven(10);
            Console.WriteLine($"The answer is: {IsEven(10)}");
            
            IsPositive(10);
            Console.WriteLine($"The answer is: {IsPositive(10)}");
            
            CanVote(10);
            Console.WriteLine($"The answer is: {CanVote(10)}");

            Console.WriteLine("Give me a number :");
            var input = Console.ReadLine();
            bool valid;
            if (int.TryParse(input, out int number))
            {
                Console.WriteLine(IsInrange(number) ? $"Yes {number} is in range" : $"No {number} is not in range");
            }
            else
                Console.WriteLine($"Invalid input: {input} is not a number");
            
            DisplayMultiplicationTable(10);
        }
    }
}
