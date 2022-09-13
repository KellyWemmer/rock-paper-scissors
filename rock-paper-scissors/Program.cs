// See https://aka.ms/new-console-template for more information

List<string> gestures = new List<string> {//List out result options
    "rock",
    "paper",
    "scissors"
};

Console.WriteLine("Welcome to Rock Paper Scissors");

for (int i = 0; i < gestures.Count; i++)
{
    Console.WriteLine(gestures[i]);
}
bool playing = true;
do
{
    Random rand = new Random();
    int randomIndex = rand.Next(0, gestures.Count - 1); //Returns a random int that <= 0 and count-1
    string secretGesture = gestures[randomIndex];

    string? input = "";
    input= Console.ReadLine();//This is where my guess is entered into memory
    Console.WriteLine("The computer's answer was " + secretGesture + " Your answer was " + input);

    if (secretGesture == input)
    {
        Console.WriteLine("Try again");
    }
    else if(secretGesture == "rock" && input == "paper")
    {
        Console.WriteLine("You've Won!");
    }
    else if(secretGesture == "paper" && input == "scissors")
    {
        Console.WriteLine("You've Won!");
    }
    else if(secretGesture == "scissors" && input == "rock")
    {
        Console.WriteLine("You've Won!");
    }
    else
    {
        Console.WriteLine("Sorry, you lost this game");
    }
} while(playing);









