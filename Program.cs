using System;

int userChoice;
int secretNumber = 42;

void DisplayPrompt(){

Console.WriteLine("Welcome To Guessing Game!!");

Console.Write("Guess the Secret Number: ");
userChoice = int.Parse(Console.ReadLine());

// Console.Write("You Guessed: ");
// Console.Write(userChoice);

}// close Display Prompt 

DisplayPrompt();

if (secretNumber == userChoice)
{
  Console.WriteLine("You Guessed The Secret Number!!");
} else {
  Console.WriteLine("Wrong!");
} //close if else
