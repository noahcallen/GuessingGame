using System;

Random random= new Random();
int randomNumber = random.Next(1, 100);

int guessCount = 10;
int userChoice;
int secretNumber = randomNumber;

Console.WriteLine("Welcome To Guessing Game!!");

void DisplayPrompt(){

Console.Write($"Guess the Secret Number (Guesses Left: {guessCount}): ");
userChoice = int.Parse(Console.ReadLine());

};// close Display Prompt 

do {
DisplayPrompt();

if (secretNumber == userChoice)
{
  Console.WriteLine($"You Guessed The Secret Number with {guessCount} guesses left!!");
  break;

} else if (userChoice < secretNumber) {

  Console.WriteLine("You guessed Lower than the Secret Number try guessing higher!");
  guessCount = guessCount - 1;

} else if (userChoice > secretNumber){

  Console.WriteLine("You guessed Higher than the Secret Number try guessing lower!");
  guessCount = guessCount - 1;

}//close if else

} while (guessCount != 0 || userChoice == secretNumber);

if (guessCount == 0)
{
  Console.WriteLine("You ran out of guesses :(");

} else {
  
  Console.WriteLine("Congrats! You Win!");

}//close if
