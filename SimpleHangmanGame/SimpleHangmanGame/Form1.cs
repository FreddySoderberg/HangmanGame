using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleHangmanGame
{
    public partial class Form1 : Form
    {
        private static String test;

        //Adds images for the game.
        static Bitmap image0 = Properties.Resources.HangmanGamePic0;
        static Bitmap image1 = Properties.Resources.HangmanGamePic1;
        static Bitmap image2 = Properties.Resources.HangmanGamePic2;
        static Bitmap image3 = Properties.Resources.HangmanGamePic3;
        static Bitmap image4 = Properties.Resources.HangmanGamePic4;
        static Bitmap image5 = Properties.Resources.HangmanGamePic5;
        static Bitmap image6 = Properties.Resources.HangmanGamePic6;
        static Bitmap image7 = Properties.Resources.HangmanGamePic7;
        static Bitmap image8 = Properties.Resources.HangmanGamePic8;
        static Bitmap image9 = Properties.Resources.HangmanGamePic9;

        //Image array.
        static Image[] images = { image0, image1, image2, image3, image4, image5, image6, image7, image8, image9 };

        public Form1() //Starts first, when the window shows up.
        {
            HangmanGameController.RandomWordGenerator(); //Starts the word generator
            String currentWord = HangmanGameController.getHiddenWord(); //Gets the hidden word.
            InitializeComponent(); //Starts the window form.
            hiddenWordLbl.Text = HangmanGameController.getHiddenWord(); //Sets the hidden word into the label.
            pictureBox1.Image = image0; //Adds the first image
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        //On button press, most action and most disgusting code..
        private void guessBtn_Click(object sender, EventArgs e)
        {
            String currentWord = HangmanGameController.getWord();//Saves the currentWord, not hidden, into a String.
            String currentHiddenWord = HangmanGameController.getHiddenWord();//Saves the hidden word into a String.

            String txtBox = textBox1.Text.ToUpper(); //Creates a String from the text in the text box and makes it Upper Case.
            pictureBox1.Image = images[HangmanGameController.getPoints()]; //Check how many points there are and show the appropriate image.

            if (txtBox.Length == 1) { //If the textbox length of letters are equal to 1.
                test = HangmanGameController.guessedLetters(txtBox, test); //Adds the used/tested letters into a String and gets the result.
                testedLetters.Text = "Tested Letters: " + test; //Adds the used/tested letters to a label for the used to see.

                char txtBoxChar = char.Parse(textBox1.Text.ToUpper()); //Turns the guessed letter into a Upper Case char.
                HangmanGameController.checkIfCorrectGuess(txtBoxChar); //Sends the char to check if it's correct.
                hiddenWordLbl.Text = HangmanGameController.getHiddenWord().ToUpper(); //Gets the new hiddenWord and display to user.

                warngLbl.Hide(); //Hides warning label if it's showing, otherwise nothing.
            } else if(txtBox.Length >= 2) { // If the textbox has 2 or more letters.
                HangmanGameController.addPoints(); // Adds point.
                pictureBox1.Image = images[HangmanGameController.getPoints()]; // Shows new/next image of hangman.
                warngLbl.Show(); // Show warning label for too many letters.
            }

            if (currentHiddenWord.Equals(currentWord)){ //If the hidden word is the same as the not hidden one, you win.
                winLbl.Show();
                quitBtn.Show();
            } else if (HangmanGameController.getPoints() == 9) { //If you don't win, but instead gets 9 points, you lose.
                lostLbl.Show();
                warngLbl.Hide();
                guessBtn.Hide();
                quitBtn.Show();
            }
            textBox1.Clear();
            pictureBox1.Image = images[HangmanGameController.getPoints()]; // Image dependent on current points.
        }


        // Does nothing, don't want to remove if the program breaks
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Exits/Closes the application.
        }
    }
}
