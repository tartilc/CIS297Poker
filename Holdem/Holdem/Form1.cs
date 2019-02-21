#region Using Statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion



namespace Holdem
{
    public partial class Form1 : Form
    {
        private Deck deck;

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        public void Initialize()
        {
            shared1.Image = Image.FromFile(@"Resources\" + deck.pullCard().ToString() + ".png");
            shared2.Image = Image.FromFile(@"Resources\" + deck.pullCard().ToString() + ".png");
            shared3.Image = Image.FromFile(@"Resources\" + deck.pullCard().ToString() + ".png");
            shared4.Image = Image.FromFile(@"Resources\" + deck.pullCard().ToString() + ".png");
            shared5.Image = Image.FromFile(@"Resources\" + deck.pullCard().ToString() + ".png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
