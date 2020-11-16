using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_App.GamePieces.ChessPieces
{
    abstract class ChessPiece
    {
        public int X;
        public int Y;
        public string color;
        public abstract List<string> moves();
        public abstract void move();
        public abstract Panel draw();
        public abstract string toString();

    }
}
