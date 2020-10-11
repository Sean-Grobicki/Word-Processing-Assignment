using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms_Coursework
{
    public partial class EditForm : Form
    {

        private Word _word;
        private AVLWordTree<Word> _tree
            ;
        public EditForm(Word word,AVLWordTree<Word> tree)
        {
            InitializeComponent();
            _word = word;
            _tree = tree;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            wordOutput.Text = _word.getSetWord;
            occurencesOutput.Text = _word.Occurrences.ToString();
            updateLocationBoxes();
        }

        private void syncListBoxes(object sender, EventArgs e)
        {
            if (sender.Equals(lineNoListBox))
            {
                linePosListBox.SelectedIndex = lineNoListBox.SelectedIndex;
            }
            else
            {
                lineNoListBox.SelectedIndex = linePosListBox.SelectedIndex;
            }
        }

        private void newLocButton_Click(object sender, EventArgs e)
        {
            try
            {
                int lineNo = Convert.ToInt32(newLineNoInput.Text);
                int linePos = Convert.ToInt32(newLinePosInput.Text);
                if (lineNo >= 0 && linePos >= 0)
                {
                    _word.addLocation(new Location(lineNo, linePos));
                    lineNoListBox.Items.Add(lineNo);
                    linePosListBox.Items.Add(linePos);
                }
            }
            catch
            { 
            
            }
        }

        private void changeLocButton_Click(object sender, EventArgs e)
        {
            try
            {
                int oldLinePos = Convert.ToInt32(linePosListBox.SelectedItem.ToString());
                int oldLineNo = Convert.ToInt32(lineNoListBox.SelectedItem.ToString());
                int newLinePos = Convert.ToInt32(changeLinePosInput.Text);
                int newLineNo = Convert.ToInt32(changeLineNoInput.Text);
                if (newLineNo >= 0 && newLinePos >= 0)
                {
                    _word.changeLocation(oldLineNo, oldLinePos, newLineNo, newLinePos);
                    linePosListBox.SelectedItem = newLinePos;
                    lineNoListBox.SelectedItem = newLineNo;
                }
            }
            catch
            { 
            
            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            _tree.replaceItem(_word);
            changeForm();
        }

        private void discardChangesButton_Click(object sender, EventArgs e)
        {
            changeForm();
        }

        private void changeForm()
        {
            this.Hide();
            SearchForm ef = new SearchForm(_tree);
            ef.Closed += (s, args) => this.Close();
            ef.Show();
        }

        private void removeOccButton_Click(object sender, EventArgs e)
        {
            int oldLinePos = Convert.ToInt32(linePosListBox.SelectedItem.ToString());
            int oldLineNo = Convert.ToInt32(lineNoListBox.SelectedItem.ToString());
            if (_word.Occurrences > 1)
            {
                _word.removeLocation(oldLineNo, oldLinePos);
                updateLocationBoxes();
            }
        }

        private void updateLocationBoxes()
        {
            lineNoListBox.Items.Clear();
            linePosListBox.Items.Clear();
            foreach (Location loc in _word.getAllLocations())
            {
                lineNoListBox.Items.Add(loc.LineNumber);
                linePosListBox.Items.Add(loc.LinePosition);
            }
            occurencesOutput.Text = _word.getAllLocations().Count().ToString();
        }
    }
}
