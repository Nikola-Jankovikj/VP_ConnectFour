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
        MainMenuForm parent;
        public GameForm(bool withBot, int turnTimeLimit, int rows, int cols, MainMenuForm parent)
        {
            InitializeComponent();
            this.parent = parent;

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
                timer2.Start();
                hasTurnTimeLimit = true;
                formatTurnTimeText();
            }
            tsslEmptySpace.Text = String.Empty;
            tsslPlayerName.Text = calculatePlayer();
            formatDefaultText();
            changeStyle();
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
                CheckWinner();
                tsslPlayerName.Text = calculatePlayer();
                changeStyle();
                if (withBot)
                {
                    Invalidate();
                    scene.AddCircle(new Point(0, 0));
                    tsslPlayerName.Text = calculatePlayer();
                    changeStyle();
                    Invalidate();
                    CheckWinner();
                }
            }
        }

        private void CheckWinner()
        {
            if (scene.DidPlayerWin())
            {
                timer1.Stop();
                timer2.Stop();
                ShowPlayerWonDialog();
            }
            else if (scene.IsTableFull())
            {
                timer1.Stop();
                timer2.Stop();
                ShowGameFinishedWithDrawDialog();
            }
            else if (hasTurnTimeLimit)
            {
                ResetTurnTimer();
            }
        }

        private void ResetTurnTimer()
        {
            timer2.Stop();
            timer2.Start();
            turnTimeTicks = turnTimeLimit;
            formatTurnTimeText();
        }

        private void ShowGameFinishedWithDrawDialog()
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to play again?", "Draw", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GameForm newForm = new GameForm(withBot, turnTimeLimit, rows, columns, parent);
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
                GameForm newForm = new GameForm(withBot, turnTimeLimit, rows, columns, parent);
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

        private void changeStyle()
        {
            if (calculatePlayer() == "Player 1")
            {
                tsslPlayerName.ForeColor = Color.Crimson;
                tsslPlayerName.BackColor = Color.Gold;
                tsslTotalTime.ForeColor = Color.Crimson;
                tsslTotalTime.BackColor = Color.Gold;
                tsslTurnTime.ForeColor = Color.Crimson;
                tsslTurnTime.BackColor = Color.Gold;
            }
            else
            {
                tsslPlayerName.BackColor = Color.Crimson;
                tsslPlayerName.ForeColor = Color.Gold;
                tsslTotalTime.BackColor = Color.Crimson;
                tsslTotalTime.ForeColor = Color.Gold;
                tsslTurnTime.BackColor = Color.Crimson;
                tsslTurnTime.ForeColor = Color.Gold;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            totalTimeTicks++;
            tsslTotalTime.Text = formatTimeToText(totalTimeTicks);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (hasTurnTimeLimit)
            {
                turnTimeTicks--;
                if (turnTimeTicks == 0)
                {
                    scene.turnTimeEnded();
                    tsslPlayerName.Text = calculatePlayer();
                    changeStyle();
                    turnTimeTicks = turnTimeLimit;
                    if (withBot)
                    {
                        scene.AddCircle(new Point(0, 0));
                        Invalidate();
                        CheckWinner();
                    }
                }
                formatTurnTimeText();
            }
            else
            {
                tsslTurnTime.Text = String.Empty;
            }
        }

        private string formatTimeToText(int time)
        {
            int minutes = time / 60;
            int seconds = time - minutes * 60;
            return String.Format("{0}:{1}", minutes.ToString("D2"), seconds.ToString("D2"));
        }

        private void formatTurnTimeText()
        {
            tsslTurnTime.Text = "Turn timer: " + turnTimeTicks.ToString() + "s  | ";
            tsslTurnTime.Font = new Font("Unispace", 8);
        }

        private void formatDefaultText()
        {
            tsslPlayerName.Font = new Font("Unispace", 8);
            tsslTotalTime.Font = new Font("Unispace", 8);
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
