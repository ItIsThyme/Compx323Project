
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byReleaseDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonGameInfo = new System.Windows.Forms.Button();
            this.buttonGameReview = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Location = new System.Drawing.Point(441, 237);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(155, 42);
            this.buttonAddToOrder.TabIndex = 0;
            this.buttonAddToOrder.Text = "Add to Order";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            this.buttonAddToOrder.Click += new System.EventHandler(this.buttonAddToOrder_Click);
            // 
            // buttonDeleteFromOrder
            // 
            this.buttonDeleteFromOrder.Location = new System.Drawing.Point(619, 237);
            this.buttonDeleteFromOrder.Name = "buttonDeleteFromOrder";
            this.buttonDeleteFromOrder.Size = new System.Drawing.Size(155, 42);
            this.buttonDeleteFromOrder.TabIndex = 1;
            this.buttonDeleteFromOrder.Text = "Delete from Order";
            this.buttonDeleteFromOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteFromOrder.Click += new System.EventHandler(this.buttonDeleteFromOrder_Click);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Location = new System.Drawing.Point(502, 299);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(198, 40);
            this.buttonCheckout.TabIndex = 2;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 16;
            this.listBoxOrder.Location = new System.Drawing.Point(450, 39);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(307, 164);
            this.listBoxOrder.TabIndex = 3;
            // 
            // listBoxGames
            // 
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.ItemHeight = 16;
            this.listBoxGames.Location = new System.Drawing.Point(21, 48);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.Size = new System.Drawing.Size(357, 500);
            this.listBoxGames.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byNameToolStripMenuItem,
            this.byReleaseDateToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // byNameToolStripMenuItem
            // 
            this.byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            this.byNameToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.byNameToolStripMenuItem.Text = "By Name";
            // 
            // byReleaseDateToolStripMenuItem
            // 
            this.byReleaseDateToolStripMenuItem.Name = "byReleaseDateToolStripMenuItem";
            this.byReleaseDateToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.byReleaseDateToolStripMenuItem.Text = "By Release Date";
            // 
            // buttonGameInfo
            // 
            this.buttonGameInfo.Location = new System.Drawing.Point(468, 378);
            this.buttonGameInfo.Name = "buttonGameInfo";
            this.buttonGameInfo.Size = new System.Drawing.Size(268, 42);
            this.buttonGameInfo.TabIndex = 6;
            this.buttonGameInfo.Text = "View Game Information";
            this.buttonGameInfo.UseVisualStyleBackColor = true;
            this.buttonGameInfo.Click += new System.EventHandler(this.buttonGameInfo_Click);
            // 
            // buttonGameReview
            // 
            this.buttonGameReview.Location = new System.Drawing.Point(468, 439);
            this.buttonGameReview.Name = "buttonGameReview";
            this.buttonGameReview.Size = new System.Drawing.Size(268, 42);
            this.buttonGameReview.TabIndex = 7;
            this.buttonGameReview.Text = "View Game Reviews";
            this.buttonGameReview.UseVisualStyleBackColor = true;
            this.buttonGameReview.Click += new System.EventHandler(this.buttonGameReview_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(468, 497);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(268, 42);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // BuyGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonGameReview);
            this.Controls.Add(this.buttonGameInfo);
            this.Controls.Add(this.listBoxGames);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.buttonDeleteFromOrder);
            this.Controls.Add(this.buttonAddToOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BuyGames";
            this.Text = "BuyGames";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.Button buttonDeleteFromOrder;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.ListBox listBoxGames;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byReleaseDateToolStripMenuItem;
        private System.Windows.Forms.Button buttonGameInfo;
        private System.Windows.Forms.Button buttonGameReview;
        private System.Windows.Forms.Button buttonBack;
    }
}