using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubPractice
{
    public partial class Form1 : Form
    {
        string playerName;
        string dragonName;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text != "" && txtDragonName.Text != "")
            {
                playerName = txtPlayerName.Text;
                dragonName = txtDragonName.Text;

                rtbLog.Text = "Player Name: " + playerName + "\nDragon Name: " + dragonName;
            }
            else
            {
                rtbLog.Text = "You didn't enter anything and you die.";
                //Boy do I love having nothing with the same consistency as a my sandwich in my sandwich
            }
        }
    }
}
