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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
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
            this.tabController.Size = new System.Drawing.Size(2081, 984);
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
            this.StartPage.Size = new System.Drawing.Size(2073, 955);
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
            this.MainGame.Controls.Add(this.label3);
            this.MainGame.Controls.Add(this.label4);
            this.MainGame.Controls.Add(this.label5);
            this.MainGame.Controls.Add(this.pbCanvas);
            this.MainGame.Location = new System.Drawing.Point(4, 25);
            this.MainGame.Name = "MainGame";
            this.MainGame.Size = new System.Drawing.Size(2073, 955);
            this.MainGame.TabIndex = 2;
            this.MainGame.Text = "MainGame";
            this.MainGame.UseVisualStyleBackColor = true;
            this.MainGame.Click += new System.EventHandler(this.MainGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(714, 689);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "End Text";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.Paint += new System.Windows.Forms.PaintEventHandler(this.updateGraphics);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(800, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Score:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.Paint += new System.Windows.Forms.PaintEventHandler(this.updateGraphics);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(934, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 34);
            this.label5.TabIndex = 6;
            this.label5.Text = "00";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.Paint += new System.Windows.Forms.PaintEventHandler(this.updateGraphics);
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
            // MainGamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1645, 740);
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
        private System.Windows.Forms.TabPage MainGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Timer gameTimer;
    }
}