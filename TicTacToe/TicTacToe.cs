using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Tic_Tac_Toe.Entities;

namespace Tic_Tac_Toe
{
    /** ************************************************************************
    * \brief Information about the game logic.
    * \details This class contains all functions responsible for the game logic.
    * \author Thiago Sérvulo Guimarães - thiagoservulog@gmail.com
    * \date 25/03/2024
    * \version v1.1.0
    ***************************************************************************/
    public partial class TicTacToe : Form
    {
        /// \brief Number of rounds of the game.
        private int round;

        /// \brief Player information.
        private Player player;

        /// \brief Computer information.
        private Player computer;

        /// \brief It contains all the buttons of the game.
        private Button[] buttons;

        /// \brief It contains all the corner buttons of the board.
        private Button[] buttonsCorners;

        /// \brief It contains all the buttons in the cross position of the board.
        private Button[] buttonsCross;

        /** ************************************************************************
        * \brief Constructor of the game.
        * \details Constructor of the game.
        ***************************************************************************/
        public TicTacToe()
        {
            // Initialize component
            InitializeComponent();

            // Initialize palyers
            player = new Player(0, 0, 'X', "#A4A4FF");
            computer = new Player(0, 0, 'O', "#ED6767");

            // Initialize buttons
            buttons = new Button[9] { button1, button2, button3, button4, button5, 
                                      button6, button7, button8, button9 };
            buttonsCorners = new Button[4] { button1, button3, button7, button9 };
            buttonsCross = new Button[4] { button2, button4, button6, button8 };

            // Initialize new game
            NewGame();
        }

