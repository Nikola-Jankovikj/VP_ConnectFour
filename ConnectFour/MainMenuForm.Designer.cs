namespace ConnectFour
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.gbPickOpponent = new System.Windows.Forms.GroupBox();
            this.rbPlayAgainstComputer = new System.Windows.Forms.RadioButton();
            this.rbPlayAgainstFriend = new System.Windows.Forms.RadioButton();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.nudCols = new System.Windows.Forms.NumericUpDown();
            this.lblNumRows = new System.Windows.Forms.Label();
            this.lblNumColumns = new System.Windows.Forms.Label();
            this.nudTurnTimeLimit = new System.Windows.Forms.NumericUpDown();
            this.cbHasTurnTimeLimit = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbDiff = new System.Windows.Forms.GroupBox();
            this.rbHardBot = new System.Windows.Forms.RadioButton();
            this.rbEasyBot = new System.Windows.Forms.RadioButton();
            this.btnHelp = new System.Windows.Forms.Button();
            this.gbPickOpponent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTurnTimeLimit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbDiff.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.welcomeLbl.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.welcomeLbl.Location = new System.Drawing.Point(69, 38);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(249, 19);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Welcome to Connect Four!";
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.IndianRed;
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startBtn.Location = new System.Drawing.Point(56, 372);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(269, 45);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start Game";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // gbPickOpponent
            // 
            this.gbPickOpponent.Controls.Add(this.rbPlayAgainstComputer);
            this.gbPickOpponent.Controls.Add(this.rbPlayAgainstFriend);
            this.gbPickOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPickOpponent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbPickOpponent.Location = new System.Drawing.Point(56, 78);
            this.gbPickOpponent.Name = "gbPickOpponent";
            this.gbPickOpponent.Size = new System.Drawing.Size(159, 74);
            this.gbPickOpponent.TabIndex = 2;
            this.gbPickOpponent.TabStop = false;
            this.gbPickOpponent.Text = "Pick Opponent";
            // 
            // rbPlayAgainstComputer
            // 
            this.rbPlayAgainstComputer.AutoSize = true;
            this.rbPlayAgainstComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlayAgainstComputer.Location = new System.Drawing.Point(7, 43);
            this.rbPlayAgainstComputer.Name = "rbPlayAgainstComputer";
            this.rbPlayAgainstComputer.Size = new System.Drawing.Size(100, 20);
            this.rbPlayAgainstComputer.TabIndex = 1;
            this.rbPlayAgainstComputer.TabStop = true;
            this.rbPlayAgainstComputer.Text = "vs Computer";
            this.rbPlayAgainstComputer.UseVisualStyleBackColor = true;
            this.rbPlayAgainstComputer.CheckedChanged += new System.EventHandler(this.rbPlayAgainstComputer_CheckedChanged);
            // 
            // rbPlayAgainstFriend
            // 
            this.rbPlayAgainstFriend.AutoSize = true;
            this.rbPlayAgainstFriend.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbPlayAgainstFriend.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbPlayAgainstFriend.Location = new System.Drawing.Point(7, 20);
            this.rbPlayAgainstFriend.Name = "rbPlayAgainstFriend";
            this.rbPlayAgainstFriend.Size = new System.Drawing.Size(80, 20);
            this.rbPlayAgainstFriend.TabIndex = 0;
            this.rbPlayAgainstFriend.TabStop = true;
            this.rbPlayAgainstFriend.Text = "vs Friend";
            this.rbPlayAgainstFriend.UseVisualStyleBackColor = true;
            // 
            // nudRows
            // 
            this.nudRows.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nudRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRows.ForeColor = System.Drawing.Color.IndianRed;
            this.nudRows.Location = new System.Drawing.Point(7, 50);
            this.nudRows.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudRows.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(120, 21);
            this.nudRows.TabIndex = 3;
            this.nudRows.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // nudCols
            // 
            this.nudCols.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nudCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCols.ForeColor = System.Drawing.Color.IndianRed;
            this.nudCols.Location = new System.Drawing.Point(142, 50);
            this.nudCols.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudCols.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCols.Name = "nudCols";
            this.nudCols.Size = new System.Drawing.Size(120, 21);
            this.nudCols.TabIndex = 4;
            this.nudCols.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // lblNumRows
            // 
            this.lblNumRows.AutoSize = true;
            this.lblNumRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRows.Location = new System.Drawing.Point(6, 31);
            this.lblNumRows.Name = "lblNumRows";
            this.lblNumRows.Size = new System.Drawing.Size(41, 16);
            this.lblNumRows.TabIndex = 5;
            this.lblNumRows.Text = "Rows";
            // 
            // lblNumColumns
            // 
            this.lblNumColumns.AutoSize = true;
            this.lblNumColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumColumns.Location = new System.Drawing.Point(139, 31);
            this.lblNumColumns.Name = "lblNumColumns";
            this.lblNumColumns.Size = new System.Drawing.Size(59, 16);
            this.lblNumColumns.TabIndex = 6;
            this.lblNumColumns.Text = "Columns";
            // 
            // nudTurnTimeLimit
            // 
            this.nudTurnTimeLimit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nudTurnTimeLimit.Enabled = false;
            this.nudTurnTimeLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTurnTimeLimit.ForeColor = System.Drawing.Color.IndianRed;
            this.nudTurnTimeLimit.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTurnTimeLimit.Location = new System.Drawing.Point(142, 31);
            this.nudTurnTimeLimit.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudTurnTimeLimit.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTurnTimeLimit.Name = "nudTurnTimeLimit";
            this.nudTurnTimeLimit.Size = new System.Drawing.Size(120, 21);
            this.nudTurnTimeLimit.TabIndex = 8;
            this.nudTurnTimeLimit.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cbHasTurnTimeLimit
            // 
            this.cbHasTurnTimeLimit.AutoSize = true;
            this.cbHasTurnTimeLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHasTurnTimeLimit.Location = new System.Drawing.Point(9, 32);
            this.cbHasTurnTimeLimit.Name = "cbHasTurnTimeLimit";
            this.cbHasTurnTimeLimit.Size = new System.Drawing.Size(107, 20);
            this.cbHasTurnTimeLimit.TabIndex = 9;
            this.cbHasTurnTimeLimit.Text = "Enable Timer";
            this.cbHasTurnTimeLimit.UseVisualStyleBackColor = true;
            this.cbHasTurnTimeLimit.CheckedChanged += new System.EventHandler(this.cbHasTurnTimeLimit_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudRows);
            this.groupBox1.Controls.Add(this.lblNumRows);
            this.groupBox1.Controls.Add(this.nudCols);
            this.groupBox1.Controls.Add(this.lblNumColumns);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(56, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 85);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Table Size";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbHasTurnTimeLimit);
            this.groupBox2.Controls.Add(this.nudTurnTimeLimit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(56, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 68);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enable Time Limited Turns in Seconds";
            // 
            // gbDiff
            // 
            this.gbDiff.Controls.Add(this.rbHardBot);
            this.gbDiff.Controls.Add(this.rbEasyBot);
            this.gbDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiff.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbDiff.Location = new System.Drawing.Point(221, 78);
            this.gbDiff.Name = "gbDiff";
            this.gbDiff.Size = new System.Drawing.Size(104, 74);
            this.gbDiff.TabIndex = 12;
            this.gbDiff.TabStop = false;
            this.gbDiff.Text = "Difficulty";
            // 
            // rbHardBot
            // 
            this.rbHardBot.AutoSize = true;
            this.rbHardBot.Enabled = false;
            this.rbHardBot.Location = new System.Drawing.Point(6, 43);
            this.rbHardBot.Name = "rbHardBot";
            this.rbHardBot.Size = new System.Drawing.Size(55, 20);
            this.rbHardBot.TabIndex = 1;
            this.rbHardBot.Text = "Hard";
            this.rbHardBot.UseVisualStyleBackColor = true;
            // 
            // rbEasyBot
            // 
            this.rbEasyBot.AutoSize = true;
            this.rbEasyBot.Checked = true;
            this.rbEasyBot.Enabled = false;
            this.rbEasyBot.Location = new System.Drawing.Point(6, 21);
            this.rbEasyBot.Name = "rbEasyBot";
            this.rbEasyBot.Size = new System.Drawing.Size(56, 20);
            this.rbEasyBot.TabIndex = 0;
            this.rbEasyBot.TabStop = true;
            this.rbEasyBot.Text = "Easy";
            this.rbEasyBot.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnHelp.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.IndianRed;
            this.btnHelp.Location = new System.Drawing.Point(3, 1);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(25, 24);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 444);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.gbDiff);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPickOpponent);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.welcomeLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.Text = "Connect Four - Main Menu";
            this.gbPickOpponent.ResumeLayout(false);
            this.gbPickOpponent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTurnTimeLimit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbDiff.ResumeLayout(false);
            this.gbDiff.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.GroupBox gbPickOpponent;
        private System.Windows.Forms.RadioButton rbPlayAgainstComputer;
        private System.Windows.Forms.RadioButton rbPlayAgainstFriend;
        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.NumericUpDown nudCols;
        private System.Windows.Forms.Label lblNumRows;
        private System.Windows.Forms.Label lblNumColumns;
        private System.Windows.Forms.NumericUpDown nudTurnTimeLimit;
        private System.Windows.Forms.CheckBox cbHasTurnTimeLimit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbDiff;
        private System.Windows.Forms.RadioButton rbHardBot;
        private System.Windows.Forms.RadioButton rbEasyBot;
        private System.Windows.Forms.Button btnHelp;
    }
}

