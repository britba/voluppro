using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of integers
        List<int> numbers = new List<int>();
        
        // Add some numbers to the list
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        
        // Iterate through the list and print each number
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
