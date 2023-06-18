
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTotalTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPlayerName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTurnTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tsslEmptySpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotalTime,
            this.tsslEmptySpace,
            this.tsslTurnTime,
            this.tsslPlayerName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTotalTime
            // 
            this.tsslTotalTime.Name = "tsslTotalTime";
            this.tsslTotalTime.Size = new System.Drawing.Size(118, 17);
            this.tsslTotalTime.Text = "toolStripStatusLabel1";
            // 
            // tsslPlayerName
            // 
            this.tsslPlayerName.Name = "tsslPlayerName";
            this.tsslPlayerName.Size = new System.Drawing.Size(118, 17);
            this.tsslPlayerName.Text = "toolStripStatusLabel1";
            // 
            // tsslTurnTime
            // 
            this.tsslTurnTime.Name = "tsslTurnTime";
            this.tsslTurnTime.Size = new System.Drawing.Size(118, 17);
            this.tsslTurnTime.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tsslEmptySpace
            // 
            this.tsslEmptySpace.Name = "tsslEmptySpace";
            this.tsslEmptySpace.Size = new System.Drawing.Size(400, 17);
            this.tsslEmptySpace.Spring = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameForm";
            this.Text = "Connect Four - Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseClick);
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
    }
}