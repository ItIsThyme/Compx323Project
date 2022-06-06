
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
            this.SuspendLayout();
            // 
            // listBoxGames
            // 
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.ItemHeight = 16;
            this.listBoxGames.Location = new System.Drawing.Point(13, 61);
            this.listBoxGames.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.Size = new System.Drawing.Size(289, 388);
            this.listBoxGames.TabIndex = 1;
            // 
            // buttonViewInformation
            // 
            this.buttonViewInformation.Location = new System.Drawing.Point(326, 177);
            this.buttonViewInformation.Name = "buttonViewInformation";
            this.buttonViewInformation.Size = new System.Drawing.Size(171, 43);
            this.buttonViewInformation.TabIndex = 2;
            this.buttonViewInformation.Text = "View Information";
            this.buttonViewInformation.UseVisualStyleBackColor = true;
            this.buttonViewInformation.Click += new System.EventHandler(this.buttonViewInformation_Click);
            // 
            // buttonReview
            // 
            this.buttonReview.Location = new System.Drawing.Point(326, 259);
            this.buttonReview.Name = "buttonReview";
            this.buttonReview.Size = new System.Drawing.Size(171, 43);
            this.buttonReview.TabIndex = 3;
            this.buttonReview.Text = "Review Game";
            this.buttonReview.UseVisualStyleBackColor = true;
            this.buttonReview.Click += new System.EventHandler(this.buttonReview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Games";
            // 
            // OwnedGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReview);
            this.Controls.Add(this.buttonViewInformation);
            this.Controls.Add(this.listBoxGames);
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
    }
}