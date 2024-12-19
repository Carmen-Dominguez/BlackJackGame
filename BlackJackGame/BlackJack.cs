using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlackJackGame
{
    public partial class BlackJack : Form
    {
        public BlackJack()
        {
            InitializeComponent();
        }
  
        private int scoreDealer = 0;
        private int dealerPlace = 0;
        private int scorePlayer = 0;
        private int playerPlace = 0;
        private int wins = 0;
        private int loss = 0;
        private int ties = 0;
        private bool playBust = false;
        private bool dealBust = false;

        //The Hit method, will do what happens when one clicks the Hit button
        public void Hit()
        {
            Image pic;
            Card Card = new Card();
            int ranNum = Card.randomCard();
            Card = Card.getCard(ranNum);
            PictureBox[] picArray = new PictureBox[5];

            picArray[2] = picBox3;
            picArray[3] = picBox4;
            picArray[4] = picBox5;

            if (playerPlace <= 4)
            {              
                //Picture
                picArray[playerPlace].Visible = true;
                pic = Card.CardIm;
                picArray[playerPlace].Image = pic;
                scorePlayer = Ace(getPlayScore(Card.Score), ranNum);

                //Score                              
                PlayScoreLbl.Text = "Score: " + scorePlayer;
                ranNum = Card.randomCard();

                ranNum = Card.randomCard();
                Card = Card.getCard(ranNum);
                playerPlace++;
            }
            else
            {
                Stand();
                Compare();
            }

        }

        //The Stand method will commence the Dealer's play time
        public void Stand()
        {
            HitBtn.Enabled = false;
            StandBtn.Enabled = false;
            DealBtn.Enabled = true;
            Image pic;
            Card Card = new Card();
            int ranNum;
            PictureBox[] picArray = new PictureBox[5];

            picArray[1] = picBox7;
            picArray[2] = picBox8;
            picArray[3] = picBox9;
            picArray[4] = picBox10;

            ranNum = Card.randomCard();
            Card = Card.getCard(ranNum);
            while (scoreDealer < 17)
            {
                if (dealerPlace <= 4)
                {                    
                    //Picture
                    picArray[dealerPlace].Visible = true;
                    pic = Card.CardIm;
                    picArray[dealerPlace].Image = pic;
                    scoreDealer = Ace(getDealScore(Card.Score), ranNum);

                    //Score                              
                    DealScoreLbl.Text = "Score: " + scoreDealer;
                    ranNum = Card.randomCard();

                    ranNum = Card.randomCard();
                    Card = Card.getCard(ranNum);
                    dealerPlace++;
                }
            }
        }

        //The Hand method will deal out a new hand to the Player and Dealer
        public void Hand()
        {
            Clear();

            playBust = false;
            dealBust = false;
            Image pic;            
            Card Card = new Card();
            int ranNum = Card.randomCard();            
            Card = Card.getCard(ranNum);
            PictureBox[] picArray = new PictureBox[3];

            picArray[0] = picBox1;
            picArray[1] = picBox2;
            picArray[2] = picBox6;

            //This is the Dealer's Cards
            //Display Dealer info
            //Picture           
            picArray[2].Visible = true;
            pic = Card.CardIm;
            picArray[2].Image = pic;

            //Score
            scoreDealer = Ace(getDealScore(Card.Score), ranNum); ;
            DealScoreLbl.Text = "Score: " + scoreDealer;
            dealerPlace++;
            ranNum = Card.randomCard();

            //This is the Player's Cards
            //Display Player info
            ranNum = Card.randomCard();
            Card = Card.getCard(ranNum);
            for(int n = 0; n < 2; n++)
            {
                scorePlayer = Ace(getPlayScore(Card.Score), ranNum);
                //Picture
                playerPlace = n;
                picArray[playerPlace].Visible = true;
                pic = Card.CardIm;
                picArray[playerPlace].Image = pic;

                //Score                              
                PlayScoreLbl.Text = "Score: " + scorePlayer;
             
                ranNum = Card.randomCard();
                Card = Card.getCard(ranNum);                
                playerPlace++;                
            }

            //If the Player hits a BlackJack on the first try
            if (scorePlayer == 21)
            {
                Stand();
            }                 
        }

        //This method will work out the score for the Player
        private int getPlayScore(int score)
        {
            scorePlayer = scorePlayer + score;
            if (scorePlayer > 21)
            {
                MessageBox.Show("Bust!\nYou Lose.");
                HitBtn.Enabled = false;
                loss++;
                playBust = true;
                LossLbl.Text = ("Loss: " + loss);

                //The Stand method
                Stand();
                DealBtn.Enabled = true;

            }
            else if (scorePlayer == 21)
            {
                MessageBox.Show("BlackJack!");
                HitBtn.Enabled = false;
                Stand();

                //The Stand method
                Stand();
                Compare();
                DealBtn.Enabled = true;
            }
            return scorePlayer;
        }

        //This method will work out the score of the Dealer
        public int getDealScore(int score)
        {
            scoreDealer = scoreDealer + score;
            if (scoreDealer > 21)
            {
                MessageBox.Show("Bust!");
                dealBust = true;
            }
            else if (scoreDealer == 21)
            {
                MessageBox.Show("BlackJack!");
            }
            return scoreDealer;
        }

        //The Clear method, will clear the screen
        public void Clear()
        {
            PictureBox[] picArray = new PictureBox[10];

            picArray[0] = picBox1;
            picArray[1] = picBox2;
            picArray[2] = picBox3;
            picArray[3] = picBox4;
            picArray[4] = picBox5;
            picArray[5] = picBox6;
            picArray[6] = picBox7;
            picArray[7] = picBox8;
            picArray[8] = picBox9;
            picArray[9] = picBox10;

            for (int a = 0; a < 10; a++)
            {
                 picArray[a].Visible = false;
            }
            //The scores and counters
            scoreDealer = 0;
            dealerPlace = 0;
            scorePlayer = 0;
            playerPlace = 0;

            //The backCard
            picBox7.Visible = true;
            picBox7.Image = Image.FromFile("Cards/CardBack.png");
        }

        //The Ace method will give value to the Ace card
        public int Ace(int score, int card)
        {
            
            if (card == 0 || card == 13 || card == 26 || card == 39)
            {
                if (score + 11 < 21)
                {
                    score = score + 11;
                }
                else
                    return score + 1;
            }
            return score;
        }

        //This will compare the scores to see who wins
        public void Compare()
        {
            if (((scoreDealer > scorePlayer) & dealBust == false) || (playBust == true && dealBust == false))
            {
                loss++;
                MessageBox.Show("You lose!");
                LossLbl.Text = "Loss: " + loss;
            }
            else if (scorePlayer == scoreDealer)
            {
                ties++;
                MessageBox.Show("It's a tie!");
                TiesLbl.Text = "Ties: " + ties;
            }
            else if(((scoreDealer < scorePlayer) & playBust == false) || (dealBust == true & playBust == false))
            {
                wins++;
                MessageBox.Show("You win!");
                WinsLbl.Text = "Wins: " + wins;
            }
        }

        //This method will start a new game
        public void newGame()
        {
            Clear();
            DealBtn.Enabled = true;
            //The counters are reset
            wins = 0;
            loss = 0;
            ties = 0;

            WinsLbl.Text = "Wins: ";
            LossLbl.Text = "Loss: ";
            TiesLbl.Text = "Ties: ";

            Hand();
            HitBtn.Enabled = true;
            StandBtn.Enabled = true;
        }

        //This is the Deal button
        private void DealBtn_Click(object sender, EventArgs e)
        {
            playBust = false;
            dealBust = false;
            Hand();
            DealBtn.Enabled = false;
            HitBtn.Enabled = true;
            StandBtn.Enabled = true;
        }

        //The New Game button, will clear the screen & deal a new hand
        protected void NewGameBtn_Click(object sender, EventArgs e)
        {
            newGame();
        }

        //The Hit button will deal a card according to the rules
        private void HitBtn_Click(object sender, EventArgs e)
        {
            Hit();
        }

        //The Exit button, will close the application
        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Does the same as the Exit button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Shows what the application is about
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        //Shows the Rules Form
        private void viewRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rules rules = new Rules();
            rules.Show();
        }

        //The stand button will let the Dealer play and after that compare the scores
        private void StandBtn_Click(object sender, EventArgs e)
        {
            Stand();
            Compare();
        }
    }
}
