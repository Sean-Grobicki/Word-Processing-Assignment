using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Coursework
{
    public class Word : IComparable
    {
        private String _word;
        private int _occurrences;
        private LinkedList<Location> _locations;

        public Word(String word, Location location)
        {
            _locations = new LinkedList<Location>();
            getSetWord = word;
            _locations.AddFirst(location);
            Occurrences = 1;
        }

        public string getSetWord { get => _word; set => _word = value; }
        public int Occurrences { get => _occurrences; set => _occurrences = value; }

        public LinkedList<Location> getAllLocations()
        {
            return _locations;
        }

        public void addLocation(Location newLocation)
        {
            _locations.AddLast(newLocation);
            Occurrences++;
        }

        public int CompareTo(object other)
        {
            Word otherWord = (Word)other;
            return _word.CompareTo(otherWord.getSetWord);
        }

        public void changeLocation(int oldLineNo,int oldLinePos,int newLineNo, int newLinePos)
        {
            _locations.Find(new Location(oldLineNo, oldLinePos)).Value = new Location(newLineNo,newLinePos);
        }

        public void removeLocation(int lineNo,int linePos)
        {
            foreach (Location l in _locations)
            {
                if (lineNo == l.LineNumber && linePos == l.LinePosition)
                {
                    _locations.Remove(l);
                    _occurrences--;
                    break;
                }
            }
        }
    }
}
