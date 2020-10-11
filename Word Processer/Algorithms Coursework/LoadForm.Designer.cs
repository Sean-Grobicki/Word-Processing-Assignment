namespace Algorithms_Coursework
{
    partial class LoadForm
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileInfoButton = new System.Windows.Forms.Button();
            this.fileNamePlaceholder = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.fileOutputDisplay = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 334);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.fileNameLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.fileInfoButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.fileNamePlaceholder, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.openFileButton, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(519, 103);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fileNameLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.fileNameLabel, 2);
            this.fileNameLabel.Location = new System.Drawing.Point(107, 43);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(0, 16);
            this.fileNameLabel.TabIndex = 2;
            // 
            // fileInfoButton
            // 
            this.fileInfoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileInfoButton.Location = new System.Drawing.Point(416, 33);
            this.fileInfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.fileInfoButton.Name = "fileInfoButton";
            this.fileInfoButton.Size = new System.Drawing.Size(99, 36);
            this.fileInfoButton.TabIndex = 4;
            this.fileInfoButton.Text = "File Analysis";
            this.fileInfoButton.UseVisualStyleBackColor = true;
            this.fileInfoButton.Visible = false;
            this.fileInfoButton.Click += new System.EventHandler(this.fileInfoButton_Click);
            // 
            // fileNamePlaceholder
            // 
            this.fileNamePlaceholder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileNamePlaceholder.AutoSize = true;
            this.fileNamePlaceholder.Location = new System.Drawing.Point(15, 43);
            this.fileNamePlaceholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileNamePlaceholder.Name = "fileNamePlaceholder";
            this.fileNamePlaceholder.Size = new System.Drawing.Size(73, 16);
            this.fileNamePlaceholder.TabIndex = 1;
            this.fileNamePlaceholder.Text = "File Name:";
            // 
            // openFileButton
            // 
            this.openFileButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openFileButton.Location = new System.Drawing.Point(313, 33);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(95, 36);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Controls.Add(this.fileOutputDisplay, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 115);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(519, 103);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // fileOutputDisplay
            // 
            this.fileOutputDisplay.AutoSize = true;
            this.fileOutputDisplay.Location = new System.Drawing.Point(55, 0);
            this.fileOutputDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileOutputDisplay.Name = "fileOutputDisplay";
            this.fileOutputDisplay.Size = new System.Drawing.Size(104, 16);
            this.fileOutputDisplay.TabIndex = 6;
            this.fileOutputDisplay.Text = "File Not Loaded";
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 334);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(543, 373);
            this.Name = "LoadForm";
            this.Text = "Load File";
            this.Load += new System.EventHandler(this.LoadForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label fileOutputDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button fileInfoButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label fileNamePlaceholder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

