using System;

namespace WorkingWithVariables
{
  class Program
  {
    static void Main(string[] args)
    {
      var numberOfCupsOfCoffee = "two";
      Console.WriteLine("What is your name?");
      var fullName = Console.ReadLine();
      var today = new DateTime(2020, 2, 10);

      if (fullName == "Alice")
      {
        Console.WriteLine("Hello, Alice. This is a special message for you!");
      }
      Console.WriteLine("My name is " + fullName + ", and I have had " + numberOfCupsOfCoffee + " cups of coffee on " + today.ToString("MMMM dd, yyyy") + ".");

      Console.WriteLine("What is your name?");
      var user = Console.ReadLine();
      Console.WriteLine("Greetings, " + user + ".");

      Console.WriteLine("Give me two numbers, please");
      var operand1 = double.Parse(Console.ReadLine());
      var operand2 = double.Parse(Console.ReadLine());
      var sum = operand1 + operand2;
      Console.WriteLine("The sum is " + sum);

      var difference = operand1 - operand2;
      Console.WriteLine("The difference is " + difference);

      var quotient = operand1 / operand2;
      Console.WriteLine("The quotient is " + quotient);

      var product = operand1 * operand2;
      Console.WriteLine("The product is " + product);

      var remainder = operand1 % operand2;
      Console.WriteLine("The remainder is " + remainder);
    }
  }
}
