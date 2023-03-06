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
            this.label1 = new System.Windows.Forms.Label();
            this.MainGame = new System.Windows.Forms.TabPage();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreCount = new System.Windows.Forms.Label();
            this.tabController.SuspendLayout();
            this.StartPage.SuspendLayout();
            this.MainGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.StartPage);
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
            this.StartPage.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(709, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 111);
            this.label1.TabIndex = 3;
            this.label1.Text = ".NOM";
            // 
            // MainGame
            // 
            this.MainGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainGame.BackgroundImage")));
            this.MainGame.Controls.Add(this.ScoreCount);
            this.MainGame.Controls.Add(this.ScoreLabel);
            this.MainGame.Controls.Add(this.label3);
            this.MainGame.Controls.Add(this.pbCanvas);
            this.MainGame.Location = new System.Drawing.Point(4, 25);
            this.MainGame.Name = "MainGame";
            this.MainGame.Size = new System.Drawing.Size(1763, 802);
            this.MainGame.TabIndex = 2;
            this.MainGame.Text = "MainGame";
            this.MainGame.UseVisualStyleBackColor = true;
            this.MainGame.Click += new System.EventHandler(this.MainGame_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ScoreLabel.Location = new System.Drawing.Point(742, 66);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(101, 36);
            this.ScoreLabel.TabIndex = 9;
            this.ScoreLabel.Text = "Score:";
            this.ScoreLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(714, 689);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 34);
            this.label3.TabIndex = 8;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.Paint += new System.Windows.Forms.PaintEventHandler(this.updateGraphics);
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
            // ScoreCount
            // 
            this.ScoreCount.AutoSize = true;
            this.ScoreCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreCount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ScoreCount.Location = new System.Drawing.Point(880, 69);
            this.ScoreCount.Name = "ScoreCount";
            this.ScoreCount.Size = new System.Drawing.Size(58, 40);
            this.ScoreCount.TabIndex = 10;
            this.ScoreCount.Text = "00";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage StartPage;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.TabPage MainGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ScoreCount;
    }
}