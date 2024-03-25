using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Tic_Tac_Toe.Entities;

namespace Tic_Tac_Toe
{
    /** ************************************************************************
    * \brief Information about the game.
    * \details 
    * \author Thiago Sérvulo Guimarães - thiagoservulog@gmail.com
    * \date 25/03/2024
    * \version v1.1.0
    ***************************************************************************/
    public partial class Form1 : Form
    {
        private int round;
        private Player player;
        private Player computer;
        private Button[] buttons;
        private Button[] buttonsConners;
        private Button[] buttonsCross;

        public Form1()
        {
            InitializeComponent();
            player = new Player(0, 0, 'X');
            computer = new Player(0, 0, 'O');
            buttons = new Button[9] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            buttonsConners = new Button[4] { button1, button3, button7, button9 };
            buttonsCross = new Button[4] { button2, button4, button6, button8 };
            NewGame();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button1);
        }

        private void Button2Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button2);
        }

        private void Button3Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button3);
        }

        private void Button4Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button4);
        }

        private void Button5Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button5);
        }

        private void Button6Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button6);
        }

        private void Button7Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button7);
        }

        private void Button8Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button8);
        }

        private void Button9Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button9);
        }

        private void MarkSymbol(Button button)
        {
            button.Text = ((round % 2) == 0) ? player.Symbol.ToString() : computer.Symbol.ToString();
            button.Enabled = false;
            MainGame();
        }

        /*--------------------------------------------------------------------------------------------------
        Função: MainGame.
        Descrição: Função responsável por gerenciar as jogadas e fazer o controle do jogo.
        Argumentos: Nenhum.
        Retorno: Nenhum.
        ---------------------------------------------------------------------------------------------------*/
        private void MainGame()
        {
            round += 1;
            CheckEndGame();
            if ((round % 2) == 1)
            {
                MarkSymbol(PlayComputer());
            }
        }

        /*--------------------------------------------------------------------------------------------------
        Função: CheckEndGame.
        Descrição: Função que checa se o jogo chegou ao fim.
        Argumentos: Nenhum.
        Retorno: Nenhum.
        ---------------------------------------------------------------------------------------------------*/
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

        /*--------------------------------------------------------------------------------------------------
        Função: NewGame.
        Descrição: Função responsável por resetar o tabuleiro e as variáveis globais.
        Argumentos: Nenhum.
        Retorno: Nenhum.
        ---------------------------------------------------------------------------------------------------*/
        private void NewGame()
        {
            round = 0;
            foreach (Button button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
                button.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        /*--------------------------------------------------------------------------------------------------
        Função: CheckWinner.
        Descrição: Função responsável por checar se há um vencedor em uma partida ou não.
        Argumentos: Nenhum.
        Retorno: Retorna uma classe do tipo 'Player' caso exista um vencedor, ou 'null' caso não exista.
        ---------------------------------------------------------------------------------------------------*/
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

        /*--------------------------------------------------------------------------------------------------
        Função: ConvertStringToChar.
        Descrição: Função responsável por converter uma variável do tipo string para char.
                   Se a string estiver vazia, será retornado o caractere ' '.
        Argumentos: s - string a ser convertida.
        Retorno: Retorna o valor convertido no tipo char.
        ---------------------------------------------------------------------------------------------------*/
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

        private Player CheckPlayerWinner(char c)
        {
            if (c == computer.Symbol)
            {
                return computer;
            }
            else if (c == player.Symbol)
            {
                return player;
            }
            else
            {
                return null;
            }
        }

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
                    return ShuffleButton(buttonsConners);
                }
            }
            else if (round == 3) // Exclusive possibilities of round 3
            {
                // If two corners are marked by the player, play in the criss-cross position
                if (CountButtonsMarkedByPlayer(buttonsConners) == 2)
                {
                    return ShuffleButton(buttonsCross);
                }

                // If two corners are marked by the player or computer, play in the corners
                if (CountButtonsMarked(buttonsConners) == 2) 
                {
                    return ShuffleButton(buttonsConners);
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

        private Button CheckDiagonals(int init, int end, int step)
        {
            int count = 0;
            for (int i = init; i <= end; i += step)
            {
                if (ConvertStringToChar(buttons[i].Text) != ' ')
                {
                    count++;
                }
            }

            if(count == 2)
            {
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

        private Button CheckPossibleWinner(Player possibleWinner)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (ConvertStringToChar(buttons[i].Text) != ' ')
                {
                    continue;
                }
                else
                {
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

        private Button ShuffleButton(Button[] buttons)
        {
            List<Button> ListButtons = new List<Button>();
            for (int i = 0; i < buttons.Length; i++)
            {
                if (ConvertStringToChar(buttons[i].Text) == ' ')
                {
                    ListButtons.Add(buttons[i]);
                }
            }
            Random randNum = new Random();
            return ListButtons[randNum.Next(ListButtons.Count)];
        }

        private void EndGame(string message)
        {
            MessageBox.Show(message, "End of game");
            NewGame();
        }

        private int CountButtonsMarkedByPlayer(Button[] buttons)
        {
            return CountButtonsMarkedBySymbol(buttons, player.Symbol);
        }

        private int CountButtonsMarked(Button[] buttons)
        {
            return CountButtonsMarkedBySymbol(buttons, ' ');
        }

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
        * \brief 
        * \details 
        *    |   |
        * -----------
        *  X |   |
        * -----------
        *  A | X |
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
