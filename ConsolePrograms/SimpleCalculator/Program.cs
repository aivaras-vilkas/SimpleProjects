while (true)
{
Console.WriteLine("********Welcome To Simple Calculator********");
Console.WriteLine("Enter First number");
double firstNumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Second number");
double secondNumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Chosen an operator: (+, -, *, /)");
string chosenOperator = Console.ReadLine();
string wantToRestart;


    if (chosenOperator.Length > 1)
    {
        Console.WriteLine();
        Console.WriteLine("Error: INCORRECT OPERATOR !!!");
        Console.WriteLine("Enter valid operator:");
        chosenOperator = Console.ReadLine();
    }

    switch (chosenOperator)
    {
        case "+":
            Console.WriteLine(firstNumber + secondNumber);
            break;
        case "-":
            Console.WriteLine(firstNumber - secondNumber);
            break;
        case "*":
            Console.WriteLine(firstNumber * secondNumber);
            break;
        case "/":
            Console.WriteLine(firstNumber / secondNumber);
            break;
    }

    Console.WriteLine("Want to restart the calculator?");
    wantToRestart = (Console.ReadLine()).ToLower();
    if (wantToRestart != "taip")
    {
        break;
    }
}

