namespace Game
{
    partial class StartPages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPages));
            this.tabController = new System.Windows.Forms.TabControl();
            this.StartPage = new System.Windows.Forms.TabPage();
            this.PlayerChoicesPage = new System.Windows.Forms.TabPage();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.singlePlayer = new System.Windows.Forms.Button();
            this.multiPlayer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabController.SuspendLayout();
            this.StartPage.SuspendLayout();
            this.PlayerChoicesPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.StartPage);
            this.tabController.Controls.Add(this.PlayerChoicesPage);
            this.tabController.Location = new System.Drawing.Point(-11, -51);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(1260, 676);
            this.tabController.TabIndex = 3;
            // 
            // StartPage
            // 
            this.StartPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartPage.BackgroundImage")));
            this.StartPage.Controls.Add(this.startButton);
            this.StartPage.Controls.Add(this.label1);
            this.StartPage.Location = new System.Drawing.Point(4, 22);
            this.StartPage.Name = "StartPage";
            this.StartPage.Padding = new System.Windows.Forms.Padding(3);
            this.StartPage.Size = new System.Drawing.Size(1252, 650);
            this.StartPage.TabIndex = 0;
            this.StartPage.Text = "StartPage";
            this.StartPage.UseVisualStyleBackColor = true;
            // 
            // PlayerChoicesPage
            // 
            this.PlayerChoicesPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayerChoicesPage.BackgroundImage")));
            this.PlayerChoicesPage.Controls.Add(this.singlePlayer);
            this.PlayerChoicesPage.Controls.Add(this.multiPlayer);
            this.PlayerChoicesPage.Controls.Add(this.label2);
            this.PlayerChoicesPage.Location = new System.Drawing.Point(4, 22);
            this.PlayerChoicesPage.Name = "PlayerChoicesPage";
            this.PlayerChoicesPage.Padding = new System.Windows.Forms.Padding(3);
            this.PlayerChoicesPage.Size = new System.Drawing.Size(1252, 650);
            this.PlayerChoicesPage.TabIndex = 1;
            this.PlayerChoicesPage.Text = "PlayerChoicesPage";
            this.PlayerChoicesPage.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startButton.BackgroundImage")));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startButton.Location = new System.Drawing.Point(488, 328);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(306, 84);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(532, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 90);
            this.label1.TabIndex = 3;
            this.label1.Text = ".NOM";
            // 
            // singlePlayer
            // 
            this.singlePlayer.BackColor = System.Drawing.Color.Transparent;
            this.singlePlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("singlePlayer.BackgroundImage")));
            this.singlePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.singlePlayer.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.singlePlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.singlePlayer.Location = new System.Drawing.Point(466, 205);
            this.singlePlayer.Name = "singlePlayer";
            this.singlePlayer.Size = new System.Drawing.Size(306, 84);
            this.singlePlayer.TabIndex = 9;
            this.singlePlayer.Text = "Single Player";
            this.singlePlayer.UseVisualStyleBackColor = false;
            this.singlePlayer.Click += new System.EventHandler(this.singlePlayer_Click);
            // 
            // multiPlayer
            // 
            this.multiPlayer.BackColor = System.Drawing.Color.Transparent;
            this.multiPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("multiPlayer.BackgroundImage")));
            this.multiPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiPlayer.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.multiPlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.multiPlayer.Location = new System.Drawing.Point(466, 321);
            this.multiPlayer.Name = "multiPlayer";
            this.multiPlayer.Size = new System.Drawing.Size(306, 84);
            this.multiPlayer.TabIndex = 8;
            this.multiPlayer.Text = "Multiplayer";
            this.multiPlayer.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(433, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 67);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player Choices:";
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1235, 601);
            this.Controls.Add(this.tabController);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.tabController.ResumeLayout(false);
            this.StartPage.ResumeLayout(false);
            this.StartPage.PerformLayout();
            this.PlayerChoicesPage.ResumeLayout(false);
            this.PlayerChoicesPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage StartPage;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage PlayerChoicesPage;
        private System.Windows.Forms.Button singlePlayer;
        private System.Windows.Forms.Button multiPlayer;
        private System.Windows.Forms.Label label2;
    }
}