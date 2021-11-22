namespace GuessAWord
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHiddenWord = new System.Windows.Forms.Label();
            this.lblGuessALetter = new System.Windows.Forms.Label();
            this.lblNumberOfTries = new System.Windows.Forms.Label();
            this.txtLetterGuess = new System.Windows.Forms.TextBox();
            this.txtNumTries = new System.Windows.Forms.TextBox();
            this.lblLetters = new System.Windows.Forms.Label();
            this.lblLettersUsed = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSoundEffects = new System.Windows.Forms.CheckBox();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHiddenWord
            // 
            this.lblHiddenWord.AutoSize = true;
            this.lblHiddenWord.Font = new System.Drawing.Font("Courier New", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiddenWord.Location = new System.Drawing.Point(12, 89);
            this.lblHiddenWord.Name = "lblHiddenWord";
            this.lblHiddenWord.Size = new System.Drawing.Size(237, 37);
            this.lblHiddenWord.TabIndex = 0;
            this.lblHiddenWord.Text = "Hidden Word";
            // 
            // lblGuessALetter
            // 
            this.lblGuessALetter.AutoSize = true;
            this.lblGuessALetter.Location = new System.Drawing.Point(13, 143);
            this.lblGuessALetter.Name = "lblGuessALetter";
            this.lblGuessALetter.Size = new System.Drawing.Size(138, 25);
            this.lblGuessALetter.TabIndex = 1;
            this.lblGuessALetter.Text = "Guess a letter:";
            // 
            // lblNumberOfTries
            // 
            this.lblNumberOfTries.AutoSize = true;
            this.lblNumberOfTries.Location = new System.Drawing.Point(14, 200);
            this.lblNumberOfTries.Name = "lblNumberOfTries";
            this.lblNumberOfTries.Size = new System.Drawing.Size(149, 25);
            this.lblNumberOfTries.TabIndex = 2;
            this.lblNumberOfTries.Text = "Number of tries:";
            // 
            // txtLetterGuess
            // 
            this.txtLetterGuess.Location = new System.Drawing.Point(178, 145);
            this.txtLetterGuess.Name = "txtLetterGuess";
            this.txtLetterGuess.Size = new System.Drawing.Size(112, 29);
            this.txtLetterGuess.TabIndex = 3;
            // 
            // txtNumTries
            // 
            this.txtNumTries.Location = new System.Drawing.Point(178, 200);
            this.txtNumTries.Name = "txtNumTries";
            this.txtNumTries.ReadOnly = true;
            this.txtNumTries.Size = new System.Drawing.Size(112, 29);
            this.txtNumTries.TabIndex = 4;
            // 
            // lblLetters
            // 
            this.lblLetters.AutoSize = true;
            this.lblLetters.Location = new System.Drawing.Point(14, 299);
            this.lblLetters.Name = "lblLetters";
            this.lblLetters.Size = new System.Drawing.Size(125, 25);
            this.lblLetters.TabIndex = 5;
            this.lblLetters.Text = "Letters used:";
            // 
            // lblLettersUsed
            // 
            this.lblLettersUsed.AutoSize = true;
            this.lblLettersUsed.Font = new System.Drawing.Font("Courier New", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLettersUsed.Location = new System.Drawing.Point(145, 299);
            this.lblLettersUsed.Name = "lblLettersUsed";
            this.lblLettersUsed.Size = new System.Drawing.Size(237, 37);
            this.lblLettersUsed.TabIndex = 6;
            this.lblLettersUsed.Text = "abcdefghijk";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(340, 145);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(110, 52);
            this.btnGuess.TabIndex = 7;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(495, 146);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(92, 51);
            this.btnPlayAgain.TabIndex = 8;
            this.btnPlayAgain.Text = "Reset";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(335, 246);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(154, 25);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status Message";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(149, 30);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(298, 29);
            this.txtPlayerName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Player Name:";
            // 
            // chkSoundEffects
            // 
            this.chkSoundEffects.AutoSize = true;
            this.chkSoundEffects.Location = new System.Drawing.Point(476, 30);
            this.chkSoundEffects.Name = "chkSoundEffects";
            this.chkSoundEffects.Size = new System.Drawing.Size(160, 29);
            this.chkSoundEffects.TabIndex = 14;
            this.chkSoundEffects.Text = "Sound Effects";
            this.chkSoundEffects.UseVisualStyleBackColor = true;
            // 
            // lblDefinition
            // 
            this.lblDefinition.AutoSize = true;
            this.lblDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDefinition.Location = new System.Drawing.Point(13, 368);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(120, 29);
            this.lblDefinition.TabIndex = 15;
            this.lblDefinition.Text = "Definition:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 488);
            this.Controls.Add(this.lblDefinition);
            this.Controls.Add(this.chkSoundEffects);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblLettersUsed);
            this.Controls.Add(this.lblLetters);
            this.Controls.Add(this.txtNumTries);
            this.Controls.Add(this.txtLetterGuess);
            this.Controls.Add(this.lblNumberOfTries);
            this.Controls.Add(this.lblGuessALetter);
            this.Controls.Add(this.lblHiddenWord);
            this.Name = "FormMain";
            this.Text = "Guess A Word";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHiddenWord;
        private System.Windows.Forms.Label lblGuessALetter;
        private System.Windows.Forms.Label lblNumberOfTries;
        private System.Windows.Forms.TextBox txtLetterGuess;
        private System.Windows.Forms.TextBox txtNumTries;
        private System.Windows.Forms.Label lblLetters;
        private System.Windows.Forms.Label lblLettersUsed;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSoundEffects;
        private System.Windows.Forms.Label lblDefinition;
    }
}

