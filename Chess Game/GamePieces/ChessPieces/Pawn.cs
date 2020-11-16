using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_App.GamePieces.ChessPieces
{
    class Pawn : ChessPiece
    {
        
        public override Panel draw()
        {
            Panel p = new Panel();
            p.Size = new System.Drawing.Size(56, 56);
            TextBox piece = new TextBox();
            piece.Text = "P";
            p.Controls.Add(piece);
            if (this.color == "white")
            {
                p.BackColor = Color.White;
            }
            else
            {
                p.BackColor = Color.Black;
            }
            p.Left = this.X * 60+2;
            p.Top = this.Y * 60+2;
            
            return p;
        }

        public override void move()
        {
            System.Diagnostics.Debug.WriteLine("pawn");
        }

        public override List<string> moves()
        {
            throw new NotImplementedException();
        }
        public override string toString()
        {
            throw new NotImplementedException();
        }
    }
}
