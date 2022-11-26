namespace WFUI
{
    partial class SignUpForm
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
            this.newRegisterButton = new System.Windows.Forms.Button();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.newLoginTextBox = new System.Windows.Forms.TextBox();
            this.newLoginLabel = new System.Windows.Forms.Label();
            this.newDispNameTextBox = new System.Windows.Forms.TextBox();
            this.newDispNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newRegisterButton
            // 
            this.newRegisterButton.Location = new System.Drawing.Point(11, 92);
            this.newRegisterButton.Margin = new System.Windows.Forms.Padding(2);
            this.newRegisterButton.Name = "newRegisterButton";
            this.newRegisterButton.Size = new System.Drawing.Size(212, 29);
            this.newRegisterButton.TabIndex = 11;
            this.newRegisterButton.Text = "Register";
            this.newRegisterButton.UseVisualStyleBackColor = true;
            this.newRegisterButton.Click += new System.EventHandler(this.newRegisterButton_Click);
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(108, 33);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(106, 23);
            this.newPasswordTextBox.TabIndex = 10;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(11, 37);
            this.newPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(57, 15);
            this.newPasswordLabel.TabIndex = 9;
            this.newPasswordLabel.Text = "Password";
            // 
            // newLoginTextBox
            // 
            this.newLoginTextBox.Location = new System.Drawing.Point(108, 11);
            this.newLoginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.newLoginTextBox.Name = "newLoginTextBox";
            this.newLoginTextBox.Size = new System.Drawing.Size(106, 23);
            this.newLoginTextBox.TabIndex = 8;
            // 
            // newLoginLabel
            // 
            this.newLoginLabel.AutoSize = true;
            this.newLoginLabel.Location = new System.Drawing.Point(11, 15);
            this.newLoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newLoginLabel.Name = "newLoginLabel";
            this.newLoginLabel.Size = new System.Drawing.Size(37, 15);
            this.newLoginLabel.TabIndex = 7;
            this.newLoginLabel.Text = "Login";
            // 
            // newDispNameTextBox
            // 
            this.newDispNameTextBox.Location = new System.Drawing.Point(108, 57);
            this.newDispNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.newDispNameTextBox.Name = "newDispNameTextBox";
            this.newDispNameTextBox.Size = new System.Drawing.Size(106, 23);
            this.newDispNameTextBox.TabIndex = 13;
            // 
            // newDispNameLabel
            // 
            this.newDispNameLabel.AutoSize = true;
            this.newDispNameLabel.Location = new System.Drawing.Point(11, 61);
            this.newDispNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newDispNameLabel.Name = "newDispNameLabel";
            this.newDispNameLabel.Size = new System.Drawing.Size(80, 15);
            this.newDispNameLabel.TabIndex = 12;
            this.newDispNameLabel.Text = "Display Name";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 128);
            this.Controls.Add(this.newDispNameTextBox);
            this.Controls.Add(this.newDispNameLabel);
            this.Controls.Add(this.newRegisterButton);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.newLoginTextBox);
            this.Controls.Add(this.newLoginLabel);
            this.Name = "SignUpForm";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button newRegisterButton;
        private TextBox newPasswordTextBox;
        private Label newPasswordLabel;
        private TextBox newLoginTextBox;
        private Label newLoginLabel;
        private TextBox newDispNameTextBox;
        private Label newDispNameLabel;
    }
}