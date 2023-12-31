﻿using System;
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
        bool botIsEasy;
        MainMenuForm parent;
        public GameForm(bool withBot, int turnTimeLimit, int rows, int cols, MainMenuForm parent, bool botIsEasy)
        {
            InitializeComponent();

            this.withBot = withBot;
            this.turnTimeLimit = turnTimeLimit;            
            this.rows = rows;
            this.columns = cols;
            this.Width = cols*(2 * Circle.Radius + 2 * Scene.DistanceBetweenCircles) + 15;
            this.Height = rows*(2 * Circle.Radius + 2 * Scene.DistanceBetweenCircles) + 60;
            this.parent = parent;
            this.botIsEasy = botIsEasy;
            scene = new Scene(rows, cols, withBot, botIsEasy);
            DoubleBuffered = true;
            totalTimeTicks = 0;
            turnTimeTicks = turnTimeLimit;
            timer1.Start();
            Invalidate();
            if (turnTimeLimit == 0)
            {
                hasTurnTimeLimit = false;
            }
            else
            {
                timer2.Start();
                hasTurnTimeLimit = true;
                FormatTurnTimeText();
            }
            tsslEmptySpace.Text = String.Empty;
            tsslPlayerName.Text = CalculatePlayer();
            ChangeStyle();
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
                if (CheckWinner()) { return; }
                tsslPlayerName.Text = CalculatePlayer();
                ChangeStyle();
                if (withBot)
                {
                    tsslTurnTime.Text = "";
                    var t = Task.Delay(1000);
                    t.Wait();
                    scene.AddCircle(new Point(0, 0));
                    Invalidate();
                    CheckWinner();
                    tsslPlayerName.Text = CalculatePlayer();
                    ChangeStyle();
                }
            }
        }


        private bool CheckWinner()
        {
            if (scene.DidPlayerWin())
            {
                timer1.Stop();
                timer2.Stop();
                ShowPlayerWonDialog();
                return true;
            }
            else if (scene.IsTableFull())
            {
                timer1.Stop();
                timer2.Stop();
                ShowGameFinishedWithDrawDialog();
                return true;
            }
            else if (hasTurnTimeLimit)
            {
                ResetTurnTimer();
                return false;
            }
            return false;
        }


        private void ResetTurnTimer()
        {
            timer2.Stop();
            timer2.Start();
            turnTimeTicks = turnTimeLimit;
            FormatTurnTimeText();
        }


        private void ShowGameFinishedWithDrawDialog()
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to play again?", "Draw", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GameForm newForm = new GameForm(withBot, turnTimeLimit, rows, columns, parent, botIsEasy);
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
            string player = CalculatePlayer();
            DialogResult dialogResult = MessageBox.Show("Would you like to play again?", String.Format("{0} wins!", player), MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GameForm newForm = new GameForm(withBot, turnTimeLimit, rows, columns, parent, botIsEasy);
                newForm.Show();
                this.Dispose(false);
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }


        private string CalculatePlayer()
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


        private void ChangeStyle()
        {
            if (!scene.IsPlayerOne)
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
            tsslTotalTime.Text = FormatTimeToText(totalTimeTicks);
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (hasTurnTimeLimit)
            {
                turnTimeTicks--;
                if (turnTimeTicks == 0)
                {
                    scene.turnTimeEnded();
                    tsslPlayerName.Text = CalculatePlayer();
                    ChangeStyle();
                    turnTimeTicks = turnTimeLimit;
                    if (withBot)
                    {
                        tsslTurnTime.Text = "";
                        var t = Task.Delay(1000);
                        t.Wait();
                        scene.AddCircle(new Point(0, 0));
                        Invalidate();
                        CheckWinner();
                        tsslPlayerName.Text = CalculatePlayer();
                        ChangeStyle();
                    }
                }
                FormatTurnTimeText();
            }
            else
            {
                tsslTurnTime.Text = String.Empty;
            }
        }


        private string FormatTimeToText(int time)
        {
            int minutes = time / 60;
            int seconds = time - minutes * 60;
            return String.Format("{0}:{1}", minutes.ToString("D2"), seconds.ToString("D2"));
        }


        private void FormatTurnTimeText()
        {
            tsslTurnTime.Text = "Turn timer: " + turnTimeTicks.ToString() + "s   | ";
            tsslTurnTime.Font = new Font("Bahnschrift SemiBold", 9);
        }


        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }


        private void GameForm_MouseMove(object sender, MouseEventArgs e)
        {
            scene.MarkInHovered(e.Location);
            Invalidate();
        }
    }
}
