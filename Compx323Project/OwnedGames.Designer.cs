
namespace Compx323Project
{
    partial class OwnedGames
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
            this.listBoxGames = new System.Windows.Forms.ListBox();
            this.buttonViewInformation = new System.Windows.Forms.Button();
            this.buttonReview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxGames
            // 
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.Location = new System.Drawing.Point(10, 50);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.Size = new System.Drawing.Size(218, 316);
            this.listBoxGames.TabIndex = 1;
            // 
            // buttonViewInformation
            // 
            this.buttonViewInformation.Location = new System.Drawing.Point(246, 110);
            this.buttonViewInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonViewInformation.Name = "buttonViewInformation";
            this.buttonViewInformation.Size = new System.Drawing.Size(128, 35);
            this.buttonViewInformation.TabIndex = 2;
            this.buttonViewInformation.Text = "View Information";
            this.buttonViewInformation.UseVisualStyleBackColor = true;
            this.buttonViewInformation.Click += new System.EventHandler(this.buttonViewInformation_Click);
            // 
            // buttonReview
            // 
            this.buttonReview.Location = new System.Drawing.Point(246, 173);
            this.buttonReview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReview.Name = "buttonReview";
            this.buttonReview.Size = new System.Drawing.Size(128, 35);
            this.buttonReview.TabIndex = 3;
            this.buttonReview.Text = "Review Game";
            this.buttonReview.UseVisualStyleBackColor = true;
            this.buttonReview.Click += new System.EventHandler(this.buttonReview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Games";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(246, 236);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(128, 35);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // OwnedGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 379);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReview);
            this.Controls.Add(this.buttonViewInformation);
            this.Controls.Add(this.listBoxGames);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OwnedGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OwnedGames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGames;
        private System.Windows.Forms.Button buttonViewInformation;
        private System.Windows.Forms.Button buttonReview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
    }
}