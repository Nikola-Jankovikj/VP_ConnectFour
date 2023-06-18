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
    public partial class MainMenuForm : Form
    {
        public bool WithBot { get; set; }
        public int Rows { get; set; }
        public int Cols { get; set; }
        public int TurnTimeLimit { get; set; }

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
            var GameForm = new GameForm(WithBot, TurnTimeLimit, Rows, Cols);
            GameForm.Closed += (s, args) => this.Close();
            GameForm.Show();
        }

        private void GetValues()
        {
            if (rbPlayAgainstComputer.Checked) { WithBot = true; }
            Rows = (int)nudRows.Value;
            Cols = (int)nudCols.Value;
            if (cbHasTurnTimeLimit.Checked) { TurnTimeLimit = (int) nudTurnTimeLimit.Value; }
        }
    }
}
