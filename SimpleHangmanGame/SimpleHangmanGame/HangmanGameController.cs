using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHangmanGame
{
    class HangmanGameController
    {
        /*I just want it to be clear, DO NOT USE THIS AS A TEMPLATE! I made this for fun! And you should NOT code like THIS! WARNING!*/private static String[] randomWord = { "INITIALIZE", "VARIABLE", "CSHARP", "PROGRAMMING", "STUDYING", "COMPUTER"};
        
        private static int currentPoints = 0;
        private static String currentWord, currentHiddenWord, newHiddenWord;

        //***** Setters and Getters *****
        public static void SetWord(String newWord)
        {
            currentWord = newWord;
        }

        public static String getWord()
        {
            return currentWord;
        }

        private static void setHiddenWord(String hiddenWord) //Sets the hidden word eg *******.
        {
            currentHiddenWord = hiddenWord;
        }

        public static String getHiddenWord()
        {
            return currentHiddenWord;
        }

        // ***** Setters and Getters *****

        //Generates a random int, which then enters into the array, then sets the chosen word.
        public static void RandomWordGenerator()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 6);
            currentWord = randomWord[randomNumber];
            SetWord(currentWord); //This saves a copy of the current word, not hidden, so we can compare it later.
            hideWord(currentWord);
        }

        //Converts the current word from a word choosen by the RandomWordGenerator to a String of *.
        private static void hideWord(String hiddenWord) {
            hiddenWord = getWord(); //Declares the "hiddenWord".
            char[] hiddenWordArr = hiddenWord.ToCharArray(); //Turns the hiddenWord into a char Array List.
            for (int a = 0; a < hiddenWord.Length; a++)
            {
                hiddenWordArr[a] = '*'; //Turns each char of the hidden word into "*". To hide the word.
            }
            newHiddenWord = new string(hiddenWordArr); //Turns the char Array List back into String.
            setHiddenWord(newHiddenWord); //Sets the new hiddenWord eg. ****** Instead of a word.
        }

        public static void checkIfCorrectGuess(char currentGuess)
        {
            String hiddenWord = getHiddenWord(); //Gets the current hiddenWord.
            char[] hiddenWordArr = hiddenWord.ToCharArray(); //Turns the hiddenWord into a char Array List.
            char[] currentWordArr = currentWord.ToCharArray(); //Turns the currentWord into a char Array List.

            for (int a = 0; a < currentWord.Length; a++) { //If int 'a' is less than currentWords lenght, run this.
                if (currentWordArr[a].Equals(currentGuess)) //If currentWord Array List is equal to the guess from the player
                {
                    hiddenWordArr[a] = currentGuess; //Changes * into the guessed letter, on the spot 'a' in the char Array List.
                    newHiddenWord = new string(hiddenWordArr); //Turns the new word into a String.
                }
            }
            if (currentHiddenWord.Equals(newHiddenWord)) //Only to add points. See if you successfully made a right guess.
            {
                addPoints(); //Calls the addPoints method.
            }
            setHiddenWord(newHiddenWord); //Sets the new hiddenWord, even if it wasnt changed.
        }

        //Adds the guessed letters into a String then returns it so the player can see what's been tested.
        public static String guessedLetters(String guessedLetter, String currentGuess) {
             currentGuess = guessedLetter + ", " + currentGuess;
             return currentGuess;
        }

        // ***** Win/Lose conditions *****

        public static void addPoints()
        {
            currentPoints++;
            Console.WriteLine(currentPoints);
        }

        public static int getPoints()
        {
            return currentPoints;
        }
    }
}
