using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;

        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }
        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }








        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 15;

            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //draw horizental line
            e.Graphics.DrawLine(whitePen, 550, 150, 550, 550);
            e.Graphics.DrawLine(whitePen, 720, 150, 720, 550);

            //draw vertical line
            e.Graphics.DrawLine(whitePen, 410, 275, 860, 275);
            e.Graphics.DrawLine(whitePen, 410, 425, 860, 425);


        }


        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }

            return false;


        }

        public void EndGame()
        {
            lblTurn.Text = "Game Over";

            switch (GameStatus.Winner)

            {
                case enWinner.Player1:

                    lblWinner.Text = "Player 1";
                    break;

                case enWinner.Player2:

                    lblWinner.Text = "Player 2";
                    break;

                default:
                        
                    lblWinner.Text = "Draw";
                    break;

            }

            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void CheckWinner()
        {
            //check rows
            //check row 1
            if (CheckValues(button1, button2, button3))
                return;

            //check row 2
            if (CheckValues(button4, button5, button6))
                return;

            //check row 3
            if (CheckValues(button7, button8, button9))
                return;

            //check columns
            //check column 1
            if (CheckValues(button1, button4, button7))
                return;

            //check column 2
            if (CheckValues(button2, button5, button8))
                return;

            //check column 3
            if (CheckValues(button3, button6, button9))
                return;

            //check diagonals
            //check diagonal 1
            if (CheckValues(button1, button5, button9))
                return;

            //check diagonal 2
            if (CheckValues(button3, button5, button7))
                return;

        }


        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button) sender);
        }
        

        public void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Properties.Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        lblTurn.Text = "Player 2";
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;
                    case enPlayer.Player2:
                        btn.Image = Properties.Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lblTurn.Text = "Player 1";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;
                }
            }
            else

            {
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }

        public void RestButton(Button btn)
        {
            btn.Image = Properties.Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
        }

        public void RestartGame()
        {
            RestButton(button1);
            RestButton(button2);
            RestButton(button3);
            RestButton(button4);
            RestButton(button5);
            RestButton(button6);
            RestButton(button7);
            RestButton(button8);
            RestButton(button9);

            PlayerTurn = enPlayer.Player1;
            lblTurn.Text = "Player 1";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
            lblWinner.Text = "In Progress";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
