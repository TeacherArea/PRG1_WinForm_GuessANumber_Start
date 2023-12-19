namespace PRG1_GuessANumber_Start
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lbl_userGuess = new Label();
            Btn_Guess = new Button();
            txtB_UserGuess = new TextBox();
            dropDown_Difficulty = new ComboBox();
            lbl_Difficulty = new Label();
            listB_guesses = new ListBox();
            lbl_guesses = new Label();
            btn_Start = new Button();
            btn_PlayAgain = new Button();
            groupBox_Settings = new GroupBox();
            groupBox_Game = new GroupBox();
            txtB_Result = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox_Settings.SuspendLayout();
            groupBox_Game.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.wizard;
            pictureBox1.Location = new Point(588, 253);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(574, 18);
            label1.Name = "label1";
            label1.Size = new Size(186, 43);
            label1.TabIndex = 1;
            label1.Text = "Gissa ett tal!";
            // 
            // lbl_userGuess
            // 
            lbl_userGuess.AutoSize = true;
            lbl_userGuess.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_userGuess.Location = new Point(20, 28);
            lbl_userGuess.Name = "lbl_userGuess";
            lbl_userGuess.Size = new Size(67, 25);
            lbl_userGuess.TabIndex = 2;
            lbl_userGuess.Text = "Ditt tal:";
            // 
            // Btn_Guess
            // 
            Btn_Guess.BackColor = Color.FromArgb(110, 102, 205);
            Btn_Guess.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Guess.ForeColor = Color.White;
            Btn_Guess.Location = new Point(20, 73);
            Btn_Guess.Name = "Btn_Guess";
            Btn_Guess.Size = new Size(222, 50);
            Btn_Guess.TabIndex = 3;
            Btn_Guess.Text = "Gissa";
            Btn_Guess.UseVisualStyleBackColor = false;
            Btn_Guess.Click += Btn_Guess_Click;
            // 
            // txtB_UserGuess
            // 
            txtB_UserGuess.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_UserGuess.Location = new Point(135, 21);
            txtB_UserGuess.Name = "txtB_UserGuess";
            txtB_UserGuess.RightToLeft = RightToLeft.Yes;
            txtB_UserGuess.Size = new Size(107, 35);
            txtB_UserGuess.TabIndex = 4;
            txtB_UserGuess.TextChanged += txtB_UserGuess_TextChanged;
            // 
            // dropDown_Difficulty
            // 
            dropDown_Difficulty.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dropDown_Difficulty.ForeColor = Color.FromArgb(128, 128, 255);
            dropDown_Difficulty.FormattingEnabled = true;
            dropDown_Difficulty.Items.AddRange(new object[] { "10", "20", "50", "100" });
            dropDown_Difficulty.Location = new Point(16, 53);
            dropDown_Difficulty.Name = "dropDown_Difficulty";
            dropDown_Difficulty.RightToLeft = RightToLeft.No;
            dropDown_Difficulty.Size = new Size(222, 33);
            dropDown_Difficulty.TabIndex = 1;
            // 
            // lbl_Difficulty
            // 
            lbl_Difficulty.AutoSize = true;
            lbl_Difficulty.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Difficulty.Location = new Point(16, 20);
            lbl_Difficulty.Name = "lbl_Difficulty";
            lbl_Difficulty.Size = new Size(217, 25);
            lbl_Difficulty.TabIndex = 6;
            lbl_Difficulty.Text = "Svårighet (störst nummer)";
            // 
            // listB_guesses
            // 
            listB_guesses.FormattingEnabled = true;
            listB_guesses.ItemHeight = 15;
            listB_guesses.Location = new Point(20, 217);
            listB_guesses.Name = "listB_guesses";
            listB_guesses.Size = new Size(222, 184);
            listB_guesses.TabIndex = 7;
            // 
            // lbl_guesses
            // 
            lbl_guesses.AutoSize = true;
            lbl_guesses.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_guesses.Location = new Point(20, 186);
            lbl_guesses.Name = "lbl_guesses";
            lbl_guesses.Size = new Size(97, 25);
            lbl_guesses.TabIndex = 8;
            lbl_guesses.Text = "Gissningar";
            // 
            // btn_Start
            // 
            btn_Start.BackColor = Color.FromArgb(110, 102, 205);
            btn_Start.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Start.ForeColor = Color.White;
            btn_Start.Location = new Point(16, 118);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(222, 50);
            btn_Start.TabIndex = 2;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = false;
            btn_Start.Click += btn_Start_Click;
            // 
            // btn_PlayAgain
            // 
            btn_PlayAgain.BackColor = Color.FromArgb(110, 102, 205);
            btn_PlayAgain.Enabled = false;
            btn_PlayAgain.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_PlayAgain.ForeColor = Color.White;
            btn_PlayAgain.Location = new Point(16, 178);
            btn_PlayAgain.Name = "btn_PlayAgain";
            btn_PlayAgain.Size = new Size(222, 50);
            btn_PlayAgain.TabIndex = 11;
            btn_PlayAgain.Text = "Spela igen?";
            btn_PlayAgain.UseMnemonic = false;
            btn_PlayAgain.UseVisualStyleBackColor = false;
            btn_PlayAgain.Click += btn_PlayAgain_Click;
            // 
            // groupBox_Settings
            // 
            groupBox_Settings.Controls.Add(btn_Start);
            groupBox_Settings.Controls.Add(btn_PlayAgain);
            groupBox_Settings.Controls.Add(dropDown_Difficulty);
            groupBox_Settings.Controls.Add(lbl_Difficulty);
            groupBox_Settings.Location = new Point(302, 196);
            groupBox_Settings.Name = "groupBox_Settings";
            groupBox_Settings.Size = new Size(256, 242);
            groupBox_Settings.TabIndex = 12;
            groupBox_Settings.TabStop = false;
            groupBox_Settings.Text = "Inställningar";
            // 
            // groupBox_Game
            // 
            groupBox_Game.Controls.Add(txtB_Result);
            groupBox_Game.Controls.Add(lbl_userGuess);
            groupBox_Game.Controls.Add(Btn_Guess);
            groupBox_Game.Controls.Add(txtB_UserGuess);
            groupBox_Game.Controls.Add(lbl_guesses);
            groupBox_Game.Controls.Add(listB_guesses);
            groupBox_Game.Enabled = false;
            groupBox_Game.Location = new Point(12, 18);
            groupBox_Game.Name = "groupBox_Game";
            groupBox_Game.Size = new Size(263, 420);
            groupBox_Game.TabIndex = 13;
            groupBox_Game.TabStop = false;
            groupBox_Game.Text = "Spelet";
            // 
            // txtB_Result
            // 
            txtB_Result.BackColor = SystemColors.Control;
            txtB_Result.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_Result.ForeColor = Color.Black;
            txtB_Result.Location = new Point(20, 140);
            txtB_Result.Name = "txtB_Result";
            txtB_Result.Size = new Size(222, 29);
            txtB_Result.TabIndex = 10;
            txtB_Result.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 182, 253);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox_Game);
            Controls.Add(groupBox_Settings);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox_Settings.ResumeLayout(false);
            groupBox_Settings.PerformLayout();
            groupBox_Game.ResumeLayout(false);
            groupBox_Game.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label lbl_userGuess;
        private Button Btn_Guess;
        private TextBox txtB_UserGuess;
        private ComboBox dropDown_Difficulty;
        private Label lbl_Difficulty;
        private ListBox listB_guesses;
        private Label lbl_guesses;
        private Button btn_Start;
        private Button btn_PlayAgain;
        private GroupBox groupBox_Settings;
        private GroupBox groupBox_Game;
        private TextBox txtB_Result;
    }
}
