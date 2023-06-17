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
        public GameForm(bool withBot, int turnTimeLimit, int rows, int cols)
        {
            InitializeComponent();
            this.Width = cols * 50;
            this.Height = rows * 50 + 20;
            scene = new Scene(rows, cols, withBot);
            DoubleBuffered = true;
            this.turnTimeLimit = turnTimeLimit;
            timer1.Start();
            totalTimeTicks = 0;
            turnTimeTicks = 0;
            Invalidate();
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
            // Check if circle is added
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
