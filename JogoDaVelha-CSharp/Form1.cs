using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JogoDaVelha_CSharp.Entities;

namespace JogoDaVelha_CSharp
{
    public partial class Form1 : Form
    {
        private int round;
        private Player player;
        private Player computer;
        private Button[] buttons;

        public Form1()
        {
            InitializeComponent();
            round = 0;
            player = new Player(0, 0, 'X');
            computer = new Player(0, 0, 'O');
            buttons = new Button[9] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
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

        private void MainGame()
        {
            round += 1;
            CheckEndGame();
            if ((round % 2) == 1)
            {
                MarkSymbol(PlayComputer());
            }
        }

        private void CheckEndGame()
        {
            if(round == 9)
            {
                NewGame();
                MessageBox.Show("empate");
            }
            else
            {
                if (CheckWinner() != null)
                {
                    MessageBox.Show("alguém ganhou");
                    NewGame();
                }
            }
        }

        private void NewGame()
        {
            round = 0;
            foreach(Button button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
            }
        }

        private Player CheckWinner()
        {
            // Checando linhas
            for (int i = 0; i < 9; i += 3)
            {
                if ((ConvertStringToChar(buttons[i].Text) == ConvertStringToChar(buttons[i + 1].Text)) &&
                    (ConvertStringToChar(buttons[i].Text) == ConvertStringToChar(buttons[i + 2].Text)) &&
                    (ConvertStringToChar(buttons[i].Text) != ' '))
                {
                    return CheckPlayerWinner(ConvertStringToChar(buttons[i].Text));
                }
            }

            // Checando colunas
            for (int i = 0; i < 3; i++)
            {
                if ((ConvertStringToChar(buttons[i].Text) == ConvertStringToChar(buttons[i + 3].Text)) &&
                    (ConvertStringToChar(buttons[i].Text) == ConvertStringToChar(buttons[i + 6].Text)) &&
                    (ConvertStringToChar(buttons[i].Text) != ' '))
                {
                    return CheckPlayerWinner(ConvertStringToChar(buttons[i].Text));
                }
            }

            // Checando diagonal principal
            if ((ConvertStringToChar(buttons[0].Text) == ConvertStringToChar(buttons[4].Text)) &&
                (ConvertStringToChar(buttons[0].Text) == ConvertStringToChar(buttons[8].Text)) &&
                (ConvertStringToChar(buttons[0].Text) != ' '))
            {
                return CheckPlayerWinner(ConvertStringToChar(buttons[0].Text));
            }

            // Checando diagonal secundária
            if ((ConvertStringToChar(buttons[2].Text) == ConvertStringToChar(buttons[4].Text)) &&
                (ConvertStringToChar(buttons[2].Text) == ConvertStringToChar(buttons[6].Text)) &&
                (ConvertStringToChar(buttons[2].Text) != ' '))
            {
                return CheckPlayerWinner(ConvertStringToChar(buttons[2].Text));
            }

            return null;
        }

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
                computer.Victories += 1;
                return computer;
            }
            else if (c == player.Symbol)
            {
                player.Victories += 1;
                return player;
            }
            else
            {
                return null;
            }
        }

        private Button PlayComputer()
        {
            if(round == 1)
            {
                return FirstPlay();
            }
            else
            {
                Button button = CheckPossibleWinner(computer);
                if(button != null)
                {
                    return button;
                }

                button = CheckPossibleWinner(player);
                if (button != null)
                {
                    return button;
                }
            }
            return ShuffleButton(buttons);        
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

        private Button FirstPlay()
        {
            if(ConvertStringToChar(button5.Text) == ' ')
            {
                return button5;
            }
            else
            {
                Button[] buttonsConners = new Button[4] { button1, button3, button7, button9 };
                return ShuffleButton(buttonsConners);
            }
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
    }

}
