// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("Welcome to the History quiz " + name);
Console.WriteLine();

string[] questions = 
    
{
 "At what year the battle of Waterloo was fought?",
 "How wrote a book about military strategy 'On War'?",
 "When did WW1 have begun?",
 "Who was a known general of Cartagena?",
 "How many Punic Wars there were?"
};

string[] answers =
{
 "A. 1815 \nB. 1812 \nC. 1805",
 "A. Napoleon Bonaparte \nB. Clauzewitz \nC. Elder Moltke",
 "A. 1905 \nB. 1918 \nC. 1914",
 "A. Scipio Africanus \nB. Hannibal Barsa \nC. Marcus Aurelius",
 "A. 1 \nB. 2 \nC. 3"
};

int startingPlayerScore = 0;
int[] correctAnswers = {0, 1, 2, 1, 3};


for (int i = 0; i < questions.Length; i++)
{

    Console.WriteLine("Question: " + (i + 1));
    Console.WriteLine(questions[i]);
    Console.WriteLine(answers[i]);
    Console.WriteLine("Please enter the answer: A, B, C");
    string playerAnswer = Console.ReadLine().ToUpper();

    while ((playerAnswer != "A") && (playerAnswer != "B") && (playerAnswer != "C"))
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("You have entered wrong value.");
        Console.WriteLine("------Please try again-------");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("");
        Console.WriteLine("Question: " + (i + 1));
        Console.WriteLine(questions[i]);
        Console.WriteLine(answers[i]);
        Console.WriteLine("Please enter the answer: A, B, C");
        playerAnswer = Console.ReadLine().ToUpper();
    }

    if (string.Equals(playerAnswer, "A") && correctAnswers[i] == 0)
    {
        startingPlayerScore++;
        Console.WriteLine("Correct");
        Console.WriteLine("");
    }
    if (string.Equals(playerAnswer, "B") && correctAnswers[i] == 1)
    {
        startingPlayerScore++;
        Console.WriteLine("Correct");
        Console.WriteLine("");
    }
    if (string.Equals(playerAnswer, "C") && correctAnswers[i] == 2)
    {
        startingPlayerScore++;
        Console.WriteLine("Correct");
        Console.WriteLine("");
    }
      
    
}
Console.WriteLine("");
Console.WriteLine("YOUR Results");
Console.WriteLine(name +" had " + (startingPlayerScore) + " correct answers out of 5");

