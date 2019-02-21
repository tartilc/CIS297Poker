using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Cards Downloaded from: http://acbl.mybigcommerce.com/52-playing-cards/
//https://stackoverflow.com/questions/17193825/loading-picturebox-image-from-resource-file-with-path-part-3

namespace Holdem
{
    public partial class Form1 : Form
    {
        private Deck deck;
        private PokerHand hand;

        int balanceComp = 100;
        int balanceUser = 100;
        int raiseComp = 0;
        int raiseUser = 0;
        int sumRaiseComp = 0;
        int sumRaiseUser = 0;

        public Form1()
        {
            InitializeComponent();
            deck = new Deck();
            hand = new PokerHand(deck);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            spreadCards();
        }

        public void spreadCards()
        {
            deck.shuffle();
            hand.pullCards();

            shared1.Image = Image.FromFile(@"Resources\" + hand[0].ToString() + ".png");
            shared2.Image = Image.FromFile(@"Resources\" + hand[1].ToString() + ".png");
            shared3.Image = Image.FromFile(@"Resources\" + hand[2].ToString() + ".png");
            shared4.Image = Image.FromFile(@"Resources\" + hand[3].ToString() + ".png");
            shared5.Image = Image.FromFile(@"Resources\" + hand[4].ToString() + ".png");

            computerHole1.Image = Image.FromFile(@"Resources\" + hand[5].ToString() + ".png");
            computerHole2.Image = Image.FromFile(@"Resources\" + hand[6].ToString() + ".png");
            playerHole1.Image = Image.FromFile(@"Resources\" + hand[7].ToString() + ".png");
            playerHole2.Image = Image.FromFile(@"Resources\" + hand[8].ToString() + ".png");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            deck.shuffle();
            spreadCards();
            computerBalance.Text = Convert.ToString(balanceComp);
            playerBalance.Text = Convert.ToString(balanceUser);
        }

        private void raiseButton_Click(object sender, EventArgs e)
        {
            raiseComp += 10;
            raiseUser += 10;

            sumRaiseComp = balanceComp - raiseComp;
            sumRaiseUser = balanceUser - raiseUser;

            computerBet.Text = Convert.ToString(raiseComp);
            playerBet.Text = Convert.ToString(raiseUser);

            computerBalance.Text = Convert.ToString(sumRaiseComp);
            playerBalance.Text = Convert.ToString(sumRaiseUser);

            if(sumRaiseComp <= 0)
            {
                computerBalance.Text = "Out of Money";
              
            }
            else
            {

            }

            if (sumRaiseUser <= 0)
            {
                playerBalance.Text = "Out of Money";
            }
            else
            {

            }







        }

        private void foldButton_Click(object sender, EventArgs e)
        {

        }

        private void callButton_Click(object sender, EventArgs e)
        {
            
        }
    }

}
