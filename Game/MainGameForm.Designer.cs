namespace Game
{
    partial class MainGameForm
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
            this.tabController = new System.Windows.Forms.TabControl();
            this.StartPage = new System.Windows.Forms.TabPage();
            this.GameTitlePic = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.PlayerChoicePage = new System.Windows.Forms.TabPage();
            this.MultiplayerButton = new System.Windows.Forms.Button();
            this.SinglePlayerButton = new System.Windows.Forms.Button();
            this.PlayerChoices = new System.Windows.Forms.Label();
            this.SPAndMPGame = new System.Windows.Forms.TabPage();
            this.hamImage = new System.Windows.Forms.PictureBox();
            this.FinalScoreBlueSnakeText = new System.Windows.Forms.Label();
            this.ScoreCount2 = new System.Windows.Forms.Label();
            this.ScoreLabel2 = new System.Windows.Forms.Label();
            this.FinalScoreGreenSnakeText = new System.Windows.Forms.Label();
            this.RestartGameText = new System.Windows.Forms.Label();
            this.ScoreCount = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GameOverText = new System.Windows.Forms.Label();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.tabController.SuspendLayout();
            this.StartPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameTitlePic)).BeginInit();
            this.PlayerChoicePage.SuspendLayout();
            this.SPAndMPGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hamImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.StartPage);
            this.tabController.Controls.Add(this.PlayerChoicePage);
            this.tabController.Controls.Add(this.SPAndMPGame);
            this.tabController.Location = new System.Drawing.Point(-3, -63);
            this.tabController.Margin = new System.Windows.Forms.Padding(4);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(1212, 875);
            this.tabController.TabIndex = 3;
            this.tabController.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabController_KeyDown);
            // 
            // StartPage
            // 
            this.StartPage.BackColor = System.Drawing.Color.Black;
            this.StartPage.Controls.Add(this.GameTitlePic);
            this.StartPage.Controls.Add(this.startButton);
            this.StartPage.Location = new System.Drawing.Point(4, 25);
            this.StartPage.Margin = new System.Windows.Forms.Padding(4);
            this.StartPage.Name = "StartPage";
            this.StartPage.Padding = new System.Windows.Forms.Padding(4);
            this.StartPage.Size = new System.Drawing.Size(1204, 846);
            this.StartPage.TabIndex = 0;
            this.StartPage.Text = "StartPage";
            // 
            // GameTitlePic
            // 
            this.GameTitlePic.BackColor = System.Drawing.Color.Transparent;
            this.GameTitlePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GameTitlePic.Image = global::Game.Properties.Resources.logo3;
            this.GameTitlePic.Location = new System.Drawing.Point(154, 128);
            this.GameTitlePic.Name = "GameTitlePic";
            this.GameTitlePic.Size = new System.Drawing.Size(819, 380);
            this.GameTitlePic.TabIndex = 5;
            this.GameTitlePic.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.ForestGreen;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Black;
            this.startButton.Location = new System.Drawing.Point(437, 555);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(362, 103);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // PlayerChoicePage
            // 
            this.PlayerChoicePage.BackColor = System.Drawing.Color.Black;
            this.PlayerChoicePage.Controls.Add(this.MultiplayerButton);
            this.PlayerChoicePage.Controls.Add(this.SinglePlayerButton);
            this.PlayerChoicePage.Controls.Add(this.PlayerChoices);
            this.PlayerChoicePage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayerChoicePage.Location = new System.Drawing.Point(4, 25);
            this.PlayerChoicePage.Name = "PlayerChoicePage";
            this.PlayerChoicePage.Size = new System.Drawing.Size(1204, 846);
            this.PlayerChoicePage.TabIndex = 3;
            this.PlayerChoicePage.Text = "PlayerChoicePage";
            // 
            // MultiplayerButton
            // 
            this.MultiplayerButton.BackColor = System.Drawing.Color.ForestGreen;
            this.MultiplayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MultiplayerButton.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplayerButton.ForeColor = System.Drawing.Color.Black;
            this.MultiplayerButton.Location = new System.Drawing.Point(396, 552);
            this.MultiplayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.MultiplayerButton.Name = "MultiplayerButton";
            this.MultiplayerButton.Size = new System.Drawing.Size(408, 103);
            this.MultiplayerButton.TabIndex = 7;
            this.MultiplayerButton.Text = "Multiplayer";
            this.MultiplayerButton.UseVisualStyleBackColor = false;
            this.MultiplayerButton.Click += new System.EventHandler(this.MultiplayerButton_Click);
            // 
            // SinglePlayerButton
            // 
            this.SinglePlayerButton.BackColor = System.Drawing.Color.ForestGreen;
            this.SinglePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SinglePlayerButton.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinglePlayerButton.ForeColor = System.Drawing.Color.Black;
            this.SinglePlayerButton.Location = new System.Drawing.Point(396, 386);
            this.SinglePlayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.SinglePlayerButton.Name = "SinglePlayerButton";
            this.SinglePlayerButton.Size = new System.Drawing.Size(408, 103);
            this.SinglePlayerButton.TabIndex = 6;
            this.SinglePlayerButton.Text = "Singleplayer";
            this.SinglePlayerButton.UseVisualStyleBackColor = false;
            this.SinglePlayerButton.Click += new System.EventHandler(this.SinglePlayerButton_Click);
            // 
            // PlayerChoices
            // 
            this.PlayerChoices.AutoSize = true;
            this.PlayerChoices.BackColor = System.Drawing.Color.Transparent;
            this.PlayerChoices.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerChoices.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayerChoices.Location = new System.Drawing.Point(198, 130);
            this.PlayerChoices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerChoices.Name = "PlayerChoices";
            this.PlayerChoices.Size = new System.Drawing.Size(791, 145);
            this.PlayerChoices.TabIndex = 5;
            this.PlayerChoices.Text = "Player Choices";
            // 
            // SPAndMPGame
            // 
            this.SPAndMPGame.BackColor = System.Drawing.Color.Black;
            this.SPAndMPGame.Controls.Add(this.hamImage);
            this.SPAndMPGame.Controls.Add(this.FinalScoreBlueSnakeText);
            this.SPAndMPGame.Controls.Add(this.ScoreCount2);
            this.SPAndMPGame.Controls.Add(this.ScoreLabel2);
            this.SPAndMPGame.Controls.Add(this.FinalScoreGreenSnakeText);
            this.SPAndMPGame.Controls.Add(this.RestartGameText);
            this.SPAndMPGame.Controls.Add(this.ScoreCount);
            this.SPAndMPGame.Controls.Add(this.ScoreLabel);
            this.SPAndMPGame.Controls.Add(this.GameOverText);
            this.SPAndMPGame.Controls.Add(this.pbCanvas);
            this.SPAndMPGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SPAndMPGame.Location = new System.Drawing.Point(4, 25);
            this.SPAndMPGame.Name = "SPAndMPGame";
            this.SPAndMPGame.Size = new System.Drawing.Size(1204, 846);
            this.SPAndMPGame.TabIndex = 2;
            this.SPAndMPGame.Text = "SPAndMPGame";
            // 
            // hamImage
            // 
            this.hamImage.Location = new System.Drawing.Point(594, 371);
            this.hamImage.Name = "hamImage";
            this.hamImage.Size = new System.Drawing.Size(66, 56);
            this.hamImage.TabIndex = 16;
            this.hamImage.TabStop = false;
            // 
            // FinalScoreBlueSnakeText
            // 
            this.FinalScoreBlueSnakeText.AutoSize = true;
            this.FinalScoreBlueSnakeText.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalScoreBlueSnakeText.ForeColor = System.Drawing.Color.LimeGreen;
            this.FinalScoreBlueSnakeText.Location = new System.Drawing.Point(403, 573);
            this.FinalScoreBlueSnakeText.Name = "FinalScoreBlueSnakeText";
            this.FinalScoreBlueSnakeText.Size = new System.Drawing.Size(439, 75);
            this.FinalScoreBlueSnakeText.TabIndex = 15;
            this.FinalScoreBlueSnakeText.Text = "BlueSnakeScore";
            this.FinalScoreBlueSnakeText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ScoreCount2
            // 
            this.ScoreCount2.AutoSize = true;
            this.ScoreCount2.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreCount2.ForeColor = System.Drawing.Color.Turquoise;
            this.ScoreCount2.Location = new System.Drawing.Point(410, 84);
            this.ScoreCount2.Name = "ScoreCount2";
            this.ScoreCount2.Size = new System.Drawing.Size(45, 35);
            this.ScoreCount2.TabIndex = 14;
            this.ScoreCount2.Text = "00";
            // 
            // ScoreLabel2
            // 
            this.ScoreLabel2.AutoSize = true;
            this.ScoreLabel2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel2.ForeColor = System.Drawing.Color.Turquoise;
            this.ScoreLabel2.Location = new System.Drawing.Point(125, 80);
            this.ScoreLabel2.Name = "ScoreLabel2";
            this.ScoreLabel2.Size = new System.Drawing.Size(232, 37);
            this.ScoreLabel2.TabIndex = 13;
            this.ScoreLabel2.Text = "BlueSnake Score:";
            // 
            // FinalScoreGreenSnakeText
            // 
            this.FinalScoreGreenSnakeText.AutoSize = true;
            this.FinalScoreGreenSnakeText.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalScoreGreenSnakeText.ForeColor = System.Drawing.Color.LimeGreen;
            this.FinalScoreGreenSnakeText.Location = new System.Drawing.Point(387, 430);
            this.FinalScoreGreenSnakeText.Name = "FinalScoreGreenSnakeText";
            this.FinalScoreGreenSnakeText.Size = new System.Drawing.Size(475, 75);
            this.FinalScoreGreenSnakeText.TabIndex = 12;
            this.FinalScoreGreenSnakeText.Text = "GreenSnakeScore";
            this.FinalScoreGreenSnakeText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RestartGameText
            // 
            this.RestartGameText.AutoSize = true;
            this.RestartGameText.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartGameText.ForeColor = System.Drawing.Color.Red;
            this.RestartGameText.Location = new System.Drawing.Point(408, 783);
            this.RestartGameText.Name = "RestartGameText";
            this.RestartGameText.Size = new System.Drawing.Size(131, 45);
            this.RestartGameText.TabIndex = 11;
            this.RestartGameText.Text = "Restart";
            this.RestartGameText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ScoreCount
            // 
            this.ScoreCount.AutoSize = true;
            this.ScoreCount.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreCount.ForeColor = System.Drawing.Color.ForestGreen;
            this.ScoreCount.Location = new System.Drawing.Point(1018, 84);
            this.ScoreCount.Name = "ScoreCount";
            this.ScoreCount.Size = new System.Drawing.Size(45, 35);
            this.ScoreCount.TabIndex = 10;
            this.ScoreCount.Text = "00";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.ScoreLabel.Location = new System.Drawing.Point(699, 81);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(250, 37);
            this.ScoreLabel.TabIndex = 9;
            this.ScoreLabel.Text = "GreenSnake Score:";
            // 
            // GameOverText
            // 
            this.GameOverText.AutoSize = true;
            this.GameOverText.BackColor = System.Drawing.Color.Transparent;
            this.GameOverText.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverText.ForeColor = System.Drawing.Color.Red;
            this.GameOverText.Location = new System.Drawing.Point(277, 223);
            this.GameOverText.Name = "GameOverText";
            this.GameOverText.Size = new System.Drawing.Size(585, 145);
            this.GameOverText.TabIndex = 8;
            this.GameOverText.Text = "Game Over";
            this.GameOverText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GameOverText.Paint += new System.Windows.Forms.PaintEventHandler(this.updateGraphics);
            // 
            // pbCanvas
            // 
            this.pbCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCanvas.Location = new System.Drawing.Point(132, 152);
            this.pbCanvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(921, 616);
            this.pbCanvas.TabIndex = 5;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.updateGraphics);
            // 
            // MainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 809);
            this.Controls.Add(this.tabController);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainGameForm";
            this.Text = "StartScreen";
            this.tabController.ResumeLayout(false);
            this.StartPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GameTitlePic)).EndInit();
            this.PlayerChoicePage.ResumeLayout(false);
            this.PlayerChoicePage.PerformLayout();
            this.SPAndMPGame.ResumeLayout(false);
            this.SPAndMPGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hamImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage StartPage;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.TabPage SPAndMPGame;
        private System.Windows.Forms.Label GameOverText;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ScoreCount;
        private System.Windows.Forms.Label RestartGameText;
        private System.Windows.Forms.Label FinalScoreGreenSnakeText;
        private System.Windows.Forms.Label ScoreCount2;
        private System.Windows.Forms.Label ScoreLabel2;
        private System.Windows.Forms.TabPage PlayerChoicePage;
        private System.Windows.Forms.Button MultiplayerButton;
        private System.Windows.Forms.Button SinglePlayerButton;
        private System.Windows.Forms.Label PlayerChoices;
        private System.Windows.Forms.PictureBox GameTitlePic;
        private System.Windows.Forms.Label FinalScoreBlueSnakeText;
        private System.Windows.Forms.PictureBox hamImage;
    }
}