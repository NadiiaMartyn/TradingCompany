namespace WFUI
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.profileTabPage = new System.Windows.Forms.TabPage();
            this.changeDisplayNameButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.displayNameLabel = new System.Windows.Forms.Label();
            this.ordersTabPage = new System.Windows.Forms.TabPage();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.repeatOrderToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.CommentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.showComments_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sortDescToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sortAscToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl.SuspendLayout();
            this.profileTabPage.SuspendLayout();
            this.ordersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.profileTabPage);
            this.tabControl.Controls.Add(this.ordersTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(384, 211);
            this.tabControl.TabIndex = 0;
            // 
            // profileTabPage
            // 
            this.profileTabPage.Controls.Add(this.changeDisplayNameButton);
            this.profileTabPage.Controls.Add(this.changePasswordButton);
            this.profileTabPage.Controls.Add(this.passwordLabel);
            this.profileTabPage.Controls.Add(this.loginLabel);
            this.profileTabPage.Controls.Add(this.displayNameLabel);
            this.profileTabPage.Location = new System.Drawing.Point(4, 24);
            this.profileTabPage.Name = "profileTabPage";
            this.profileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.profileTabPage.Size = new System.Drawing.Size(376, 183);
            this.profileTabPage.TabIndex = 0;
            this.profileTabPage.Text = "Profile";
            this.profileTabPage.UseVisualStyleBackColor = true;
            // 
            // changeDisplayNameButton
            // 
            this.changeDisplayNameButton.Location = new System.Drawing.Point(24, 131);
            this.changeDisplayNameButton.Name = "changeDisplayNameButton";
            this.changeDisplayNameButton.Size = new System.Drawing.Size(148, 23);
            this.changeDisplayNameButton.TabIndex = 4;
            this.changeDisplayNameButton.Text = "Change Display Name";
            this.changeDisplayNameButton.UseVisualStyleBackColor = true;
            this.changeDisplayNameButton.Click += new System.EventHandler(this.changeDisplayNameButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(189, 131);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(148, 23);
            this.changePasswordButton.TabIndex = 3;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(24, 93);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(24, 60);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(37, 15);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login";
            // 
            // displayNameLabel
            // 
            this.displayNameLabel.AutoSize = true;
            this.displayNameLabel.Location = new System.Drawing.Point(24, 29);
            this.displayNameLabel.Name = "displayNameLabel";
            this.displayNameLabel.Size = new System.Drawing.Size(80, 15);
            this.displayNameLabel.TabIndex = 0;
            this.displayNameLabel.Text = "Display Name";
            // 
            // ordersTabPage
            // 
            this.ordersTabPage.Controls.Add(this.ordersDataGridView);
            this.ordersTabPage.Controls.Add(this.toolStrip1);
            this.ordersTabPage.Location = new System.Drawing.Point(4, 24);
            this.ordersTabPage.Name = "ordersTabPage";
            this.ordersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ordersTabPage.Size = new System.Drawing.Size(393, 183);
            this.ordersTabPage.TabIndex = 1;
            this.ordersTabPage.Text = "Orders";
            this.ordersTabPage.UseVisualStyleBackColor = true;
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.AllowUserToResizeColumns = false;
            this.ordersDataGridView.AllowUserToResizeRows = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersDataGridView.Location = new System.Drawing.Point(3, 28);
            this.ordersDataGridView.MultiSelect = false;
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ordersDataGridView.RowTemplate.Height = 25;
            this.ordersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDataGridView.Size = new System.Drawing.Size(387, 152);
            this.ordersDataGridView.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repeatOrderToolStripButton1,
            this.CommentToolStripButton,
            this.showComments_ToolStripButton,
            this.toolStripSeparator1,
            this.searchToolStripTextBox,
            this.toolStripSeparator2,
            this.sortDescToolStripButton,
            this.sortAscToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(387, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // repeatOrderToolStripButton1
            // 
            this.repeatOrderToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.repeatOrderToolStripButton1.Image = global::WFUI.Properties.Resources.Repeat_Icon;
            this.repeatOrderToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.repeatOrderToolStripButton1.Name = "repeatOrderToolStripButton1";
            this.repeatOrderToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.repeatOrderToolStripButton1.Text = "Repeat Order";
            this.repeatOrderToolStripButton1.Click += new System.EventHandler(this.RepeatOrderToolStripButton_Click);
            // 
            // CommentToolStripButton
            // 
            this.CommentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CommentToolStripButton.Image = global::WFUI.Properties.Resources.Comment_Icon;
            this.CommentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CommentToolStripButton.Name = "CommentToolStripButton";
            this.CommentToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CommentToolStripButton.Text = "Comment";
            this.CommentToolStripButton.Click += new System.EventHandler(this.CommentToolStripButton_Click);
            // 
            // showComments_ToolStripButton
            // 
            this.showComments_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showComments_ToolStripButton.Image = global::WFUI.Properties.Resources.CommentList_Icon1;
            this.showComments_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showComments_ToolStripButton.Name = "showComments_ToolStripButton";
            this.showComments_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.showComments_ToolStripButton.Text = "Show Comments";
            this.showComments_ToolStripButton.Click += new System.EventHandler(this.ShowCommentsToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // searchToolStripTextBox
            // 
            this.searchToolStripTextBox.Name = "searchToolStripTextBox";
            this.searchToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.searchToolStripTextBox.TextChanged += new System.EventHandler(this.SearchToolStripTextBox_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sortDescToolStripButton
            // 
            this.sortDescToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sortDescToolStripButton.Image = global::WFUI.Properties.Resources.DownArrow;
            this.sortDescToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortDescToolStripButton.Name = "sortDescToolStripButton";
            this.sortDescToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.sortDescToolStripButton.Text = "Sort Descending";
            this.sortDescToolStripButton.Click += new System.EventHandler(this.SortDescToolStripButton_Click);
            // 
            // sortAscToolStripButton
            // 
            this.sortAscToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sortAscToolStripButton.Image = global::WFUI.Properties.Resources.UpArrow;
            this.sortAscToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortAscToolStripButton.Name = "sortAscToolStripButton";
            this.sortAscToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.sortAscToolStripButton.Text = "Sort Ascending";
            this.sortAscToolStripButton.Click += new System.EventHandler(this.sortAscToolStripButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.tabControl.ResumeLayout(false);
            this.profileTabPage.ResumeLayout(false);
            this.profileTabPage.PerformLayout();
            this.ordersTabPage.ResumeLayout(false);
            this.ordersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage profileTabPage;
        private TabPage ordersTabPage;
        private Label passwordLabel;
        private Label loginLabel;
        private Label displayNameLabel;
        private Button changePasswordButton;
        private Button changeDisplayNameButton;
        private DataGridView ordersDataGridView;
        private ToolStrip toolStrip1;
        private ToolStripButton repeatOrderToolStripButton1;
        private ToolStripButton CommentToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox searchToolStripTextBox;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton sortDescToolStripButton;
        private ToolStripButton sortAscToolStripButton;
        private ToolStripButton showComments_ToolStripButton;
    }
}