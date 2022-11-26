namespace WFUI
{
    partial class TextPromptForm
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
            this.promptTextBox = new System.Windows.Forms.TextBox();
            this.promptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptTextBox
            // 
            this.promptTextBox.Location = new System.Drawing.Point(12, 12);
            this.promptTextBox.Multiline = true;
            this.promptTextBox.Name = "promptTextBox";
            this.promptTextBox.Size = new System.Drawing.Size(360, 147);
            this.promptTextBox.TabIndex = 0;
            // 
            // promptButton
            // 
            this.promptButton.Location = new System.Drawing.Point(12, 163);
            this.promptButton.Name = "promptButton";
            this.promptButton.Size = new System.Drawing.Size(360, 35);
            this.promptButton.TabIndex = 1;
            this.promptButton.UseVisualStyleBackColor = true;
            this.promptButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // TextPromptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 201);
            this.Controls.Add(this.promptButton);
            this.Controls.Add(this.promptTextBox);
            this.Name = "TextPromptForm";
            this.Text = "New Comment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox promptTextBox;
        private Button promptButton;
    }
}