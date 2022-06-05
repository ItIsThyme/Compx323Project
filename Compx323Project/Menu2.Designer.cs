
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.loggedinLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameListBox
            // 
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.ItemHeight = 16;
            this.gameListBox.Location = new System.Drawing.Point(16, 31);
            this.gameListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(231, 436);
            this.gameListBox.TabIndex = 0;
            // 
            // getGames
            // 
            this.getGames.Location = new System.Drawing.Point(256, 431);
            this.getGames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getGames.Name = "getGames";
            this.getGames.Size = new System.Drawing.Size(172, 37);
            this.getGames.TabIndex = 1;
            this.getGames.Text = "Get games";
            this.getGames.UseVisualStyleBackColor = true;
            this.getGames.Click += new System.EventHandler(this.getGames_Click);
            // 
            // addReview
            // 
            this.addReview.Location = new System.Drawing.Point(256, 386);
            this.addReview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addReview.Name = "addReview";
            this.addReview.Size = new System.Drawing.Size(172, 37);
            this.addReview.TabIndex = 2;
            this.addReview.Text = "Review selected game";
            this.addReview.UseVisualStyleBackColor = true;
            this.addReview.Click += new System.EventHandler(this.addReview_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(539, 214);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(164, 22);
            this.usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(539, 257);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(164, 22);
            this.passwordTextBox.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(539, 302);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(165, 37);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(443, 218);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 17);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(443, 261);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(535, 191);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 8;
            // 
            // loggedinLabel
            // 
            this.loggedinLabel.AutoSize = true;
            this.loggedinLabel.Location = new System.Drawing.Point(535, 364);
            this.loggedinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loggedinLabel.Name = "loggedinLabel";
            this.loggedinLabel.Size = new System.Drawing.Size(0, 17);
            this.loggedinLabel.TabIndex = 9;
            // 
            // logoutButton
            // 
            this.logoutButton.Enabled = false;
            this.logoutButton.Location = new System.Drawing.Point(539, 404);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(165, 37);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Visible = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // orderListBox
            // 
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.ItemHeight = 16;
            this.orderListBox.Location = new System.Drawing.Point(436, 31);
            this.orderListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(267, 132);
            this.orderListBox.TabIndex = 11;
            this.orderListBox.SelectedIndexChanged += new System.EventHandler(this.orderListBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(256, 31);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(172, 37);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add to order";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(256, 71);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(172, 37);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove from order";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(256, 126);
            this.orderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(172, 37);
            this.orderButton.TabIndex = 14;
            this.orderButton.Text = "Place order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 487);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.orderListBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.loggedinLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.addReview);
            this.Controls.Add(this.getGames);
            this.Controls.Add(this.gameListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuScreen";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox gameListBox;
        private System.Windows.Forms.Button getGames;
        private System.Windows.Forms.Button addReview;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label loggedinLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button orderButton;
    }
}

