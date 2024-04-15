using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // Objective: Iterate through a character array. Try to parse each character into an integer.
            // If you attempt to parse a letter into an integer, an exception will occur. 
            // Use a try-catch statement to avoid a run-time exception.
            // Below we will set this up.
            // ------------------------------------------------------------------------------



            
            char[] arr = new[] { '2', '3', '4', '5', '6', '7', 'a', 'b', 'c' };

            
            var numbers = new List<int>();
            
            string str;
            
            foreach(char character in arr) 
            { 
                try 
                {
                    str = character.ToString();
                    int i = int.Parse(str);
                    numbers.Add(i);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unable to Parse '{character}'");
                }
            }
                
                    
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
