namespace InventoryManagementSystem
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginShowPW = new System.Windows.Forms.CheckBox();
            this.LoginClear = new System.Windows.Forms.Label();
            this.LoginSubmit = new System.Windows.Forms.Button();
            this.PWTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PWLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.LoginTitle = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginPanel.Controls.Add(this.pictureBox1);
            this.LoginPanel.Controls.Add(this.LoginShowPW);
            this.LoginPanel.Controls.Add(this.LoginClear);
            this.LoginPanel.Controls.Add(this.LoginSubmit);
            this.LoginPanel.Controls.Add(this.PWTextBox);
            this.LoginPanel.Controls.Add(this.UsernameTextBox);
            this.LoginPanel.Controls.Add(this.PWLabel);
            this.LoginPanel.Controls.Add(this.UserLabel);
            this.LoginPanel.Controls.Add(this.LoginTitle);
            this.LoginPanel.Location = new System.Drawing.Point(330, 170);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(520, 566);
            this.LoginPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(165, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 87);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LoginShowPW
            // 
            this.LoginShowPW.AutoSize = true;
            this.LoginShowPW.Location = new System.Drawing.Point(115, 492);
            this.LoginShowPW.Name = "LoginShowPW";
            this.LoginShowPW.Size = new System.Drawing.Size(162, 29);
            this.LoginShowPW.TabIndex = 8;
            this.LoginShowPW.Text = "Show Password";
            this.LoginShowPW.UseVisualStyleBackColor = true;
            this.LoginShowPW.CheckedChanged += new System.EventHandler(this.LoginShowPW_CheckedChanged);
            // 
            // LoginClear
            // 
            this.LoginClear.AutoSize = true;
            this.LoginClear.Location = new System.Drawing.Point(342, 493);
            this.LoginClear.Name = "LoginClear";
            this.LoginClear.Size = new System.Drawing.Size(51, 25);
            this.LoginClear.TabIndex = 7;
            this.LoginClear.Text = "Clear";
            this.LoginClear.Click += new System.EventHandler(this.LoginClear_Click);
            // 
            // LoginSubmit
            // 
            this.LoginSubmit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoginSubmit.Location = new System.Drawing.Point(115, 425);
            this.LoginSubmit.Name = "LoginSubmit";
            this.LoginSubmit.Size = new System.Drawing.Size(278, 34);
            this.LoginSubmit.TabIndex = 6;
            this.LoginSubmit.Text = "Submit";
            this.LoginSubmit.UseVisualStyleBackColor = false;
            // 
            // PWTextBox
            // 
            this.PWTextBox.Location = new System.Drawing.Point(115, 357);
            this.PWTextBox.Name = "PWTextBox";
            this.PWTextBox.Size = new System.Drawing.Size(278, 31);
            this.PWTextBox.TabIndex = 5;
            this.PWTextBox.UseSystemPasswordChar = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(115, 258);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(278, 31);
            this.UsernameTextBox.TabIndex = 4;
            // 
            // PWLabel
            // 
            this.PWLabel.AutoSize = true;
            this.PWLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PWLabel.Location = new System.Drawing.Point(199, 307);
            this.PWLabel.Name = "PWLabel";
            this.PWLabel.Size = new System.Drawing.Size(111, 29);
            this.PWLabel.TabIndex = 3;
            this.PWLabel.Text = "Password";
            this.PWLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserLabel.Location = new System.Drawing.Point(193, 202);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(117, 29);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "Username";
            this.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginTitle
            // 
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginTitle.Location = new System.Drawing.Point(28, 37);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(457, 32);
            this.LoginTitle.TabIndex = 0;
            this.LoginTitle.Text = "Inventory Management System";
            this.LoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 907);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel LoginPanel;
        private Label LoginTitle;
        private Label UserLabel;
        private Label PWLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button LoginSubmit;
        private TextBox PWTextBox;
        private TextBox UsernameTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private CheckBox LoginShowPW;
        private Label LoginClear;
        private PictureBox pictureBox1;
    }
}