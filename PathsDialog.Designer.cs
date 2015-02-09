namespace ContentManager
{
    partial class PathsDialog
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
            this.ContentLabel = new System.Windows.Forms.Label();
            this.ContentBox = new System.Windows.Forms.TextBox();
            this.RuntimeBox = new System.Windows.Forms.TextBox();
            this.RuntimeLabel = new System.Windows.Forms.Label();
            this.ContentExploreButton = new System.Windows.Forms.Button();
            this.RuntimeExploreButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.ContentLabel.Location = new System.Drawing.Point(4, 8);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(47, 13);
            this.ContentLabel.TabIndex = 0;
            this.ContentLabel.Text = "Content:";
            // 
            // ContentBox
            // 
            this.ContentBox.Location = new System.Drawing.Point(56, 4);
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.Size = new System.Drawing.Size(356, 20);
            this.ContentBox.TabIndex = 1;
            // 
            // RuntimeBox
            // 
            this.RuntimeBox.Location = new System.Drawing.Point(56, 28);
            this.RuntimeBox.Name = "RuntimeBox";
            this.RuntimeBox.Size = new System.Drawing.Size(356, 20);
            this.RuntimeBox.TabIndex = 2;
            // 
            // RuntimeLabel
            // 
            this.RuntimeLabel.AutoSize = true;
            this.RuntimeLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.RuntimeLabel.Location = new System.Drawing.Point(2, 32);
            this.RuntimeLabel.Name = "RuntimeLabel";
            this.RuntimeLabel.Size = new System.Drawing.Size(49, 13);
            this.RuntimeLabel.TabIndex = 3;
            this.RuntimeLabel.Text = "Runtime:";
            // 
            // ContentExploreButton
            // 
            this.ContentExploreButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.ContentExploreButton.Location = new System.Drawing.Point(416, 4);
            this.ContentExploreButton.Name = "ContentExploreButton";
            this.ContentExploreButton.Size = new System.Drawing.Size(40, 20);
            this.ContentExploreButton.TabIndex = 4;
            this.ContentExploreButton.Text = "...";
            this.ContentExploreButton.UseVisualStyleBackColor = true;
            this.ContentExploreButton.Click += new System.EventHandler(this.ContentExploreButton_Click);
            // 
            // RuntimeExploreButton
            // 
            this.RuntimeExploreButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.RuntimeExploreButton.Location = new System.Drawing.Point(416, 28);
            this.RuntimeExploreButton.Name = "RuntimeExploreButton";
            this.RuntimeExploreButton.Size = new System.Drawing.Size(40, 20);
            this.RuntimeExploreButton.TabIndex = 5;
            this.RuntimeExploreButton.Text = "...";
            this.RuntimeExploreButton.UseVisualStyleBackColor = true;
            this.RuntimeExploreButton.Click += new System.EventHandler(this.RuntimeExploreButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.YesButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.YesButton.Location = new System.Drawing.Point(380, 56);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 6;
            this.YesButton.Text = "OK";
            this.YesButton.UseVisualStyleBackColor = true;
            // 
            // NoButton
            // 
            this.NoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NoButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.NoButton.Location = new System.Drawing.Point(300, 56);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 7;
            this.NoButton.Text = "Cancel";
            this.NoButton.UseVisualStyleBackColor = true;
            // 
            // PathsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 84);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.RuntimeExploreButton);
            this.Controls.Add(this.ContentExploreButton);
            this.Controls.Add(this.RuntimeLabel);
            this.Controls.Add(this.RuntimeBox);
            this.Controls.Add(this.ContentBox);
            this.Controls.Add(this.ContentLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PathsDialog";
            this.ShowInTaskbar = false;
            this.Text = "PathsDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.TextBox ContentBox;
        private System.Windows.Forms.TextBox RuntimeBox;
        private System.Windows.Forms.Label RuntimeLabel;
        private System.Windows.Forms.Button ContentExploreButton;
        private System.Windows.Forms.Button RuntimeExploreButton;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
    }
}