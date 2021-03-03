using System;
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

            computerNum = generator.Next(1, 4);

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
                lblWinBor.Text = win + "";
            }
            else if (computerNum == 1 && radScissor.Checked == true)
            {
                lblWin.Text = "You Lose!";
                lose += 1;
                lblLoseBor.Text = lose + "";
            }
            else if (computerNum == 1 && radRock.Checked == true)
            {
                lblWin.Text = "It's a Tie!";
                tie += 1;
                lblTieBor.Text = tie + "";
            }

            if (computerNum == 2 && radPaper.Checked == true)
            {
                lblWin.Text = "It's a Tie!";
                tie += 1;
                lblTieBor.Text = tie + "";
            }
            else if (computerNum == 2 && radScissor.Checked == true)
            {
                lblWin.Text = "You Win!";
                win += 1;
                lblWinBor.Text = win + "";
            }
            else if (computerNum == 2 && radRock.Checked == true)
            {
                lblWin.Text = "You Lose!";
                lose += 1;
                lblLoseBor.Text = lose + "";
            }

            if (computerNum == 3 && radScissor.Checked == true)
            {
                lblWin.Text = "It's a Tie!";
                tie += 1;
                lblTieBor.Text = tie + "";
            }
            else if (computerNum == 3 && radRock.Checked == true)
            {
                lblWin.Text = "You Win!";
                win += 1;
                lblWinBor.Text = win + "";
            }
            else if (computerNum == 3 && radPaper.Checked == true)
            {
                lblWin.Text = "You Lose!";
                lose += 1;
                lblLoseBor.Text = lose + "";
            }


           
    }

       
    }
}
