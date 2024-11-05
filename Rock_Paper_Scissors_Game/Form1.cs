using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Rounds = 0;

        enum enGameChoise { Rock = 1, Paper = 2, Scissors = 3 };
        
        enum enCheekWinner { User, Computer, Draw};

        struct stGameInfo
        {
            public enCheekWinner Winner;
            public short CountUserWins;
            public short CountComputerWins;
            public short ComputerRoundsWins;
            public short UserRoundsWins;
            public short RoundsDraw;
            public string RoundWinner;

        };

        stGameInfo sGameStatus;
        enGameChoise ChoiseComputer;
        enGameChoise ChoiseUser;


        void GetChoiseComputer()
        {
            Random random = new Random();
            int Choise = random.Next(1, 4);
            ChoiseComputer = (enGameChoise) Choise;  
        }

        void GetIconComputerChoise()
        {
            switch (ChoiseComputer)
            {
                case enGameChoise.Rock:
                    pbIconComputerChoise.BackgroundImage = Properties.Resources.Rock;
                    break;

                case enGameChoise.Paper:
                    pbIconComputerChoise.BackgroundImage = Properties.Resources.Paper;
                    break;

                case enGameChoise.Scissors:
                    pbIconComputerChoise.BackgroundImage = Properties.Resources.Scissors;
                    break;
            }
        }
        void GetIconUserChoise()
        {
            switch (ChoiseUser)
            {
                case enGameChoise.Rock:
                    pbIconUserChoise.BackgroundImage = Properties.Resources.Rock;
                    break;

                case enGameChoise.Paper:
                    pbIconUserChoise.BackgroundImage = Properties.Resources.Paper;
                    break;

                case enGameChoise.Scissors:
                    pbIconUserChoise.BackgroundImage = Properties.Resources.Scissors;
                    break;
            }
        }
     

        void PrintUserResults()
        {
            lblResultUser.Text = sGameStatus.UserRoundsWins.ToString();
        }
        void PrintComputerResults()
        {
            lblResultComputer.Text = sGameStatus.ComputerRoundsWins.ToString();

        }
        void PrintDrawResults()
        {
            lblResultDraw.Text = sGameStatus.RoundsDraw.ToString();

        }
        void FinalWinner()
        {
            if (sGameStatus.CountComputerWins == sGameStatus.CountUserWins)
            {
                sGameStatus.RoundsDraw++;
            }
            else if (sGameStatus.CountUserWins > sGameStatus.CountComputerWins)
            {
                sGameStatus.UserRoundsWins++;
            }
            else
                sGameStatus.ComputerRoundsWins++;


            PrintComputerResults();
            PrintUserResults();
            PrintDrawResults();

            sGameStatus.CountComputerWins = 0;
            sGameStatus.CountUserWins = 0;

        }
        void GetWinnerEasyLvl()
        {
            GetChoiseComputer();
            GetIconComputerChoise();
            GetIconUserChoise();
            switch(ChoiseUser)
            {
                case enGameChoise.Rock:
                    switch(ChoiseComputer)
                    {
                        case enGameChoise.Rock:
                            sGameStatus.RoundWinner = "Draw";
                            break;

                        case enGameChoise.Paper:
                            sGameStatus.CountUserWins++;
                            sGameStatus.RoundWinner = "YOU";
                            break;

                        case enGameChoise.Scissors:
                            sGameStatus.CountUserWins++;
                            sGameStatus.RoundWinner = "YOU";
                            break;
                    }
                    break;

                case enGameChoise.Paper:
                    switch (ChoiseComputer)
                    {
                        case enGameChoise.Rock:
                            sGameStatus.CountComputerWins++;
                            sGameStatus.RoundWinner = "Computer";
                            break;

                        case enGameChoise.Paper:
                            sGameStatus.RoundWinner = "Draw";
                            
                            break;

                        case enGameChoise.Scissors:
                            sGameStatus.CountComputerWins++;
                            sGameStatus.RoundWinner = "Computer";
                            break;
                    }
                    break;

                case enGameChoise.Scissors:

                    switch (ChoiseComputer)
                    {
                        case enGameChoise.Rock:
                            sGameStatus.CountComputerWins++;
                            sGameStatus.RoundWinner = "Computer";
                            break;

                        case enGameChoise.Paper:
                            sGameStatus.CountUserWins++;
                            sGameStatus.RoundWinner = "YOU";
                            break;

                        case enGameChoise.Scissors:
                            sGameStatus.RoundWinner = "Draw";
                           
                            break;
                    }
                    break;
            }

          

        }

        void GetWinnerHardLvl()
        {

           //GetChoiseComputer();
            GetIconUserChoise();

            switch (ChoiseUser)
            {
                case enGameChoise.Rock:
                    ChoiseComputer = enGameChoise.Rock;
                    sGameStatus.RoundWinner = "Draw";
                    GetIconComputerChoise();


                    break;

                case enGameChoise.Paper:
                    ChoiseComputer = enGameChoise.Scissors;
                    GetIconComputerChoise();
                    sGameStatus.CountComputerWins++;
                    sGameStatus.RoundWinner = "Computer";
                    break;

                case enGameChoise.Scissors:

                    ChoiseComputer = enGameChoise.Rock;
                    GetIconComputerChoise();
                    sGameStatus.CountComputerWins++;
                    sGameStatus.RoundWinner = "Computer";
                    break;
            }


        }


        void PerformGame()
        {
            if (Rounds > 0)
            {
                lblRoundNumber.Text = "Round " + Rounds + " :" ;
                Rounds--;

                if (cmbLevels.SelectedItem.ToString() == "Easy")
                {
                    GetWinnerEasyLvl();
                }
                else
                {
                    GetWinnerHardLvl();
                }

                lblDisplayFinalResults.Text += "Round " + (Rounds+1) + " :" + Environment.NewLine;
                lblDisplayFinalResults.Text += "Winner : " + sGameStatus.RoundWinner + Environment.NewLine + Environment.NewLine;

                lblResultRound.Text = sGameStatus.RoundWinner;
            }

            if (Rounds == 0)
            {
                FinalWinner();
                lblTotalUserBonus.Text = sGameStatus.UserRoundsWins + "$";
                lblTotalUserBonus.Tag = sGameStatus.UserRoundsWins.ToString();

                pnlComputerInfo.Enabled = false;
                pnlUserInfo.Enabled = false;
                pnlDisplayFinalResults.Visible = true;
            }
                

            


            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ChoiseUser = enGameChoise.Paper;
            PerformGame();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            ChoiseUser = enGameChoise.Scissors;
            PerformGame();

        }

        private void btnRockUser_Click(object sender, EventArgs e)
        {
            ChoiseUser = enGameChoise.Rock;
            PerformGame();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void storeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlDisplayFinalResults.Visible = false;
            pnlComputerInfo.Enabled = false;
            pnlUserInfo.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!(cmbLevels.SelectedItem == null) && !(cmbRounds.SelectedItem == null))
            {
                Rounds = Convert.ToInt16(cmbRounds.SelectedItem);
                pnlComputerInfo.Enabled = true;
                pnlUserInfo.Enabled = true;
            }
            
            
        }

        private void msStoreOptins_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void msStoreOptins_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void cmbRounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        Form Shop = new ShopForm();
        Form BuyCoins = new BuyCoinsForm();

        private void shopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shop.ShowDialog();
        }
        


        private void buyCoinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyCoins.ShowDialog();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            cmbLevels.SelectedItem = null;
            cmbRounds.SelectedItem = null;

            lblRoundNumber.Text = "";
            lblResultRound.Text = "";

            sGameStatus.Winner = 0;
            sGameStatus.CountComputerWins = 0;
            sGameStatus.CountUserWins = 0;
            sGameStatus.RoundWinner = "";


            pnlComputerInfo.Enabled = false;
            pnlUserInfo.Enabled = false;

            lblDisplayFinalResults.Text = "";
            pnlDisplayFinalResults.Visible = false;


            pbIconComputerChoise.BackgroundImage = null;
            pbIconUserChoise.BackgroundImage = null;

            Rounds = 0;
        }

        
    }
}
