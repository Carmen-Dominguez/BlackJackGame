using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace BlackJackGame
{
    //This will be the card
    class Card
    {
        //Empty Constructor
        public Card()
        { 
        }

        //Constructor
        public Card(Image newCardIm, int newScore)
        {
            CardIm = newCardIm;
            Score = newScore;
        }

        //The Image Card Property
        private Image mCard;
        public Image CardIm
        {
            get
            {
                return mCard;
            }
            set
            {
                mCard = value;
            }
        }

        //The Score Property
        private int mScore = 0;
        public int Score
        {
            get
            {
                return mScore;
            }
            set
            {
                mScore = value;
            }
        }

        //The Deck, the method with an array of cards, getting them randomly
        public Card getCard(int ranNum)
        {
                Card[] deckCard = new Card[53];
                if (ranNum == 0)
                {

                    Card c0 = new Card(Image.FromFile("Cards/Clubs-Ace.png"), 0);
                    return deckCard[0] = c0;
                }

                else if (ranNum == 1)
                {
                    Card c1 = new Card(Image.FromFile("Cards/Clubs-Two.png"), 2);
                    return deckCard[1] = c1;
                }

                else if (ranNum == 2)
                {
                    Card c2 = new Card(Image.FromFile("Cards/Clubs-Three.png"), 3);
                    return deckCard[2] = c2;
                }

                else if (ranNum == 3)
                {
                    Card c3 = new Card(Image.FromFile("Cards/Clubs-Four.png"), 4);
                    return deckCard[3] = c3;
                }

                else if (ranNum == 4)
                {
                    Card c4 = new Card(Image.FromFile("Cards/Clubs-Five.png"), 5);
                    return deckCard[4] = c4;
                }

                else if (ranNum == 5)
                {
                    Card c5 = new Card(Image.FromFile("Cards/Clubs-Six.png"), 6);
                    return deckCard[5] = c5;
                }

                else if (ranNum == 6)
                {
                    Card c6 = new Card(Image.FromFile("Cards/Clubs-Seven.png"), 7);
                    return deckCard[6] = c6;
                }

                else if (ranNum == 7)
                {
                    Card c7 = new Card(Image.FromFile("Cards/Clubs-Eight.png"), 8);
                    return deckCard[7] = c7;
                }

                else if (ranNum == 8)
                {
                    Card c8 = new Card(Image.FromFile("Cards/Clubs-Nine.png"), 9);
                    return deckCard[8] = c8;
                }

                else if (ranNum == 9)
                {
                    Card c9 = new Card(Image.FromFile("Cards/Clubs-Ten.png"), 10);
                    return deckCard[9] = c9;
                }

                else if (ranNum == 10)
                {
                    Card c10 = new Card(Image.FromFile("Cards/Clubs-Jack.png"), 10);
                    return deckCard[10] = c10;
                }

                else if (ranNum == 11)
                {
                    Card c11 = new Card(Image.FromFile("Cards/Clubs-Queen.png"), 10);
                    return deckCard[11] = c11;
                }

                else if (ranNum == 12)
                {
                    Card c12 = new Card(Image.FromFile("Cards/Clubs-King.png"), 10);
                    return deckCard[12] = c12;
                }

                else if (ranNum == 13)
                {
                    Card d0 = new Card(Image.FromFile("Cards/Diamonds-Ace.png"), 0);
                    return deckCard[13] = d0;
                }

                else if (ranNum == 14)
                {
                    Card d1 = new Card(Image.FromFile("Cards/Diamonds-Two.png"), 2);
                    return deckCard[14] = d1;
                }

                else if (ranNum == 15)
                {
                    Card d2 = new Card(Image.FromFile("Cards/Diamonds-Three.png"), 3);
                    return deckCard[15] = d2;
                }

                else if (ranNum == 16)
                {
                    Card d3 = new Card(Image.FromFile("Cards/Diamonds-Four.png"), 4);
                    return deckCard[16] = d3;
                }

                else if (ranNum == 17)
                {
                    Card d4 = new Card(Image.FromFile("Cards/Diamonds-Five.png"), 5);
                    return deckCard[17] = d4;
                }

                else if (ranNum == 18)
                {
                    Card d5 = new Card(Image.FromFile("Cards/Diamonds-Six.png"), 6);
                    return deckCard[18] = d5;
                }

                else if (ranNum == 19)
                {
                    Card d6 = new Card(Image.FromFile("Cards/Diamonds-Seven.png"), 7);
                    return deckCard[19] = d6;
                }

                else if (ranNum == 20)
                {
                    Card d7 = new Card(Image.FromFile("Cards/Diamonds-Eight.png"), 8);
                    return deckCard[20] = d7;
                }

                else if (ranNum == 21)
                {
                    Card d8 = new Card(Image.FromFile("Cards/Diamonds-Nine.png"), 9);
                    return deckCard[21] = d8;
                }

                else if (ranNum == 22)
                {
                    Card d9 = new Card(Image.FromFile("Cards/Diamonds-Ten.png"), 10);
                    return deckCard[22] = d9;
                }

                else if (ranNum == 23)
                {
                    Card d10 = new Card(Image.FromFile("Cards/Diamonds-Jack.png"), 10);
                    return deckCard[23] = d10;
                }

                else if (ranNum == 24)
                {
                    Card d11 = new Card(Image.FromFile("Cards/Diamonds-Queen.png"), 10);
                    return deckCard[24] = d11;
                }

                else if (ranNum == 25)
                {
                    Card d12 = new Card(Image.FromFile("Cards/Diamonds-King.png"), 10);
                    return deckCard[25] = d12;
                }

                else if (ranNum == 26)
                {
                    Card h0 = new Card(Image.FromFile("Cards/Hearts-Ace.png"), 0);
                    return deckCard[26] = h0;
                }

                else if (ranNum == 27)
                {
                    Card h1 = new Card(Image.FromFile("Cards/Hearts-Two.png"), 2);
                    return deckCard[27] = h1;
                }

                else if (ranNum == 28)
                {
                    Card h2 = new Card(Image.FromFile("Cards/Hearts-Three.png"), 3);
                    return deckCard[28] = h2;
                }

                else if (ranNum == 29)
                {
                    Card h3 = new Card(Image.FromFile("Cards/Hearts-Four.png"), 4);
                    return deckCard[29] = h3;
                }

                else if (ranNum == 30)
                {
                    Card h4 = new Card(Image.FromFile("Cards/Hearts-Five.png"), 5);
                    return deckCard[30] = h4;
                }

                else if (ranNum == 31)
                {
                    Card h5 = new Card(Image.FromFile("Cards/Hearts-Six.png"), 6);
                    return deckCard[31] = h5;
                }

                else if (ranNum == 32)
                {
                    Card h6 = new Card(Image.FromFile("Cards/Hearts-Seven.png"), 7);
                    return deckCard[32] = h6;
                }

                else if (ranNum == 33)
                {
                    Card h7 = new Card(Image.FromFile("Cards/Hearts-Eight.png"), 8);
                    return deckCard[33] = h7;
                }

                else if (ranNum == 34)
                {
                    Card h8 = new Card(Image.FromFile("Cards/Hearts-Nine.png"), 9);
                    return deckCard[34] = h8;
                }

                else if (ranNum == 35)
                {
                    Card h9 = new Card(Image.FromFile("Cards/Hearts-Ten.png"), 10);
                    return deckCard[35] = h9;
                }

                else if (ranNum == 36)
                {
                    Card h10 = new Card(Image.FromFile("Cards/Hearts-Jack.png"), 10);
                    return deckCard[36] = h10;
                }

                else if (ranNum == 37)
                {
                    Card h11 = new Card(Image.FromFile("Cards/Hearts-Queen.png"), 10);
                    return deckCard[37] = h11;
                }

                else if (ranNum == 38)
                {
                    Card h12 = new Card(Image.FromFile("Cards/Hearts-King.png"), 10);
                    return deckCard[38] = h12;
                }

                else if (ranNum == 39)
                {
                    Card s0 = new Card(Image.FromFile("Cards/Spades-Ace.png"), 0);
                    return deckCard[39] = s0;
                }

                else if (ranNum == 40)
                {
                    Card s1 = new Card(Image.FromFile("Cards/Spades-Two.png"), 2);
                    return deckCard[40] = s1;
                }

                else if (ranNum == 41)
                {
                    Card s2 = new Card(Image.FromFile("Cards/Spades-Three.png"), 3);
                    return deckCard[41] = s2;
                }

                else if (ranNum == 42)
                {
                    Card s3 = new Card(Image.FromFile("Cards/Spades-Four.png"), 4);
                    return deckCard[42] = s3;
                }

                else if (ranNum == 43)
                {
                    Card s4 = new Card(Image.FromFile("Cards/Spades-Five.png"), 5);
                    return deckCard[43] = s4;
                }

                else if (ranNum == 44)
                {
                    Card s5 = new Card(Image.FromFile("Cards/Spades-Six.png"), 6);
                    return deckCard[44] = s5;
                }

                else if (ranNum == 45)
                {
                    Card s6 = new Card(Image.FromFile("Cards/Spades-Seven.png"), 7);
                    return deckCard[45] = s6;
                }

                else if (ranNum == 46)
                {
                    Card s7 = new Card(Image.FromFile("Cards/Spades-Eight.png"), 8);
                    return deckCard[46] = s7;
                }

                else if (ranNum == 47)
                {
                    Card s8 = new Card(Image.FromFile("Cards/Spades-Nine.png"), 9);
                    return deckCard[47] = s8;
                }

                else if (ranNum == 48)
                {
                    Card s9 = new Card(Image.FromFile("Cards/Spades-Ten.png"), 10);
                    return deckCard[48] = s9;
                }

                else if (ranNum == 49)
                {
                    Card s10 = new Card(Image.FromFile("Cards/Spades-Jack.png"), 10);
                    return deckCard[49] = s10;
                }

                else if (ranNum == 50)
                {
                    Card s11 = new Card(Image.FromFile("Cards/Spades-Queen.png"), 10);
                    return deckCard[50] = s11;
                }

                else if (ranNum == 51)
                {
                    Card s12 = new Card(Image.FromFile("Cards/Spades-King.png"), 10);
                    return deckCard[51] = s12;
                }

                Card defCard = new Card(Image.FromFile("Cards/CardBack.png"), 0);
                return deckCard[52] = defCard;
            }
 
        //These method will give a random number to the Dealer & Player.It adds the cards to a collection
        Random random = new Random();
        int x;
        ArrayList cardList = new ArrayList();
        BlackJack jack = new BlackJack();

        //This will check whether a random card is already dealt. If so then a new random card is dealt until
        //one is found that's not already dealt
        public int randomCard()
        {
            x = random.Next(0, 51);
            //If the whole deck has not been dealt out yet
            if (cardList.Count != 52)
            {
                while (cardList.Contains(x))
                {
                    x = random.Next(0, 51);
                }
                cardList.Add(x);
            }
            //If deck is full (all cards have been dealed out), new game will start
            else
            {
                newDeck();
                MessageBox.Show("All the cards have been dealt.\nA new game will start");
                jack.newGame();
            }
            return x;
        }

        //Used to get a new Deck
        public void newDeck()
        {
            cardList.Clear();
        }
    }
}
