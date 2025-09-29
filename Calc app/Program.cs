CalculatorApp();

void CalculatorApp()
{
    //clare variables and initialize them to zero
    int firstnumber = 0;
    int secondnumber = 0;
    int result = 0;
    int choice = 0;

    // prompt user to enter the first number
    Console.WriteLine("enter the first Number");
    firstnumber = Convert.ToInt32(Console.ReadLine());
    // prompt user to enter the second number
    Console.WriteLine("enter the second number");

    secondnumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("choose an option from the following: ");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Multiply");
    Console.WriteLine("4 - Divide");
    //Convert string to int
    choice = Convert.ToInt32(Console.ReadLine());
    // use if statement to perform selected operation
    if (choice == 1)
    {
        result = firstnumber + secondnumber;
        Console.WriteLine("The addition of both numbers is {0}", result);
    }
    else if (choice == 2)
    {
        result = firstnumber - secondnumber;
        Console.WriteLine("The subtraction of both numbers is {0}", result);
    }
    else if (choice == 3)
    {
        result = firstnumber * secondnumber;
        Console.WriteLine("The multiplication of both numbers is {0}", result);
    }
    else if (choice == 4)
    {
        if (secondnumber != 0)
        {
            result = firstnumber / secondnumber;
            Console.WriteLine("The division of both numbers is {0}", result);
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
    }
    else
    {
        Console.WriteLine("Invalid choice");

        //perform calculation

        Console.WriteLine();
        Console.WriteLine("The addition of both numbers is {0}", result);

        Console.ReadLine();
    }
}