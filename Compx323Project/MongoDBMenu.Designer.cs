
namespace Compx323Project
{
    partial class MongoDBMenu
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
            this.userGamesButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.loggedinLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.addReview = new System.Windows.Forms.Button();
            this.getGames = new System.Windows.Forms.Button();
            this.oracleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameListBox
            // 
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.Location = new System.Drawing.Point(12, 12);
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(174, 355);
            this.gameListBox.TabIndex = 1;
            // 
            // userGamesButton
            // 
            this.userGamesButton.Location = new System.Drawing.Point(205, 301);
            this.userGamesButton.Name = "userGamesButton";
            this.userGamesButton.Size = new System.Drawing.Size(129, 30);
            this.userGamesButton.TabIndex = 30;
            this.userGamesButton.Text = "Get my games";
            this.userGamesButton.UseVisualStyleBackColor = true;
            this.userGamesButton.Click += new System.EventHandler(this.userGamesButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(205, 89);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(129, 30);
            this.orderButton.TabIndex = 29;
            this.orderButton.Text = "Place order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(205, 45);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(129, 30);
            this.removeButton.TabIndex = 28;
            this.removeButton.Text = "Remove from order";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(205, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(129, 30);
            this.addButton.TabIndex = 27;
            this.addButton.Text = "Add to order";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // orderListBox
            // 
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.Location = new System.Drawing.Point(340, 12);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(201, 108);
            this.orderListBox.TabIndex = 26;
            // 
            // logoutButton
            // 
            this.logoutButton.Enabled = false;
            this.logoutButton.Location = new System.Drawing.Point(417, 301);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(124, 30);
            this.logoutButton.TabIndex = 25;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Visible = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // loggedinLabel
            // 
            this.loggedinLabel.AutoSize = true;
            this.loggedinLabel.Location = new System.Drawing.Point(414, 274);
            this.loggedinLabel.Name = "loggedinLabel";
            this.loggedinLabel.Size = new System.Drawing.Size(0, 13);
            this.loggedinLabel.TabIndex = 24;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(414, 142);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 23;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(345, 199);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 22;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(345, 164);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 21;
            this.usernameLabel.Text = "Username";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(417, 232);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(124, 30);
            this.loginButton.TabIndex = 20;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(417, 196);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(124, 20);
            this.passwordTextBox.TabIndex = 19;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(417, 161);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(124, 20);
            this.usernameTextBox.TabIndex = 18;
            // 
            // addReview
            // 
            this.addReview.Location = new System.Drawing.Point(205, 265);
            this.addReview.Name = "addReview";
            this.addReview.Size = new System.Drawing.Size(129, 30);
            this.addReview.TabIndex = 17;
            this.addReview.Text = "Review selected game";
            this.addReview.UseVisualStyleBackColor = true;
            this.addReview.Click += new System.EventHandler(this.addReview_Click);
            // 
            // getGames
            // 
            this.getGames.Location = new System.Drawing.Point(205, 337);
            this.getGames.Name = "getGames";
            this.getGames.Size = new System.Drawing.Size(129, 30);
            this.getGames.TabIndex = 16;
            this.getGames.Text = "Get all games";
            this.getGames.UseVisualStyleBackColor = true;
            this.getGames.Click += new System.EventHandler(this.getGames_Click);
            // 
            // oracleButton
            // 
            this.oracleButton.Enabled = false;
            this.oracleButton.Location = new System.Drawing.Point(417, 337);
            this.oracleButton.Name = "oracleButton";
            this.oracleButton.Size = new System.Drawing.Size(124, 30);
            this.oracleButton.TabIndex = 31;
            this.oracleButton.Text = "Switch to oracle";
            this.oracleButton.UseVisualStyleBackColor = true;
            this.oracleButton.Visible = false;
            this.oracleButton.Click += new System.EventHandler(this.oracleButton_Click);
            // 
            // MongoDBMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 388);
            this.Controls.Add(this.oracleButton);
            this.Controls.Add(this.userGamesButton);
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
            this.Name = "MongoDBMenu";
            this.Text = "MongoDBMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox gameListBox;
        private System.Windows.Forms.Button userGamesButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label loggedinLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button addReview;
        private System.Windows.Forms.Button getGames;
        private System.Windows.Forms.Button oracleButton;
    }
}