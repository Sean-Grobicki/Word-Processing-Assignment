namespace Algorithms_Coursework
{
    partial class EditForm
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
            this.wordPlaceHolder = new System.Windows.Forms.Label();
            this.occurencesPlaceHolder = new System.Windows.Forms.Label();
            this.wordOutput = new System.Windows.Forms.Label();
            this.occurencesOutput = new System.Windows.Forms.Label();
            this.locationsPlaceHolder = new System.Windows.Forms.Label();
            this.lineNoListBox = new System.Windows.Forms.ListBox();
            this.linePosListBox = new System.Windows.Forms.ListBox();
            this.lineNoPlaceHolder = new System.Windows.Forms.Label();
            this.linePosPlaceholder = new System.Windows.Forms.Label();
            this.changeLocButton = new System.Windows.Forms.Button();
            this.changeLineNoInput = new System.Windows.Forms.TextBox();
            this.changeLinePosInput = new System.Windows.Forms.TextBox();
            this.changeLineNoPlaceholder = new System.Windows.Forms.Label();
            this.changeLinePosPlaceholder = new System.Windows.Forms.Label();
            this.newLinePosPlaceholder = new System.Windows.Forms.Label();
            this.newLineNoPlaceholder = new System.Windows.Forms.Label();
            this.newLinePosInput = new System.Windows.Forms.TextBox();
            this.newLineNoInput = new System.Windows.Forms.TextBox();
            this.newLocButton = new System.Windows.Forms.Button();
            this.wordGroupBox = new System.Windows.Forms.GroupBox();
            this.newLocGroupBox = new System.Windows.Forms.GroupBox();
            this.changeLocGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.discardChangesButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.removeOccButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.wordGroupBox.SuspendLayout();
            this.newLocGroupBox.SuspendLayout();
            this.changeLocGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordPlaceHolder
            // 
            this.wordPlaceHolder.AutoSize = true;
            this.wordPlaceHolder.Location = new System.Drawing.Point(13, 16);
            this.wordPlaceHolder.Name = "wordPlaceHolder";
            this.wordPlaceHolder.Size = new System.Drawing.Size(33, 13);
            this.wordPlaceHolder.TabIndex = 0;
            this.wordPlaceHolder.Text = "Word";
            // 
            // occurencesPlaceHolder
            // 
            this.occurencesPlaceHolder.AutoSize = true;
            this.occurencesPlaceHolder.Location = new System.Drawing.Point(14, 42);
            this.occurencesPlaceHolder.Name = "occurencesPlaceHolder";
            this.occurencesPlaceHolder.Size = new System.Drawing.Size(65, 13);
            this.occurencesPlaceHolder.TabIndex = 1;
            this.occurencesPlaceHolder.Text = "Occurences";
            // 
            // wordOutput
            // 
            this.wordOutput.AutoSize = true;
            this.wordOutput.Location = new System.Drawing.Point(81, 16);
            this.wordOutput.Name = "wordOutput";
            this.wordOutput.Size = new System.Drawing.Size(0, 13);
            this.wordOutput.TabIndex = 2;
            // 
            // occurencesOutput
            // 
            this.occurencesOutput.AutoSize = true;
            this.occurencesOutput.Location = new System.Drawing.Point(93, 42);
            this.occurencesOutput.Name = "occurencesOutput";
            this.occurencesOutput.Size = new System.Drawing.Size(0, 13);
            this.occurencesOutput.TabIndex = 3;
            // 
            // locationsPlaceHolder
            // 
            this.locationsPlaceHolder.AutoSize = true;
            this.locationsPlaceHolder.Location = new System.Drawing.Point(14, 83);
            this.locationsPlaceHolder.Name = "locationsPlaceHolder";
            this.locationsPlaceHolder.Size = new System.Drawing.Size(53, 13);
            this.locationsPlaceHolder.TabIndex = 4;
            this.locationsPlaceHolder.Text = "Locations";
            // 
            // lineNoListBox
            // 
            this.lineNoListBox.FormattingEnabled = true;
            this.lineNoListBox.Location = new System.Drawing.Point(16, 122);
            this.lineNoListBox.Name = "lineNoListBox";
            this.lineNoListBox.Size = new System.Drawing.Size(77, 212);
            this.lineNoListBox.TabIndex = 5;
            this.lineNoListBox.SelectedIndexChanged += new System.EventHandler(this.syncListBoxes);
            // 
            // linePosListBox
            // 
            this.linePosListBox.FormattingEnabled = true;
            this.linePosListBox.Location = new System.Drawing.Point(124, 122);
            this.linePosListBox.Name = "linePosListBox";
            this.linePosListBox.Size = new System.Drawing.Size(77, 212);
            this.linePosListBox.TabIndex = 6;
            this.linePosListBox.SelectedIndexChanged += new System.EventHandler(this.syncListBoxes);
            // 
            // lineNoPlaceHolder
            // 
            this.lineNoPlaceHolder.AutoSize = true;
            this.lineNoPlaceHolder.Location = new System.Drawing.Point(14, 106);
            this.lineNoPlaceHolder.Name = "lineNoPlaceHolder";
            this.lineNoPlaceHolder.Size = new System.Drawing.Size(67, 13);
            this.lineNoPlaceHolder.TabIndex = 7;
            this.lineNoPlaceHolder.Text = "Line Number";
            // 
            // linePosPlaceholder
            // 
            this.linePosPlaceholder.AutoSize = true;
            this.linePosPlaceholder.Location = new System.Drawing.Point(121, 106);
            this.linePosPlaceholder.Name = "linePosPlaceholder";
            this.linePosPlaceholder.Size = new System.Drawing.Size(67, 13);
            this.linePosPlaceholder.TabIndex = 8;
            this.linePosPlaceholder.Text = "Line Position";
            // 
            // changeLocButton
            // 
            this.changeLocButton.Location = new System.Drawing.Point(81, 66);
            this.changeLocButton.Name = "changeLocButton";
            this.changeLocButton.Size = new System.Drawing.Size(75, 23);
            this.changeLocButton.TabIndex = 9;
            this.changeLocButton.Text = "Confirm";
            this.changeLocButton.UseVisualStyleBackColor = true;
            this.changeLocButton.Click += new System.EventHandler(this.changeLocButton_Click);
            // 
            // changeLineNoInput
            // 
            this.changeLineNoInput.Location = new System.Drawing.Point(15, 42);
            this.changeLineNoInput.Name = "changeLineNoInput";
            this.changeLineNoInput.Size = new System.Drawing.Size(100, 20);
            this.changeLineNoInput.TabIndex = 10;
            // 
            // changeLinePosInput
            // 
            this.changeLinePosInput.Location = new System.Drawing.Point(121, 42);
            this.changeLinePosInput.Name = "changeLinePosInput";
            this.changeLinePosInput.Size = new System.Drawing.Size(100, 20);
            this.changeLinePosInput.TabIndex = 11;
            // 
            // changeLineNoPlaceholder
            // 
            this.changeLineNoPlaceholder.AutoSize = true;
            this.changeLineNoPlaceholder.Location = new System.Drawing.Point(15, 26);
            this.changeLineNoPlaceholder.Name = "changeLineNoPlaceholder";
            this.changeLineNoPlaceholder.Size = new System.Drawing.Size(70, 13);
            this.changeLineNoPlaceholder.TabIndex = 12;
            this.changeLineNoPlaceholder.Text = "Line Number:";
            // 
            // changeLinePosPlaceholder
            // 
            this.changeLinePosPlaceholder.AutoSize = true;
            this.changeLinePosPlaceholder.Location = new System.Drawing.Point(118, 26);
            this.changeLinePosPlaceholder.Name = "changeLinePosPlaceholder";
            this.changeLinePosPlaceholder.Size = new System.Drawing.Size(70, 13);
            this.changeLinePosPlaceholder.TabIndex = 13;
            this.changeLinePosPlaceholder.Text = "Line Position:";
            // 
            // newLinePosPlaceholder
            // 
            this.newLinePosPlaceholder.AutoSize = true;
            this.newLinePosPlaceholder.Location = new System.Drawing.Point(125, 25);
            this.newLinePosPlaceholder.Name = "newLinePosPlaceholder";
            this.newLinePosPlaceholder.Size = new System.Drawing.Size(70, 13);
            this.newLinePosPlaceholder.TabIndex = 20;
            this.newLinePosPlaceholder.Text = "Line Position:";
            // 
            // newLineNoPlaceholder
            // 
            this.newLineNoPlaceholder.AutoSize = true;
            this.newLineNoPlaceholder.Location = new System.Drawing.Point(6, 25);
            this.newLineNoPlaceholder.Name = "newLineNoPlaceholder";
            this.newLineNoPlaceholder.Size = new System.Drawing.Size(70, 13);
            this.newLineNoPlaceholder.TabIndex = 19;
            this.newLineNoPlaceholder.Text = "Line Number:";
            // 
            // newLinePosInput
            // 
            this.newLinePosInput.Location = new System.Drawing.Point(125, 42);
            this.newLinePosInput.Name = "newLinePosInput";
            this.newLinePosInput.Size = new System.Drawing.Size(100, 20);
            this.newLinePosInput.TabIndex = 18;
            // 
            // newLineNoInput
            // 
            this.newLineNoInput.Location = new System.Drawing.Point(6, 42);
            this.newLineNoInput.Name = "newLineNoInput";
            this.newLineNoInput.Size = new System.Drawing.Size(100, 20);
            this.newLineNoInput.TabIndex = 17;
            // 
            // newLocButton
            // 
            this.newLocButton.Location = new System.Drawing.Point(75, 73);
            this.newLocButton.Name = "newLocButton";
            this.newLocButton.Size = new System.Drawing.Size(75, 23);
            this.newLocButton.TabIndex = 16;
            this.newLocButton.Text = "Confirm";
            this.newLocButton.UseVisualStyleBackColor = true;
            this.newLocButton.Click += new System.EventHandler(this.newLocButton_Click);
            // 
            // wordGroupBox
            // 
            this.wordGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wordGroupBox.Controls.Add(this.wordPlaceHolder);
            this.wordGroupBox.Controls.Add(this.occurencesPlaceHolder);
            this.wordGroupBox.Controls.Add(this.locationsPlaceHolder);
            this.wordGroupBox.Controls.Add(this.lineNoListBox);
            this.wordGroupBox.Controls.Add(this.linePosListBox);
            this.wordGroupBox.Controls.Add(this.lineNoPlaceHolder);
            this.wordGroupBox.Controls.Add(this.linePosPlaceholder);
            this.wordGroupBox.Controls.Add(this.wordOutput);
            this.wordGroupBox.Controls.Add(this.occurencesOutput);
            this.wordGroupBox.Location = new System.Drawing.Point(16, 36);
            this.wordGroupBox.Name = "wordGroupBox";
            this.tableLayoutPanel1.SetRowSpan(this.wordGroupBox, 3);
            this.wordGroupBox.Size = new System.Drawing.Size(220, 358);
            this.wordGroupBox.TabIndex = 24;
            this.wordGroupBox.TabStop = false;
            this.wordGroupBox.Text = "Word";
            // 
            // newLocGroupBox
            // 
            this.newLocGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newLocGroupBox.Controls.Add(this.newLineNoPlaceholder);
            this.newLocGroupBox.Controls.Add(this.newLinePosPlaceholder);
            this.newLocGroupBox.Controls.Add(this.newLocButton);
            this.newLocGroupBox.Controls.Add(this.newLineNoInput);
            this.newLocGroupBox.Controls.Add(this.newLinePosInput);
            this.newLocGroupBox.Location = new System.Drawing.Point(262, 18);
            this.newLocGroupBox.Name = "newLocGroupBox";
            this.newLocGroupBox.Size = new System.Drawing.Size(231, 106);
            this.newLocGroupBox.TabIndex = 25;
            this.newLocGroupBox.TabStop = false;
            this.newLocGroupBox.Text = "Add New Location:";
            // 
            // changeLocGroupBox
            // 
            this.changeLocGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeLocGroupBox.Controls.Add(this.changeLineNoPlaceholder);
            this.changeLocGroupBox.Controls.Add(this.changeLocButton);
            this.changeLocGroupBox.Controls.Add(this.changeLineNoInput);
            this.changeLocGroupBox.Controls.Add(this.changeLinePosInput);
            this.changeLocGroupBox.Controls.Add(this.changeLinePosPlaceholder);
            this.changeLocGroupBox.Location = new System.Drawing.Point(262, 161);
            this.changeLocGroupBox.Name = "changeLocGroupBox";
            this.changeLocGroupBox.Size = new System.Drawing.Size(231, 106);
            this.changeLocGroupBox.TabIndex = 26;
            this.changeLocGroupBox.TabStop = false;
            this.changeLocGroupBox.Text = "Change Location";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.wordGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.changeLocGroupBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.newLocGroupBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 430);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // discardChangesButton
            // 
            this.discardChangesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.discardChangesButton.Location = new System.Drawing.Point(3, 93);
            this.discardChangesButton.Name = "discardChangesButton";
            this.discardChangesButton.Size = new System.Drawing.Size(112, 39);
            this.discardChangesButton.TabIndex = 23;
            this.discardChangesButton.Text = "Discard Changes";
            this.discardChangesButton.UseVisualStyleBackColor = true;
            this.discardChangesButton.Click += new System.EventHandler(this.discardChangesButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveChangesButton.Location = new System.Drawing.Point(3, 48);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(112, 39);
            this.saveChangesButton.TabIndex = 22;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // removeOccButton
            // 
            this.removeOccButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeOccButton.Location = new System.Drawing.Point(3, 3);
            this.removeOccButton.Name = "removeOccButton";
            this.removeOccButton.Size = new System.Drawing.Size(112, 39);
            this.removeOccButton.TabIndex = 15;
            this.removeOccButton.Text = "Remove Occurence";
            this.removeOccButton.UseVisualStyleBackColor = true;
            this.removeOccButton.Click += new System.EventHandler(this.removeOccButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.removeOccButton);
            this.flowLayoutPanel1.Controls.Add(this.saveChangesButton);
            this.flowLayoutPanel1.Controls.Add(this.discardChangesButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(316, 289);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(124, 138);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 430);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(520, 469);
            this.Name = "EditForm";
            this.Text = "Edit Word";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.wordGroupBox.ResumeLayout(false);
            this.wordGroupBox.PerformLayout();
            this.newLocGroupBox.ResumeLayout(false);
            this.newLocGroupBox.PerformLayout();
            this.changeLocGroupBox.ResumeLayout(false);
            this.changeLocGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label wordPlaceHolder;
        private System.Windows.Forms.Label occurencesPlaceHolder;
        private System.Windows.Forms.Label wordOutput;
        private System.Windows.Forms.Label occurencesOutput;
        private System.Windows.Forms.Label locationsPlaceHolder;
        private System.Windows.Forms.ListBox lineNoListBox;
        private System.Windows.Forms.ListBox linePosListBox;
        private System.Windows.Forms.Label lineNoPlaceHolder;
        private System.Windows.Forms.Label linePosPlaceholder;
        private System.Windows.Forms.Button changeLocButton;
        private System.Windows.Forms.TextBox changeLineNoInput;
        private System.Windows.Forms.TextBox changeLinePosInput;
        private System.Windows.Forms.Label changeLineNoPlaceholder;
        private System.Windows.Forms.Label changeLinePosPlaceholder;
        private System.Windows.Forms.Label newLinePosPlaceholder;
        private System.Windows.Forms.Label newLineNoPlaceholder;
        private System.Windows.Forms.TextBox newLinePosInput;
        private System.Windows.Forms.TextBox newLineNoInput;
        private System.Windows.Forms.Button newLocButton;
        private System.Windows.Forms.GroupBox wordGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox changeLocGroupBox;
        private System.Windows.Forms.GroupBox newLocGroupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button removeOccButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button discardChangesButton;
    }
}