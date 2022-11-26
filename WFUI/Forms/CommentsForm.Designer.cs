namespace WFUI
{
    partial class CommentsForm
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
            this.commentsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // commentsFlowLayoutPanel
            // 
            this.commentsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.commentsFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.commentsFlowLayoutPanel.Name = "commentsFlowLayoutPanel";
            this.commentsFlowLayoutPanel.Size = new System.Drawing.Size(384, 201);
            this.commentsFlowLayoutPanel.TabIndex = 0;
            // 
            // CommentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 201);
            this.Controls.Add(this.commentsFlowLayoutPanel);
            this.Name = "CommentsForm";
            this.Text = "Comments";
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel commentsFlowLayoutPanel;
    }
}