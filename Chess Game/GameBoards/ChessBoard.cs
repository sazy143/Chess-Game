using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_App.GamePieces.ChessPieces;

namespace Game_App.GameBoards
{
    class ChessBoard : IGameBoard
    {
        int placesX = 8;
        int placesY = 8;
        int squareSize = Properties.Settings.Default.SquareSize;
        Panel panel;
        List<ChessPiece> Board = new List<ChessPiece>();
        public ChessBoard()
        {
            panel = new Panel();
            panel.Size = new System.Drawing.Size(480, 480);
            panel.BackColor = Color.Aqua;
            panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_paint);
            setUpBoard();
            drawPieces(Board);
        }

        public Panel Draw()
        {
            return panel;
        }

        public void setUpBoard()
        {
            /*set original piece positions (N = Knight)
            R-N-B-Q-K-B-N-R
            P-P-P-P-P-P-P-P
            *-*-*-*-*-*-*-*
            *-*-*-*-*-*-*-*
            Flipped

            X and Y positions from 0 - 7
            */
            

            //black pawns
            for(int i = 0; i < placesX; i++)
            {
                Board.Add(new Pawn()
                {
                    X = i,
                    Y = 1,
                    color = "black"
                });
            }
            //black rooks
            Board.Add(new Rook()
            {
                X = 0,
                Y = 0,
                color = "black"
            });
            Board.Add(new Rook()
            {
                X = 7,
                Y = 0,
                color = "black"
            });
            //black knights
            Board.Add(new Knight()
            {
                X = 1,
                Y = 0,
                color = "black"
            });
            Board.Add(new Knight()
            {
                X = 6,
                Y = 0,
                color = "black"
            });
            //black bishops
            Board.Add(new Bishop()
            {
                X = 2,
                Y = 0,
                color = "black"
            });
            Board.Add(new Bishop()
            {
                X = 5,
                Y = 0,
                color = "black"
            });
            //black queen
            Board.Add(new Queen()
            {
                X = 3,
                Y = 0,
                color = "black"
            });
            //black king
            Board.Add(new King()
            {
                X = 4,
                Y = 0,
                color = "black"
            });


            //white pawns
            for (int i = 0; i < placesX; i++)
            {
                Board.Add(new Pawn()
                {
                    X = i,
                    Y = 6,
                    color = "white"
                });
            }
            //white rooks
            Board.Add(new Rook()
            {
                X = 0,
                Y = 7,
                color = "white"
            });
            Board.Add(new Rook()
            {
                X = 7,
                Y = 7,
                color = "white"
            });
            //white knights
            Board.Add(new Knight()
            {
                X = 1,
                Y = 7,
                color = "white"
            });
            Board.Add(new Knight()
            {
                X = 6,
                Y = 7,
                color = "white"
            });
            //white bishops
            Board.Add(new Bishop()
            {
                X = 2,
                Y = 7,
                color = "white"
            });
            Board.Add(new Bishop()
            {
                X = 5,
                Y = 7,
                color = "white"
            });
            //white queen
            Board.Add(new Queen()
            {
                X = 3,
                Y = 7,
                color = "white"
            });
            //white king
            Board.Add(new King()
            {
                X = 4,
                Y = 7,
                color = "white"
            });

        }

        private void drawPieces(List<ChessPiece> pieces)
        {
            foreach(ChessPiece piece in pieces)
            {
                panel.Controls.Add(piece.draw());
            }
        }

        public void toString()
        {
            string boardString = "";
            int counter = 0;
            foreach(ChessPiece piece in Board)
            {
                if (counter % 8 == 0)
                    boardString += "\n";
                boardString += piece.ToString();
            }
        }

        private void panel_paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel.CreateGraphics();
            //Define brushes and pens
            Pen blackPen = new Pen(Color.Black);
            SolidBrush brownBrush = new SolidBrush(Color.Brown);

            //Draw all the Squares
            for (int i = 0; i < placesX; i++)
            {
                for (int j = 0; j < placesY; j++)
                {
                    if ((i + j) % 2 == 1)
                    {
                        g.FillRectangle(brownBrush, (i * squareSize) , (j * squareSize) , squareSize, squareSize);
                    }
                }
            }

            //Draw boarder around board (Draw second so lines are on top)
            g.DrawRectangle(blackPen, 0, 0, squareSize * placesX, squareSize * placesY);
        }
    }
}
