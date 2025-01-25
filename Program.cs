using System;

int userChoice;
int secretNumber = 42;

void DisplayPrompt(){

Console.WriteLine("Welcome To Guessing Game!!");

Console.WriteLine("Which Number is the Secret Number? ");
Console.WriteLine("1. 24 \n2. 57 \n3. 42 \n4. 98 ");


Console.Write("Pick a number 1-4: ");
userChoice = int.Parse(Console.ReadLine());

// Console.Write("You Guessed: ");
// Console.Write(userChoice);

}// close Display Prompt 

DisplayPrompt();

if (3 == userChoice)
{
  Console.WriteLine("You Guessed The Secret Number!!");
} else {
  Console.WriteLine("Wrong!");
} //close if else
