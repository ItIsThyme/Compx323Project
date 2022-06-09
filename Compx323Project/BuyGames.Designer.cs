
namespace Compx323Project
{
    partial class BuyGames
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
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.buttonDeleteFromOrder = new System.Windows.Forms.Button();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.listBoxGames = new System.Windows.Forms.ListBox();
            this.buttonGameInfo = new System.Windows.Forms.Button();
            this.buttonGameReview = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Location = new System.Drawing.Point(328, 183);
            this.buttonAddToOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(116, 34);
            this.buttonAddToOrder.TabIndex = 0;
            this.buttonAddToOrder.Text = "Add to Order";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            this.buttonAddToOrder.Click += new System.EventHandler(this.buttonAddToOrder_Click);
            // 
            // buttonDeleteFromOrder
            // 
            this.buttonDeleteFromOrder.Location = new System.Drawing.Point(461, 183);
            this.buttonDeleteFromOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteFromOrder.Name = "buttonDeleteFromOrder";
            this.buttonDeleteFromOrder.Size = new System.Drawing.Size(116, 34);
            this.buttonDeleteFromOrder.TabIndex = 1;
            this.buttonDeleteFromOrder.Text = "Delete from Order";
            this.buttonDeleteFromOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteFromOrder.Click += new System.EventHandler(this.buttonDeleteFromOrder_Click);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Location = new System.Drawing.Point(374, 233);
            this.buttonCheckout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(148, 32);
            this.buttonCheckout.TabIndex = 2;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.Location = new System.Drawing.Point(337, 49);
            this.listBoxOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(231, 121);
            this.listBoxOrder.TabIndex = 3;
            // 
            // listBoxGames
            // 
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.Location = new System.Drawing.Point(16, 22);
            this.listBoxGames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.Size = new System.Drawing.Size(269, 407);
            this.listBoxGames.TabIndex = 4;
            // 
            // buttonGameInfo
            // 
            this.buttonGameInfo.Location = new System.Drawing.Point(348, 297);
            this.buttonGameInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGameInfo.Name = "buttonGameInfo";
            this.buttonGameInfo.Size = new System.Drawing.Size(201, 34);
            this.buttonGameInfo.TabIndex = 6;
            this.buttonGameInfo.Text = "View Game Information";
            this.buttonGameInfo.UseVisualStyleBackColor = true;
            this.buttonGameInfo.Click += new System.EventHandler(this.buttonGameInfo_Click);
            // 
            // buttonGameReview
            // 
            this.buttonGameReview.Location = new System.Drawing.Point(348, 347);
            this.buttonGameReview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGameReview.Name = "buttonGameReview";
            this.buttonGameReview.Size = new System.Drawing.Size(201, 34);
            this.buttonGameReview.TabIndex = 7;
            this.buttonGameReview.Text = "View Game Reviews";
            this.buttonGameReview.UseVisualStyleBackColor = true;
            this.buttonGameReview.Click += new System.EventHandler(this.buttonGameReview_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(348, 394);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(201, 34);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Your cart:";
            // 
            // BuyGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonGameReview);
            this.Controls.Add(this.buttonGameInfo);
            this.Controls.Add(this.listBoxGames);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.buttonDeleteFromOrder);
            this.Controls.Add(this.buttonAddToOrder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BuyGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyGames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.Button buttonDeleteFromOrder;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.ListBox listBoxGames;
        private System.Windows.Forms.Button buttonGameInfo;
        private System.Windows.Forms.Button buttonGameReview;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
    }
}