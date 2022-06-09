
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
            this.buttonAddToOrder.Location = new System.Drawing.Point(656, 352);
            this.buttonAddToOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(232, 66);
            this.buttonAddToOrder.TabIndex = 0;
            this.buttonAddToOrder.Text = "Add to Order";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            this.buttonAddToOrder.Click += new System.EventHandler(this.buttonAddToOrder_Click);
            // 
            // buttonDeleteFromOrder
            // 
            this.buttonDeleteFromOrder.Location = new System.Drawing.Point(922, 352);
            this.buttonDeleteFromOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteFromOrder.Name = "buttonDeleteFromOrder";
            this.buttonDeleteFromOrder.Size = new System.Drawing.Size(232, 66);
            this.buttonDeleteFromOrder.TabIndex = 1;
            this.buttonDeleteFromOrder.Text = "Delete from Order";
            this.buttonDeleteFromOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteFromOrder.Click += new System.EventHandler(this.buttonDeleteFromOrder_Click);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Location = new System.Drawing.Point(747, 448);
            this.buttonCheckout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(297, 62);
            this.buttonCheckout.TabIndex = 2;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 25;
            this.listBoxOrder.Location = new System.Drawing.Point(674, 94);
            this.listBoxOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(458, 229);
            this.listBoxOrder.TabIndex = 3;
            // 
            // listBoxGames
            // 
            this.listBoxGames.Font = new System.Drawing.Font("Courier New", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.ItemHeight = 23;
            this.listBoxGames.Location = new System.Drawing.Point(33, 42);
            this.listBoxGames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.Size = new System.Drawing.Size(534, 763);
            this.listBoxGames.TabIndex = 4;
            // 
            // buttonGameInfo
            // 
            this.buttonGameInfo.Location = new System.Drawing.Point(696, 572);
            this.buttonGameInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGameInfo.Name = "buttonGameInfo";
            this.buttonGameInfo.Size = new System.Drawing.Size(402, 66);
            this.buttonGameInfo.TabIndex = 6;
            this.buttonGameInfo.Text = "View Game Information";
            this.buttonGameInfo.UseVisualStyleBackColor = true;
            this.buttonGameInfo.Click += new System.EventHandler(this.buttonGameInfo_Click);
            // 
            // buttonGameReview
            // 
            this.buttonGameReview.Location = new System.Drawing.Point(696, 667);
            this.buttonGameReview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGameReview.Name = "buttonGameReview";
            this.buttonGameReview.Size = new System.Drawing.Size(402, 66);
            this.buttonGameReview.TabIndex = 7;
            this.buttonGameReview.Text = "View Game Reviews";
            this.buttonGameReview.UseVisualStyleBackColor = true;
            this.buttonGameReview.Click += new System.EventHandler(this.buttonGameReview_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(696, 758);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(402, 66);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(854, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Your cart:";
            // 
            // BuyGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 861);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonGameReview);
            this.Controls.Add(this.buttonGameInfo);
            this.Controls.Add(this.listBoxGames);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.buttonDeleteFromOrder);
            this.Controls.Add(this.buttonAddToOrder);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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