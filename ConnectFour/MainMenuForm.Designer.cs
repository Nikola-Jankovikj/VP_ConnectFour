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
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.nudCols = new System.Windows.Forms.NumericUpDown();
            this.lblNumRows = new System.Windows.Forms.Label();
            this.lblNumColumns = new System.Windows.Forms.Label();
            this.nudTurnTimeLimit = new System.Windows.Forms.NumericUpDown();
            this.cbHasTurnTimeLimit = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbPickOpponent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTurnTimeLimit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.welcomeLbl.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.welcomeLbl.Location = new System.Drawing.Point(68, 29);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(249, 19);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Welcome to Connect Four!";
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.IndianRed;
            this.startBtn.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startBtn.Location = new System.Drawing.Point(55, 367);
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
            this.gbPickOpponent.Location = new System.Drawing.Point(55, 71);
            this.gbPickOpponent.Name = "gbPickOpponent";
            this.gbPickOpponent.Size = new System.Drawing.Size(269, 74);
            this.gbPickOpponent.TabIndex = 2;
            this.gbPickOpponent.TabStop = false;
            this.gbPickOpponent.Text = "Pick Your Opponent";
            // 
            // rbPlayAgainstComputer
            // 
            this.rbPlayAgainstComputer.AutoSize = true;
            this.rbPlayAgainstComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlayAgainstComputer.Location = new System.Drawing.Point(7, 43);
            this.rbPlayAgainstComputer.Name = "rbPlayAgainstComputer";
            this.rbPlayAgainstComputer.Size = new System.Drawing.Size(161, 20);
            this.rbPlayAgainstComputer.TabIndex = 1;
            this.rbPlayAgainstComputer.TabStop = true;
            this.rbPlayAgainstComputer.Text = "Play Against Computer";
            this.rbPlayAgainstComputer.UseVisualStyleBackColor = true;
            // 
            // rbPlayAgainstFriend
            // 
            this.rbPlayAgainstFriend.AutoSize = true;
            this.rbPlayAgainstFriend.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbPlayAgainstFriend.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbPlayAgainstFriend.Location = new System.Drawing.Point(7, 20);
            this.rbPlayAgainstFriend.Name = "rbPlayAgainstFriend";
            this.rbPlayAgainstFriend.Size = new System.Drawing.Size(141, 20);
            this.rbPlayAgainstFriend.TabIndex = 0;
            this.rbPlayAgainstFriend.TabStop = true;
            this.rbPlayAgainstFriend.Text = "Play Against Friend";
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
            10,
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
            this.groupBox1.Location = new System.Drawing.Point(55, 169);
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
            this.groupBox2.Location = new System.Drawing.Point(55, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 68);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enable Time Limited Turns in Seconds";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 436);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPickOpponent);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.welcomeLbl);
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
    }
}

