﻿
namespace JogoDaVelha_CSharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBoxScoreBoard = new System.Windows.Forms.GroupBox();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelComputer = new System.Windows.Forms.Label();
            this.groupBoxScoreBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 122);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 122);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 122);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 122);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(138, 223);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 122);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(264, 223);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 122);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 97);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 122);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(138, 97);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 122);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(264, 97);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 122);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // groupBoxScoreBoard
            // 
            this.groupBoxScoreBoard.Controls.Add(this.labelPlayer);
            this.groupBoxScoreBoard.Controls.Add(this.labelComputer);
            this.groupBoxScoreBoard.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxScoreBoard.Location = new System.Drawing.Point(12, 12);
            this.groupBoxScoreBoard.Name = "groupBoxScoreBoard";
            this.groupBoxScoreBoard.Size = new System.Drawing.Size(372, 79);
            this.groupBoxScoreBoard.TabIndex = 9;
            this.groupBoxScoreBoard.TabStop = false;
            this.groupBoxScoreBoard.Text = "Placar Geral:";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(168, 35);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(84, 25);
            this.labelPlayer.TabIndex = 1;
            this.labelPlayer.Text = "Jogador:";
            this.labelPlayer.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelComputer
            // 
            this.labelComputer.AutoSize = true;
            this.labelComputer.Location = new System.Drawing.Point(6, 35);
            this.labelComputer.Name = "labelComputer";
            this.labelComputer.Size = new System.Drawing.Size(122, 25);
            this.labelComputer.TabIndex = 0;
            this.labelComputer.Text = "Computador:";
            this.labelComputer.Click += new System.EventHandler(this.labelComputer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 483);
            this.Controls.Add(this.groupBoxScoreBoard);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxScoreBoard.ResumeLayout(false);
            this.groupBoxScoreBoard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBoxScoreBoard;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelComputer;
    }
}

