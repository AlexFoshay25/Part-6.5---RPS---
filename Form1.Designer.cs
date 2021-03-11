namespace Part_6._5____RPS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblOpponent = new System.Windows.Forms.Label();
            this.grpPlayerChoice = new System.Windows.Forms.GroupBox();
            this.radScissor = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.imgOpponent = new System.Windows.Forms.PictureBox();
            this.btnGameStart = new System.Windows.Forms.Button();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblWinBor = new System.Windows.Forms.Label();
            this.lblLoseBor = new System.Windows.Forms.Label();
            this.lblTieBor = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.txtBetAmt = new System.Windows.Forms.TextBox();
            this.lblBettingAmt = new System.Windows.Forms.Label();
            this.lblMoneyTotal = new System.Windows.Forms.Label();
            this.grpPlayerChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(152, 71);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(99, 25);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Text = "Player 1";
            // 
            // lblOpponent
            // 
            this.lblOpponent.AutoSize = true;
            this.lblOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponent.Location = new System.Drawing.Point(552, 71);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(99, 25);
            this.lblOpponent.TabIndex = 3;
            this.lblOpponent.Text = "Player 2";
            // 
            // grpPlayerChoice
            // 
            this.grpPlayerChoice.Controls.Add(this.radScissor);
            this.grpPlayerChoice.Controls.Add(this.radPaper);
            this.grpPlayerChoice.Controls.Add(this.radRock);
            this.grpPlayerChoice.Location = new System.Drawing.Point(12, 338);
            this.grpPlayerChoice.Name = "grpPlayerChoice";
            this.grpPlayerChoice.Size = new System.Drawing.Size(200, 100);
            this.grpPlayerChoice.TabIndex = 4;
            this.grpPlayerChoice.TabStop = false;
            this.grpPlayerChoice.Text = "Player 1\'s Choice";
            // 
            // radScissor
            // 
            this.radScissor.AutoSize = true;
            this.radScissor.Location = new System.Drawing.Point(7, 68);
            this.radScissor.Name = "radScissor";
            this.radScissor.Size = new System.Drawing.Size(64, 17);
            this.radScissor.TabIndex = 2;
            this.radScissor.TabStop = true;
            this.radScissor.Text = "Scissors";
            this.radScissor.UseVisualStyleBackColor = true;
            this.radScissor.CheckedChanged += new System.EventHandler(this.radScissor_CheckedChanged);
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Location = new System.Drawing.Point(7, 44);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(53, 17);
            this.radPaper.TabIndex = 1;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            this.radPaper.CheckedChanged += new System.EventHandler(this.radPaper_CheckedChanged);
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Location = new System.Drawing.Point(7, 20);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(51, 17);
            this.radRock.TabIndex = 0;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            this.radRock.CheckedChanged += new System.EventHandler(this.radRock_CheckedChanged);
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = global::Part_6._5____RPS.Properties.Resources.questionmark;
            this.imgPlayer.Location = new System.Drawing.Point(106, 99);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(185, 205);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 1;
            this.imgPlayer.TabStop = false;
            // 
            // imgOpponent
            // 
            this.imgOpponent.Image = global::Part_6._5____RPS.Properties.Resources.questionmark;
            this.imgOpponent.Location = new System.Drawing.Point(504, 99);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(187, 205);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpponent.TabIndex = 0;
            this.imgOpponent.TabStop = false;
            // 
            // btnGameStart
            // 
            this.btnGameStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameStart.Location = new System.Drawing.Point(354, 338);
            this.btnGameStart.Name = "btnGameStart";
            this.btnGameStart.Size = new System.Drawing.Size(91, 37);
            this.btnGameStart.TabIndex = 5;
            this.btnGameStart.Text = "Play";
            this.btnGameStart.UseVisualStyleBackColor = true;
            this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(331, 37);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(103, 33);
            this.lblWin.TabIndex = 6;
            this.lblWin.Text = "--------";
            // 
            // lblWinBor
            // 
            this.lblWinBor.AutoSize = true;
            this.lblWinBor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinBor.Location = new System.Drawing.Point(706, 356);
            this.lblWinBor.Name = "lblWinBor";
            this.lblWinBor.Size = new System.Drawing.Size(32, 18);
            this.lblWinBor.TabIndex = 7;
            this.lblWinBor.Text = "----";
            // 
            // lblLoseBor
            // 
            this.lblLoseBor.AutoSize = true;
            this.lblLoseBor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoseBor.Location = new System.Drawing.Point(706, 381);
            this.lblLoseBor.Name = "lblLoseBor";
            this.lblLoseBor.Size = new System.Drawing.Size(32, 18);
            this.lblLoseBor.TabIndex = 8;
            this.lblLoseBor.Text = "----";
            // 
            // lblTieBor
            // 
            this.lblTieBor.AutoSize = true;
            this.lblTieBor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieBor.Location = new System.Drawing.Point(706, 406);
            this.lblTieBor.Name = "lblTieBor";
            this.lblTieBor.Size = new System.Drawing.Size(32, 18);
            this.lblTieBor.TabIndex = 9;
            this.lblTieBor.Text = "----";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(688, 322);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(71, 24);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "Score:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(655, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Win";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(655, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Loss";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tie";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 24);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Rock Paper Scissors";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(714, 9);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(66, 20);
            this.lblMoney.TabIndex = 15;
            this.lblMoney.Text = "Money:";
            // 
            // txtBetAmt
            // 
            this.txtBetAmt.Location = new System.Drawing.Point(354, 382);
            this.txtBetAmt.Name = "txtBetAmt";
            this.txtBetAmt.Size = new System.Drawing.Size(91, 20);
            this.txtBetAmt.TabIndex = 16;
            // 
            // lblBettingAmt
            // 
            this.lblBettingAmt.AutoSize = true;
            this.lblBettingAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBettingAmt.Location = new System.Drawing.Point(270, 385);
            this.lblBettingAmt.Name = "lblBettingAmt";
            this.lblBettingAmt.Size = new System.Drawing.Size(78, 13);
            this.lblBettingAmt.TabIndex = 17;
            this.lblBettingAmt.Text = "Place A Bet:";
            // 
            // lblMoneyTotal
            // 
            this.lblMoneyTotal.AutoSize = true;
            this.lblMoneyTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyTotal.Location = new System.Drawing.Point(724, 29);
            this.lblMoneyTotal.Name = "lblMoneyTotal";
            this.lblMoneyTotal.Size = new System.Drawing.Size(31, 15);
            this.lblMoneyTotal.TabIndex = 18;
            this.lblMoneyTotal.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMoneyTotal);
            this.Controls.Add(this.lblBettingAmt);
            this.Controls.Add(this.txtBetAmt);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTieBor);
            this.Controls.Add(this.lblLoseBor);
            this.Controls.Add(this.lblWinBor);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.btnGameStart);
            this.Controls.Add(this.grpPlayerChoice);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.imgOpponent);
            this.Name = "Form1";
            this.Text = "Rock, Paper, Scissors";
            this.grpPlayerChoice.ResumeLayout(false);
            this.grpPlayerChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgOpponent;
        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblOpponent;
        private System.Windows.Forms.GroupBox grpPlayerChoice;
        private System.Windows.Forms.RadioButton radScissor;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.Button btnGameStart;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblWinBor;
        private System.Windows.Forms.Label lblLoseBor;
        private System.Windows.Forms.Label lblTieBor;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.TextBox txtBetAmt;
        private System.Windows.Forms.Label lblBettingAmt;
        private System.Windows.Forms.Label lblMoneyTotal;
    }
}

