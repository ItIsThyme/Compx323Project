namespace Compx323Project
{
    partial class ChooseDatabaseTypeForm
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
            this.radioButtonOracle = new System.Windows.Forms.RadioButton();
            this.radioButtonMongo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonOracle
            // 
            this.radioButtonOracle.AutoSize = true;
            this.radioButtonOracle.Checked = true;
            this.radioButtonOracle.Location = new System.Drawing.Point(289, 102);
            this.radioButtonOracle.Name = "radioButtonOracle";
            this.radioButtonOracle.Size = new System.Drawing.Size(106, 29);
            this.radioButtonOracle.TabIndex = 0;
            this.radioButtonOracle.TabStop = true;
            this.radioButtonOracle.Text = "Oracle";
            this.radioButtonOracle.UseVisualStyleBackColor = true;
            // 
            // radioButtonMongo
            // 
            this.radioButtonMongo.AutoSize = true;
            this.radioButtonMongo.Location = new System.Drawing.Point(289, 149);
            this.radioButtonMongo.Name = "radioButtonMongo";
            this.radioButtonMongo.Size = new System.Drawing.Size(138, 29);
            this.radioButtonMongo.TabIndex = 1;
            this.radioButtonMongo.TabStop = true;
            this.radioButtonMongo.Text = "MongoDB";
            this.radioButtonMongo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select database type";
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Location = new System.Drawing.Point(289, 360);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(131, 57);
            this.buttonLaunch.TabIndex = 3;
            this.buttonLaunch.Text = "Launch";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(275, 272);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(174, 31);
            this.textBoxAddress.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Database address";
            // 
            // ChooseDatabaseTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 580);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.buttonLaunch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonMongo);
            this.Controls.Add(this.radioButtonOracle);
            this.Name = "ChooseDatabaseTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseDatabaseTypeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonOracle;
        private System.Windows.Forms.RadioButton radioButtonMongo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label2;
    }
}