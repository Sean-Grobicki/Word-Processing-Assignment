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
    public partial class SearchForm : Form
    {
        private AVLWordTree<Word> _tree;
        public SearchForm(AVLWordTree<Word> tree)
        {
            InitializeComponent();
            _tree = tree;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            List<Word> words = _tree.inOrder();
            updateWordListBoxes(words);
            uniqueWordOutput.Text = _tree.count().ToString();
            Word mostCommon = _tree.getMostCommonOccurence();
            mostCommonOutput.Text = mostCommon.getSetWord + " occured " + mostCommon.Occurrences + " times";
            nameSearchRB.Checked = true;
            alphaRB.Checked = true;
            desRB.Checked = true;
        }

        private void editWordButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditForm ef = new EditForm(_tree.getItem(new Word(wordListbox.Items[wordListbox.SelectedIndex].ToString(),new Location(0,0))), _tree);
            ef.Closed += (s, args) => this.Close();
            ef.Show();
        }

        private void syncListBoxes(object sender, EventArgs e)
        {
            if (sender.Equals(wordListbox))
            {
                occurencesListbox.SelectedIndex = wordListbox.SelectedIndex;
            }
            else
            {
                wordListbox.SelectedIndex = occurencesListbox.SelectedIndex;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<Word> searchWords = new List<Word>();
            try
            {
                
                if (searchOccurencesRB.Checked)
                {
                    int occurences = Convert.ToInt32(searchInput.Text);
                    searchWords = _tree.searchWordOccurences(occurences);
                }
                else
                {
                    string findWord = searchInput.Text.ToString();
                    searchWords = _tree.searchByName(findWord);
                }
                updateWordListBoxes(searchWords);
            }
            catch
            { 
            
            }
        }

        private void collocationButton_Click(object sender, EventArgs e)
        {
            Word findWord1 = new Word(colInput1.Text, new Location(0, 0));
            Word findWord2 = new Word(colInput2.Text, new Location(0, 0));
            Word word1 = _tree.getItem(findWord1);
            Word word2 = _tree.getItem(findWord2);
            int counter = 0;
            if (word1 != null && word2 != null)
            {
                foreach (Location w1Loc in word1.getAllLocations())
                {
                    foreach (Location w2Loc in word2.getAllLocations())
                    {
                        if (w1Loc.isNextToo(w2Loc))
                        {
                            counter++;
                        }
                    }
                }
            }
            colOccOutput.Text = counter.ToString();

        }
        private void displayButtton_Click(object sender, EventArgs e)
        {
            List<Word> words = new List<Word>();
            if (alphaRB.Checked == true)
            {
                words = _tree.inOrder();
            }
            else
            {
                words = _tree.occInOrder();
            }
            if (ascRB.Checked == true)
            {
                words.Reverse();
            }
            updateWordListBoxes(words);
        }

        private void removeWordButton_Click(object sender, EventArgs e)
        {
            Word toRemove = _tree.getItem(new Word(wordListbox.SelectedItem.ToString(),new Location(0,0)));
            _tree.removeItem(toRemove);
            updateWordListBoxes(_tree.inOrder());
        }


        private void updateWordListBoxes(List<Word> words)
        {
            wordListbox.Items.Clear();
            occurencesListbox.Items.Clear();
            foreach (Word word in words)
            {
                wordListbox.Items.Add(word.getSetWord);
                occurencesListbox.Items.Add(word.Occurrences);
            }
        } 
    }
}
