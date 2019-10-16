using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ChallengeApplication
{
    public class Square : Quadrilateral
    {
        public Square(string sColour, int SideLength) : base(sColour, SideLength, SideLength, SideLength, SideLength)
        {
            List<int> Square = new List<int>();
        }

        public int GetArea()
        {
            return Side1Length * Side1Length;
        }
        public override string ToString()
        {
            return Colour + ", " + Side1Length * Side1Length;

        }
    }
}
