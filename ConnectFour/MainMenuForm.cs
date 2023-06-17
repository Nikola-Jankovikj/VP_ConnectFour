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
    public partial class MainMenuForm : Form
    {
       
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void nudTimeLimit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var GameForm = new GameForm(true, 15, 8, 10);
            GameForm.Closed += (s, args) => this.Close();
            GameForm.Show();
        }
    }
}
