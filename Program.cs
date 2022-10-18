// Richard Johnson
// 10-18-2022
// Add two numbers
// 
// 

// This bool will decide if the while loop continues
bool playAgain = true;
    bool isNumber;
    bool isNumber2;
    int num1 = 0;
    int num2 = 0;

// This while loop will continue looping as long as playAgain is true
while(playAgain == true)
{
    // The program asks the user if they would like to add two numbers, and then takes their input
    Console.WriteLine("Would you like to add two numbers together?");
    Console.Write("YES or NO: ");
    string yesNo = Console.ReadLine();
    // The user's input will be taken, and converted to all uppercase letters
    yesNo = yesNo.ToUpper();
        if (yesNo == "NO")
        {
            Console.WriteLine("Alright, goodbye.");
            playAgain = false;
        }
        else if(yesNo == "YES")
        {
            Console.WriteLine("Alright! Let's begin!");
            Console.WriteLine(" ");
            Console.Write("Please enter your first number: ");
            string firstNum = Console.ReadLine();
            //This should confirm if the user's input is a number or not
            isNumber = Int32.TryParse(firstNum, out num1);
            // int num1 = Convert.ToInt32(firstNum);


                if (isNumber == true)
                {
                    // This will run if the first number is a valid number
                    Console.WriteLine(" ");
                    Console.Write("Now enter your second number: ");
                    string secondNum = Console.ReadLine();
                    isNumber2 = Int32.TryParse(secondNum, out num2);
                    // int num2 = Convert.ToInt32(secondNum);
                        if (isNumber2 == true)
                        {
                            int sum = (num1 + num2);
                            Console.WriteLine(" ");
                            Console.WriteLine("Calculating...");
                            Console.WriteLine(" ");
                            Console.WriteLine($"Your sum is {sum}.");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid Input: {secondNum} isn't a number");
                            Console.WriteLine(" ");
                        }

                        
                }
                else
                {
                    // This will run if it isn't a valid number
                    Console.WriteLine("Invalid Entry");
                    Console.Write("Please enter a valid number");
                }


            
        }
        else
        {
            Console.WriteLine("Invalid Entry");
            Console.WriteLine("Restarting...");
        }
}