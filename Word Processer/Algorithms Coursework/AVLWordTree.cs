using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Algorithms_Coursework
{
    public class AVLWordTree<T> : AVLTree<T> where T : Word
    {
        private string _filename;
        public string filename { get => _filename; set => _filename = value; }

        public void addNewLocation(Word word)
        {
            _addNewLocation(ref root, word);
        }

        private void _addNewLocation(ref Node<T> tree, Word word)
        {
            if (tree != null)
            {
                if (tree.Data.CompareTo(word) == 0)
                {
                    tree.Data.addLocation(word.getAllLocations().First());
                }
                else if (word.CompareTo(tree.Data) > 0)
                {
                    _addNewLocation(ref tree.Right, word);
                }
                else if (word.CompareTo(tree.Data) < 0)
                {
                    _addNewLocation(ref tree.Left, word);
                }
            }
        }

        // Necessary
        public List<Word> searchWordOccurences(int occurences)
        {
            List<Word> words = new List<Word>();
            _searchWordOccurences(root, ref words, occurences);
            return words;
        }

        private void _searchWordOccurences(Node<T> tree, ref List<Word> words, int occurences)
        {
            if (tree != null)
            {
                if (tree.Data.Occurrences == occurences)
                {
                    words.Add(tree.Data);
                }
                _searchWordOccurences(tree.Left, ref words, occurences);
                _searchWordOccurences(tree.Right, ref words, occurences);
            }
        }

        // Necessary
        public List<Word> searchByName(string findWord)
        {
            List<Word> words = new List<Word>();
            _searchByName(root,ref words, findWord);
            return words;
        }

        private void _searchByName(Node<T> tree, ref List<Word> words, string findWord)
        {
            if (tree != null)
            {
                Regex rx = new Regex("^"+findWord);
                if (rx.IsMatch(tree.Data.getSetWord))
                {
                    words.Add(tree.Data);
                    _searchByName(tree.Right, ref words, findWord);
                    _searchByName(tree.Left, ref words, findWord);
                }
                else
                {
                    if (tree.Data.getSetWord.CompareTo(findWord) < 0)
                    {
                        _searchByName(tree.Right, ref words, findWord);
                    }
                    else
                    {
                        _searchByName(tree.Left, ref words, findWord);
                    }
                }
               
            }
        }

        // Necessary
        public Word getMostCommonOccurence()
        {
            Word commonWord = root.Data;
            _getMostCommonOccurence(root, ref commonWord);
            return commonWord;
        }

        private void _getMostCommonOccurence(Node<T> tree ,ref Word bestOccurence)
        {
            if (tree != null)
            {
                if (tree.Data.Occurrences > bestOccurence.Occurrences)
                {
                    bestOccurence = tree.Data;
                }
                _getMostCommonOccurence(tree.Left, ref bestOccurence);
                _getMostCommonOccurence(tree.Right, ref bestOccurence);
            }
        }
        
        // necessary
        public List<Word> occInOrder()
        {
            List<Word> words = new List<Word>();
            _occInOrder(root,ref words);
            return words.OrderByDescending(x => x.Occurrences).ToList();
        }

        private void _occInOrder(Node<T> tree,ref List<Word> words)
        {
            if (tree != null)
            {
                words.Add(tree.Data);
                _occInOrder(tree.Left,ref words);
                _occInOrder(tree.Right,ref words);
            }
        }
    }
}
