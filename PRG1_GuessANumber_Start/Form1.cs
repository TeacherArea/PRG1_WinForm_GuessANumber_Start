using System.Threading;

namespace PRG1_GuessANumber_Start
{
    public partial class Form1 : Form
    {
        int computerNo;
        int countGuesses;

        public Form1()
        {
            InitializeComponent();
            dropDown_Difficulty.SelectedItem = dropDown_Difficulty.Items[0];
            txtB_Result.Visible = false;
        }

        private async void Btn_Guess_Click(object sender, EventArgs e)
        {
            countGuesses++;
            txtB_Result.Visible = true;
            listB_guesses.Items.Add($"{countGuesses} försök");
            if (!int.TryParse(txtB_UserGuess.Text, out int correctGuess))
            {
                txtB_Result.Visible = false;
                MessageBox.Show("Vänligen skriv in ett heltal", "Fel!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (correctGuess == computerNo)
                {
                    txtB_Result.BackColor = Color.FromArgb(128, 255, 128);
                    txtB_Result.ForeColor = Color.White;
                    txtB_Result.Text = "VINST!";
                    lbl_userGuess.Text = "Datorns tal:";
                    groupBox_Game.Enabled = false;
                    btn_PlayAgain.Enabled = true;
                }
                else if (correctGuess < computerNo)
                {
                    txtB_Result.BackColor = Color.FromArgb(255, 128, 128);
                    txtB_Result.Text = "För lågt";
                }
                else
                {
                    txtB_Result.BackColor = Color.FromArgb(255, 128, 128);
                    txtB_Result.Text = "För högt";
                }
            }

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            dropDown_Difficulty.Enabled = false;
            int biggest = int.Parse(dropDown_Difficulty.SelectedItem.ToString());
            RandomNumber(biggest);
            btn_PlayAgain.Enabled = false;
            groupBox_Game.Enabled = true;
            countGuesses = 0;
            btn_Start.Enabled = false;
        }
        private void RandomNumber(int biggest)
        {
            Random random = new Random();
            computerNo = random.Next(0, biggest);
        }

        private void txtB_UserGuess_TextChanged(object sender, EventArgs e)
        {
            txtB_Result.Visible = false;
        }

        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Din tur att vara kreativ.\nLycka till!", "Fungerar inte",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
