﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_6._5____RPS
{
    public partial class Form1 : Form
    {
        Random generator = new Random();

        int computerNum;
        int win;
        int lose;
        int tie;
        double money;
        double playermoney;
        double zero;

        public Form1()
        {
            InitializeComponent();
        }

        private void radRock_CheckedChanged(object sender, EventArgs e)
        {
            

            if (radRock.Checked == true)
            {
                imgPlayer.Image = Properties.Resources.Rock;

            }
        }

        private void radPaper_CheckedChanged(object sender, EventArgs e)
        {
            if (radPaper.Checked == true)
            {
                imgPlayer.Image = Properties.Resources.Paper;

            }
        }

        private void radScissor_CheckedChanged(object sender, EventArgs e)
        {
            if (radScissor.Checked == true)
            {
                imgPlayer.Image = Properties.Resources.Scissors;

            }

        }




        private void btnGameStart_Click(object sender, EventArgs e)
        {
            //1 = Rock
            //2 = Paper
            //3 = Scissors

            zero = 0;

            money = 0;

            playermoney = 100;

            money = Convert.ToDouble(txtBetAmt.Text);

            playermoney = Convert.ToDouble(lblMoneyTotal.Text);

            computerNum = generator.Next(1, 4);

            if (money <= playermoney) 
            {
                if (money < zero)
                    money = 0;

                if (computerNum == 1)
                {
                    imgOpponent.Image = Properties.Resources.Rock;
                }
                else if (computerNum == 2)
                {
                    imgOpponent.Image = Properties.Resources.Paper;
                }
                else if (computerNum == 3)
                {
                    imgOpponent.Image = Properties.Resources.Scissors;
                }

                if (computerNum == 1 && radPaper.Checked == true)
                {
                    lblWin.Text = "You Win!";
                    win += 1;
                    playermoney = playermoney + money * 2;
                    lblWinBor.Text = win + "";
                    lblMoneyTotal.Text = $"{playermoney}";
                }
                else if (computerNum == 1 && radScissor.Checked == true)
                {
                    lblWin.Text = "You Lose!";
                    lose += 1;
                    playermoney = playermoney - money;
                    lblLoseBor.Text = lose + "";
                    lblMoneyTotal.Text = $"{playermoney}";
                }
                else if (computerNum == 1 && radRock.Checked == true)
                {
                    lblWin.Text = "It's a Tie!";
                    tie += 1;
                    playermoney = playermoney + 0;
                    lblTieBor.Text = tie + "";
                    lblMoneyTotal.Text = $"{playermoney}";
                }

                if (computerNum == 2 && radPaper.Checked == true)
                {
                    lblWin.Text = "It's a Tie!";
                    tie += 1;
                    playermoney = playermoney + 0;
                    lblTieBor.Text = tie + "";
                    lblMoneyTotal.Text = $"{playermoney}";
                }
                else if (computerNum == 2 && radScissor.Checked == true)
                {
                    lblWin.Text = "You Win!";
                    win += 1;
                    playermoney = playermoney + money * 2;
                    lblWinBor.Text = win + "";
                    lblMoneyTotal.Text = $"{playermoney}";
                }
                else if (computerNum == 2 && radRock.Checked == true)
                {
                    lblWin.Text = "You Lose!";
                    lose += 1;
                    playermoney = playermoney - money;
                    lblLoseBor.Text = lose + "";
                    lblMoneyTotal.Text = $"{playermoney}";
                }

                if (computerNum == 3 && radScissor.Checked == true)
                {
                    lblWin.Text = "It's a Tie!";
                    tie += 1;
                    playermoney = playermoney + 0;
                    lblTieBor.Text = tie + "";
                    lblMoneyTotal.Text = $"{playermoney}";
                }
                else if (computerNum == 3 && radRock.Checked == true)
                {
                    lblWin.Text = "You Win!";
                    win += 1;
                    playermoney = playermoney + money * 2;
                    lblWinBor.Text = win + "";
                    lblMoneyTotal.Text = $"{playermoney}";
                }
                else if (computerNum == 3 && radPaper.Checked == true)
                {
                    lblWin.Text = "You Lose!";
                    lose += 1;
                    playermoney = playermoney - money;
                    lblLoseBor.Text = lose + "";
                    lblMoneyTotal.Text = $"{playermoney}";
                }

            }

            if (money <= zero)
            {
                if (computerNum == 1)
                {
                    imgOpponent.Image = Properties.Resources.Rock;
                }
                else if (computerNum == 2)
                {
                    imgOpponent.Image = Properties.Resources.Paper;
                }
                else if (computerNum == 3)
                {
                    imgOpponent.Image = Properties.Resources.Scissors;
                }

                if (computerNum == 1 && radPaper.Checked == true)
                {
                    lblWin.Text = "You Win! (No Bet)";
                    lblMoneyTotal.Text = $"{playermoney}";
                    lblWinBor.Text = win + "";
                }
                else if (computerNum == 1 && radScissor.Checked == true)
                {
                    lblWin.Text = "You Lose! (No Bet)";
                    lblMoneyTotal.Text = $"{playermoney}";
                    lblLoseBor.Text = lose + "";
                }
                else if (computerNum == 1 && radRock.Checked == true)
                {
                    lblWin.Text = "It's a Tie! (No Bet)";
                    lblMoneyTotal.Text = $"{playermoney}";
                    lblTieBor.Text = tie + "";
                }

                if (computerNum == 2 && radPaper.Checked == true)
                {
                    lblWin.Text = "It's a Tie! (No Bet)";
                    lblMoneyTotal.Text = $"{playermoney}";
                    lblTieBor.Text = tie + "";
                }
                else if (computerNum == 2 && radScissor.Checked == true)
                {
                    lblWin.Text = "You Win! (No Bet)";
                    lblMoneyTotal.Text = $"{playermoney}";
                    lblWinBor.Text = win + "";
                }
                else if (computerNum == 2 && radRock.Checked == true)
                {
                    lblWin.Text = "You Lose! (No Bet)";
                    lblMoneyTotal.Text = $"{playermoney}";
                    lblLoseBor.Text = lose + "";
                }

                if (computerNum == 3 && radScissor.Checked == true)
                {
                    lblWin.Text = "It's a Tie! (No Bet)";
                    lblMoneyTotal.Text = $"{playermoney}";
                    lblTieBor.Text = tie + "";
                }
                else if (computerNum == 3 && radRock.Checked == true)
                {
                    lblWin.Text = "You Win! (No Bet)";
                    lblWinBor.Text = win + "";
                    lblMoneyTotal.Text = $"{playermoney}";
                }
                else if (computerNum == 3 && radPaper.Checked == true)
                {
                    lblWin.Text = "You Lose! (No Bet)";
                    lblLoseBor.Text = lose + "";
                    lblMoneyTotal.Text = $"{playermoney}";
                }
            }

            if (playermoney <= zero)
            {
                lblBankrupt.Text = $"No Money Left - No More Bets Allowed";
                lblInfo.Text = $"Restart Game To Replenish Bank";
                lblInfo2.Text = $"- Bet With '$0' to Continue Playing -";
            }
            





        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