        /** ************************************************************************
        * \brief Marks a symbol on the button.
        * \details This method marks a symbol on the button 1.
        * \param sender The sender object.
        * \param e The event arguments.
        ***************************************************************************/
        private void Button1Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button1);
        }

        /** ************************************************************************
        * \brief Marks a symbol on the button.
        * \details This method marks a symbol on the button 2.
        * \param sender The sender object.
        * \param e The event arguments.
        ***************************************************************************/
        private void Button2Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button2);
        }

        /** ************************************************************************
        * \brief Marks a symbol on the button.
        * \details This method marks a symbol on the button 3.
        * \param sender The sender object.
        * \param e The event arguments.
        ***************************************************************************/
        private void Button3Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button3);
        }

        /** ************************************************************************
        * \brief Marks a symbol on the button.
        * \details This method marks a symbol on the button 4.
        * \param sender The sender object.
        * \param e The event arguments.
        ***************************************************************************/
        private void Button4Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button4);
        }

        /** ************************************************************************
        * \brief Marks a symbol on the button.
        * \details This method marks a symbol on the button 5.
        * \param sender The sender object.
        * \param e The event arguments.
        ***************************************************************************/
        private void Button5Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button5);
        }

        /** ************************************************************************
        * \brief Marks a symbol on the button.
        * \details This method marks a symbol on the button 6.
        * \param sender The sender object.
        * \param e The event arguments.
        ***************************************************************************/
        private void Button6Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button6);
        }

        /** ************************************************************************
        * \brief Marks a symbol on the button.
        * \details This method marks a symbol on the button 7.
        * \param sender The sender object.
        * \param e The event arguments.
        ***************************************************************************/
        private void Button7Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button7);
        }

        /** ************************************************************************
        * \brief Marks a symbol on the button.
        * \details This method marks a symbol on the button 8.
        * \param sender The sender object.
        * \param e The event arguments.
        ***************************************************************************/
        private void Button8Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button8);
        }

        /** ************************************************************************
        * \brief Marks a symbol on the button.
        * \details This method marks a symbol on the button 9.
        * \param sender The sender object.
        * \param e The event arguments.
        ***************************************************************************/
        private void Button9Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button9);
        }

        /** ************************************************************************
        * \brief Marks symbol on the button.
        * \details This function marks a symbol on the specified button according
        * to the current round.
        * \param button The button to mark the symbol on.
        ***************************************************************************/
        private void MarkSymbol(Button button)
        {
            // Check current palyer
            button.Text = ((round % 2) == 0) ? player.Symbol.ToString() : computer.Symbol.ToString();

            // Set button color
            button.UseVisualStyleBackColor = true;
            Color color = ColorTranslator.FromHtml(((round % 2) == 0) ? player.Color : computer.Color);
            button.BackColor = color;

            // Update button status
            button.Enabled = false;

            // Call main function
            MainGame();
        }

        /** ************************************************************************
        * \brief Main function.
        * \details Function responsible for managing the plays and controlling the 
        * game.
        ***************************************************************************/
        private void MainGame()
        {
            // Increment round
            round += 1;
            
            // Check end game
            CheckEndGame();

            // Check is the current player is the Computer
            if ((round % 2) == 1)
            {
                // Play computer
                MarkSymbol(PlayComputer());
            }
        }

        /** ************************************************************************
        * \brief Check end game.
        * \details Function that checks if the game has ended.
        ***************************************************************************/
        private void CheckEndGame()
        {
            // Check if it's a draw (all 9 squares are filled and there's no winner)
            if (round == 9)
            {
                player.AddDraw();
                computer.AddDraw();
                labelDraws.Text = $"Draw: {player.Draws}";
                EndGame("Draw");
            }
            else
            {
                // Check if the computer won
                if (CheckWinner() == computer)
                {
                    computer.AddVictory();
                    labelDefeats.Text = $"Defeats: {computer.Victories}";
                    EndGame("You lost");     
                }
                else if (CheckWinner() == player) // Check if the player won
                {
                    player.AddVictory();
                    labelVictories.Text = $"Victory: {player.Victories}";
                    EndGame("You win");
                }
            }
        }

        /** ************************************************************************
        * \brief New game.
        * \details Function responsible for resetting the board and global
        * variables.
        ***************************************************************************/
        private void NewGame()
        {
            // Reset round number
            round = 0;

            // Reset buttons
            foreach (Button button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
                button.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        /** ************************************************************************
        * \brief Check winner.
        * \details Function responsible for checking if there is a winner in a
        * match or not.
        * \return Returns a 'Player' class if there is a winner, or 'null' if there
        * is none.
        ***************************************************************************/
        private Player CheckWinner()
        {
            // Check rows
            for (int i = 0; i < 9; i += 3)
            {
                if ((ConvertStringToChar(buttons[i].Text) == ConvertStringToChar(buttons[i + 1].Text)) &&
                    (ConvertStringToChar(buttons[i].Text) == ConvertStringToChar(buttons[i + 2].Text)) &&
                    (ConvertStringToChar(buttons[i].Text) != ' '))
                {
                    return CheckPlayerWinner(ConvertStringToChar(buttons[i].Text));
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if ((ConvertStringToChar(buttons[i].Text) == ConvertStringToChar(buttons[i + 3].Text)) &&
                    (ConvertStringToChar(buttons[i].Text) == ConvertStringToChar(buttons[i + 6].Text)) &&
                    (ConvertStringToChar(buttons[i].Text) != ' '))
                {
                    return CheckPlayerWinner(ConvertStringToChar(buttons[i].Text));
                }
            }

            // Check main diagonal
            if ((ConvertStringToChar(buttons[0].Text) == ConvertStringToChar(buttons[4].Text)) &&
                (ConvertStringToChar(buttons[0].Text) == ConvertStringToChar(buttons[8].Text)) &&
                (ConvertStringToChar(buttons[0].Text) != ' '))
            {
                return CheckPlayerWinner(ConvertStringToChar(buttons[0].Text));
            }

            // Check secundary diagonal
            if ((ConvertStringToChar(buttons[2].Text) == ConvertStringToChar(buttons[4].Text)) &&
                (ConvertStringToChar(buttons[2].Text) == ConvertStringToChar(buttons[6].Text)) &&
                (ConvertStringToChar(buttons[2].Text) != ' '))
            {
                return CheckPlayerWinner(ConvertStringToChar(buttons[2].Text));
            }

            return null;
        }

        /** ************************************************************************
        * \brief Convert string to char.
        * \details Function responsible for converting a string variable to a char 
        * type. If the string is empty, the character ' ' will be returned.
        * \param s String to be converted.
        * \return Value converted in char type.
        ***************************************************************************/
        private char ConvertStringToChar(string s)
        {
            try
            {
                return char.Parse(s);
            }
            catch (FormatException)
            {
                return ' ';
            }
        }

        /** ************************************************************************
        * \brief Check player winner.
        * \details Function responsible for verifying if a player is a winner.
        * \param c Character referring to the player.
        * \return Winner (player or computer), if one exists. If not, returns null.
        ***************************************************************************/
        private Player CheckPlayerWinner(char c)
        {
            // The computer won
            if (c == computer.Symbol) 
            {
                return computer;
            }

            // The palyer won
            if (c == player.Symbol) 
            {
                return player;
            }

            // No one won
            return null;
        }

        /** ************************************************************************
        * \brief Play computer.
        * \details Function responsible for checking, based on a series of
        * possibilities, and deciding which position the computer will play.
        * \return Button corresponding to the position to be played by the computer.
        ***************************************************************************/
        private Button PlayComputer()
        {
            Button button;

            // Check for computer's winning possibility
            if ((button = CheckPossibleWinner(computer)) != null)
            {
                return button;
            }

            // Check for player's winning possibility
            if ((button = CheckPossibleWinner(player)) != null)
            {
                return button;
            }

            // Exclusive possibilities of round 1
            if (round == 1)
            {
                // If the center is empty, play there
                if (ConvertStringToChar(button5.Text) == ' ')
                {
                    return button5;
                }
                else // If not, play in one of the corners
                {
                    return ShuffleButton(buttonsCorners);
                }
            }
            else if (round == 3) // Exclusive possibilities of round 3
            {
                // If two corners are marked by the player, play in the criss-cross position
                if (CountButtonsMarkedByPlayer(buttonsCorners) == 2)
                {
                    return ShuffleButton(buttonsCross);
                }

                // If two corners are marked by the player or computer, play in the corners
                if (CountButtonsMarked(buttonsCorners) == 2) 
                {
                    return ShuffleButton(buttonsCorners);
                }

                // Check main diagonal
                if ((button = CheckDiagonals(0, 8, 4)) != null) 
                {
                    return button;
                }

                // Check secundary diagonal
                if ((button = CheckDiagonals(2, 6, 2)) != null)
                {
                    return button;
                }

                // Check special condition of the cross
                if ((button = CheckSpecialConditionOfTheCross(buttons)) != null)
                {
                    return button;
                } 
            }

            // Randomly choose an empty square to play
            return ShuffleButton(buttons);
        }

        /** ************************************************************************
        * \brief Check diagonals.
        * \details Checks the fields that are on the diagonal, using the provided
        * parameters.
        * \param init First position of the diagonal.
        * \param end Last position of the diagonal.
        * \param step Step to traverse the diagonal.
        * \return Returns a button from the diagonal if it should be played, or
        * none if playing on the diagonal is indifferent.
        ***************************************************************************/
        private Button CheckDiagonals(int init, int end, int step)
        {
            int count = 0;

            // Count not empty fields
            for (int i = init; i <= end; i += step)
            {
                if (ConvertStringToChar(buttons[i].Text) != ' ')
                {
                    count++;
                }
            }

            if(count == 2)
            {
                // Count empty fields
                for (int i = init; i <= end; i += step)
                {
                    if (ConvertStringToChar(buttons[i].Text) == ' ')
                    {
                        return buttons[i];
                    }
                }
            }

            return null;
        }

        /** ************************************************************************
        * \brief Check possible winner.
        * \details Checks if the player provided is a potential winner.
        * \param possibleWinner Player to be checked as a possible winner.
        * \return Returns the position that should be played to win the game or
        * avoid defeat.
        ***************************************************************************/
        private Button CheckPossibleWinner(Player possibleWinner)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                // Check empty fields
                if (ConvertStringToChar(buttons[i].Text) != ' ')
                {
                    continue;
                }
                else
                {
                    // Get symbol of the player informed
                    buttons[i].Text = possibleWinner.Symbol.ToString();
                    Player player = CheckWinner();
                    buttons[i].Text = ' '.ToString();
                    if (player != null)
                    {
                        return buttons[i];
                    }
                }
            }
            return null;
        }

        /** ************************************************************************
        * \brief Shuffle button.
        * \details Randomly selects a button from a given set of buttons.
        * \param buttons List of buttons eligible for random selection.
        * \return Button chosen after the draw.
        ***************************************************************************/
        private Button ShuffleButton(Button[] buttons)
        {
            List<Button> ListButtons = new List<Button>();
            for (int i = 0; i < buttons.Length; i++)
            {
                // Check empty fields
                if (ConvertStringToChar(buttons[i].Text) == ' ')
                {
                    ListButtons.Add(buttons[i]);
                }
            }
            Random randNum = new Random();
            return ListButtons[randNum.Next(ListButtons.Count)];
        }

        /** ************************************************************************
        * \brief End game.
        * \details Displays a message box with the provided message, indicating
        * the end of the game.
        * \param message Message to be displayed in the message box.
        ***************************************************************************/
        private void EndGame(string message)
        {
            // Show the message box
            MessageBox.Show(message, "End of game", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Start a new game
            NewGame();
        }

        /** ************************************************************************
        * \brief Counts buttons marked by the player.
        * \details This function counts the number of buttons marked by the player.
        * \param buttons The array of buttons representing the game board.
        * \return The number of buttons marked by the player.
        ***************************************************************************/
        private int CountButtonsMarkedByPlayer(Button[] buttons)
        {
            return CountButtonsMarkedBySymbol(buttons, player.Symbol);
        }

        /** ************************************************************************
        * \brief Counts marked buttons.
        * \details This function counts the number of buttons that are marked.
        * \param buttons The array of buttons representing the game board.
        * \return The number of marked buttons.
        ***************************************************************************/
        private int CountButtonsMarked(Button[] buttons)
        {
            return CountButtonsMarkedBySymbol(buttons, ' ');
        }

        /** ************************************************************************
        * \brief Counts buttons marked by a specific symbol.
        * \details This function counts the number of buttons marked with the
        * specified symbol.
        * \param buttons The array of buttons representing the game board.
        * \param symbol The symbol to count.
        * \return The number of buttons marked by the specified symbol.
        ***************************************************************************/
        private int CountButtonsMarkedBySymbol(Button[] buttons, char symbol)
        {
            int quant = 0;
            foreach (Button button in buttons)
            {
                if (ConvertStringToChar(button.Text) != symbol)
                {
                    quant += 1;
                }
            }
            return quant;
        }

        /** ************************************************************************
        * \brief Checks for a special condition on the cross.
        * \details This function checks for a special condition where X marks are
        * on two corners of the cross.
        * \param buttons The array of buttons representing the game board.
        * \return The button representing the empty cell in the cross, or null if
        * the condition is not met.
        ***************************************************************************/
        private Button CheckSpecialConditionOfTheCross(Button[] buttons)
        {
            // Check condition on fields 1 and 3
            if ((ConvertStringToChar(buttons[1].Text) == ConvertStringToChar(buttons[3].Text)) &&
                (ConvertStringToChar(buttons[1].Text) != ' '))
            {
                return buttons[0];
            }

            // Check condition on fields 1 and 5
            if ((ConvertStringToChar(buttons[1].Text) == ConvertStringToChar(buttons[5].Text)) &&
                (ConvertStringToChar(buttons[1].Text) != ' '))
            {
                return buttons[2];
            }

            // Check condition on fields 3 and 7
            if ((ConvertStringToChar(buttons[3].Text) == ConvertStringToChar(buttons[7].Text)) &&
                (ConvertStringToChar(buttons[3].Text) != ' '))
            {
                return buttons[6];
            }

            // Check condition on fields 5 and 7
            if ((ConvertStringToChar(buttons[5].Text) == ConvertStringToChar(buttons[7].Text)) &&
                (ConvertStringToChar(buttons[5].Text) != ' '))
            {
                return buttons[8];
            }

            // No condition was found
            return null;
        }
    }

}
