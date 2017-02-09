using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) {
            //StartGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private String button_click(object sender, EventArgs e) {
            ChoicePaper.Enabled = false;
            ChoiceRock.Enabled = false;
            ChoiceScissors.Enabled = false;
            String ChoicePlayer = "";

            Button button = (Button)sender;

            if (button == ChoiceRock) {
                ChoicePlayer = ChoiceRock.Text;
            } else if (button == ChoicePaper) {
                ChoicePlayer = ChoicePaper.Text;
            } else if (button == ChoiceScissors) {
                ChoicePlayer = ChoiceScissors.Text;
            } return ChoicePlayer;
        }
    }
}