using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{
    public partial class MainMenuForm : Form
    {
        public bool WithBot { get; set; }
        public static int Rows { get; set; }
        public static int Cols { get; set; }
        public int TurnTimeLimit { get; set; }
        public bool BotIsEasy { get; set; }

        public MainMenuForm()
        {
            InitializeComponent();
            WithBot = false;
            TurnTimeLimit = 0;
            rbPlayAgainstFriend.Checked = true;
        }

        private void cbHasTurnTimeLimit_CheckedChanged(object sender, EventArgs e)
        {
            nudTurnTimeLimit.Enabled = !nudTurnTimeLimit.Enabled;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            GetValues();
            this.Hide();
            var GameForm = new GameForm(WithBot, TurnTimeLimit, Rows, Cols, this, BotIsEasy);
            GameForm.Show();
        }

        private void GetValues()
        {
            if (rbPlayAgainstComputer.Checked) 
            { 
                WithBot = true;
                BotIsEasy = rbEasyBot.Checked;
            }
            else { WithBot = false; }
            Rows = (int)nudRows.Value;
            Cols = (int)nudCols.Value;
            if (cbHasTurnTimeLimit.Checked) { TurnTimeLimit = (int) nudTurnTimeLimit.Value; }
            else { TurnTimeLimit = 0; }
        }

        private void rbPlayAgainstComputer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPlayAgainstComputer.Checked)
            {
                rbEasyBot.Enabled = true;
                rbHardBot.Enabled = true;
            } else
            {
                rbEasyBot.Enabled = false;
                rbHardBot.Enabled = false;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string filePath = "../../help.txt";
            string fileContents = "";

            try
            {
                fileContents = File.ReadAllText(filePath);
            }
            catch (IOException exception)
            {
                Console.WriteLine("An error occurred while reading the file:");
                Console.WriteLine(exception.Message);
            }

            MessageBox.Show(fileContents, String.Format("How to Play?"), MessageBoxButtons.OK);
        }
    }
}
