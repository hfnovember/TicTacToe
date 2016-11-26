using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTTNicos
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void exitButtonForm2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(GetRandomTaunt(), "Quit?!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes) Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            initialize();
            humanScoreLabel.Text = "0";
            computerScoreLabel.Text = "0";
            if (Program.isHard)
            {
                difficultyChange.Text = "Hard";
                difficultyChange.BackColor = Color.Red;
            } 
            else
            {
                difficultyChange.Text = "Easy";
                difficultyChange.BackColor = Color.Green;
            }
            roundNumber.Text = Program.roundNumber.ToString();
        }

        private bool checkWin(Player player)
        {
            //Horizontals
            if (Program.gameArray[0] == player.getSymbol() && Program.gameArray[1] == player.getSymbol() && Program.gameArray[2] == player.getSymbol()) return true;
            else if (Program.gameArray[3] == player.getSymbol() && Program.gameArray[4] == player.getSymbol() && Program.gameArray[5] == player.getSymbol()) return true;
            else if (Program.gameArray[6] == player.getSymbol() && Program.gameArray[7] == player.getSymbol() && Program.gameArray[8] == player.getSymbol()) return true;
            //Verticals
            else if (Program.gameArray[0] == player.getSymbol() && Program.gameArray[3] == player.getSymbol() && Program.gameArray[6] == player.getSymbol()) return true;
            else if (Program.gameArray[1] == player.getSymbol() && Program.gameArray[4] == player.getSymbol() && Program.gameArray[7] == player.getSymbol()) return true;
            else if (Program.gameArray[2] == player.getSymbol() && Program.gameArray[5] == player.getSymbol() && Program.gameArray[8] == player.getSymbol()) return true;
            //Diagonals
            else if (Program.gameArray[0] == player.getSymbol() && Program.gameArray[4] == player.getSymbol() && Program.gameArray[8] == player.getSymbol()) return true;
            else if (Program.gameArray[6] == player.getSymbol() && Program.gameArray[4] == player.getSymbol() && Program.gameArray[2] == player.getSymbol()) return true;
            //No Win
            else return false;
        }

        private bool checkFullBoard()
        {
            bool boardFilled = true;
            for (int i = 0; i < Program.gameSize; i++)
            {
                if (Program.gameArray[i] == " ")
                {
                    boardFilled = false;
                    break;
                }//end if
            }//end for
            return boardFilled;
        }

        /******************************************************************************/
        /****** BUTTONS ***************************************************************/

        private void position1_Click(object sender, EventArgs e)
        {
            if (position1.Text == " ")
            {
                position1.Text = Program.human.getSymbol();
                Program.gameArray[0] = Program.human.getSymbol();
                position1.ForeColor = Color.Cyan;
                if (checkWin(Program.human) || checkWin(Program.computer) || checkFullBoard())
                {
                    position1.Enabled = false;
                    position2.Enabled = false;
                    position3.Enabled = false;
                    position4.Enabled = false;
                    position5.Enabled = false;
                    position6.Enabled = false;
                    position7.Enabled = false;
                    position8.Enabled = false;
                    position9.Enabled = false;

                    if (checkWin(Program.human))
                    {
                        MessageBox.Show("Nicely done!", "You won!" );
                        int humanScore = Int32.Parse(humanScoreLabel.Text);
                        humanScore++;
                        humanScoreLabel.Text = humanScore.ToString();
                    }
                    else if (checkWin(Program.computer))
                    {
                        MessageBox.Show("Not good enough.", "You lost!");
                        int computerScore = Int32.Parse(computerScoreLabel.Text);
                        computerScore++;
                        computerScoreLabel.Text = computerScore.ToString();
                    }
                    else if (checkFullBoard())
                    {
                        MessageBox.Show("Stand down!", "Draw!");
                    }

                    playAgainButton.Visible = true;
                }
                else
                {
                    if (Program.isHard) computerMoveHard();
                    else computerMoveEasy();
                }
            }
        }

        private void position2_Click(object sender, EventArgs e)
        {
            if (position2.Text == " ")
            {
                position2.Text = Program.human.getSymbol();
                Program.gameArray[1] = Program.human.getSymbol();
                position2.ForeColor = Color.Cyan;
                if (checkWin(Program.human) || checkWin(Program.computer) || checkFullBoard())
                {
                    position1.Enabled = false;
                    position2.Enabled = false;
                    position3.Enabled = false;
                    position4.Enabled = false;
                    position5.Enabled = false;
                    position6.Enabled = false;
                    position7.Enabled = false;
                    position8.Enabled = false;
                    position9.Enabled = false;

                    if (checkWin(Program.human))
                    {
                        MessageBox.Show("Nicely done!", "You won!" );
                        int humanScore = Int32.Parse(humanScoreLabel.Text);
                        humanScore++;
                        humanScoreLabel.Text = humanScore.ToString();
                    }
                    else if (checkWin(Program.computer))
                    {
                        MessageBox.Show("Not good enough.", "You lost!");
                        int computerScore = Int32.Parse(computerScoreLabel.Text);
                        computerScore++;
                        computerScoreLabel.Text = computerScore.ToString();
                    }
                    else if (checkFullBoard())
                    {
                        MessageBox.Show("Stand down!", "Draw!");
                    }

                    playAgainButton.Visible = true;
                }
                else
                {
                    if (Program.isHard) computerMoveHard();
                    else computerMoveEasy();
                }
            }
        }

        private void position3_Click(object sender, EventArgs e)
        {
            if (position3.Text == " ")
            {
                position3.Text = Program.human.getSymbol();
                Program.gameArray[2] = Program.human.getSymbol();
                position3.ForeColor = Color.Cyan;
                if (checkWin(Program.human) || checkWin(Program.computer) || checkFullBoard())
                {
                    position1.Enabled = false;
                    position2.Enabled = false;
                    position3.Enabled = false;
                    position4.Enabled = false;
                    position5.Enabled = false;
                    position6.Enabled = false;
                    position7.Enabled = false;
                    position8.Enabled = false;
                    position9.Enabled = false;

                    if (checkWin(Program.human))
                    {
                        MessageBox.Show("Nicely done!", "You won!" );
                        int humanScore = Int32.Parse(humanScoreLabel.Text);
                        humanScore++;
                        humanScoreLabel.Text = humanScore.ToString();
                    }
                    else if (checkWin(Program.computer))
                    {
                        MessageBox.Show("Not good enough.", "You lost!");
                        int computerScore = Int32.Parse(computerScoreLabel.Text);
                        computerScore++;
                        computerScoreLabel.Text = computerScore.ToString();
                    }
                    else if (checkFullBoard())
                    {
                        MessageBox.Show("Stand down!", "Draw!");
                    }

                    playAgainButton.Visible = true;
                }
                else
                {
                    if (Program.isHard) computerMoveHard();
                    else computerMoveEasy();
                }
            }
        }

        private void position4_Click(object sender, EventArgs e)
        {
            if (position4.Text == " ")
            {
                position4.Text = Program.human.getSymbol();
                Program.gameArray[3] = Program.human.getSymbol();
                position4.ForeColor = Color.Cyan;
                if (checkWin(Program.human) || checkWin(Program.computer) || checkFullBoard())
                {
                    position1.Enabled = false;
                    position2.Enabled = false;
                    position3.Enabled = false;
                    position4.Enabled = false;
                    position5.Enabled = false;
                    position6.Enabled = false;
                    position7.Enabled = false;
                    position8.Enabled = false;
                    position9.Enabled = false;

                    if (checkWin(Program.human))
                    {
                        MessageBox.Show("Nicely done!", "You won!" );
                        int humanScore = Int32.Parse(humanScoreLabel.Text);
                        humanScore++;
                        humanScoreLabel.Text = humanScore.ToString();
                    }
                    else if (checkWin(Program.computer))
                    {
                        MessageBox.Show("Not good enough.", "You lost!");
                        int computerScore = Int32.Parse(computerScoreLabel.Text);
                        computerScore++;
                        computerScoreLabel.Text = computerScore.ToString();
                    }
                    else if (checkFullBoard())
                    {
                        MessageBox.Show("Stand down!", "Draw!");
                    }

                    playAgainButton.Visible = true;
                }
                else
                {
                    if (Program.isHard) computerMoveHard();
                    else computerMoveEasy();
                }
            }
        }

        private void position5_Click(object sender, EventArgs e)
        {
            if (position5.Text == " ")
            {
                position5.Text = Program.human.getSymbol();
                Program.gameArray[4] = Program.human.getSymbol();
                position5.ForeColor = Color.Cyan;
                if (checkWin(Program.human) || checkWin(Program.computer) || checkFullBoard())
                {
                    position1.Enabled = false;
                    position2.Enabled = false;
                    position3.Enabled = false;
                    position4.Enabled = false;
                    position5.Enabled = false;
                    position6.Enabled = false;
                    position7.Enabled = false;
                    position8.Enabled = false;
                    position9.Enabled = false;

                    if (checkWin(Program.human))
                    {
                        MessageBox.Show("Nicely done!", "You won!" );
                        int humanScore = Int32.Parse(humanScoreLabel.Text);
                        humanScore++;
                        humanScoreLabel.Text = humanScore.ToString();
                    }
                    else if (checkWin(Program.computer))
                    {
                        MessageBox.Show("Not good enough.", "You lost!");
                        int computerScore = Int32.Parse(computerScoreLabel.Text);
                        computerScore++;
                        computerScoreLabel.Text = computerScore.ToString();
                    }
                    else if (checkFullBoard())
                    {
                        MessageBox.Show("Stand down!", "Draw!");
                    }

                    playAgainButton.Visible = true;
                }
                else
                {
                    if (Program.isHard) computerMoveHard();
                    else computerMoveEasy();
                }
            }
        }

        private void position6_Click(object sender, EventArgs e)
        {
            if (position6.Text == " ")
            {
                position6.Text = Program.human.getSymbol();
                Program.gameArray[5] = Program.human.getSymbol();
                position6.ForeColor = Color.Cyan;
                if (checkWin(Program.human) || checkWin(Program.computer) || checkFullBoard())
                {
                    position1.Enabled = false;
                    position2.Enabled = false;
                    position3.Enabled = false;
                    position4.Enabled = false;
                    position5.Enabled = false;
                    position6.Enabled = false;
                    position7.Enabled = false;
                    position8.Enabled = false;
                    position9.Enabled = false;

                    if (checkWin(Program.human))
                    {
                        MessageBox.Show("Nicely done!", "You won!" );
                        int humanScore = Int32.Parse(humanScoreLabel.Text);
                        humanScore++;
                        humanScoreLabel.Text = humanScore.ToString();
                    }
                    else if (checkWin(Program.computer))
                    {
                        MessageBox.Show("Not good enough.", "You lost!");
                        int computerScore = Int32.Parse(computerScoreLabel.Text);
                        computerScore++;
                        computerScoreLabel.Text = computerScore.ToString();
                    }
                    else if (checkFullBoard())
                    {
                        MessageBox.Show("Stand down!", "Draw!");
                    }

                    playAgainButton.Visible = true;
                }
                else
                {
                    if (Program.isHard) computerMoveHard();
                    else computerMoveEasy();
                }
            }
        }

        private void position7_Click(object sender, EventArgs e)
        {
            if (position7.Text == " ")
            {
                position7.Text = Program.human.getSymbol();
                Program.gameArray[6] = Program.human.getSymbol();
                position7.ForeColor = Color.Cyan;
                if (checkWin(Program.human) || checkWin(Program.computer) || checkFullBoard())
                {
                    position1.Enabled = false;
                    position2.Enabled = false;
                    position3.Enabled = false;
                    position4.Enabled = false;
                    position5.Enabled = false;
                    position6.Enabled = false;
                    position7.Enabled = false;
                    position8.Enabled = false;
                    position9.Enabled = false;

                    if (checkWin(Program.human))
                    {
                        MessageBox.Show("Nicely done!", "You won!" );
                        int humanScore = Int32.Parse(humanScoreLabel.Text);
                        humanScore++;
                        humanScoreLabel.Text = humanScore.ToString();
                    }
                    else if (checkWin(Program.computer))
                    {
                        MessageBox.Show("Not good enough.", "You lost!");
                        int computerScore = Int32.Parse(computerScoreLabel.Text);
                        computerScore++;
                        computerScoreLabel.Text = computerScore.ToString();
                    }
                    else if (checkFullBoard())
                    {
                        MessageBox.Show("Stand down!", "Draw!");
                    }

                    playAgainButton.Visible = true;
                }
                else
                {
                    if (Program.isHard) computerMoveHard();
                    else computerMoveEasy();
                }
            }
        }

        private void position8_Click(object sender, EventArgs e)
        {
            if (position8.Text == " ")
            {
                position8.Text = Program.human.getSymbol();
                Program.gameArray[7] = Program.human.getSymbol();
                position8.ForeColor = Color.Cyan;
                if (checkWin(Program.human) || checkWin(Program.computer) || checkFullBoard())
                {
                    position1.Enabled = false;
                    position2.Enabled = false;
                    position3.Enabled = false;
                    position4.Enabled = false;
                    position5.Enabled = false;
                    position6.Enabled = false;
                    position7.Enabled = false;
                    position8.Enabled = false;
                    position9.Enabled = false;

                    if (checkWin(Program.human))
                    {
                        MessageBox.Show("Nicely done!", "You won!" );
                        int humanScore = Int32.Parse(humanScoreLabel.Text);
                        humanScore++;
                        humanScoreLabel.Text = humanScore.ToString();
                    }
                    else if (checkWin(Program.computer))
                    {
                        MessageBox.Show("Not good enough.", "You lost!");
                        int computerScore = Int32.Parse(computerScoreLabel.Text);
                        computerScore++;
                        computerScoreLabel.Text = computerScore.ToString();
                    }
                    else if (checkFullBoard())
                    {
                        MessageBox.Show("Stand down!", "Draw!");
                    }

                    playAgainButton.Visible = true;
                }
                else
                {
                    if (Program.isHard) computerMoveHard();
                    else computerMoveEasy();
                }
            }
        }

        private void position9_Click(object sender, EventArgs e)
        {
            if (position9.Text == " ")
            {
                position9.Text = Program.human.getSymbol();
                Program.gameArray[8] = Program.human.getSymbol();
                position9.ForeColor = Color.Cyan;
                if (checkWin(Program.human) || checkWin(Program.computer) || checkFullBoard())
                {
                    position1.Enabled = false;
                    position2.Enabled = false;
                    position3.Enabled = false;
                    position4.Enabled = false;
                    position5.Enabled = false;
                    position6.Enabled = false;
                    position7.Enabled = false;
                    position8.Enabled = false;
                    position9.Enabled = false;

                    if (checkWin(Program.human))
                    {
                        MessageBox.Show("Nicely done!", "You won!" );
                        int humanScore = Int32.Parse(humanScoreLabel.Text);
                        humanScore++;
                        humanScoreLabel.Text = humanScore.ToString();
                    }
                    else if (checkWin(Program.computer))
                    {
                        MessageBox.Show("Not good enough.", "You lost!");
                        int computerScore = Int32.Parse(computerScoreLabel.Text);
                        computerScore++;
                        computerScoreLabel.Text = computerScore.ToString();
                    }
                    else if (checkFullBoard())
                    {
                        MessageBox.Show("Stand down!", "Draw!");
                    }

                    playAgainButton.Visible = true;
                }
                else
                {
                    if (Program.isHard) computerMoveHard();
                    else computerMoveEasy();
                }
            }
        }


        /************************************************************************************************/

        private void computerMoveHard()
        {
            int[] convertedBoard = new int[Program.gameSize];
            int boardCount = 0;
            for (int i = 0; i < Program.gameSize; i++)
            {
                if (Program.gameArray[i] == Program.human.getSymbol()) convertedBoard[boardCount] = -1;
                else if (Program.gameArray[i] == Program.computer.getSymbol()) convertedBoard[boardCount] = 1;
                else convertedBoard[boardCount] = 0;
                boardCount++;
            }//end for

            int move = -1;
            int score = -2;
            for (int i = 0; i < Program.gameSize; ++i)
            {
                if (convertedBoard[i] == 0)
                {
                    convertedBoard[i] = 1;
                    int tempScore = -Minimax(convertedBoard, -1, Program.gameSize);
                    convertedBoard[i] = 0;
                    if (tempScore > score)
                    {
                        score = tempScore;
                        move = i;
                    }//end if
                }//end for
            }//end for

            convertedBoard[move] = 1;
            

            for (int i = 0; i < Program.gameSize; i++)
            {
                if (convertedBoard[i] == 1) Program.gameArray[i] = Program.computer.getSymbol();
                else if (convertedBoard[i] == -1) Program.gameArray[i] = Program.human.getSymbol();
                else Program.gameArray[i] = " ";
            }//end for

            updateButtons();

            if (checkWin(Program.human) || checkWin(Program.computer) || checkFullBoard())
            {
                position1.Enabled = false;
                position2.Enabled = false;
                position3.Enabled = false;
                position4.Enabled = false;
                position5.Enabled = false;
                position6.Enabled = false;
                position7.Enabled = false;
                position8.Enabled = false;
                position9.Enabled = false;

                if (checkWin(Program.human))
                {
                    MessageBox.Show("Nicely done!", "You won!" );
                    int humanScore = Int32.Parse(humanScoreLabel.Text);
                    humanScore++;
                    humanScoreLabel.Text = humanScore.ToString();
                }
                else if (checkWin(Program.computer))
                {
                    MessageBox.Show("Not good enough.", "You lost!");
                    int computerScore = Int32.Parse(computerScoreLabel.Text);
                    computerScore++;
                    computerScoreLabel.Text = computerScore.ToString();
                }
                else if (checkFullBoard())
                {
                    MessageBox.Show("Stand down!", "Draw!");
                }

                playAgainButton.Visible = true;
            }

        }//end computerMoveHard()

        private int WinnerPick(int[] convertedGameBoard, int cSize)
        {
            int[,] winCases = new int[8, 3] { 
		        { 0, 1, 2 },
		        { 3, 4, 5 },
		        { 6, 7, 8 },
		        { 0, 3, 6 },
		        { 1, 4, 7 }, 
		        { 2, 5, 8 },
		        { 0, 4, 8 },
		        { 2, 4, 6 }
	        };

            for (int i = 0; i < cSize - 1; ++i)
            {
                if (convertedGameBoard[winCases[i,0]] != 0 &&
                    convertedGameBoard[winCases[i,0]] == convertedGameBoard[winCases[i,1]] &&
                    convertedGameBoard[winCases[i,0]] == convertedGameBoard[winCases[i,2]])
                    return convertedGameBoard[winCases[i,2]];
            }//end for

            return 0;

        }//end winnerPick()

        private int Minimax(int[] convertedGameBoard, int player, int cSize)
        {
            int winPick = WinnerPick(convertedGameBoard, cSize);
            if (winPick != 0) return winPick * player;

            else
            {

                int move = -1;
                int score = -2;
                int i;
                for (i = 0; i < cSize; ++i)
                {
                    if (convertedGameBoard[i] == 0)
                    {
                        convertedGameBoard[i] = player;
                        int thisScore = -Minimax(convertedGameBoard, player * -1, cSize);
                        if (thisScore > score)
                        {
                            score = thisScore;
                            move = i;
                        }//end if new score > old score
                        convertedGameBoard[i] = 0;
                    }//end if legal
                }//end for

                if (move == -1) return 0;
                else return score;

            }//end if no winner
        }//end Minimax()

        private void initialize()
        {
            Program.InitializeArray(Program.gameArray);
            position1.Text = " ";
            position2.Text = " ";
            position3.Text = " ";
            position4.Text = " ";
            position5.Text = " ";
            position6.Text = " ";
            position7.Text = " ";
            position8.Text = " ";
            position9.Text = " ";
            position1.Enabled = true;
            position2.Enabled = true;
            position3.Enabled = true;
            position4.Enabled = true;
            position5.Enabled = true;
            position6.Enabled = true;
            position7.Enabled = true;
            position8.Enabled = true;
            position9.Enabled = true;
            position1.ForeColor = Color.Red;
            position2.ForeColor = Color.Red;
            position3.ForeColor = Color.Red;
            position4.ForeColor = Color.Red;
            position5.ForeColor = Color.Red;
            position6.ForeColor = Color.Red;
            position7.ForeColor = Color.Red;
            position8.ForeColor = Color.Red;
            position9.ForeColor = Color.Red;
            playAgainButton.Visible = false;

        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            initialize();
            Program.roundNumber++;
            roundNumber.Text = Program.roundNumber.ToString();
            playAgainButton.Visible = false;
        }


        private void computerMoveEasy()
        {
            int randomPosition;
            do
            {
                Random rnd = new Random();
                randomPosition = rnd.Next(0, 9);
            } while (Program.gameArray[randomPosition] != " ");

           if (Program.gameArray[randomPosition] == " ") Program.gameArray[randomPosition] = Program.computer.getSymbol();
           updateButtons();

            if (checkWin(Program.human) || checkWin(Program.computer) || checkFullBoard())
            {
                position1.Enabled = false;
                position2.Enabled = false;
                position3.Enabled = false;
                position4.Enabled = false;
                position5.Enabled = false;
                position6.Enabled = false;
                position7.Enabled = false;
                position8.Enabled = false;
                position9.Enabled = false;

                if (checkWin(Program.human))
                {
                    MessageBox.Show("Nicely done!", "You won!" );
                    int humanScore = Int32.Parse(humanScoreLabel.Text);
                    humanScore++;
                    humanScoreLabel.Text = humanScore.ToString();
                }
                else if (checkWin(Program.computer))
                {
                    MessageBox.Show("Not good enough.", "You lost!");
                    int computerScore = Int32.Parse(computerScoreLabel.Text);
                    computerScore++;
                    computerScoreLabel.Text = computerScore.ToString();
                }
                else if (checkFullBoard())
                {
                    MessageBox.Show("Stand down!", "Draw!");
                }

                playAgainButton.Visible = true;
            }

        }

        private void updateButtons()
        {
            position1.Text = Program.gameArray[0];
            position2.Text = Program.gameArray[1];
            position3.Text = Program.gameArray[2];
            position4.Text = Program.gameArray[3];
            position5.Text = Program.gameArray[4];
            position6.Text = Program.gameArray[5];
            position7.Text = Program.gameArray[6];
            position8.Text = Program.gameArray[7];
            position9.Text = Program.gameArray[8];
        }

        private void difficultyChange_Click(object sender, EventArgs e)
        {
            if (Program.isHard) Program.isHard = false;
            else Program.isHard = true;

            if (Program.isHard)
            {
                difficultyChange.Text = "Hard";
                difficultyChange.BackColor = Color.Red;
            }
            else
            {
                difficultyChange.Text = "Easy";
                difficultyChange.BackColor = Color.Green;
            }
        }

        private string GetRandomTaunt()
        {
            string[] taunts = new string [10];
            taunts[0] = "TOO SCARED TO GO ON...";
            taunts[1] = "RUNNING HOME TO MOMMA?";
            taunts[2] = "ARE YOU SURE? I WILL REALLY MISS YOU :'( ";
            taunts[3] = "ARE YOU REALLY A QUITTER?";
            taunts[4] = "I WOULDN'T LEAVE IF I WERE YOU... DOS IS MUCH WORSE!";
            taunts[5] = "RETIRING TOO SOON?";
            taunts[6] = "GO AHEAD AND LEAVE. SEE IF I CARE!";
            taunts[7] = "GET OUT OF HERE AND GO BACK TO YOUR BORING PROGRAMS...";
            taunts[8] = "WHEN YOU COME BACK, I WILL BE WAITING FOR YOU!";
            taunts[9] = "PUSS PUSS!";

            Random rnd = new Random();
            int random = rnd.Next(0, 10);
            return taunts[random];

        }//end getRandomTaunt()

    }//NAMESPACE
}//TTTNICOS