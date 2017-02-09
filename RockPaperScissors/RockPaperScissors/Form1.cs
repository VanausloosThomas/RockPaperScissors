using RockPaperScissors.Source.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RockPaperScissors.Source.Domain;

namespace RockPaperScissors {

    public partial class Form1 : Form, IGameservice {

        public Form1() {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) {
            ChoicePaper.Enabled = true;
            ChoiceRock.Enabled = true;
            ChoiceScissors.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        public void DefaultStartUp() {
            buttonComputersChoice.Enabled = false;
            text_computer.Text = "Computer";
        }

        private void button_click(object sender, EventArgs e) {
            ChoicePaper.Enabled = false;
            ChoiceRock.Enabled = false;
            ChoiceScissors.Enabled = false;
            String ChoicePlayer = "";

            ComputerMakesMove();

            Button button = (Button)sender;

            if (button == ChoiceRock) {
                ChoicePlayer = ChoiceRock.Text;
                buttonPlayersChoice.Text = ChoiceRock.Text;
            } else if (button == ChoicePaper) {
                ChoicePlayer = ChoicePaper.Text;
                buttonPlayersChoice.Text = ChoicePaper.Text;
            } else if (button == ChoiceScissors) {
                ChoicePlayer = ChoiceScissors.Text;
                buttonPlayersChoice.Text = ChoiceScissors.Text;
            } 
        }

        public void ComputerMakesMove() {
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            DefaultStartUp();
        }

        private void CheckWinner() {
            
        }

        public Winner SinglePlayerGame(Hand hand) {
            throw new NotImplementedException();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Made by team (at least) one bridge to far ...\nSeppe, Steven, Thomas & Xan\nVersion 0.1", "About");
        }
    }
}