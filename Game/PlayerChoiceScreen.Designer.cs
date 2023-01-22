namespace Game
{
    partial class PlayerChoiceScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerChoiceScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.multiPlayer = new System.Windows.Forms.Button();
            this.singlePlayer = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(431, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 67);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player Choices:";
            // 
            // multiPlayer
            // 
            this.multiPlayer.BackColor = System.Drawing.Color.Transparent;
            this.multiPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("multiPlayer.BackgroundImage")));
            this.multiPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiPlayer.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.multiPlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.multiPlayer.Location = new System.Drawing.Point(464, 285);
            this.multiPlayer.Name = "multiPlayer";
            this.multiPlayer.Size = new System.Drawing.Size(306, 84);
            this.multiPlayer.TabIndex = 4;
            this.multiPlayer.Text = "Multiplayer";
            this.multiPlayer.UseVisualStyleBackColor = false;
            this.multiPlayer.Click += new System.EventHandler(this.multiPlayer_Click);
            // 
            // singlePlayer
            // 
            this.singlePlayer.BackColor = System.Drawing.Color.Transparent;
            this.singlePlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("singlePlayer.BackgroundImage")));
            this.singlePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.singlePlayer.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.singlePlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.singlePlayer.Location = new System.Drawing.Point(464, 169);
            this.singlePlayer.Name = "singlePlayer";
            this.singlePlayer.Size = new System.Drawing.Size(306, 84);
            this.singlePlayer.TabIndex = 5;
            this.singlePlayer.Text = "Single Player";
            this.singlePlayer.UseVisualStyleBackColor = false;
            this.singlePlayer.Click += new System.EventHandler(this.singlePlayer_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpButton.BackgroundImage")));
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.helpButton.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.helpButton.Location = new System.Drawing.Point(516, 425);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(199, 84);
            this.helpButton.TabIndex = 6;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // PlayerChoiceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1235, 601);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.singlePlayer);
            this.Controls.Add(this.multiPlayer);
            this.Controls.Add(this.label1);
            this.Name = "PlayerChoiceScreen";
            this.Text = "PlayerChoiceScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button multiPlayer;
        private System.Windows.Forms.Button singlePlayer;
        private System.Windows.Forms.Button helpButton;
    }
}