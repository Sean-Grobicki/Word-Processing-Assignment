using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Coursework
{
    public class Location
    {
        private int _lineNumber;
        private int _linePosition;

        public Location(int lineNo,int linePos)
        {
            LineNumber = lineNo;
            LinePosition = linePos;
        }
        public int LineNumber { get => _lineNumber; set => _lineNumber = value; }
        public int LinePosition { get => _linePosition; set => _linePosition = value; }

        public bool isNextToo(Location other)
        {
            if (_lineNumber == other.LineNumber && (_linePosition - 1 == other.LinePosition || _linePosition + 1 == other.LinePosition))
            {
                return true;
            }
            return false;
        }
    }
}
