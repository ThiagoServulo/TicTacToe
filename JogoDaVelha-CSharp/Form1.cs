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

        private void button1_Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MarkSymbol(this.button8);
        }

        private void button9_Click(object sender, EventArgs e)
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
            // Checando linhas
            for(int i = 0; i < 9; i += 3)
            {
                try
                {
                    if ((char.Parse(buttons[i].Text) == char.Parse(buttons[i + 1].Text)) &&
                        (char.Parse(buttons[i].Text) == char.Parse(buttons[i + 2].Text)))
                    {
                        labelComputer.Text = "ganhou";
                    }
                }
                catch(FormatException)
                {
                    // Não é necessário tratar esse tipo de erro
                }
            }

            // Checando colunas
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    if ((char.Parse(buttons[i].Text) == char.Parse(buttons[i + 3].Text)) &&
                        (char.Parse(buttons[i].Text) == char.Parse(buttons[i + 6].Text)))
                    {
                        labelComputer.Text = "ganhou";
                    }
                }
                catch (FormatException)
                {
                    // Não é necessário tratar esse tipo de erro
                }
            }

            return null;
        }
    }
}
