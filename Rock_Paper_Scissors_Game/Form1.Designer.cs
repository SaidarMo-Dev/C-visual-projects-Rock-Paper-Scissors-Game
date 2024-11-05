namespace Rock_Paper_Scissors_Game
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRockUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPaperUser = new System.Windows.Forms.Button();
            this.btnScissorsUser = new System.Windows.Forms.Button();
            this.lblResultUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnScissorsComputer = new System.Windows.Forms.Button();
            this.btnPaperComputer = new System.Windows.Forms.Button();
            this.btnRockComputer = new System.Windows.Forms.Button();
            this.lblResultComputer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultDraw = new System.Windows.Forms.Label();
            this.lblTotalUserBonus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbLevels = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbRounds = new System.Windows.Forms.ComboBox();
            this.pnlComputerInfo = new System.Windows.Forms.Panel();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pbIconUserChoise = new System.Windows.Forms.PictureBox();
            this.pbIconComputerChoise = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msStoreOptins = new System.Windows.Forms.ToolStripMenuItem();
            this.shopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyCoinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.lblRoundNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultRound = new System.Windows.Forms.Label();
            this.pnlDisplayFinalResults = new System.Windows.Forms.Panel();
            this.lblDisplayFinalResults = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlComputerInfo.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconUserChoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconComputerChoise)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlDisplayFinalResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRockUser
            // 
            this.btnRockUser.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnRockUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRockUser.FlatAppearance.BorderSize = 0;
            this.btnRockUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRockUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnRockUser.ForeColor = System.Drawing.Color.White;
            this.btnRockUser.Location = new System.Drawing.Point(11, 176);
            this.btnRockUser.Name = "btnRockUser";
            this.btnRockUser.Size = new System.Drawing.Size(109, 39);
            this.btnRockUser.TabIndex = 0;
            this.btnRockUser.Text = "Rock";
            this.btnRockUser.UseVisualStyleBackColor = false;
            this.btnRockUser.Click += new System.EventHandler(this.btnRockUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Rock_Paper_Scissors_Game.Properties.Resources.User;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(11, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 152);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnPaperUser
            // 
            this.btnPaperUser.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnPaperUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaperUser.FlatAppearance.BorderSize = 0;
            this.btnPaperUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaperUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPaperUser.ForeColor = System.Drawing.Color.White;
            this.btnPaperUser.Location = new System.Drawing.Point(131, 176);
            this.btnPaperUser.Name = "btnPaperUser";
            this.btnPaperUser.Size = new System.Drawing.Size(109, 39);
            this.btnPaperUser.TabIndex = 2;
            this.btnPaperUser.Text = "Paper";
            this.btnPaperUser.UseVisualStyleBackColor = false;
            this.btnPaperUser.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnScissorsUser
            // 
            this.btnScissorsUser.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnScissorsUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScissorsUser.FlatAppearance.BorderSize = 0;
            this.btnScissorsUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScissorsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnScissorsUser.ForeColor = System.Drawing.Color.White;
            this.btnScissorsUser.Location = new System.Drawing.Point(253, 176);
            this.btnScissorsUser.Name = "btnScissorsUser";
            this.btnScissorsUser.Size = new System.Drawing.Size(109, 39);
            this.btnScissorsUser.TabIndex = 3;
            this.btnScissorsUser.Text = "Scissors";
            this.btnScissorsUser.UseVisualStyleBackColor = false;
            this.btnScissorsUser.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblResultUser
            // 
            this.lblResultUser.AutoSize = true;
            this.lblResultUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.lblResultUser.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblResultUser.Location = new System.Drawing.Point(245, 67);
            this.lblResultUser.Name = "lblResultUser";
            this.lblResultUser.Size = new System.Drawing.Size(43, 47);
            this.lblResultUser.TabIndex = 4;
            this.lblResultUser.Text = "0";
            this.lblResultUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(451, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 54);
            this.label2.TabIndex = 5;
            this.label2.Text = "VS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(172, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 152);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnScissorsComputer
            // 
            this.btnScissorsComputer.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnScissorsComputer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScissorsComputer.FlatAppearance.BorderSize = 0;
            this.btnScissorsComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScissorsComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnScissorsComputer.ForeColor = System.Drawing.Color.White;
            this.btnScissorsComputer.Location = new System.Drawing.Point(7, 176);
            this.btnScissorsComputer.Name = "btnScissorsComputer";
            this.btnScissorsComputer.Size = new System.Drawing.Size(109, 39);
            this.btnScissorsComputer.TabIndex = 7;
            this.btnScissorsComputer.Text = "Scissors";
            this.btnScissorsComputer.UseVisualStyleBackColor = false;
            // 
            // btnPaperComputer
            // 
            this.btnPaperComputer.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnPaperComputer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaperComputer.FlatAppearance.BorderSize = 0;
            this.btnPaperComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaperComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPaperComputer.ForeColor = System.Drawing.Color.White;
            this.btnPaperComputer.Location = new System.Drawing.Point(126, 176);
            this.btnPaperComputer.Name = "btnPaperComputer";
            this.btnPaperComputer.Size = new System.Drawing.Size(109, 39);
            this.btnPaperComputer.TabIndex = 8;
            this.btnPaperComputer.Text = "Paper";
            this.btnPaperComputer.UseVisualStyleBackColor = false;
            // 
            // btnRockComputer
            // 
            this.btnRockComputer.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnRockComputer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRockComputer.FlatAppearance.BorderSize = 0;
            this.btnRockComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRockComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnRockComputer.ForeColor = System.Drawing.Color.White;
            this.btnRockComputer.Location = new System.Drawing.Point(244, 176);
            this.btnRockComputer.Name = "btnRockComputer";
            this.btnRockComputer.Size = new System.Drawing.Size(109, 39);
            this.btnRockComputer.TabIndex = 9;
            this.btnRockComputer.Text = "Rock";
            this.btnRockComputer.UseVisualStyleBackColor = false;
            // 
            // lblResultComputer
            // 
            this.lblResultComputer.AutoSize = true;
            this.lblResultComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.lblResultComputer.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblResultComputer.Location = new System.Drawing.Point(73, 61);
            this.lblResultComputer.Name = "lblResultComputer";
            this.lblResultComputer.Size = new System.Drawing.Size(43, 47);
            this.lblResultComputer.TabIndex = 10;
            this.lblResultComputer.Text = "0";
            this.lblResultComputer.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(453, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "Draw";
            // 
            // lblResultDraw
            // 
            this.lblResultDraw.AutoSize = true;
            this.lblResultDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.lblResultDraw.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblResultDraw.Location = new System.Drawing.Point(475, 238);
            this.lblResultDraw.Name = "lblResultDraw";
            this.lblResultDraw.Size = new System.Drawing.Size(43, 47);
            this.lblResultDraw.TabIndex = 12;
            this.lblResultDraw.Text = "0";
            // 
            // lblTotalUserBonus
            // 
            this.lblTotalUserBonus.AutoSize = true;
            this.lblTotalUserBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.lblTotalUserBonus.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTotalUserBonus.Location = new System.Drawing.Point(904, 8);
            this.lblTotalUserBonus.Name = "lblTotalUserBonus";
            this.lblTotalUserBonus.Size = new System.Drawing.Size(66, 47);
            this.lblTotalUserBonus.TabIndex = 13;
            this.lblTotalUserBonus.Text = "0$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(301, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Level :";
            // 
            // cmbLevels
            // 
            this.cmbLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevels.FormattingEnabled = true;
            this.cmbLevels.ItemHeight = 13;
            this.cmbLevels.Items.AddRange(new object[] {
            "Easy",
            "Hard"});
            this.cmbLevels.Location = new System.Drawing.Point(356, 26);
            this.cmbLevels.Name = "cmbLevels";
            this.cmbLevels.Size = new System.Drawing.Size(121, 21);
            this.cmbLevels.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(513, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Rounds :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmbRounds
            // 
            this.cmbRounds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRounds.FormattingEnabled = true;
            this.cmbRounds.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "9"});
            this.cmbRounds.Location = new System.Drawing.Point(593, 25);
            this.cmbRounds.Name = "cmbRounds";
            this.cmbRounds.Size = new System.Drawing.Size(121, 21);
            this.cmbRounds.TabIndex = 17;
            this.cmbRounds.Tag = "0";
            this.cmbRounds.SelectedIndexChanged += new System.EventHandler(this.cmbRounds_SelectedIndexChanged);
            // 
            // pnlComputerInfo
            // 
            this.pnlComputerInfo.Controls.Add(this.pictureBox2);
            this.pnlComputerInfo.Controls.Add(this.btnRockComputer);
            this.pnlComputerInfo.Controls.Add(this.btnPaperComputer);
            this.pnlComputerInfo.Controls.Add(this.btnScissorsComputer);
            this.pnlComputerInfo.Controls.Add(this.lblResultComputer);
            this.pnlComputerInfo.Location = new System.Drawing.Point(630, 62);
            this.pnlComputerInfo.Name = "pnlComputerInfo";
            this.pnlComputerInfo.Size = new System.Drawing.Size(357, 222);
            this.pnlComputerInfo.TabIndex = 18;
            this.pnlComputerInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Controls.Add(this.pictureBox1);
            this.pnlUserInfo.Controls.Add(this.btnRockUser);
            this.pnlUserInfo.Controls.Add(this.btnPaperUser);
            this.pnlUserInfo.Controls.Add(this.btnScissorsUser);
            this.pnlUserInfo.Controls.Add(this.lblResultUser);
            this.pnlUserInfo.Location = new System.Drawing.Point(12, 62);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(370, 222);
            this.pnlUserInfo.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(606, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbIconUserChoise
            // 
            this.pbIconUserChoise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIconUserChoise.Location = new System.Drawing.Point(210, 290);
            this.pbIconUserChoise.Name = "pbIconUserChoise";
            this.pbIconUserChoise.Size = new System.Drawing.Size(90, 63);
            this.pbIconUserChoise.TabIndex = 20;
            this.pbIconUserChoise.TabStop = false;
            // 
            // pbIconComputerChoise
            // 
            this.pbIconComputerChoise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIconComputerChoise.Location = new System.Drawing.Point(656, 290);
            this.pbIconComputerChoise.Name = "pbIconComputerChoise";
            this.pbIconComputerChoise.Size = new System.Drawing.Size(90, 63);
            this.pbIconComputerChoise.TabIndex = 21;
            this.pbIconComputerChoise.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msStoreOptins});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msStoreOptins
            // 
            this.msStoreOptins.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shopToolStripMenuItem,
            this.buyCoinsToolStripMenuItem});
            this.msStoreOptins.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.msStoreOptins.Name = "msStoreOptins";
            this.msStoreOptins.Size = new System.Drawing.Size(46, 20);
            this.msStoreOptins.Text = "Store";
            this.msStoreOptins.MouseEnter += new System.EventHandler(this.msStoreOptins_MouseEnter);
            this.msStoreOptins.MouseHover += new System.EventHandler(this.msStoreOptins_MouseHover);
            // 
            // shopToolStripMenuItem
            // 
            this.shopToolStripMenuItem.Name = "shopToolStripMenuItem";
            this.shopToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.shopToolStripMenuItem.Text = "Shop";
            this.shopToolStripMenuItem.Click += new System.EventHandler(this.shopToolStripMenuItem_Click);
            // 
            // buyCoinsToolStripMenuItem
            // 
            this.buyCoinsToolStripMenuItem.Name = "buyCoinsToolStripMenuItem";
            this.buyCoinsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.buyCoinsToolStripMenuItem.Text = "Buy Coins";
            this.buyCoinsToolStripMenuItem.Click += new System.EventHandler(this.buyCoinsToolStripMenuItem_Click);
            // 
            // btnResetGame
            // 
            this.btnResetGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnResetGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetGame.FlatAppearance.BorderSize = 0;
            this.btnResetGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnResetGame.ForeColor = System.Drawing.Color.Black;
            this.btnResetGame.Location = new System.Drawing.Point(807, 408);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(163, 39);
            this.btnResetGame.TabIndex = 23;
            this.btnResetGame.Text = "Reset Game";
            this.btnResetGame.UseVisualStyleBackColor = false;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // lblRoundNumber
            // 
            this.lblRoundNumber.AutoSize = true;
            this.lblRoundNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundNumber.Location = new System.Drawing.Point(457, 290);
            this.lblRoundNumber.Name = "lblRoundNumber";
            this.lblRoundNumber.Size = new System.Drawing.Size(40, 18);
            this.lblRoundNumber.TabIndex = 24;
            this.lblRoundNumber.Text = "        ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(388, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Winner :";
            // 
            // lblResultRound
            // 
            this.lblResultRound.AutoSize = true;
            this.lblResultRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultRound.ForeColor = System.Drawing.Color.Red;
            this.lblResultRound.Location = new System.Drawing.Point(478, 316);
            this.lblResultRound.Name = "lblResultRound";
            this.lblResultRound.Size = new System.Drawing.Size(80, 24);
            this.lblResultRound.TabIndex = 26;
            this.lblResultRound.Text = "              ";
            this.lblResultRound.UseMnemonic = false;
            // 
            // pnlDisplayFinalResults
            // 
            this.pnlDisplayFinalResults.AutoScroll = true;
            this.pnlDisplayFinalResults.Controls.Add(this.lblDisplayFinalResults);
            this.pnlDisplayFinalResults.Controls.Add(this.lblResults);
            this.pnlDisplayFinalResults.Location = new System.Drawing.Point(12, 290);
            this.pnlDisplayFinalResults.Name = "pnlDisplayFinalResults";
            this.pnlDisplayFinalResults.Size = new System.Drawing.Size(179, 157);
            this.pnlDisplayFinalResults.TabIndex = 27;
            // 
            // lblDisplayFinalResults
            // 
            this.lblDisplayFinalResults.AutoSize = true;
            this.lblDisplayFinalResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDisplayFinalResults.Location = new System.Drawing.Point(24, 36);
            this.lblDisplayFinalResults.Name = "lblDisplayFinalResults";
            this.lblDisplayFinalResults.Size = new System.Drawing.Size(0, 16);
            this.lblDisplayFinalResults.TabIndex = 29;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.BackColor = System.Drawing.Color.White;
            this.lblResults.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.Color.Red;
            this.lblResults.Location = new System.Drawing.Point(5, 5);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(109, 19);
            this.lblResults.TabIndex = 28;
            this.lblResults.Text = "Final Results :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 459);
            this.Controls.Add(this.pnlDisplayFinalResults);
            this.Controls.Add(this.lblResultRound);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRoundNumber);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.pbIconComputerChoise);
            this.Controls.Add(this.pbIconUserChoise);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlUserInfo);
            this.Controls.Add(this.pnlComputerInfo);
            this.Controls.Add(this.cmbRounds);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbLevels);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalUserBonus);
            this.Controls.Add(this.lblResultDraw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "X-O Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlComputerInfo.ResumeLayout(false);
            this.pnlComputerInfo.PerformLayout();
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconUserChoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconComputerChoise)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDisplayFinalResults.ResumeLayout(false);
            this.pnlDisplayFinalResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRockUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPaperUser;
        private System.Windows.Forms.Button btnScissorsUser;
        private System.Windows.Forms.Label lblResultUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnScissorsComputer;
        private System.Windows.Forms.Button btnPaperComputer;
        private System.Windows.Forms.Button btnRockComputer;
        private System.Windows.Forms.Label lblResultComputer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultDraw;
        private System.Windows.Forms.Label lblTotalUserBonus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbLevels;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbRounds;
        private System.Windows.Forms.Panel pnlComputerInfo;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbIconUserChoise;
        private System.Windows.Forms.PictureBox pbIconComputerChoise;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msStoreOptins;
        private System.Windows.Forms.ToolStripMenuItem shopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyCoinsToolStripMenuItem;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Label lblRoundNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultRound;
        private System.Windows.Forms.Panel pnlDisplayFinalResults;
        private System.Windows.Forms.Label lblDisplayFinalResults;
        private System.Windows.Forms.Label lblResults;
    }
}

