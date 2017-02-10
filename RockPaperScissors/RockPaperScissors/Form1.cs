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

    public partial class Form1 : Form {
        private GameService gameService = new GameService();

        public Form1() {
            InitializeComponent();
        }

        private void newSinglePlayerGameToolStripMenuItem_Click(object sender, EventArgs e) {
            InitializeSingePlayerGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void InitializeSingePlayerGame() {
            gameService.InitialiseSinglePlayerGame();
            Counters(0,0);
        }

        public void DefaultStartUp() {
            buttonComputersChoice.Enabled = false;
            text_computer.Text = "Computer";
        }

        private void button_click(object sender, EventArgs e) {
            DisableButtons();
            Button button = (Button)sender;
            CheckWinner(ref button);
            ResetButtons();
        }

        public void ResetButtons() {
            ChoicePaper.Enabled = true;
            ChoiceRock.Enabled = true;
            ChoiceScissors.Enabled = true;
            buttonComputersChoice.Text = "";
            buttonPlayersChoice.Text = "";
        }

        public void DisableButtons() {
            ChoicePaper.Enabled = false;
            ChoiceRock.Enabled = false;
            ChoiceScissors.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e) {
            DefaultStartUp();
            InitializeSingePlayerGame();
        }

        internal void CheckWinner(ref Button button) {
            var matchResult = gameService.PlayGame(DetermineHandChoice(button));
            buttonComputersChoice.Text = matchResult.OtherPlayerHand().ToString();
            Counters(matchResult.Player1GetScore(),matchResult.OtherPlayerGetScore());

            if (!matchResult.Draw) {
                MessageBox.Show(matchResult.WinnerName() + " won with " + matchResult.WinnerHand() + "!", matchResult.WinnerName() + " has won!");
            } else {
                MessageBox.Show("Draw! Try again!", "Draw!");
            }
        }

        private void Counters(int Player1Counter, int OtherPlayerCounter) {
            //count_draws.Text = //need to implement
            score_player.Text = Player1Counter.ToString();
            score_otherplayer.Text = OtherPlayerCounter.ToString();

        }

        private Hand DetermineHandChoice(Button button) {
            if (button == ChoicePaper) {
                buttonPlayersChoice.Text = ChoicePaper.Text;
                return Hand.Paper;
            } else if (button == ChoiceScissors) {
                buttonPlayersChoice.Text = ChoiceScissors.Text;
                return Hand.Scissors;
            }
            buttonPlayersChoice.Text = ChoiceRock.Text;
            return Hand.Rock;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {

            MessageBox.Show("Made by team (at least) one bridge to far ...\nSeppe, Steven, Thomas & Xan\nVersion 0.1", "About");
        }

        private void buttonComputersChoice_Click(object sender, EventArgs e) {
        }
    }
}