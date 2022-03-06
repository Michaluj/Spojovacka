using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzleGame
{
    public partial class fSpojovacka : Form
    {
        public fSpojovacka()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            bool AboveIsTaken = false;
            bool BelowIsTaken = false;
            bool LeftIsTaken = false;
            bool RightIsTaken = false;

            bool isTop = false;
            bool isBottom = false;
            bool isLeft = false;
            bool isRight = false;

            int posX = panel1.Location.X;
            int posY = panel1.Location.Y;

            if(panel1.Location.Y - 100 < 0)
            {
                isTop = true;
            }
            if(panel1.Location.Y + 100 >= 300)
            {
                isBottom = true;
            }
            if(panel1.Location.X - 200 < 0)
            {
                isLeft = true;
            }
            if(panel1.Location.X + 200 >= 600)
            {
                isRight = true;
            }

            if(panel1.Location.Y - 100 == panel3.Location.Y && panel1.Location.X == panel3.Location.X)
            {
                AboveIsTaken = true;
            }
            if(panel1.Location.Y + 100 == panel3.Location.Y && panel1.Location.X == panel3.Location.X)
            {
                BelowIsTaken = true;
            }
            if(panel1.Location.X - 200 == panel3.Location.X && panel1.Location.Y == panel3.Location.Y)
            {
                LeftIsTaken = true;
            }
            if(panel1.Location.X + 200 == panel3.Location.X && panel1.Location.Y == panel3.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel1.Location.Y - 100 == panel4.Location.Y && panel1.Location.X == panel4.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel1.Location.Y + 100 == panel4.Location.Y && panel1.Location.X == panel4.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel1.Location.X - 200 == panel4.Location.X && panel1.Location.Y == panel4.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel1.Location.X + 200 == panel4.Location.X && panel1.Location.Y == panel4.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel1.Location.Y - 100 == panel5.Location.Y && panel1.Location.X == panel5.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel1.Location.Y + 100 == panel5.Location.Y && panel1.Location.X == panel5.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel1.Location.X - 200 == panel5.Location.X && panel1.Location.Y == panel5.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel1.Location.X + 200 == panel5.Location.X && panel1.Location.Y == panel5.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel1.Location.Y - 100 == panel6.Location.Y && panel1.Location.X == panel6.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel1.Location.Y + 100 == panel6.Location.Y && panel1.Location.X == panel6.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel1.Location.X - 200 == panel6.Location.X && panel1.Location.Y == panel6.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel1.Location.X + 200 == panel6.Location.X && panel1.Location.Y == panel6.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel1.Location.Y - 100 == panel7.Location.Y && panel1.Location.X == panel7.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel1.Location.Y + 100 == panel7.Location.Y && panel1.Location.X == panel7.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel1.Location.X - 200 == panel7.Location.X && panel1.Location.Y == panel7.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel1.Location.X + 200 == panel7.Location.X && panel1.Location.Y == panel7.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel1.Location.Y - 100 == panel8.Location.Y && panel1.Location.X == panel8.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel1.Location.Y + 100 == panel8.Location.Y && panel1.Location.X == panel8.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel1.Location.X - 200 == panel8.Location.X && panel1.Location.Y == panel8.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel1.Location.X + 200 == panel8.Location.X && panel1.Location.Y == panel8.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel1.Location.Y - 100 == panel9.Location.Y && panel1.Location.X == panel9.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel1.Location.Y + 100 == panel9.Location.Y && panel1.Location.X == panel9.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel1.Location.X - 200 == panel9.Location.X && panel1.Location.Y == panel9.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel1.Location.X + 200 == panel9.Location.X && panel1.Location.Y == panel9.Location.Y)
            {
                RightIsTaken = true;
            }

            //MessageBox.Show(AboveIsTaken.ToString());
            //MessageBox.Show(BelowIsTaken.ToString());
            //MessageBox.Show(LeftIsTaken.ToString());
            //MessageBox.Show(RightIsTaken.ToString());
            //MessageBox.Show(isTop.ToString());
            //MessageBox.Show(isBottom.ToString());
            //MessageBox.Show(isLeft.ToString());
            //MessageBox.Show(isRight.ToString());

            if (!AboveIsTaken && !isTop)
            {
                panel1.Location = new Point(posX, posY - 100);
            }
            else if(!BelowIsTaken && !isBottom)
            {
                panel1.Location = new Point(posX, posY + 100);
            }
            else if(!LeftIsTaken && !isLeft)
            {
                panel1.Location = new Point(posX - 200, posY);
            }
            else if(!RightIsTaken && !isRight)
            {
                panel1.Location = new Point(posX + 200, posY);
            }
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            bool AboveIsTaken = false;
            bool BelowIsTaken = false;
            bool LeftIsTaken = false;
            bool RightIsTaken = false;

            bool isTop = false;
            bool isBottom = false;
            bool isLeft = false;
            bool isRight = false;

            int posX = panel6.Location.X;
            int posY = panel6.Location.Y;

            if(panel6.Location.Y - 100 < 0)
            {
                isTop = true;
            }
            if(panel6.Location.Y + 100 >= 300)
            {
                isBottom = true;
            }
            if(panel6.Location.X - 200 < 0)
            {
                isLeft = true;
            }
            if(panel6.Location.X + 200 >= 600)
            {
                isRight = true;
            }

            if (panel6.Location.Y - 100 == panel3.Location.Y && panel6.Location.X == panel3.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel6.Location.Y + 100 == panel3.Location.Y && panel6.Location.X == panel3.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel6.Location.X - 200 == panel3.Location.X && panel6.Location.Y == panel3.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel6.Location.X + 200 == panel3.Location.X && panel6.Location.Y == panel3.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel6.Location.Y - 100 == panel4.Location.Y && panel6.Location.X == panel4.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel6.Location.Y + 100 == panel4.Location.Y && panel6.Location.X == panel4.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel6.Location.X - 200 == panel4.Location.X && panel6.Location.Y == panel4.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel6.Location.X + 200 == panel4.Location.X && panel6.Location.Y == panel4.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel6.Location.Y - 100 == panel5.Location.Y && panel6.Location.X == panel5.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel6.Location.Y + 100 == panel5.Location.Y && panel6.Location.X == panel5.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel6.Location.X - 200 == panel5.Location.X && panel6.Location.Y == panel5.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel6.Location.X + 200 == panel5.Location.X && panel6.Location.Y == panel5.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel6.Location.Y - 100 == panel1.Location.Y && panel6.Location.X == panel1.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel6.Location.Y + 100 == panel1.Location.Y && panel6.Location.X == panel1.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel6.Location.X - 200 == panel1.Location.X && panel6.Location.Y == panel1.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel6.Location.X + 200 == panel1.Location.X && panel6.Location.Y == panel1.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel6.Location.Y - 100 == panel7.Location.Y && panel6.Location.X == panel7.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel6.Location.Y + 100 == panel7.Location.Y && panel6.Location.X == panel7.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel6.Location.X - 200 == panel7.Location.X && panel6.Location.Y == panel7.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel6.Location.X + 200 == panel7.Location.X && panel6.Location.Y == panel7.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel6.Location.Y - 100 == panel8.Location.Y && panel6.Location.X == panel8.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel6.Location.Y + 100 == panel8.Location.Y && panel6.Location.X == panel8.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel6.Location.X - 200 == panel8.Location.X && panel6.Location.Y == panel8.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel6.Location.X + 200 == panel8.Location.X && panel6.Location.Y == panel8.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel6.Location.Y - 100 == panel9.Location.Y && panel6.Location.X == panel9.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel6.Location.Y + 100 == panel9.Location.Y && panel6.Location.X == panel9.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel6.Location.X - 200 == panel9.Location.X && panel6.Location.Y == panel9.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel6.Location.X + 200 == panel9.Location.X && panel6.Location.Y == panel9.Location.Y)
            {
                RightIsTaken = true;
            }

            //MessageBox.Show(AboveIsTaken.ToString());
            //MessageBox.Show(BelowIsTaken.ToString());
            //MessageBox.Show(LeftIsTaken.ToString());
            //MessageBox.Show(RightIsTaken.ToString());
            //MessageBox.Show(isTop.ToString());
            //MessageBox.Show(isBottom.ToString());
            //MessageBox.Show(isLeft.ToString());
            //MessageBox.Show(isRight.ToString());

            if (!AboveIsTaken && !isTop)
            {
                panel6.Location = new Point(posX, posY - 100);
            }
            else if (!BelowIsTaken && !isBottom)
            {
                panel6.Location = new Point(posX, posY + 100);
            }
            else if (!LeftIsTaken && !isLeft)
            {
                panel6.Location = new Point(posX - 200, posY);
            }
            else if (!RightIsTaken && !isRight)
            {
                panel6.Location = new Point(posX + 200, posY);
            }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            bool AboveIsTaken = false;
            bool BelowIsTaken = false;
            bool LeftIsTaken = false;
            bool RightIsTaken = false;

            bool isTop = false;
            bool isBottom = false;
            bool isLeft = false;
            bool isRight = false;

            int posX = panel4.Location.X;
            int posY = panel4.Location.Y;

            if (panel4.Location.Y - 100 < 0)
            {
                isTop = true;
            }
            if (panel4.Location.Y + 100 >= 300)
            {
                isBottom = true;
            }
            if (panel4.Location.X - 200 < 0)
            {
                isLeft = true;
            }
            if (panel4.Location.X + 200 >= 600)
            {
                isRight = true;
            }

            if (panel4.Location.Y - 100 == panel3.Location.Y && panel4.Location.X == panel3.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel4.Location.Y + 100 == panel3.Location.Y && panel4.Location.X == panel3.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel4.Location.X - 200 == panel3.Location.X && panel4.Location.Y == panel3.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel4.Location.X + 200 == panel3.Location.X && panel4.Location.Y == panel3.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel4.Location.Y - 100 == panel1.Location.Y && panel4.Location.X == panel1.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel4.Location.Y + 100 == panel1.Location.Y && panel4.Location.X == panel1.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel4.Location.X - 200 == panel1.Location.X && panel4.Location.Y == panel1.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel4.Location.X + 200 == panel1.Location.X && panel4.Location.Y == panel1.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel4.Location.Y - 100 == panel5.Location.Y && panel4.Location.X == panel5.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel4.Location.Y + 100 == panel5.Location.Y && panel4.Location.X == panel5.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel4.Location.X - 200 == panel5.Location.X && panel4.Location.Y == panel5.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel4.Location.X + 200 == panel5.Location.X && panel4.Location.Y == panel5.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel4.Location.Y - 100 == panel6.Location.Y && panel4.Location.X == panel6.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel4.Location.Y + 100 == panel6.Location.Y && panel4.Location.X == panel6.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel4.Location.X - 200 == panel6.Location.X && panel4.Location.Y == panel6.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel4.Location.X + 200 == panel6.Location.X && panel4.Location.Y == panel6.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel4.Location.Y - 100 == panel7.Location.Y && panel4.Location.X == panel7.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel4.Location.Y + 100 == panel7.Location.Y && panel4.Location.X == panel7.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel4.Location.X - 200 == panel7.Location.X && panel4.Location.Y == panel7.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel4.Location.X + 200 == panel7.Location.X && panel4.Location.Y == panel7.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel4.Location.Y - 100 == panel8.Location.Y && panel4.Location.X == panel8.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel4.Location.Y + 100 == panel8.Location.Y && panel4.Location.X == panel8.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel4.Location.X - 200 == panel8.Location.X && panel4.Location.Y == panel8.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel4.Location.X + 200 == panel8.Location.X && panel4.Location.Y == panel8.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel4.Location.Y - 100 == panel9.Location.Y && panel4.Location.X == panel9.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel4.Location.Y + 100 == panel9.Location.Y && panel4.Location.X == panel9.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel4.Location.X - 200 == panel9.Location.X && panel4.Location.Y == panel9.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel4.Location.X + 200 == panel9.Location.X && panel4.Location.Y == panel9.Location.Y)
            {
                RightIsTaken = true;
            }

            //MessageBox.Show(AboveIsTaken.ToString());
            //MessageBox.Show(BelowIsTaken.ToString());
            //MessageBox.Show(LeftIsTaken.ToString());
            //MessageBox.Show(RightIsTaken.ToString());
            //MessageBox.Show(isTop.ToString());
            //MessageBox.Show(isBottom.ToString());
            //MessageBox.Show(isLeft.ToString());
            //MessageBox.Show(isRight.ToString());

            if (!AboveIsTaken && !isTop)
            {
                panel4.Location = new Point(posX, posY - 100);
            }
            else if (!BelowIsTaken && !isBottom)
            {
                panel4.Location = new Point(posX, posY + 100);
            }
            else if (!LeftIsTaken && !isLeft)
            {
                panel4.Location = new Point(posX - 200, posY);
            }
            else if (!RightIsTaken && !isRight)
            {
                panel4.Location = new Point(posX + 200, posY);
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            bool AboveIsTaken = false;
            bool BelowIsTaken = false;
            bool LeftIsTaken = false;
            bool RightIsTaken = false;

            bool isTop = false;
            bool isBottom = false;
            bool isLeft = false;
            bool isRight = false;

            int posX = panel3.Location.X;
            int posY = panel3.Location.Y;

            if (panel3.Location.Y - 100 < 0)
            {
                isTop = true;
            }
            if (panel3.Location.Y + 100 >= 300)
            {
                isBottom = true;
            }
            if (panel3.Location.X - 200 < 0)
            {
                isLeft = true;
            }
            if (panel3.Location.X + 200 >= 600)
            {
                isRight = true;
            }

            if (panel3.Location.Y - 100 == panel1.Location.Y && panel3.Location.X == panel1.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel3.Location.Y + 100 == panel1.Location.Y && panel3.Location.X == panel1.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel3.Location.X - 200 == panel1.Location.X && panel3.Location.Y == panel1.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel3.Location.X + 200 == panel1.Location.X && panel3.Location.Y == panel1.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel3.Location.Y - 100 == panel4.Location.Y && panel3.Location.X == panel4.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel3.Location.Y + 100 == panel4.Location.Y && panel3.Location.X == panel4.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel3.Location.X - 200 == panel4.Location.X && panel3.Location.Y == panel4.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel3.Location.X + 200 == panel4.Location.X && panel3.Location.Y == panel4.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel3.Location.Y - 100 == panel5.Location.Y && panel3.Location.X == panel5.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel3.Location.Y + 100 == panel5.Location.Y && panel3.Location.X == panel5.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel3.Location.X - 200 == panel5.Location.X && panel3.Location.Y == panel5.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel3.Location.X + 200 == panel5.Location.X && panel3.Location.Y == panel5.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel3.Location.Y - 100 == panel6.Location.Y && panel3.Location.X == panel6.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel3.Location.Y + 100 == panel6.Location.Y && panel3.Location.X == panel6.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel3.Location.X - 200 == panel6.Location.X && panel3.Location.Y == panel6.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel3.Location.X + 200 == panel6.Location.X && panel3.Location.Y == panel6.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel3.Location.Y - 100 == panel7.Location.Y && panel3.Location.X == panel7.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel3.Location.Y + 100 == panel7.Location.Y && panel3.Location.X == panel7.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel3.Location.X - 200 == panel7.Location.X && panel3.Location.Y == panel7.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel3.Location.X + 200 == panel7.Location.X && panel3.Location.Y == panel7.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel3.Location.Y - 100 == panel8.Location.Y && panel3.Location.X == panel8.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel3.Location.Y + 100 == panel8.Location.Y && panel3.Location.X == panel8.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel3.Location.X - 200 == panel8.Location.X && panel3.Location.Y == panel8.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel3.Location.X + 200 == panel8.Location.X && panel3.Location.Y == panel8.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel3.Location.Y - 100 == panel9.Location.Y && panel3.Location.X == panel9.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel3.Location.Y + 100 == panel9.Location.Y && panel3.Location.X == panel9.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel3.Location.X - 200 == panel9.Location.X && panel3.Location.Y == panel9.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel3.Location.X + 200 == panel9.Location.X && panel3.Location.Y == panel9.Location.Y)
            {
                RightIsTaken = true;
            }

            //MessageBox.Show(AboveIsTaken.ToString());
            //MessageBox.Show(BelowIsTaken.ToString());
            //MessageBox.Show(LeftIsTaken.ToString());
            //MessageBox.Show(RightIsTaken.ToString());
            //MessageBox.Show(isTop.ToString());
            //MessageBox.Show(isBottom.ToString());
            //MessageBox.Show(isLeft.ToString());
            //MessageBox.Show(isRight.ToString());

            if (!AboveIsTaken && !isTop)
            {
                panel3.Location = new Point(posX, posY - 100);
            }
            else if (!BelowIsTaken && !isBottom)
            {
                panel3.Location = new Point(posX, posY + 100);
            }
            else if (!LeftIsTaken && !isLeft)
            {
                panel3.Location = new Point(posX - 200, posY);
            }
            else if (!RightIsTaken && !isRight)
            {
                panel3.Location = new Point(posX + 200, posY);
            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            bool AboveIsTaken = false;
            bool BelowIsTaken = false;
            bool LeftIsTaken = false;
            bool RightIsTaken = false;

            bool isTop = false;
            bool isBottom = false;
            bool isLeft = false;
            bool isRight = false;

            int posX = panel5.Location.X;
            int posY = panel5.Location.Y;

            if (panel5.Location.Y - 100 < 0)
            {
                isTop = true;
            }
            if (panel5.Location.Y + 100 >= 300)
            {
                isBottom = true;
            }
            if (panel5.Location.X - 200 < 0)
            {
                isLeft = true;
            }
            if (panel5.Location.X + 200 >= 600)
            {
                isRight = true;
            }

            if (panel5.Location.Y - 100 == panel1.Location.Y && panel5.Location.X == panel1.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel5.Location.Y + 100 == panel1.Location.Y && panel5.Location.X == panel1.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel5.Location.X - 200 == panel1.Location.X && panel5.Location.Y == panel1.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel5.Location.X + 200 == panel1.Location.X && panel5.Location.Y == panel1.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel5.Location.Y - 100 == panel4.Location.Y && panel5.Location.X == panel4.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel5.Location.Y + 100 == panel4.Location.Y && panel5.Location.X == panel4.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel5.Location.X - 200 == panel4.Location.X && panel5.Location.Y == panel4.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel5.Location.X + 200 == panel4.Location.X && panel5.Location.Y == panel4.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel5.Location.Y - 100 == panel3.Location.Y && panel5.Location.X == panel3.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel5.Location.Y + 100 == panel3.Location.Y && panel5.Location.X == panel3.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel5.Location.X - 200 == panel3.Location.X && panel5.Location.Y == panel3.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel5.Location.X + 200 == panel3.Location.X && panel5.Location.Y == panel3.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel5.Location.Y - 100 == panel6.Location.Y && panel5.Location.X == panel6.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel5.Location.Y + 100 == panel6.Location.Y && panel5.Location.X == panel6.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel5.Location.X - 200 == panel6.Location.X && panel5.Location.Y == panel6.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel5.Location.X + 200 == panel6.Location.X && panel5.Location.Y == panel6.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel5.Location.Y - 100 == panel7.Location.Y && panel5.Location.X == panel7.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel5.Location.Y + 100 == panel7.Location.Y && panel5.Location.X == panel7.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel5.Location.X - 200 == panel7.Location.X && panel5.Location.Y == panel7.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel5.Location.X + 200 == panel7.Location.X && panel5.Location.Y == panel7.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel5.Location.Y - 100 == panel8.Location.Y && panel5.Location.X == panel8.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel5.Location.Y + 100 == panel8.Location.Y && panel5.Location.X == panel8.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel5.Location.X - 200 == panel8.Location.X && panel5.Location.Y == panel8.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel5.Location.X + 200 == panel8.Location.X && panel5.Location.Y == panel8.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel5.Location.Y - 100 == panel9.Location.Y && panel5.Location.X == panel9.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel5.Location.Y + 100 == panel9.Location.Y && panel5.Location.X == panel9.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel5.Location.X - 200 == panel9.Location.X && panel5.Location.Y == panel9.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel5.Location.X + 200 == panel9.Location.X && panel5.Location.Y == panel9.Location.Y)
            {
                RightIsTaken = true;
            }

            //MessageBox.Show(AboveIsTaken.ToString());
            //MessageBox.Show(BelowIsTaken.ToString());
            //MessageBox.Show(LeftIsTaken.ToString());
            //MessageBox.Show(RightIsTaken.ToString());
            //MessageBox.Show(isTop.ToString());
            //MessageBox.Show(isBottom.ToString());
            //MessageBox.Show(isLeft.ToString());
            //MessageBox.Show(isRight.ToString());

            if (!AboveIsTaken && !isTop)
            {
                panel5.Location = new Point(posX, posY - 100);
            }
            else if (!BelowIsTaken && !isBottom)
            {
                panel5.Location = new Point(posX, posY + 100);
            }
            else if (!LeftIsTaken && !isLeft)
            {
                panel5.Location = new Point(posX - 200, posY);
            }
            else if (!RightIsTaken && !isRight)
            {
                panel5.Location = new Point(posX + 200, posY);
            }
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            bool AboveIsTaken = false;
            bool BelowIsTaken = false;
            bool LeftIsTaken = false;
            bool RightIsTaken = false;

            bool isTop = false;
            bool isBottom = false;
            bool isLeft = false;
            bool isRight = false;

            int posX = panel7.Location.X;
            int posY = panel7.Location.Y;

            if (panel7.Location.Y - 100 < 0)
            {
                isTop = true;
            }
            if (panel7.Location.Y + 100 >= 300)
            {
                isBottom = true;
            }
            if (panel7.Location.X - 200 < 0)
            {
                isLeft = true;
            }
            if (panel7.Location.X + 200 >= 600)
            {
                isRight = true;
            }

            if (panel7.Location.Y - 100 == panel1.Location.Y && panel7.Location.X == panel1.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel7.Location.Y + 100 == panel1.Location.Y && panel7.Location.X == panel1.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel7.Location.X - 200 == panel1.Location.X && panel7.Location.Y == panel1.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel7.Location.X + 200 == panel1.Location.X && panel7.Location.Y == panel1.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel7.Location.Y - 100 == panel4.Location.Y && panel7.Location.X == panel4.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel7.Location.Y + 100 == panel4.Location.Y && panel7.Location.X == panel4.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel7.Location.X - 200 == panel4.Location.X && panel7.Location.Y == panel4.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel7.Location.X + 200 == panel4.Location.X && panel7.Location.Y == panel4.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel7.Location.Y - 100 == panel3.Location.Y && panel7.Location.X == panel3.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel7.Location.Y + 100 == panel3.Location.Y && panel7.Location.X == panel3.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel7.Location.X - 200 == panel3.Location.X && panel7.Location.Y == panel3.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel7.Location.X + 200 == panel3.Location.X && panel7.Location.Y == panel3.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel7.Location.Y - 100 == panel6.Location.Y && panel7.Location.X == panel6.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel7.Location.Y + 100 == panel6.Location.Y && panel7.Location.X == panel6.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel7.Location.X - 200 == panel6.Location.X && panel7.Location.Y == panel6.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel7.Location.X + 200 == panel6.Location.X && panel7.Location.Y == panel6.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel7.Location.Y - 100 == panel5.Location.Y && panel7.Location.X == panel5.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel7.Location.Y + 100 == panel5.Location.Y && panel7.Location.X == panel5.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel7.Location.X - 200 == panel5.Location.X && panel7.Location.Y == panel5.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel7.Location.X + 200 == panel5.Location.X && panel7.Location.Y == panel5.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel7.Location.Y - 100 == panel8.Location.Y && panel7.Location.X == panel8.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel7.Location.Y + 100 == panel8.Location.Y && panel7.Location.X == panel8.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel7.Location.X - 200 == panel8.Location.X && panel7.Location.Y == panel8.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel7.Location.X + 200 == panel8.Location.X && panel7.Location.Y == panel8.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel7.Location.Y - 100 == panel9.Location.Y && panel7.Location.X == panel9.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel7.Location.Y + 100 == panel9.Location.Y && panel7.Location.X == panel9.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel7.Location.X - 200 == panel9.Location.X && panel7.Location.Y == panel9.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel7.Location.X + 200 == panel9.Location.X && panel7.Location.Y == panel9.Location.Y)
            {
                RightIsTaken = true;
            }

            //MessageBox.Show(AboveIsTaken.ToString());
            //MessageBox.Show(BelowIsTaken.ToString());
            //MessageBox.Show(LeftIsTaken.ToString());
            //MessageBox.Show(RightIsTaken.ToString());
            //MessageBox.Show(isTop.ToString());
            //MessageBox.Show(isBottom.ToString());
            //MessageBox.Show(isLeft.ToString());
            //MessageBox.Show(isRight.ToString());

            if (!AboveIsTaken && !isTop)
            {
                panel7.Location = new Point(posX, posY - 100);
            }
            else if (!BelowIsTaken && !isBottom)
            {
                panel7.Location = new Point(posX, posY + 100);
            }
            else if (!LeftIsTaken && !isLeft)
            {
                panel7.Location = new Point(posX - 200, posY);
            }
            else if (!RightIsTaken && !isRight)
            {
                panel7.Location = new Point(posX + 200, posY);
            }
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            bool AboveIsTaken = false;
            bool BelowIsTaken = false;
            bool LeftIsTaken = false;
            bool RightIsTaken = false;

            bool isTop = false;
            bool isBottom = false;
            bool isLeft = false;
            bool isRight = false;

            int posX = panel9.Location.X;
            int posY = panel9.Location.Y;

            if (panel9.Location.Y - 100 < 0)
            {
                isTop = true;
            }
            if (panel9.Location.Y + 100 >= 300)
            {
                isBottom = true;
            }
            if (panel9.Location.X - 200 < 0)
            {
                isLeft = true;
            }
            if (panel9.Location.X + 200 >= 600)
            {
                isRight = true;
            }

            if (panel9.Location.Y - 100 == panel1.Location.Y && panel9.Location.X == panel1.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel9.Location.Y + 100 == panel1.Location.Y && panel9.Location.X == panel1.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel9.Location.X - 200 == panel1.Location.X && panel9.Location.Y == panel1.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel9.Location.X + 200 == panel1.Location.X && panel9.Location.Y == panel1.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel9.Location.Y - 100 == panel4.Location.Y && panel9.Location.X == panel4.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel9.Location.Y + 100 == panel4.Location.Y && panel9.Location.X == panel4.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel9.Location.X - 200 == panel4.Location.X && panel9.Location.Y == panel4.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel9.Location.X + 200 == panel4.Location.X && panel9.Location.Y == panel4.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel9.Location.Y - 100 == panel3.Location.Y && panel9.Location.X == panel3.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel9.Location.Y + 100 == panel3.Location.Y && panel9.Location.X == panel3.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel9.Location.X - 200 == panel3.Location.X && panel9.Location.Y == panel3.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel9.Location.X + 200 == panel3.Location.X && panel9.Location.Y == panel3.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel9.Location.Y - 100 == panel6.Location.Y && panel9.Location.X == panel6.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel9.Location.Y + 100 == panel6.Location.Y && panel9.Location.X == panel6.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel9.Location.X - 200 == panel6.Location.X && panel9.Location.Y == panel6.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel9.Location.X + 200 == panel6.Location.X && panel9.Location.Y == panel6.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel9.Location.Y - 100 == panel5.Location.Y && panel9.Location.X == panel5.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel9.Location.Y + 100 == panel5.Location.Y && panel9.Location.X == panel5.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel9.Location.X - 200 == panel5.Location.X && panel9.Location.Y == panel5.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel9.Location.X + 200 == panel5.Location.X && panel9.Location.Y == panel5.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel9.Location.Y - 100 == panel8.Location.Y && panel9.Location.X == panel8.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel9.Location.Y + 100 == panel8.Location.Y && panel9.Location.X == panel8.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel9.Location.X - 200 == panel8.Location.X && panel9.Location.Y == panel8.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel9.Location.X + 200 == panel8.Location.X && panel9.Location.Y == panel8.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel9.Location.Y - 100 == panel7.Location.Y && panel9.Location.X == panel7.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel9.Location.Y + 100 == panel7.Location.Y && panel9.Location.X == panel7.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel9.Location.X - 200 == panel7.Location.X && panel9.Location.Y == panel7.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel9.Location.X + 200 == panel7.Location.X && panel9.Location.Y == panel7.Location.Y)
            {
                RightIsTaken = true;
            }

            //MessageBox.Show(AboveIsTaken.ToString());
            //MessageBox.Show(BelowIsTaken.ToString());
            //MessageBox.Show(LeftIsTaken.ToString());
            //MessageBox.Show(RightIsTaken.ToString());
            //MessageBox.Show(isTop.ToString());
            //MessageBox.Show(isBottom.ToString());
            //MessageBox.Show(isLeft.ToString());
            //MessageBox.Show(isRight.ToString());

            if (!AboveIsTaken && !isTop)
            {
                panel9.Location = new Point(posX, posY - 100);
            }
            else if (!BelowIsTaken && !isBottom)
            {
                panel9.Location = new Point(posX, posY + 100);
            }
            else if (!LeftIsTaken && !isLeft)
            {
                panel9.Location = new Point(posX - 200, posY);
            }
            else if (!RightIsTaken && !isRight)
            {
                panel9.Location = new Point(posX + 200, posY);
            }
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            bool AboveIsTaken = false;
            bool BelowIsTaken = false;
            bool LeftIsTaken = false;
            bool RightIsTaken = false;

            bool isTop = false;
            bool isBottom = false;
            bool isLeft = false;
            bool isRight = false;

            int posX = panel8.Location.X;
            int posY = panel8.Location.Y;

            if (panel8.Location.Y - 100 < 0)
            {
                isTop = true;
            }
            if (panel8.Location.Y + 100 >= 300)
            {
                isBottom = true;
            }
            if (panel8.Location.X - 200 < 0)
            {
                isLeft = true;
            }
            if (panel8.Location.X + 200 >= 600)
            {
                isRight = true;
            }

            if (panel8.Location.Y - 100 == panel1.Location.Y && panel8.Location.X == panel1.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel8.Location.Y + 100 == panel1.Location.Y && panel8.Location.X == panel1.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel8.Location.X - 200 == panel1.Location.X && panel8.Location.Y == panel1.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel8.Location.X + 200 == panel1.Location.X && panel8.Location.Y == panel1.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel8.Location.Y - 100 == panel4.Location.Y && panel8.Location.X == panel4.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel8.Location.Y + 100 == panel4.Location.Y && panel8.Location.X == panel4.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel8.Location.X - 200 == panel4.Location.X && panel8.Location.Y == panel4.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel8.Location.X + 200 == panel4.Location.X && panel8.Location.Y == panel4.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel8.Location.Y - 100 == panel3.Location.Y && panel8.Location.X == panel3.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel8.Location.Y + 100 == panel3.Location.Y && panel8.Location.X == panel3.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel8.Location.X - 200 == panel3.Location.X && panel8.Location.Y == panel3.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel8.Location.X + 200 == panel3.Location.X && panel8.Location.Y == panel3.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel8.Location.Y - 100 == panel6.Location.Y && panel8.Location.X == panel6.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel8.Location.Y + 100 == panel6.Location.Y && panel8.Location.X == panel6.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel8.Location.X - 200 == panel6.Location.X && panel8.Location.Y == panel6.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel8.Location.X + 200 == panel6.Location.X && panel8.Location.Y == panel6.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel8.Location.Y - 100 == panel5.Location.Y && panel8.Location.X == panel5.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel8.Location.Y + 100 == panel5.Location.Y && panel8.Location.X == panel5.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel8.Location.X - 200 == panel5.Location.X && panel8.Location.Y == panel5.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel8.Location.X + 200 == panel5.Location.X && panel8.Location.Y == panel5.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel8.Location.Y - 100 == panel9.Location.Y && panel8.Location.X == panel9.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel8.Location.Y + 100 == panel9.Location.Y && panel8.Location.X == panel9.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel8.Location.X - 200 == panel9.Location.X && panel8.Location.Y == panel9.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel8.Location.X + 200 == panel9.Location.X && panel8.Location.Y == panel9.Location.Y)
            {
                RightIsTaken = true;
            }

            if (panel8.Location.Y - 100 == panel7.Location.Y && panel8.Location.X == panel7.Location.X)
            {
                AboveIsTaken = true;
            }
            if (panel8.Location.Y + 100 == panel7.Location.Y && panel8.Location.X == panel7.Location.X)
            {
                BelowIsTaken = true;
            }
            if (panel8.Location.X - 200 == panel7.Location.X && panel8.Location.Y == panel7.Location.Y)
            {
                LeftIsTaken = true;
            }
            if (panel8.Location.X + 200 == panel7.Location.X && panel8.Location.Y == panel7.Location.Y)
            {
                RightIsTaken = true;
            }

            //MessageBox.Show(AboveIsTaken.ToString());
            //MessageBox.Show(BelowIsTaken.ToString());
            //MessageBox.Show(LeftIsTaken.ToString());
            //MessageBox.Show(RightIsTaken.ToString());
            //MessageBox.Show(isTop.ToString());
            //MessageBox.Show(isBottom.ToString());
            //MessageBox.Show(isLeft.ToString());
            //MessageBox.Show(isRight.ToString());

            if (!AboveIsTaken && !isTop)
            {
                panel8.Location = new Point(posX, posY - 100);
            }
            else if (!BelowIsTaken && !isBottom)
            {
                panel8.Location = new Point(posX, posY + 100);
            }
            else if (!LeftIsTaken && !isLeft)
            {
                panel8.Location = new Point(posX - 200, posY);
            }
            else if (!RightIsTaken && !isRight)
            {
                panel8.Location = new Point(posX + 200, posY);
            }
        }

        private void nováHraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void ukončitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
