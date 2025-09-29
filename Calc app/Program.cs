CalculatorApp();

void CalculatorApp()
{
    //clare variables and initialize them to zero
    int firstnumber = 0;
    int secondnumber = 0;
    int result = 0;

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

    //perform calculation
    result = firstnumber + secondnumber;
    Console.WriteLine();
    Console.WriteLine("The addition of both numbers is {0}", result);

    Console.ReadLine();
}