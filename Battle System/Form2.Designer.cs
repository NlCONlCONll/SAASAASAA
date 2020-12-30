namespace Battle_System
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblNamaGame = new System.Windows.Forms.Label();
            this.picBoxBgMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(325, 332);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(157, 52);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "PLAY!";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // lblNamaGame
            // 
            this.lblNamaGame.AutoSize = true;
            this.lblNamaGame.Location = new System.Drawing.Point(354, 177);
            this.lblNamaGame.Name = "lblNamaGame";
            this.lblNamaGame.Size = new System.Drawing.Size(91, 17);
            this.lblNamaGame.TabIndex = 1;
            this.lblNamaGame.Text = "NAMA GAME";
            this.lblNamaGame.Click += new System.EventHandler(this.label1_Click);
            // 
            // picBoxBgMenu
            // 
            this.picBoxBgMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxBgMenu.BackgroundImage")));
            this.picBoxBgMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxBgMenu.Location = new System.Drawing.Point(-4, 0);
            this.picBoxBgMenu.Name = "picBoxBgMenu";
            this.picBoxBgMenu.Size = new System.Drawing.Size(806, 451);
            this.picBoxBgMenu.TabIndex = 2;
            this.picBoxBgMenu.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNamaGame);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.picBoxBgMenu);
            this.Name = "FormMenu";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblNamaGame;
        private System.Windows.Forms.PictureBox picBoxBgMenu;
    }
}