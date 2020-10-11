using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
namespace Algorithms_Coursework
{
    public partial class LoadForm : Form
    {
        private AVLWordTree<Word> _tree;

        public LoadForm()
        {
            InitializeComponent();
            openFile.FileName = "";
        }

        public LoadForm(AVLWordTree<Word> tree) 
        {
            InitializeComponent();
            _tree = tree;
            fileNameLabel.Text = _tree.filename;
            openFile.FileName = _tree.filename;
        }

        private void fileInfoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm sf = new SearchForm(_tree);
            sf.Closed += (s, args) => this.Close();
            sf.Show();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            const int MAX_FILE_LINES = 50000;
            string[] AllLines = new string[MAX_FILE_LINES];
            openFile.ShowDialog();
            Regex rx = new Regex(@"([a-zA-Z0-9s_\\.\-\\(\):])+(.txt)$");
            if (rx.IsMatch(openFile.FileName))
            {
                _tree = new AVLWordTree<Word>();
                _tree.filename = openFile.FileName;
                AllLines = File.ReadAllLines(_tree.filename);
                fileNameLabel.Text = _tree.filename;
                fileOutputDisplay.Text = "";
                for (int i = 0; i < AllLines.Length; i++)
                {
                    //split words using space , . ? and ;
                    string line = AllLines[i];
                    fileOutputDisplay.Text += line + "\n";
                    string[] words = line.Split(' ', ',', '.', '?', ';');
                    for (int j = 0; j < words.Length; j++)
                    {
                        if (words[j] != "")
                        {
                            Word newWord = new Word(words[j].ToLower(), new Location(i, j));
                            if (_tree.contains(newWord))
                            {
                                _tree.addNewLocation(newWord);
                            }
                            else
                            {
                                _tree.insertItem(newWord);
                            }
                        }
                    }
                }
                fileInfoButton.Visible = true;
            }
        }
        private void LoadForm_Load(object sender, EventArgs e)
        {
            openFile.InitialDirectory = "";
            openFile.Title = "Open Text File";
        }
    }
}
