namespace Tic_Tac_Toe
{
    /** ************************************************************************
    * \brief Information about the game board.
    * \details This class contains all components for the game board.
    * \author Thiago Sérvulo Guimarães - thiagoservulog@gmail.com
    * \date 25/03/2024
    * \version v1.1.0
    ***************************************************************************/
    partial class TicTacToe
    {
        /// \brief Container for components.
        private System.ComponentModel.IContainer components = null;

        /** ************************************************************************
        * \brief Dispose method for releasing managed resources.
        * \details This method is used to release managed resources when they are
        * no longer needed.
        * \param disposing true to release both managed and unmanaged resources;
        * false to release only unmanaged resources.
        ***************************************************************************/
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /** ************************************************************************
        * \brief Initializes the components.
        * \details This method initializes the components used by the class.
        ***************************************************************************/
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
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
            this.labelDraws = new System.Windows.Forms.Label();
            this.labelVictories = new System.Windows.Forms.Label();
            this.labelDefeats = new System.Windows.Forms.Label();
            this.groupBoxScoreBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 122);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(138, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 122);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(264, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 122);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(12, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 122);
            this.button4.TabIndex = 3;
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(138, 223);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 122);
            this.button5.TabIndex = 4;
            this.button5.TabStop = false;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(264, 223);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 122);
            this.button6.TabIndex = 5;
            this.button6.TabStop = false;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(12, 97);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 122);
            this.button7.TabIndex = 6;
            this.button7.TabStop = false;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(138, 97);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 122);
            this.button8.TabIndex = 7;
            this.button8.TabStop = false;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(264, 97);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 122);
            this.button9.TabIndex = 8;
            this.button9.TabStop = false;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9Click);
            // 
            // groupBoxScoreBoard
            // 
            this.groupBoxScoreBoard.Controls.Add(this.labelDraws);
            this.groupBoxScoreBoard.Controls.Add(this.labelVictories);
            this.groupBoxScoreBoard.Controls.Add(this.labelDefeats);
            this.groupBoxScoreBoard.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxScoreBoard.Location = new System.Drawing.Point(12, 12);
            this.groupBoxScoreBoard.Name = "groupBoxScoreBoard";
            this.groupBoxScoreBoard.Size = new System.Drawing.Size(372, 79);
            this.groupBoxScoreBoard.TabIndex = 9;
            this.groupBoxScoreBoard.TabStop = false;
            this.groupBoxScoreBoard.Text = "Total Score:";
            // 
            // labelDraws
            // 
            this.labelDraws.AutoSize = true;
            this.labelDraws.Location = new System.Drawing.Point(145, 35);
            this.labelDraws.Name = "labelDraws";
            this.labelDraws.Size = new System.Drawing.Size(87, 25);
            this.labelDraws.TabIndex = 2;
            this.labelDraws.Text = "Draws: 0";
            // 
            // labelVictories
            // 
            this.labelVictories.AutoSize = true;
            this.labelVictories.Location = new System.Drawing.Point(255, 34);
            this.labelVictories.Name = "labelVictories";
            this.labelVictories.Size = new System.Drawing.Size(84, 25);
            this.labelVictories.TabIndex = 1;
            this.labelVictories.Text = "Victories: 0";
            // 
            // labelDefeats
            // 
            this.labelDefeats.AutoSize = true;
            this.labelDefeats.Location = new System.Drawing.Point(4, 35);
            this.labelDefeats.Name = "labelDefeats";
            this.labelDefeats.Size = new System.Drawing.Size(122, 25);
            this.labelDefeats.TabIndex = 0;
            this.labelDefeats.Text = "Defeats: 0";
            // 
            // FormGame
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(411, 522);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(411, 522);
            this.Name = "FormGame";
            this.Text = "Tic-Tac-Toe";
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
        private System.Windows.Forms.Label labelVictories;
        private System.Windows.Forms.Label labelDefeats;
        private System.Windows.Forms.Label labelDraws;
    }
}

