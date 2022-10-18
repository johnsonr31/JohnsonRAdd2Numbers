// Richard Johnson
// 10-18-2022
// Add two numbers
// 
// 

// This bool will decide if the while loop continues
bool playAgain = true;

// This while loop will continue looping as long as playAgain is true
while(playAgain == true)
{
    Console.WriteLine("Would you like to add two numbers together?");
    Console.Write("YES or NO: ");
    string yesNo = Console.ReadLine();
    yesNo = yesNo.ToUpper();
        if (yesNo == "NO")
        {
            Console.WriteLine("Alright, goodbye.");
            playAgain = false;
        }
        else if(yesNo == "YES")
        {
            Console.WriteLine("Alright! Let's begin!");
            Console.Write("Please type your first number: ");
            int firstNum = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Invalid Entry");
            Console.WriteLine("Restarting...");
        }
}