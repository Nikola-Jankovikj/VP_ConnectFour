
namespace ConnectFour
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTotalTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEmptySpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTurnTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPlayerName = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotalTime,
            this.tsslEmptySpace,
            this.tsslTurnTime,
            this.tsslPlayerName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 531);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 23);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTotalTime
            // 
            this.tsslTotalTime.BackColor = System.Drawing.Color.Gold;
            this.tsslTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslTotalTime.ForeColor = System.Drawing.Color.Crimson;
            this.tsslTotalTime.Name = "tsslTotalTime";
            this.tsslTotalTime.Size = new System.Drawing.Size(164, 17);
            this.tsslTotalTime.Text = "toolStripStatusLabel1";
            // 
            // tsslEmptySpace
            // 
            this.tsslEmptySpace.BackColor = System.Drawing.Color.RoyalBlue;
            this.tsslEmptySpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslEmptySpace.Name = "tsslEmptySpace";
            this.tsslEmptySpace.Size = new System.Drawing.Size(719, 17);
            this.tsslEmptySpace.Spring = true;
            // 
            // tsslTurnTime
            // 
            this.tsslTurnTime.Name = "tsslTurnTime";
            this.tsslTurnTime.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslPlayerName
            // 
            this.tsslPlayerName.BackColor = System.Drawing.Color.Gold;
            this.tsslPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslPlayerName.ForeColor = System.Drawing.Color.Crimson;
            this.tsslPlayerName.Name = "tsslPlayerName";
            this.tsslPlayerName.Size = new System.Drawing.Size(164, 17);
            this.tsslPlayerName.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameForm";
            this.Text = "Connect Four - Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseMove);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalTime;
        private System.Windows.Forms.ToolStripStatusLabel tsslTurnTime;
        private System.Windows.Forms.ToolStripStatusLabel tsslPlayerName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel tsslEmptySpace;
        private System.Windows.Forms.Timer timer2;
    }
}