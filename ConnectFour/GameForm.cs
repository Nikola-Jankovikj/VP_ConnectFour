using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{
    public partial class GameForm : Form
    {
        Scene scene;
        int turnTimeLimit;
        int totalTimeTicks;
        int turnTimeTicks;
        int rows;
        int columns;
        bool withBot;
        bool hasTurnTimeLimit;
        public GameForm(bool withBot, int turnTimeLimit, int rows, int cols)
        {
            InitializeComponent();
            this.withBot = withBot;
            this.rows = rows;
            this.columns = cols;
            this.Width = cols*(2 * Circle.Radius + 2 * Scene.DistanceBetweenCircles) + 15;
            this.Height = rows*(2 * Circle.Radius + 2 * Scene.DistanceBetweenCircles) + 60;
            scene = new Scene(rows, cols, withBot);
            DoubleBuffered = true;
            this.turnTimeLimit = turnTimeLimit;
            timer1.Start();
            totalTimeTicks = 0;
            turnTimeTicks = turnTimeLimit;
            Invalidate();
            tsslTotalTime.Text = "00:00";
            if (turnTimeLimit == 0)
            {
                hasTurnTimeLimit = false;
            }
            else
            {
                hasTurnTimeLimit = true;
                tsslTurnTime.Text = turnTimeTicks.ToString();
            }
            tsslEmptySpace.Text = String.Empty;
            tsslPlayerName.Text = calculatePlayer();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void GameForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && scene.AddCircle(e.Location))
            {
                Invalidate();
                if (scene.DidPlayerWin())
                {
                    ShowPlayerWonDialog();
                }
                else if (scene.IsTableFull())
                {
                    ShowGameFinishedWithDrawDialog();
                }
                else if (hasTurnTimeLimit)
                {
                    turnTimeTicks = turnTimeLimit;
                }   
            }
        }

        private void ShowGameFinishedWithDrawDialog()
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to play again?", "Draw", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GameForm newForm = new GameForm(withBot, turnTimeLimit, rows, columns);
                newForm.Show();
                this.Dispose(true);
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }

        private void ShowPlayerWonDialog()
        {
            string player = calculatePlayer();
            DialogResult dialogResult = MessageBox.Show("Would you like to play again?", String.Format("{0} wins!", player), MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GameForm newForm = new GameForm(withBot, turnTimeLimit, rows, columns);
                newForm.Show();
                this.Dispose(false);
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }

        private string calculatePlayer()
        {
            string player;
            if (scene.IsPlayerOne)
            {
                player = "Player 1";
            }
            else
            {
                if (scene.WithBot)
                {
                    player = "The Computer";
                }
                else
                {
                    player = "Player 2";
                }
            }

            return player;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            totalTimeTicks++;
            if (hasTurnTimeLimit)
            {
                turnTimeTicks--;
                if (turnTimeTicks == 0)
                {
                    scene.turnTimeEnded();
                    turnTimeTicks = turnTimeLimit;
                }
                tsslTurnTime.Text = turnTimeTicks.ToString();
            }
            tsslTotalTime.Text = formatTimeToText(totalTimeTicks);
        }

        private string formatTimeToText(int time)
        {
            int minutes = time / 60;
            int seconds = time - minutes * 60;
            return String.Format("{0}:{1}", minutes.ToString("D2"), seconds.ToString("D2"));
        }

        private void GameForm_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
