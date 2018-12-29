using System;
using System.Windows.Forms;

namespace M.El_Haj___TicTacToe
{
    public partial class TicTacToe : Form
    {
        enum PlayerTurn { None, Player1, Player2 };
        enum Winner { None, Player1, Player2, Draw };

        PlayerTurn turn;
        Winner winner;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            OnNewGame();
        }

        void OnNewGame()
        {
            PictureBox[] allPictures = {
                                         pictureBox0,
                                         pictureBox1,
                                         pictureBox2,
                                         pictureBox3,
                                         pictureBox4,
                                         pictureBox5,
                                         pictureBox6,
                                         pictureBox7,
                                         pictureBox8
                                         };

            //Clear all gameboard cells
            foreach (var p in allPictures)
                p.Image = null;

            turn = PlayerTurn.Player1;
            winner = Winner.None;
            ShowTurn();
        }

        void ShowTurn()
        {
            string status = "";
            string msg = "";

            switch (winner)
            {
                case Winner.None:
                    if (turn == PlayerTurn.Player1)
                        status = "Turn: Player1";
                    else
                        status = "Turn: Player2";
                    break;
                case Winner.Player1:
                    msg = status = "Player1 Wins!";
                    break;
                case Winner.Player2:
                    msg = status = "Player2 Wins!";
                    break;
                case Winner.Draw:
                    status = "Well, no one wins this time!";
                    break;
            }
            lblStatus.Text = status;

            if (msg != "")
                MessageBox.Show(msg, "Winner!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            MessageBox.Show(p.Name);

            //If cell has pic, do nothing
            if (p.Image != null)
                return; 

            //If Player1 & Player2 cannot make new moves, game ends
            if (turn == PlayerTurn.None)
                return;

            //Image is set after all code Method has been executed <- image is a Variable, so it's value can change during execution of Method parts 
            if (turn == PlayerTurn.Player1)
                p.Image = player1.Image;
            else
                p.Image = player2.Image;

            //Check for a winner after every Click
            winner = GetWinner();
            if (winner == Winner.None)
            {
                //Change turns
                //If PlayerTurn.Player1 == turn is T -> set P2 turn, if F -> set P1 turn
                turn = (PlayerTurn.Player1 == turn) ? PlayerTurn.Player2 : PlayerTurn.Player1;
            }
            else
            {
                turn = PlayerTurn.None;
            }

            ShowTurn();
        }

        //Logic for Winner
        //It can have 4 results = value returned: P1, P2, Draw & None 
        //Results are made upon conditions
        //Conditions are not checked within 1 large if-else structure
        //Instead every condition can have it's own smaller logic. And checking of conditions is subsiquent when Method code runs
        //Also order of checking of those conditions is important & influences game flow
        //If condition is met, return sets result value - that is passed by GetWinner()
        Winner GetWinner()
        {
            //Dictionary & element order = key to logic of checking of Winner
            //To win in Tic Tac Toe same pic must be in specific order
            //This order is represented in order of values in Dictionary - so this already provides needed logic
            //Then, cause 3 same elements must be in given order, just 1 condition to check all rows & columns & diagonals is enough
            PictureBox[] allWinningMoves = {
                                         //Check each row
                                         pictureBox0, pictureBox1, pictureBox2,
                                         pictureBox3, pictureBox4, pictureBox5,
                                         pictureBox6, pictureBox7, pictureBox8,
                                         //Check each column
                                         pictureBox0, pictureBox3, pictureBox6,
                                         pictureBox1, pictureBox4, pictureBox7,
                                         pictureBox2, pictureBox5, pictureBox8,
                                         //Check diagonals
                                         pictureBox0, pictureBox4, pictureBox8,
                                         pictureBox2, pictureBox4, pictureBox6,
                                        };

            //i=0 - cause index starts at 0, but .Length starts at 1 - so last value in index < max value of .Length
            for (int i=0; i < allWinningMoves.Length; i+=3)
            {
                if (allWinningMoves[i].Image != null)
                {
                    //Check rows & columns & diagonals
                    if (allWinningMoves[i].Image == allWinningMoves[i+1].Image && allWinningMoves[i].Image == allWinningMoves[i+2].Image)
                    {
                        //We have a winner
                        if (allWinningMoves[i].Image == player1.Image)
                            return Winner.Player1;
                        else
                            return Winner.Player2;
                    }
                }
            }

            //Check all empty cells
            //-> The game continues if there is at least 1 empty cell
            PictureBox[] allPictures = { pictureBox0,
                                         pictureBox1,
                                         pictureBox2,
                                         pictureBox3,
                                         pictureBox4,
                                         pictureBox5,
                                         pictureBox6,
                                         pictureBox7,
                                         pictureBox8
                                        };
            //Clear all gameboard cells
            foreach (var p in allPictures)
                if (p.Image == null)
                    return Winner.None;

            //It's a draw
            return Winner.Draw;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to start a new game?",
                                         "New Game",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);       
            
            if (result == DialogResult.Yes)
                OnNewGame();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit now?",
                                         "Exit",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question
                                        );
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
