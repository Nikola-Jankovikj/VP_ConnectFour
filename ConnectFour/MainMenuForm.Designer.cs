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
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.gbPickOpponent = new System.Windows.Forms.GroupBox();
            this.rbPlayAgainstComputer = new System.Windows.Forms.RadioButton();
            this.rbPlayAgainstFriend = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lblNumRows = new System.Windows.Forms.Label();
            this.lblNumColumns = new System.Windows.Forms.Label();
            this.nudTurnTimeLimit = new System.Windows.Forms.NumericUpDown();
            this.cbHasTurnTimeLimit = new System.Windows.Forms.CheckBox();
            this.gbPickOpponent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTurnTimeLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Location = new System.Drawing.Point(291, 86);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(134, 13);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Welcome to Connect Four!";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(309, 346);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(116, 45);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start Game";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // gbPickOpponent
            // 
            this.gbPickOpponent.Controls.Add(this.rbPlayAgainstComputer);
            this.gbPickOpponent.Controls.Add(this.rbPlayAgainstFriend);
            this.gbPickOpponent.Location = new System.Drawing.Point(238, 115);
            this.gbPickOpponent.Name = "gbPickOpponent";
            this.gbPickOpponent.Size = new System.Drawing.Size(252, 74);
            this.gbPickOpponent.TabIndex = 2;
            this.gbPickOpponent.TabStop = false;
            this.gbPickOpponent.Text = "Pick Opponent";
            // 
            // rbPlayAgainstComputer
            // 
            this.rbPlayAgainstComputer.AutoSize = true;
            this.rbPlayAgainstComputer.Location = new System.Drawing.Point(7, 43);
            this.rbPlayAgainstComputer.Name = "rbPlayAgainstComputer";
            this.rbPlayAgainstComputer.Size = new System.Drawing.Size(131, 17);
            this.rbPlayAgainstComputer.TabIndex = 1;
            this.rbPlayAgainstComputer.TabStop = true;
            this.rbPlayAgainstComputer.Text = "Play Against Computer";
            this.rbPlayAgainstComputer.UseVisualStyleBackColor = true;
            // 
            // rbPlayAgainstFriend
            // 
            this.rbPlayAgainstFriend.AutoSize = true;
            this.rbPlayAgainstFriend.Location = new System.Drawing.Point(7, 20);
            this.rbPlayAgainstFriend.Name = "rbPlayAgainstFriend";
            this.rbPlayAgainstFriend.Size = new System.Drawing.Size(115, 17);
            this.rbPlayAgainstFriend.TabIndex = 0;
            this.rbPlayAgainstFriend.TabStop = true;
            this.rbPlayAgainstFriend.Text = "Play Against Friend";
            this.rbPlayAgainstFriend.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(238, 225);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(370, 225);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblNumRows
            // 
            this.lblNumRows.AutoSize = true;
            this.lblNumRows.Location = new System.Drawing.Point(238, 206);
            this.lblNumRows.Name = "lblNumRows";
            this.lblNumRows.Size = new System.Drawing.Size(34, 13);
            this.lblNumRows.TabIndex = 5;
            this.lblNumRows.Text = "Rows";
            // 
            // lblNumColumns
            // 
            this.lblNumColumns.AutoSize = true;
            this.lblNumColumns.Location = new System.Drawing.Point(367, 209);
            this.lblNumColumns.Name = "lblNumColumns";
            this.lblNumColumns.Size = new System.Drawing.Size(47, 13);
            this.lblNumColumns.TabIndex = 6;
            this.lblNumColumns.Text = "Columns";
            // 
            // nudTurnTimeLimit
            // 
            this.nudTurnTimeLimit.Enabled = false;
            this.nudTurnTimeLimit.Location = new System.Drawing.Point(370, 294);
            this.nudTurnTimeLimit.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudTurnTimeLimit.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTurnTimeLimit.Name = "nudTurnTimeLimit";
            this.nudTurnTimeLimit.Size = new System.Drawing.Size(120, 20);
            this.nudTurnTimeLimit.TabIndex = 8;
            this.nudTurnTimeLimit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTurnTimeLimit.ValueChanged += new System.EventHandler(this.nudTimeLimit_ValueChanged);
            // 
            // cbHasTurnTimeLimit
            // 
            this.cbHasTurnTimeLimit.AutoSize = true;
            this.cbHasTurnTimeLimit.Location = new System.Drawing.Point(238, 294);
            this.cbHasTurnTimeLimit.Name = "cbHasTurnTimeLimit";
            this.cbHasTurnTimeLimit.Size = new System.Drawing.Size(122, 17);
            this.cbHasTurnTimeLimit.TabIndex = 9;
            this.cbHasTurnTimeLimit.Text = "Enable turn time limit";
            this.cbHasTurnTimeLimit.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbHasTurnTimeLimit);
            this.Controls.Add(this.nudTurnTimeLimit);
            this.Controls.Add(this.lblNumColumns);
            this.Controls.Add(this.lblNumRows);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.gbPickOpponent);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.welcomeLbl);
            this.Name = "MainMenuForm";
            this.Text = "Connect Four - Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.gbPickOpponent.ResumeLayout(false);
            this.gbPickOpponent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTurnTimeLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.GroupBox gbPickOpponent;
        private System.Windows.Forms.RadioButton rbPlayAgainstComputer;
        private System.Windows.Forms.RadioButton rbPlayAgainstFriend;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lblNumRows;
        private System.Windows.Forms.Label lblNumColumns;
        private System.Windows.Forms.NumericUpDown nudTurnTimeLimit;
        private System.Windows.Forms.CheckBox cbHasTurnTimeLimit;
    }
}

