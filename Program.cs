﻿// Richard Johnson
// 10-19-2022
// Add two numbers

// If the playAgain bool is true, the main while loop will continue, though it will end if this bool is false
bool playAgain = true;
// If the addition bool is true, the inner while loop will continue, and will end if this bool is false
bool addition = true;
    bool isNumber;
    bool isNumber2;
    int num1 = 0;
    int num2 = 0;
    int num;
Console.Clear();

// This while loop will continue looping as long as playAgain is true
while(playAgain == true)
{
    // The program asks the user if they would like to add two numbers, and then takes their input for YES or NO
    Console.WriteLine("Would you like to add two numbers together?");
    Console.Write("YES or NO: ");
    string yesNo = Console.ReadLine();

    // The user's input will be taken, and converted to all uppercase letters
    yesNo = yesNo.ToUpper();
    isNumber = Int32.TryParse(yesNo, out num);
        if (yesNo == "NO" && isNumber != true)
        {
            // If the player inputs NO into the console, the program will exit the while loop
            Console.WriteLine("Then goodbye.");
            playAgain = false;
        }

        else if(yesNo == "YES" && isNumber != true)
        {
            // If the player inputs YES to the console, the program will print the text below to the console, then enter a second while loop
            Console.WriteLine("Alright! Let's begin!");
            addition = true;

            // This loop will run while the player is asked to input the numbers they want to add
            while(addition == true)
            {
                // After the second while loop begins, the player will be asked to enter a number
                Console.Write("Please enter a first whole number: ");
                string firstNum = Console.ReadLine();
                // This will convert the player's input to an int, and check if their input was a valid number
                isNumber = Int32.TryParse(firstNum, out num1);


                    if (isNumber == true)
                    {
                        // If the first number is a valid whole number, the program will ask the player for another number
                        Console.WriteLine(" ");
                        Console.Write("Now enter your second whole number: ");
                        string secondNum = Console.ReadLine();
                        isNumber2 = Int32.TryParse(secondNum, out num2);
                            if (isNumber2 == true)
                            {
                                // The two numbers from the user's input will be added together
                                int sum = (num1 + num2);
                                Console.WriteLine("Calculating...");
                                Console.WriteLine(" ");
                                // The sum will be printed to the console
                                Console.WriteLine($"Your sum is {sum}.");
                                Console.WriteLine(" ");
                                addition = false;
                            }
                            else
                            {
                                // If the user's input isn't a valid number or a whole number, the program will go back to the beginning of this loop
                                Console.WriteLine($"Invalid Input: You must type a whole number.");
                                Console.WriteLine("Restarting...");
                                Console.WriteLine(" ");
                            }

                        
                    }
                    else
                    {
                        // If they player's input isn't a valid number, or a whole number, this loop will restart
                        Console.WriteLine($"Invalid Input: You must type a whole number.");
                        Console.WriteLine("Restarting...");
                        Console.WriteLine(" ");
                    }
            }
                


            
        }
        else
        {
            // If anything aside from YES or NO is typed into the console, the text below will be printed to it, and the loop will restart
            Console.WriteLine("Invalid Input");
            Console.WriteLine("Restarting...");
            Console.WriteLine(" ");
        }
}