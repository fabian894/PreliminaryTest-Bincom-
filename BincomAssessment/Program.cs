using System;

class Program
{
    static void Main()
    {
        // Task 1: Declare and initialize variables
        string name = "John Doe";
        int age = 25;
        bool isAdmin = true;

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Is Admin: " + isAdmin);

        // Task 2: Write a program that takes an integer input from the user and prints out whether the number is even or odd
        Console.Write("Enter an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is even or odd
        if (number % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }

        // Task 3: Write a program that prints out the numbers 1 to 10 using a for loop
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Task 4: Declare and initialize an integer array with the values 2, 4, 6, 8, 10
        int[] numbers = { 2, 4, 6, 8, 10 };

        // Calculate the sum of all elements in the array
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num; 
        }

        Console.WriteLine("Sum of all elements: " + sum);

        // Use a foreach loop to iterate over the array and print each element
        Console.WriteLine("Array elements:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Task 5: Write a method named Greet that takes a string parameter name and prints out a personalized greeting 
        static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        Greet("Alice");
    }
}
