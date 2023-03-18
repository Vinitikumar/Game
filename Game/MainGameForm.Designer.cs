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
            this.helpButton = new System.Windows.Forms.Button();
            this.multiplayerButton = new System.Windows.Forms.Button();
            this.singlePlayerButton = new System.Windows.Forms.Button();
            this.PlayerChoices = new System.Windows.Forms.Label();
            this.SPAndMPGame = new System.Windows.Forms.TabPage();
            this.FinalScoreBlueSnakeText = new System.Windows.Forms.Label();
            this.ScoreCountBlue = new System.Windows.Forms.Label();
            this.ScoreLabelBlue = new System.Windows.Forms.Label();
            this.FinalScoreGreenSnakeText = new System.Windows.Forms.Label();
            this.RestartGameText = new System.Windows.Forms.Label();
            this.ScoreCountGreen = new System.Windows.Forms.Label();
            this.ScoreLabelGreen = new System.Windows.Forms.Label();
            this.GameOverText = new System.Windows.Forms.Label();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.tabController.SuspendLayout();
            this.StartPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameTitlePic)).BeginInit();
            this.PlayerChoicePage.SuspendLayout();
            this.SPAndMPGame.SuspendLayout();
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
            this.GameTitlePic.Location = new System.Drawing.Point(155, 118);
            this.GameTitlePic.Name = "GameTitlePic";
            this.GameTitlePic.Size = new System.Drawing.Size(886, 383);
            this.GameTitlePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.PlayerChoicePage.Controls.Add(this.helpButton);
            this.PlayerChoicePage.Controls.Add(this.multiplayerButton);
            this.PlayerChoicePage.Controls.Add(this.singlePlayerButton);
            this.PlayerChoicePage.Controls.Add(this.PlayerChoices);
            this.PlayerChoicePage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayerChoicePage.Location = new System.Drawing.Point(4, 25);
            this.PlayerChoicePage.Name = "PlayerChoicePage";
            this.PlayerChoicePage.Size = new System.Drawing.Size(1204, 846);
            this.PlayerChoicePage.TabIndex = 3;
            this.PlayerChoicePage.Text = "PlayerChoicePage";
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Black;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.helpButton.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.helpButton.Location = new System.Drawing.Point(490, 713);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(212, 71);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // multiplayerButton
            // 
            this.multiplayerButton.BackColor = System.Drawing.Color.ForestGreen;
            this.multiplayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplayerButton.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplayerButton.ForeColor = System.Drawing.Color.Black;
            this.multiplayerButton.Location = new System.Drawing.Point(396, 552);
            this.multiplayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.multiplayerButton.Name = "multiplayerButton";
            this.multiplayerButton.Size = new System.Drawing.Size(408, 103);
            this.multiplayerButton.TabIndex = 7;
            this.multiplayerButton.Text = "Multiplayer";
            this.multiplayerButton.UseVisualStyleBackColor = false;
            this.multiplayerButton.Click += new System.EventHandler(this.multiplayerButton_Click);
            // 
            // singlePlayerButton
            // 
            this.singlePlayerButton.BackColor = System.Drawing.Color.ForestGreen;
            this.singlePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.singlePlayerButton.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singlePlayerButton.ForeColor = System.Drawing.Color.Black;
            this.singlePlayerButton.Location = new System.Drawing.Point(396, 386);
            this.singlePlayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.singlePlayerButton.Name = "singlePlayerButton";
            this.singlePlayerButton.Size = new System.Drawing.Size(408, 103);
            this.singlePlayerButton.TabIndex = 6;
            this.singlePlayerButton.Text = "Singleplayer";
            this.singlePlayerButton.UseVisualStyleBackColor = false;
            this.singlePlayerButton.Click += new System.EventHandler(this.singlePlayerButton_Click);
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
            this.SPAndMPGame.Controls.Add(this.FinalScoreBlueSnakeText);
            this.SPAndMPGame.Controls.Add(this.ScoreCountBlue);
            this.SPAndMPGame.Controls.Add(this.ScoreLabelBlue);
            this.SPAndMPGame.Controls.Add(this.FinalScoreGreenSnakeText);
            this.SPAndMPGame.Controls.Add(this.RestartGameText);
            this.SPAndMPGame.Controls.Add(this.ScoreCountGreen);
            this.SPAndMPGame.Controls.Add(this.ScoreLabelGreen);
            this.SPAndMPGame.Controls.Add(this.GameOverText);
            this.SPAndMPGame.Controls.Add(this.pbCanvas);
            this.SPAndMPGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SPAndMPGame.Location = new System.Drawing.Point(4, 25);
            this.SPAndMPGame.Name = "SPAndMPGame";
            this.SPAndMPGame.Size = new System.Drawing.Size(1204, 846);
            this.SPAndMPGame.TabIndex = 2;
            this.SPAndMPGame.Text = "SPAndMPGame";
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
            // ScoreCountBlue
            // 
            this.ScoreCountBlue.AutoSize = true;
            this.ScoreCountBlue.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreCountBlue.ForeColor = System.Drawing.Color.Turquoise;
            this.ScoreCountBlue.Location = new System.Drawing.Point(410, 84);
            this.ScoreCountBlue.Name = "ScoreCountBlue";
            this.ScoreCountBlue.Size = new System.Drawing.Size(45, 35);
            this.ScoreCountBlue.TabIndex = 14;
            this.ScoreCountBlue.Text = "00";
            // 
            // ScoreLabelBlue
            // 
            this.ScoreLabelBlue.AutoSize = true;
            this.ScoreLabelBlue.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabelBlue.ForeColor = System.Drawing.Color.Turquoise;
            this.ScoreLabelBlue.Location = new System.Drawing.Point(125, 80);
            this.ScoreLabelBlue.Name = "ScoreLabelBlue";
            this.ScoreLabelBlue.Size = new System.Drawing.Size(232, 37);
            this.ScoreLabelBlue.TabIndex = 13;
            this.ScoreLabelBlue.Text = "BlueSnake Score:";
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
            // ScoreCountGreen
            // 
            this.ScoreCountGreen.AutoSize = true;
            this.ScoreCountGreen.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreCountGreen.ForeColor = System.Drawing.Color.ForestGreen;
            this.ScoreCountGreen.Location = new System.Drawing.Point(1007, 85);
            this.ScoreCountGreen.Name = "ScoreCountGreen";
            this.ScoreCountGreen.Size = new System.Drawing.Size(45, 35);
            this.ScoreCountGreen.TabIndex = 10;
            this.ScoreCountGreen.Text = "00";
            // 
            // ScoreLabelGreen
            // 
            this.ScoreLabelGreen.AutoSize = true;
            this.ScoreLabelGreen.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabelGreen.ForeColor = System.Drawing.Color.ForestGreen;
            this.ScoreLabelGreen.Location = new System.Drawing.Point(688, 82);
            this.ScoreLabelGreen.Name = "ScoreLabelGreen";
            this.ScoreLabelGreen.Size = new System.Drawing.Size(250, 37);
            this.ScoreLabelGreen.TabIndex = 9;
            this.ScoreLabelGreen.Text = "GreenSnake Score:";
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
            this.MaximumSize = new System.Drawing.Size(1224, 856);
            this.Name = "MainGameForm";
            this.Text = "StartScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.tabController.ResumeLayout(false);
            this.StartPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GameTitlePic)).EndInit();
            this.PlayerChoicePage.ResumeLayout(false);
            this.PlayerChoicePage.PerformLayout();
            this.SPAndMPGame.ResumeLayout(false);
            this.SPAndMPGame.PerformLayout();
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
        private System.Windows.Forms.Label ScoreLabelGreen;
        private System.Windows.Forms.Label ScoreCountGreen;
        private System.Windows.Forms.Label RestartGameText;
        private System.Windows.Forms.Label FinalScoreGreenSnakeText;
        private System.Windows.Forms.Label ScoreCountBlue;
        private System.Windows.Forms.Label ScoreLabelBlue;
        private System.Windows.Forms.TabPage PlayerChoicePage;
        private System.Windows.Forms.Button multiplayerButton;
        private System.Windows.Forms.Button singlePlayerButton;
        private System.Windows.Forms.Label PlayerChoices;
        private System.Windows.Forms.PictureBox GameTitlePic;
        private System.Windows.Forms.Label FinalScoreBlueSnakeText;
        private System.Windows.Forms.Button helpButton;
    }
}