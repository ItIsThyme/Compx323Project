
namespace Compx323Project
{
    partial class MenuScreen
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
            this.gameListBox = new System.Windows.Forms.ListBox();
            this.getGames = new System.Windows.Forms.Button();
            this.addReview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameListBox
            // 
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.Location = new System.Drawing.Point(12, 25);
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(174, 355);
            this.gameListBox.TabIndex = 0;
            // 
            // getGames
            // 
            this.getGames.Location = new System.Drawing.Point(192, 350);
            this.getGames.Name = "getGames";
            this.getGames.Size = new System.Drawing.Size(145, 30);
            this.getGames.TabIndex = 1;
            this.getGames.Text = "Get games";
            this.getGames.UseVisualStyleBackColor = true;
            this.getGames.Click += new System.EventHandler(this.getGames_Click);
            // 
            // addReview
            // 
            this.addReview.Location = new System.Drawing.Point(192, 314);
            this.addReview.Name = "addReview";
            this.addReview.Size = new System.Drawing.Size(145, 30);
            this.addReview.TabIndex = 2;
            this.addReview.Text = "Review selected game";
            this.addReview.UseVisualStyleBackColor = true;
            this.addReview.Click += new System.EventHandler(this.addReview_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.addReview);
            this.Controls.Add(this.getGames);
            this.Controls.Add(this.gameListBox);
            this.Name = "MenuScreen";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox gameListBox;
        private System.Windows.Forms.Button getGames;
        private System.Windows.Forms.Button addReview;
    }
}

