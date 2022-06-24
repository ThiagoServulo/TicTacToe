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
        Button[] buttons;

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
            if ((round % 2) == 0)
            {
                button.Text = computer.Symbol.ToString();
            }
            else
            {
                button.Text = player.Symbol.ToString();
            }
            round += 1;
            button.Enabled = false;
            CheckEndGame();
        }

        private void CheckEndGame()
        {
            if(round == 9)
            {
                NewGame();
            }
            else
            {
                CheckWinner();
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
            try
            {
                // Checando linhas
                for (int i = 0; i < 9; i += 3)
                {
                    if ((char.Parse(buttons[i].Text) == char.Parse(buttons[i + 1].Text)) &&
                        (char.Parse(buttons[i].Text) == char.Parse(buttons[i + 2].Text)))
                    {
                        labelComputer.Text = "ganhou";
                    }
                }

                // Checando colunas
                for (int i = 0; i < 3; i++)
                {

                    if ((char.Parse(buttons[i].Text) == char.Parse(buttons[i + 3].Text)) &&
                        (char.Parse(buttons[i].Text) == char.Parse(buttons[i + 6].Text)))
                    {
                        labelComputer.Text = "ganhou";
                    }
                }

                // Checando diagonal principal
                if ((char.Parse(buttons[0].Text) == char.Parse(buttons[4].Text)) &&
                    (char.Parse(buttons[0].Text) == char.Parse(buttons[8].Text)))
                {
                    labelComputer.Text = "ganhou";
                }

                // Checando diagonal secundária
                if ((char.Parse(buttons[2].Text) == char.Parse(buttons[4].Text)) &&
                    (char.Parse(buttons[2].Text) == char.Parse(buttons[6].Text)))
                {
                    labelComputer.Text = "ganhou";
                }
            }
            catch (FormatException)
            {
                // Não é necessário tratar esse tipo de erro
            }

            return null;
        }
    }
}
