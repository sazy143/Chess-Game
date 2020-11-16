using Game_App.GameBoards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_App
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            drawGame();
        }

        public void drawGame()
        {
            IGameBoard board;
            board = new ChessBoard();
            Panel p = board.Draw();
            this.Controls.Add(p);
            
        }
        private void Game_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = this.CreateGraphics();
            //IGameBoard board;
            //board = new ChessBoard();
            //board.Draw();
        }

        private void Game_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.PointToClient(MousePosition).X.ToString() + " " + this.PointToClient(MousePosition).Y.ToString());
        }
    }
}
