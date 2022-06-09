
namespace Compx323Project
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonOwnedGames = new System.Windows.Forms.Button();
            this.buttonBuyGames = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logged in as:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(102, 37);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(119, 20);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.TabStop = false;
            // 
            // buttonOwnedGames
            // 
            this.buttonOwnedGames.Location = new System.Drawing.Point(34, 98);
            this.buttonOwnedGames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOwnedGames.Name = "buttonOwnedGames";
            this.buttonOwnedGames.Size = new System.Drawing.Size(185, 42);
            this.buttonOwnedGames.TabIndex = 3;
            this.buttonOwnedGames.Text = "Owned Games";
            this.buttonOwnedGames.UseVisualStyleBackColor = true;
            this.buttonOwnedGames.Click += new System.EventHandler(this.buttonOwnedGames_Click);
            // 
            // buttonBuyGames
            // 
            this.buttonBuyGames.Location = new System.Drawing.Point(34, 171);
            this.buttonBuyGames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuyGames.Name = "buttonBuyGames";
            this.buttonBuyGames.Size = new System.Drawing.Size(185, 42);
            this.buttonBuyGames.TabIndex = 4;
            this.buttonBuyGames.Text = "Buy Games";
            this.buttonBuyGames.UseVisualStyleBackColor = true;
            this.buttonBuyGames.Click += new System.EventHandler(this.buttonBuyGames_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(34, 250);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(185, 42);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 329);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonBuyGames);
            this.Controls.Add(this.buttonOwnedGames);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonOwnedGames;
        private System.Windows.Forms.Button buttonBuyGames;
        private System.Windows.Forms.Button buttonLogout;
    }
}