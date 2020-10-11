namespace Algorithms_Coursework
{
    partial class SearchForm
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
            this.nameSearchRB = new System.Windows.Forms.RadioButton();
            this.searchOccurencesRB = new System.Windows.Forms.RadioButton();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.wordListbox = new System.Windows.Forms.ListBox();
            this.occurencesListbox = new System.Windows.Forms.ListBox();
            this.wordPlaeholder = new System.Windows.Forms.Label();
            this.occurencesPlaceholder = new System.Windows.Forms.Label();
            this.uniqueWordOutput = new System.Windows.Forms.Label();
            this.uniqueWordsPlaceholder = new System.Windows.Forms.Label();
            this.removeWordButton = new System.Windows.Forms.Button();
            this.mostCommonOutput = new System.Windows.Forms.Label();
            this.commonWordPlaceholder = new System.Windows.Forms.Label();
            this.editWordButton = new System.Windows.Forms.Button();
            this.alphaRB = new System.Windows.Forms.RadioButton();
            this.occRB = new System.Windows.Forms.RadioButton();
            this.desRB = new System.Windows.Forms.RadioButton();
            this.ascRB = new System.Windows.Forms.RadioButton();
            this.colInput1 = new System.Windows.Forms.TextBox();
            this.colInput2 = new System.Windows.Forms.TextBox();
            this.colOccOutput = new System.Windows.Forms.Label();
            this.colOccPlaceholder = new System.Windows.Forms.Label();
            this.sortingValueRG = new System.Windows.Forms.GroupBox();
            this.sortingOrderRG = new System.Windows.Forms.GroupBox();
            this.searchingRG = new System.Windows.Forms.GroupBox();
            this.displayWordBox = new System.Windows.Forms.GroupBox();
            this.displayButtton = new System.Windows.Forms.Button();
            this.collocationButton = new System.Windows.Forms.Button();
            this.collocationGroupBox = new System.Windows.Forms.GroupBox();
            this.backgroundLayout = new System.Windows.Forms.TableLayoutPanel();
            this.wordGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sortingValueRG.SuspendLayout();
            this.sortingOrderRG.SuspendLayout();
            this.searchingRG.SuspendLayout();
            this.displayWordBox.SuspendLayout();
            this.collocationGroupBox.SuspendLayout();
            this.backgroundLayout.SuspendLayout();
            this.wordGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameSearchRB
            // 
            this.nameSearchRB.AutoSize = true;
            this.nameSearchRB.Location = new System.Drawing.Point(5, 21);
            this.nameSearchRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameSearchRB.Name = "nameSearchRB";
            this.nameSearchRB.Size = new System.Drawing.Size(128, 20);
            this.nameSearchRB.TabIndex = 0;
            this.nameSearchRB.TabStop = true;
            this.nameSearchRB.Text = "Search By Name";
            this.nameSearchRB.UseVisualStyleBackColor = true;
            // 
            // searchOccurencesRB
            // 
            this.searchOccurencesRB.AutoSize = true;
            this.searchOccurencesRB.Location = new System.Drawing.Point(7, 49);
            this.searchOccurencesRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchOccurencesRB.Name = "searchOccurencesRB";
            this.searchOccurencesRB.Size = new System.Drawing.Size(228, 20);
            this.searchOccurencesRB.TabIndex = 2;
            this.searchOccurencesRB.TabStop = true;
            this.searchOccurencesRB.Text = "Search By Number of Occurences";
            this.searchOccurencesRB.UseVisualStyleBackColor = true;
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(269, 47);
            this.searchInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(132, 22);
            this.searchInput.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(164, 95);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 28);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // wordListbox
            // 
            this.wordListbox.FormattingEnabled = true;
            this.wordListbox.ItemHeight = 16;
            this.wordListbox.Location = new System.Drawing.Point(39, 38);
            this.wordListbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wordListbox.Name = "wordListbox";
            this.wordListbox.Size = new System.Drawing.Size(132, 420);
            this.wordListbox.TabIndex = 5;
            this.wordListbox.SelectedIndexChanged += new System.EventHandler(this.syncListBoxes);
            // 
            // occurencesListbox
            // 
            this.occurencesListbox.FormattingEnabled = true;
            this.occurencesListbox.ItemHeight = 16;
            this.occurencesListbox.Location = new System.Drawing.Point(224, 38);
            this.occurencesListbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.occurencesListbox.Name = "occurencesListbox";
            this.occurencesListbox.Size = new System.Drawing.Size(131, 420);
            this.occurencesListbox.TabIndex = 6;
            this.occurencesListbox.SelectedIndexChanged += new System.EventHandler(this.syncListBoxes);
            // 
            // wordPlaeholder
            // 
            this.wordPlaeholder.AutoSize = true;
            this.wordPlaeholder.Location = new System.Drawing.Point(72, 18);
            this.wordPlaeholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wordPlaeholder.Name = "wordPlaeholder";
            this.wordPlaeholder.Size = new System.Drawing.Size(41, 16);
            this.wordPlaeholder.TabIndex = 8;
            this.wordPlaeholder.Text = "Word";
            // 
            // occurencesPlaceholder
            // 
            this.occurencesPlaceholder.AutoSize = true;
            this.occurencesPlaceholder.Location = new System.Drawing.Point(247, 18);
            this.occurencesPlaceholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.occurencesPlaceholder.Name = "occurencesPlaceholder";
            this.occurencesPlaceholder.Size = new System.Drawing.Size(80, 16);
            this.occurencesPlaceholder.TabIndex = 9;
            this.occurencesPlaceholder.Text = "Occurences";
            // 
            // uniqueWordOutput
            // 
            this.uniqueWordOutput.AutoSize = true;
            this.uniqueWordOutput.Location = new System.Drawing.Point(167, 90);
            this.uniqueWordOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uniqueWordOutput.Name = "uniqueWordOutput";
            this.uniqueWordOutput.Size = new System.Drawing.Size(0, 16);
            this.uniqueWordOutput.TabIndex = 11;
            // 
            // uniqueWordsPlaceholder
            // 
            this.uniqueWordsPlaceholder.AutoSize = true;
            this.uniqueWordsPlaceholder.Location = new System.Drawing.Point(21, 90);
            this.uniqueWordsPlaceholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uniqueWordsPlaceholder.Name = "uniqueWordsPlaceholder";
            this.uniqueWordsPlaceholder.Size = new System.Drawing.Size(97, 16);
            this.uniqueWordsPlaceholder.TabIndex = 10;
            this.uniqueWordsPlaceholder.Text = "Unique Words:";
            // 
            // removeWordButton
            // 
            this.removeWordButton.Location = new System.Drawing.Point(224, 512);
            this.removeWordButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeWordButton.Name = "removeWordButton";
            this.removeWordButton.Size = new System.Drawing.Size(132, 32);
            this.removeWordButton.TabIndex = 12;
            this.removeWordButton.Text = "Remove Word";
            this.removeWordButton.UseVisualStyleBackColor = true;
            this.removeWordButton.Click += new System.EventHandler(this.removeWordButton_Click);
            // 
            // mostCommonOutput
            // 
            this.mostCommonOutput.AutoSize = true;
            this.mostCommonOutput.Location = new System.Drawing.Point(167, 36);
            this.mostCommonOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mostCommonOutput.Name = "mostCommonOutput";
            this.mostCommonOutput.Size = new System.Drawing.Size(0, 16);
            this.mostCommonOutput.TabIndex = 14;
            // 
            // commonWordPlaceholder
            // 
            this.commonWordPlaceholder.AutoSize = true;
            this.commonWordPlaceholder.Location = new System.Drawing.Point(15, 48);
            this.commonWordPlaceholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.commonWordPlaceholder.Name = "commonWordPlaceholder";
            this.commonWordPlaceholder.Size = new System.Drawing.Size(133, 16);
            this.commonWordPlaceholder.TabIndex = 13;
            this.commonWordPlaceholder.Text = "Most Common Word:";
            // 
            // editWordButton
            // 
            this.editWordButton.Location = new System.Drawing.Point(41, 512);
            this.editWordButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editWordButton.Name = "editWordButton";
            this.editWordButton.Size = new System.Drawing.Size(131, 32);
            this.editWordButton.TabIndex = 15;
            this.editWordButton.Text = "Edit Word";
            this.editWordButton.UseVisualStyleBackColor = true;
            this.editWordButton.Click += new System.EventHandler(this.editWordButton_Click);
            // 
            // alphaRB
            // 
            this.alphaRB.AutoSize = true;
            this.alphaRB.Location = new System.Drawing.Point(11, 15);
            this.alphaRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alphaRB.Name = "alphaRB";
            this.alphaRB.Size = new System.Drawing.Size(111, 20);
            this.alphaRB.TabIndex = 17;
            this.alphaRB.TabStop = true;
            this.alphaRB.Text = "Alphabetically";
            this.alphaRB.UseVisualStyleBackColor = true;
            // 
            // occRB
            // 
            this.occRB.AutoSize = true;
            this.occRB.Location = new System.Drawing.Point(11, 43);
            this.occRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.occRB.Name = "occRB";
            this.occRB.Size = new System.Drawing.Size(117, 20);
            this.occRB.TabIndex = 18;
            this.occRB.TabStop = true;
            this.occRB.Text = "By Occurences";
            this.occRB.UseVisualStyleBackColor = true;
            // 
            // desRB
            // 
            this.desRB.AutoSize = true;
            this.desRB.Location = new System.Drawing.Point(7, 43);
            this.desRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.desRB.Name = "desRB";
            this.desRB.Size = new System.Drawing.Size(99, 20);
            this.desRB.TabIndex = 22;
            this.desRB.TabStop = true;
            this.desRB.Text = "Descending";
            this.desRB.UseVisualStyleBackColor = true;
            // 
            // ascRB
            // 
            this.ascRB.AutoSize = true;
            this.ascRB.Location = new System.Drawing.Point(7, 15);
            this.ascRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ascRB.Name = "ascRB";
            this.ascRB.Size = new System.Drawing.Size(90, 20);
            this.ascRB.TabIndex = 21;
            this.ascRB.TabStop = true;
            this.ascRB.Text = "Ascending";
            this.ascRB.UseVisualStyleBackColor = true;
            // 
            // colInput1
            // 
            this.colInput1.Location = new System.Drawing.Point(45, 34);
            this.colInput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colInput1.Name = "colInput1";
            this.colInput1.Size = new System.Drawing.Size(132, 22);
            this.colInput1.TabIndex = 25;
            // 
            // colInput2
            // 
            this.colInput2.Location = new System.Drawing.Point(244, 34);
            this.colInput2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colInput2.Name = "colInput2";
            this.colInput2.Size = new System.Drawing.Size(132, 22);
            this.colInput2.TabIndex = 26;
            // 
            // colOccOutput
            // 
            this.colOccOutput.AutoSize = true;
            this.colOccOutput.Location = new System.Drawing.Point(177, 121);
            this.colOccOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colOccOutput.Name = "colOccOutput";
            this.colOccOutput.Size = new System.Drawing.Size(0, 16);
            this.colOccOutput.TabIndex = 28;
            // 
            // colOccPlaceholder
            // 
            this.colOccPlaceholder.AutoSize = true;
            this.colOccPlaceholder.Location = new System.Drawing.Point(4, 121);
            this.colOccPlaceholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colOccPlaceholder.Name = "colOccPlaceholder";
            this.colOccPlaceholder.Size = new System.Drawing.Size(153, 16);
            this.colOccPlaceholder.TabIndex = 27;
            this.colOccPlaceholder.Text = "Collocation Occurences:";
            // 
            // sortingValueRG
            // 
            this.sortingValueRG.Controls.Add(this.alphaRB);
            this.sortingValueRG.Controls.Add(this.occRB);
            this.sortingValueRG.Location = new System.Drawing.Point(25, 34);
            this.sortingValueRG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortingValueRG.Name = "sortingValueRG";
            this.sortingValueRG.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortingValueRG.Size = new System.Drawing.Size(141, 74);
            this.sortingValueRG.TabIndex = 29;
            this.sortingValueRG.TabStop = false;
            // 
            // sortingOrderRG
            // 
            this.sortingOrderRG.Controls.Add(this.ascRB);
            this.sortingOrderRG.Controls.Add(this.desRB);
            this.sortingOrderRG.Location = new System.Drawing.Point(248, 34);
            this.sortingOrderRG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortingOrderRG.Name = "sortingOrderRG";
            this.sortingOrderRG.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortingOrderRG.Size = new System.Drawing.Size(128, 74);
            this.sortingOrderRG.TabIndex = 30;
            this.sortingOrderRG.TabStop = false;
            // 
            // searchingRG
            // 
            this.searchingRG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchingRG.Controls.Add(this.nameSearchRB);
            this.searchingRG.Controls.Add(this.searchOccurencesRB);
            this.searchingRG.Controls.Add(this.searchButton);
            this.searchingRG.Controls.Add(this.searchInput);
            this.searchingRG.Location = new System.Drawing.Point(73, 206);
            this.searchingRG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchingRG.MinimumSize = new System.Drawing.Size(443, 146);
            this.searchingRG.Name = "searchingRG";
            this.searchingRG.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchingRG.Size = new System.Drawing.Size(443, 146);
            this.searchingRG.TabIndex = 31;
            this.searchingRG.TabStop = false;
            this.searchingRG.Text = "Searching:";
            // 
            // displayWordBox
            // 
            this.displayWordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displayWordBox.Controls.Add(this.displayButtton);
            this.displayWordBox.Controls.Add(this.sortingValueRG);
            this.displayWordBox.Controls.Add(this.sortingOrderRG);
            this.displayWordBox.Location = new System.Drawing.Point(73, 18);
            this.displayWordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayWordBox.MinimumSize = new System.Drawing.Size(443, 127);
            this.displayWordBox.Name = "displayWordBox";
            this.displayWordBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayWordBox.Size = new System.Drawing.Size(443, 149);
            this.displayWordBox.TabIndex = 32;
            this.displayWordBox.TabStop = false;
            this.displayWordBox.Text = "Display All Unique Words:";
            // 
            // displayButtton
            // 
            this.displayButtton.Location = new System.Drawing.Point(164, 114);
            this.displayButtton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayButtton.Name = "displayButtton";
            this.displayButtton.Size = new System.Drawing.Size(100, 28);
            this.displayButtton.TabIndex = 31;
            this.displayButtton.Text = "Display";
            this.displayButtton.UseVisualStyleBackColor = true;
            this.displayButtton.Click += new System.EventHandler(this.displayButtton_Click);
            // 
            // collocationButton
            // 
            this.collocationButton.Location = new System.Drawing.Point(133, 73);
            this.collocationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.collocationButton.Name = "collocationButton";
            this.collocationButton.Size = new System.Drawing.Size(133, 34);
            this.collocationButton.TabIndex = 33;
            this.collocationButton.Text = "Get Collocation";
            this.collocationButton.UseVisualStyleBackColor = true;
            this.collocationButton.Click += new System.EventHandler(this.collocationButton_Click);
            // 
            // collocationGroupBox
            // 
            this.collocationGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.collocationGroupBox.Controls.Add(this.colOccPlaceholder);
            this.collocationGroupBox.Controls.Add(this.colOccOutput);
            this.collocationGroupBox.Controls.Add(this.collocationButton);
            this.collocationGroupBox.Controls.Add(this.colInput1);
            this.collocationGroupBox.Controls.Add(this.colInput2);
            this.collocationGroupBox.Location = new System.Drawing.Point(73, 386);
            this.collocationGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.collocationGroupBox.MinimumSize = new System.Drawing.Size(443, 158);
            this.collocationGroupBox.Name = "collocationGroupBox";
            this.collocationGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.collocationGroupBox.Size = new System.Drawing.Size(443, 158);
            this.collocationGroupBox.TabIndex = 34;
            this.collocationGroupBox.TabStop = false;
            this.collocationGroupBox.Text = "Collocation:";
            // 
            // backgroundLayout
            // 
            this.backgroundLayout.ColumnCount = 2;
            this.backgroundLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.backgroundLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.backgroundLayout.Controls.Add(this.wordGroupBox, 1, 0);
            this.backgroundLayout.Controls.Add(this.displayWordBox, 0, 0);
            this.backgroundLayout.Controls.Add(this.searchingRG, 0, 1);
            this.backgroundLayout.Controls.Add(this.collocationGroupBox, 0, 2);
            this.backgroundLayout.Controls.Add(this.groupBox2, 0, 3);
            this.backgroundLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundLayout.Location = new System.Drawing.Point(0, 0);
            this.backgroundLayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backgroundLayout.Name = "backgroundLayout";
            this.backgroundLayout.RowCount = 4;
            this.backgroundLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.backgroundLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.backgroundLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.backgroundLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.backgroundLayout.Size = new System.Drawing.Size(1180, 747);
            this.backgroundLayout.TabIndex = 35;
            // 
            // wordGroupBox
            // 
            this.wordGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wordGroupBox.Controls.Add(this.wordPlaeholder);
            this.wordGroupBox.Controls.Add(this.removeWordButton);
            this.wordGroupBox.Controls.Add(this.editWordButton);
            this.wordGroupBox.Controls.Add(this.occurencesPlaceholder);
            this.wordGroupBox.Controls.Add(this.occurencesListbox);
            this.wordGroupBox.Controls.Add(this.wordListbox);
            this.wordGroupBox.Location = new System.Drawing.Point(680, 81);
            this.wordGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wordGroupBox.MinimumSize = new System.Drawing.Size(409, 585);
            this.wordGroupBox.Name = "wordGroupBox";
            this.wordGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backgroundLayout.SetRowSpan(this.wordGroupBox, 4);
            this.wordGroupBox.Size = new System.Drawing.Size(409, 585);
            this.wordGroupBox.TabIndex = 36;
            this.wordGroupBox.TabStop = false;
            this.wordGroupBox.Text = "Words";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mostCommonOutput);
            this.groupBox2.Controls.Add(this.uniqueWordOutput);
            this.groupBox2.Controls.Add(this.commonWordPlaceholder);
            this.groupBox2.Controls.Add(this.uniqueWordsPlaceholder);
            this.groupBox2.Location = new System.Drawing.Point(73, 573);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.MinimumSize = new System.Drawing.Size(443, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(443, 158);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 28;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 747);
            this.Controls.Add(this.backgroundLayout);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(956, 721);
            this.Name = "SearchForm";
            this.Text = "File Analysis";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.sortingValueRG.ResumeLayout(false);
            this.sortingValueRG.PerformLayout();
            this.sortingOrderRG.ResumeLayout(false);
            this.sortingOrderRG.PerformLayout();
            this.searchingRG.ResumeLayout(false);
            this.searchingRG.PerformLayout();
            this.displayWordBox.ResumeLayout(false);
            this.collocationGroupBox.ResumeLayout(false);
            this.collocationGroupBox.PerformLayout();
            this.backgroundLayout.ResumeLayout(false);
            this.wordGroupBox.ResumeLayout(false);
            this.wordGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton nameSearchRB;
        private System.Windows.Forms.RadioButton searchOccurencesRB;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox wordListbox;
        private System.Windows.Forms.ListBox occurencesListbox;
        private System.Windows.Forms.Label wordPlaeholder;
        private System.Windows.Forms.Label occurencesPlaceholder;
        private System.Windows.Forms.Label uniqueWordOutput;
        private System.Windows.Forms.Label uniqueWordsPlaceholder;
        private System.Windows.Forms.Button removeWordButton;
        private System.Windows.Forms.Label mostCommonOutput;
        private System.Windows.Forms.Label commonWordPlaceholder;
        private System.Windows.Forms.Button editWordButton;
        private System.Windows.Forms.RadioButton alphaRB;
        private System.Windows.Forms.RadioButton occRB;
        private System.Windows.Forms.RadioButton desRB;
        private System.Windows.Forms.RadioButton ascRB;
        private System.Windows.Forms.TextBox colInput1;
        private System.Windows.Forms.TextBox colInput2;
        private System.Windows.Forms.Label colOccOutput;
        private System.Windows.Forms.Label colOccPlaceholder;
        private System.Windows.Forms.GroupBox sortingValueRG;
        private System.Windows.Forms.GroupBox sortingOrderRG;
        private System.Windows.Forms.GroupBox searchingRG;
        private System.Windows.Forms.GroupBox displayWordBox;
        private System.Windows.Forms.Button collocationButton;
        private System.Windows.Forms.GroupBox collocationGroupBox;
        private System.Windows.Forms.TableLayoutPanel backgroundLayout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox wordGroupBox;
        private System.Windows.Forms.Button displayButtton;
    }
}