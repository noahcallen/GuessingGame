using System;

Random random= new Random();
int randomNumber = random.Next(1, 100);

int userLevel;
int guessCount;
int userChoice;
int difficulty;
int secretNumber = randomNumber;

Console.WriteLine("Welcome To Guessing Game!!");

void Level () {

  Console.WriteLine("What Difficulty would you like to play at?");
  Console.WriteLine("1. Easy - 10 Guesses \n2. Medium - 8 Guesses \n3. Hard - 6 Guesses \n4. Cheater - 1000 Guesses");
  Console.Write("Pick a Difficulty (1-4): ");
  userLevel = int.Parse(Console.ReadLine());

  difficulty = userLevel;

  if (difficulty == 1) 
  {
    guessCount = 10;

  } else if (difficulty == 2) {

    guessCount = 8;

  } else if (difficulty == 3) {

    guessCount = 6;

  } else {

    guessCount = 1000;

  }// close else if
  Console.Clear();
} //close Level

Level();

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
