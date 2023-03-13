namespace Game
{
    partial class MainGamePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGamePage));
            this.tabController = new System.Windows.Forms.TabControl();
            this.StartPage = new System.Windows.Forms.TabPage();
            this.startButton = new System.Windows.Forms.Button();
            this.GameTitle = new System.Windows.Forms.Label();
            this.MainGame = new System.Windows.Forms.TabPage();
            this.ScoreCount2 = new System.Windows.Forms.Label();
            this.ScoreLabel2 = new System.Windows.Forms.Label();
            this.FinalScoreText = new System.Windows.Forms.Label();
            this.RestartGameText = new System.Windows.Forms.Label();
            this.ScoreCount = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GameOverText = new System.Windows.Forms.Label();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.PlayerChoicePage = new System.Windows.Forms.TabPage();
            this.SinglePlayerButton = new System.Windows.Forms.Button();
            this.PlayerChoices = new System.Windows.Forms.Label();
            this.MultiplayerButton = new System.Windows.Forms.Button();
            this.tabController.SuspendLayout();
            this.StartPage.SuspendLayout();
            this.MainGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.PlayerChoicePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.StartPage);
            this.tabController.Controls.Add(this.PlayerChoicePage);
            this.tabController.Controls.Add(this.MainGame);
            this.tabController.Location = new System.Drawing.Point(-15, -63);
            this.tabController.Margin = new System.Windows.Forms.Padding(4);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(2204, 1003);
            this.tabController.TabIndex = 3;
            this.tabController.Click += new System.EventHandler(this.tabController_Click);
            this.tabController.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabController_KeyDown);
            // 
            // StartPage
            // 
            this.StartPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartPage.BackgroundImage")));
            this.StartPage.Controls.Add(this.startButton);
            this.StartPage.Controls.Add(this.GameTitle);
            this.StartPage.Location = new System.Drawing.Point(4, 25);
            this.StartPage.Margin = new System.Windows.Forms.Padding(4);
            this.StartPage.Name = "StartPage";
            this.StartPage.Padding = new System.Windows.Forms.Padding(4);
            this.StartPage.Size = new System.Drawing.Size(2196, 974);
            this.StartPage.TabIndex = 0;
            this.StartPage.Text = "StartPage";
            this.StartPage.UseVisualStyleBackColor = true;
            this.StartPage.Click += new System.EventHandler(this.StartPage_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startButton.BackgroundImage")));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startButton.Location = new System.Drawing.Point(651, 404);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(408, 103);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // GameTitle
            // 
            this.GameTitle.AutoSize = true;
            this.GameTitle.BackColor = System.Drawing.Color.Transparent;
            this.GameTitle.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GameTitle.Location = new System.Drawing.Point(709, 186);
            this.GameTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(282, 111);
            this.GameTitle.TabIndex = 3;
            this.GameTitle.Text = ".NOM";
            // 
            // MainGame
            // 
            this.MainGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainGame.BackgroundImage")));
            this.MainGame.Controls.Add(this.ScoreCount2);
            this.MainGame.Controls.Add(this.ScoreLabel2);
            this.MainGame.Controls.Add(this.FinalScoreText);
            this.MainGame.Controls.Add(this.RestartGameText);
            this.MainGame.Controls.Add(this.ScoreCount);
            this.MainGame.Controls.Add(this.ScoreLabel);
            this.MainGame.Controls.Add(this.GameOverText);
            this.MainGame.Controls.Add(this.pbCanvas);
            this.MainGame.Location = new System.Drawing.Point(4, 25);
            this.MainGame.Name = "MainGame";
            this.MainGame.Size = new System.Drawing.Size(2196, 974);
            this.MainGame.TabIndex = 2;
            this.MainGame.Text = "MainGame";
            this.MainGame.UseVisualStyleBackColor = true;
            this.MainGame.Click += new System.EventHandler(this.MainGame_Click);
            // 
            // ScoreCount2
            // 
            this.ScoreCount2.AutoSize = true;
            this.ScoreCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreCount2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ScoreCount2.Location = new System.Drawing.Point(1230, 73);
            this.ScoreCount2.Name = "ScoreCount2";
            this.ScoreCount2.Size = new System.Drawing.Size(46, 32);
            this.ScoreCount2.TabIndex = 14;
            this.ScoreCount2.Text = "00";
            // 
            // ScoreLabel2
            // 
            this.ScoreLabel2.AutoSize = true;
            this.ScoreLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ScoreLabel2.Location = new System.Drawing.Point(1101, 69);
            this.ScoreLabel2.Name = "ScoreLabel2";
            this.ScoreLabel2.Size = new System.Drawing.Size(101, 36);
            this.ScoreLabel2.TabIndex = 13;
            this.ScoreLabel2.Text = "Score:";
            // 
            // FinalScoreText
            // 
            this.FinalScoreText.AutoSize = true;
            this.FinalScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalScoreText.ForeColor = System.Drawing.Color.LimeGreen;
            this.FinalScoreText.Location = new System.Drawing.Point(844, 494);
            this.FinalScoreText.Name = "FinalScoreText";
            this.FinalScoreText.Size = new System.Drawing.Size(0, 29);
            this.FinalScoreText.TabIndex = 12;
            this.FinalScoreText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FinalScoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // RestartGameText
            // 
            this.RestartGameText.AutoSize = true;
            this.RestartGameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartGameText.ForeColor = System.Drawing.Color.Red;
            this.RestartGameText.Location = new System.Drawing.Point(843, 710);
            this.RestartGameText.Name = "RestartGameText";
            this.RestartGameText.Size = new System.Drawing.Size(0, 32);
            this.RestartGameText.TabIndex = 11;
            this.RestartGameText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ScoreCount
            // 
            this.ScoreCount.AutoSize = true;
            this.ScoreCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreCount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ScoreCount.Location = new System.Drawing.Point(485, 72);
            this.ScoreCount.Name = "ScoreCount";
            this.ScoreCount.Size = new System.Drawing.Size(46, 32);
            this.ScoreCount.TabIndex = 10;
            this.ScoreCount.Text = "00";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ScoreLabel.Location = new System.Drawing.Point(356, 68);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(101, 36);
            this.ScoreLabel.TabIndex = 9;
            this.ScoreLabel.Text = "Score:";
            this.ScoreLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // GameOverText
            // 
            this.GameOverText.AutoSize = true;
            this.GameOverText.BackColor = System.Drawing.Color.Transparent;
            this.GameOverText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverText.ForeColor = System.Drawing.Color.Red;
            this.GameOverText.Location = new System.Drawing.Point(843, 309);
            this.GameOverText.Name = "GameOverText";
            this.GameOverText.Size = new System.Drawing.Size(0, 34);
            this.GameOverText.TabIndex = 8;
            this.GameOverText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GameOverText.Click += new System.EventHandler(this.label3_Click);
            this.GameOverText.Paint += new System.Windows.Forms.PaintEventHandler(this.updateGraphics);
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCanvas.BackgroundImage")));
            this.pbCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCanvas.Location = new System.Drawing.Point(132, 128);
            this.pbCanvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(1487, 541);
            this.pbCanvas.TabIndex = 5;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Click += new System.EventHandler(this.pbCanvas_Click);
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.updateGraphics);
            // 
            // PlayerChoicePage
            // 
            this.PlayerChoicePage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayerChoicePage.BackgroundImage")));
            this.PlayerChoicePage.Controls.Add(this.MultiplayerButton);
            this.PlayerChoicePage.Controls.Add(this.SinglePlayerButton);
            this.PlayerChoicePage.Controls.Add(this.PlayerChoices);
            this.PlayerChoicePage.Location = new System.Drawing.Point(4, 25);
            this.PlayerChoicePage.Name = "PlayerChoicePage";
            this.PlayerChoicePage.Size = new System.Drawing.Size(2196, 974);
            this.PlayerChoicePage.TabIndex = 3;
            this.PlayerChoicePage.Text = "PlayerChoicePage";
            this.PlayerChoicePage.UseVisualStyleBackColor = true;
            // 
            // SinglePlayerButton
            // 
            this.SinglePlayerButton.BackColor = System.Drawing.Color.Transparent;
            this.SinglePlayerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SinglePlayerButton.BackgroundImage")));
            this.SinglePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SinglePlayerButton.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinglePlayerButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SinglePlayerButton.Location = new System.Drawing.Point(687, 280);
            this.SinglePlayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.SinglePlayerButton.Name = "SinglePlayerButton";
            this.SinglePlayerButton.Size = new System.Drawing.Size(408, 103);
            this.SinglePlayerButton.TabIndex = 6;
            this.SinglePlayerButton.Text = "Singleplayer";
            this.SinglePlayerButton.UseVisualStyleBackColor = false;
            // 
            // PlayerChoices
            // 
            this.PlayerChoices.AutoSize = true;
            this.PlayerChoices.BackColor = System.Drawing.Color.Transparent;
            this.PlayerChoices.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerChoices.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayerChoices.Location = new System.Drawing.Point(601, 77);
            this.PlayerChoices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerChoices.Name = "PlayerChoices";
            this.PlayerChoices.Size = new System.Drawing.Size(602, 111);
            this.PlayerChoices.TabIndex = 5;
            this.PlayerChoices.Text = "Player Choices";
            // 
            // MultiplayerButton
            // 
            this.MultiplayerButton.BackColor = System.Drawing.Color.Transparent;
            this.MultiplayerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MultiplayerButton.BackgroundImage")));
            this.MultiplayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MultiplayerButton.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplayerButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MultiplayerButton.Location = new System.Drawing.Point(687, 437);
            this.MultiplayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.MultiplayerButton.Name = "MultiplayerButton";
            this.MultiplayerButton.Size = new System.Drawing.Size(408, 103);
            this.MultiplayerButton.TabIndex = 7;
            this.MultiplayerButton.Text = "Multiplayer";
            this.MultiplayerButton.UseVisualStyleBackColor = false;
            this.MultiplayerButton.Click += new System.EventHandler(this.MultiplayerButton_Click);
            // 
            // MainGamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1710, 746);
            this.Controls.Add(this.tabController);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainGamePage";
            this.Text = "StartScreen";
            this.tabController.ResumeLayout(false);
            this.StartPage.ResumeLayout(false);
            this.StartPage.PerformLayout();
            this.MainGame.ResumeLayout(false);
            this.MainGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.PlayerChoicePage.ResumeLayout(false);
            this.PlayerChoicePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage StartPage;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label GameTitle;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.TabPage MainGame;
        private System.Windows.Forms.Label GameOverText;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ScoreCount;
        private System.Windows.Forms.Label RestartGameText;
        private System.Windows.Forms.Label FinalScoreText;
        private System.Windows.Forms.Label ScoreCount2;
        private System.Windows.Forms.Label ScoreLabel2;
        private System.Windows.Forms.TabPage PlayerChoicePage;
        private System.Windows.Forms.Button MultiplayerButton;
        private System.Windows.Forms.Button SinglePlayerButton;
        private System.Windows.Forms.Label PlayerChoices;
    }
}