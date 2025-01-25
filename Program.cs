using System;

int guessCount = 0;
int userChoice;
int secretNumber = 42;

Console.WriteLine("Welcome To Guessing Game!!");

void DisplayPrompt(){

Console.WriteLine("Which Number is the Secret Number? ");
Console.WriteLine("1. 24 \n2. 57 \n3. 42 \n4. 98 ");

Console.Write($"Pick a number 1-4 (Guesses: {guessCount}): ");
userChoice = int.Parse(Console.ReadLine());

};// close Display Prompt 

do {
DisplayPrompt();

if (3 == userChoice)
{
  Console.WriteLine($"You Guessed The Secret Number in {guessCount} guesses!!");
} else {
  Console.WriteLine("Wrong!");
  guessCount = guessCount + 1;

} //close if else

} while (userChoice != 3);
