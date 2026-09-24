using System;

namespace Assignment1
{
    // Class used for Question 6 (Reference Type Example)
    internal class Person
    {
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // =========================================================================
            // Question 1: Write a program that allows the user to enter a number then print it.
            // =========================================================================
            Console.WriteLine("----- Question 1 -----");
            Console.Write("Enter a number: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("You entered: " + input1);

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 2: Convert a string to an integer, but the string contains non-numeric characters.
            // What will happen: System.FormatException will be thrown at runtime.
            // =========================================================================
            Console.WriteLine("----- Question 2 -----");
            try
            {
                string text = "123abc";
                int number = Convert.ToInt32(text);
                Console.WriteLine("Number: " + number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Output/Exception: " + ex.GetType().Name + " - " + ex.Message);
                Console.WriteLine("Explanation: Converting non-numeric string to integer throws FormatException.");
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 3: Perform a simple arithmetic operation with floating-point numbers.
            // What will happen: Floating point precision behavior in double values.
            // =========================================================================
            Console.WriteLine("----- Question 3 -----");
            double a = 5.5;
            double b = 2.1;
            double sum = a + b;
            double sub = a - b;
            double mul = a * b;
            double div = a / b;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + sub);
            Console.WriteLine("Product: " + mul);
            Console.WriteLine("Division: " + div);

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 4: Extract a substring from a given string.
            // =========================================================================
            Console.WriteLine("----- Question 4 -----");
            string message = "Hello World";
            // Substring(startIndex, length)
            string subStr = message.Substring(0, 5);
            Console.WriteLine("Original String: " + message);
            Console.WriteLine("Extracted Substring: " + subStr);

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 5: Assigning one value type variable to another and modifying the value.
            // What will happen: Modifying y does NOT affect x because value types are copied by value on Stack.
            // =========================================================================
            Console.WriteLine("----- Question 5 -----");
            int x = 10;
            int y = x; // Copying value
            y = 20;    // Modifying y

            Console.WriteLine("x = " + x); // x remains 10
            Console.WriteLine("y = " + y); // y becomes 20
            Console.WriteLine("Explanation: Value types are stored on Stack and independent copies are created.");

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 6: Assigning one reference type variable to another and modifying the object.
            // What will happen: Modifying p2 affects p1 because both variables point to the same Heap object.
            // =========================================================================
            Console.WriteLine("----- Question 6 -----");
            Person p1 = new Person();
            p1.Name = "Ahmed";

            Person p2 = p1; // Copying reference pointer
            p2.Name = "Mohamed"; // Modifying through p2

            Console.WriteLine("p1 Name: " + p1.Name); // Outputs Mohamed
            Console.WriteLine("p2 Name: " + p2.Name); // Outputs Mohamed
            Console.WriteLine("Explanation: Reference types point to the same object on Heap.");

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 7: Take two string variables and print them as one variable.
            // =========================================================================
            Console.WriteLine("----- Question 7 -----");
            string str1 = "Hello";
            string str2 = "World";
            string combined = str1 + " " + str2;
            Console.WriteLine("Combined String: " + combined);

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 8: MCQ - Code: int d = Convert.ToInt32(!(30 < 20));
            // =========================================================================
            Console.WriteLine("----- Question 8 -----");
            int d = Convert.ToInt32(!(30 < 20));
            Console.WriteLine("Output Value of d: " + d);
            Console.WriteLine("Correct Choice: A value 1 will be assigned to d.");
            Console.WriteLine("Reason: (30 < 20) is false, !false is true, Convert.ToInt32(true) is 1.");

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 9: MCQ - Code: Console.WriteLine(13 / 2 + " " + 13 % 2);
            // =========================================================================
            Console.WriteLine("----- Question 9 -----");
            Console.Write("Output: ");
            Console.WriteLine(13 / 2 + " " + 13 % 2);
            Console.WriteLine("Correct Choice: 6 1");
            Console.WriteLine("Reason: Integer division (13 / 2 = 6) and remainder (13 % 2 = 1).");

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 10: MCQ - Trace code execution.
            // =========================================================================
            Console.WriteLine("----- Question 10 -----");
            int num = 1, z = 5;
            Console.Write("Output: ");
            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);

            Console.WriteLine("Correct Choice: 7 7");
            Console.WriteLine("Reason: !(1 <= 0) is true. ++num becomes 2, z++ uses 5 (then z=6). First sum = 7. Next ++z increments z to 7.");

            Console.WriteLine("\n=========================================================================");
            Console.WriteLine("End of Assignment 1");
            Console.WriteLine("=========================================================================");
            
            Console.ReadLine(); // Keeps console open
        }
    }
}