using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minimax_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] status = new int[9];
        int max_depth = 5;
        int optimal = -1;
        int button1_situation = 0;
        int button2_situation = 0;
        int button3_situation = 0;
        int button4_situation = 0;
        int button5_situation = 0;
        int button6_situation = 0;
        int button7_situation = 0;
        int button8_situation = 0;
        int button9_situation = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(button1_situation==0)
            {
                button1.Image = imageList1.Images[1];
                status[0] = 1;
                button1_situation = 1;
            }
            else
            {
                MessageBox.Show("Wrong Input!");
            }
            if(lose())
            {
                MessageBox.Show("You Win!");
            }
            minimax();
            switch (optimal)
            {
                case 0:
                    button1.Image = imageList1.Images[2];
                    status[0] = 2;
                    break;
                case 1:
                    button2.Image = imageList1.Images[2];
                    status[1] = 2;
                    break;
                case 2:
                    button3.Image = imageList1.Images[2];
                    status[2] = 2;
                    break;
                case 3:
                    button4.Image = imageList1.Images[2];
                    status[3] = 2;
                    break;
                case 4:
                    button5.Image = imageList1.Images[2];
                    status[4] = 2;
                    break;
                case 5:
                    button6.Image = imageList1.Images[2];
                    status[5] = 2;
                    break;
                case 6:
                    button7.Image = imageList1.Images[2];
                    status[6] = 2;
                    break;
                case 7:
                    button8.Image = imageList1.Images[2];
                    status[7] = 2;
                    break;
                case 8:
                    button9.Image = imageList1.Images[2];
                    status[8] = 2;
                    break;
            }
            if(win())
            {
                MessageBox.Show("You Lose!");
            }
            else
            {
                int num = 0;
                for(int i =0;i<=8;i++)
                {
                    if(status[i]==0)
                    {
                        num++;
                    }
                }
                if(num==0)
                {
                    MessageBox.Show("Deadlock");
                }
            }
            //judge();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2_situation == 0)
            {
                button2.Image = imageList1.Images[1];
                status[1] = 1;
                button2_situation = 1;
            }
            else
            {
                MessageBox.Show("wrong input!");
            }
            if (lose())
            {
                MessageBox.Show("You Win!");
            }
            //judge();
            minimax();
            switch (optimal)
            {
                case 0:
                    button1.Image = imageList1.Images[2];
                    status[0] = 2;
                    break;
                case 1:
                    button2.Image = imageList1.Images[2];
                    status[1] = 2;
                    break;
                case 2:
                    button3.Image = imageList1.Images[2];
                    status[2] = 2;
                    break;
                case 3:
                    button4.Image = imageList1.Images[2];
                    status[3] = 2;
                    break;
                case 4:
                    button5.Image = imageList1.Images[2];
                    status[4] = 2;
                    break;
                case 5:
                    button6.Image = imageList1.Images[2];
                    status[5] = 2;
                    break;
                case 6:
                    button7.Image = imageList1.Images[2];
                    status[6] = 2;
                    break;
                case 7:
                    button8.Image = imageList1.Images[2];
                    status[7] = 2;
                    break;
                case 8:
                    button9.Image = imageList1.Images[2];
                    status[8] = 2;
                    break;
            }
            if (win())
            {
                MessageBox.Show("You Lose!");
            }
            else
            {
                int num = 0;
                for (int i = 0; i <= 8; i++)
                {
                    if (status[i] == 0)
                    {
                        num++;
                    }
                }
                if (num == 0)
                {
                    MessageBox.Show("Deadlock");
                }
            }
            //judge();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (button3_situation == 0)
            {
                button3.Image = imageList1.Images[1];
                status[2] = 1;
                button3_situation = 1;
            }
            else
            {
                MessageBox.Show("wrong input!");
            }
            if (lose())
            {
                MessageBox.Show("You Win!");
            }
            //judge();
            minimax();
            switch (optimal)
            {
                case 0:
                    button1.Image = imageList1.Images[2];
                    status[0] = 2;
                    break;
                case 1:
                    button2.Image = imageList1.Images[2];
                    status[1] = 2;
                    break;
                case 2:
                    button3.Image = imageList1.Images[2];
                    status[2] = 2;
                    break;
                case 3:
                    button4.Image = imageList1.Images[2];
                    status[3] = 2;
                    break;
                case 4:
                    button5.Image = imageList1.Images[2];
                    status[4] = 2;
                    break;
                case 5:
                    button6.Image = imageList1.Images[2];
                    status[5] = 2;
                    break;
                case 6:
                    button7.Image = imageList1.Images[2];
                    status[6] = 2;
                    break;
                case 7:
                    button8.Image = imageList1.Images[2];
                    status[7] = 2;
                    break;
                case 8:
                    button9.Image = imageList1.Images[2];
                    status[8] = 2;
                    break;
            }
            if (win())
            {
                MessageBox.Show("You Lose!");
            }
            else
            {
                int num = 0;
                for (int i = 0; i <= 8; i++)
                {
                    if (status[i] == 0)
                    {
                        num++;
                    }
                }
                if (num == 0)
                {
                    MessageBox.Show("Deadlock");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4_situation == 0)
            {
                button4.Image = imageList1.Images[1];
                status[3] = 1;
                button4_situation = 1;
            }
            else
            {
                MessageBox.Show("wrong input!");
            }
            if (lose())
            {
                MessageBox.Show("You Win!");
            }
            //judge();
            minimax();
            switch (optimal)
            {
                case 0:
                    button1.Image = imageList1.Images[2];
                    status[0] = 2;
                    break;
                case 1:
                    button2.Image = imageList1.Images[2];
                    status[1] = 2;
                    break;
                case 2:
                    button3.Image = imageList1.Images[2];
                    status[2] = 2;
                    break;
                case 3:
                    button4.Image = imageList1.Images[2];
                    status[3] = 2;
                    break;
                case 4:
                    button5.Image = imageList1.Images[2];
                    status[4] = 2;
                    break;
                case 5:
                    button6.Image = imageList1.Images[2];
                    status[5] = 2;
                    break;
                case 6:
                    button7.Image = imageList1.Images[2];
                    status[6] = 2;
                    break;
                case 7:
                    button8.Image = imageList1.Images[2];
                    status[7] = 2;
                    break;
                case 8:
                    button9.Image = imageList1.Images[2];
                    status[8] = 2;
                    break;
            }
            if (win())
            {
                MessageBox.Show("You Lose!");
            }
            else
            {
                int num = 0;
                for (int i = 0; i <= 8; i++)
                {
                    if (status[i] == 0)
                    {
                        num++;
                    }
                }
                if (num == 0)
                {
                    MessageBox.Show("Deadlock");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5_situation == 0)
            {
                button5.Image = imageList1.Images[1];
                status[4] = 1;
                button5_situation = 1;
            }
            else
            {
                MessageBox.Show("wrong input!");
            }
            if (lose())
            {
                MessageBox.Show("You Win!");
            }
            //judge();
            minimax();
            switch (optimal)
            {
                case 0:
                    button1.Image = imageList1.Images[2];
                    status[0] = 2;
                    break;
                case 1:
                    button2.Image = imageList1.Images[2];
                    status[1] = 2;
                    break;
                case 2:
                    button3.Image = imageList1.Images[2];
                    status[2] = 2;
                    break;
                case 3:
                    button4.Image = imageList1.Images[2];
                    status[3] = 2;
                    break;
                case 4:
                    button5.Image = imageList1.Images[2];
                    status[4] = 2;
                    break;
                case 5:
                    button6.Image = imageList1.Images[2];
                    status[5] = 2;
                    break;
                case 6:
                    button7.Image = imageList1.Images[2];
                    status[6] = 2;
                    break;
                case 7:
                    button8.Image = imageList1.Images[2];
                    status[7] = 2;
                    break;
                case 8:
                    button9.Image = imageList1.Images[2];
                    status[8] = 2;
                    break;
            }
            if (win())
            {
                MessageBox.Show("You Lose!");
            }
            else
            {
                int num = 0;
                for (int i = 0; i <= 8; i++)
                {
                    if (status[i] == 0)
                    {
                        num++;
                    }
                }
                if (num == 0)
                {
                    MessageBox.Show("Deadlock");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6_situation == 0)
            {
                button6.Image = imageList1.Images[1];
                status[5] = 1;
                button6_situation = 1;
            }
            else
            {
                MessageBox.Show("wrong input!");
            }
            if (lose())
            {
                MessageBox.Show("You Win!");
            }
            //judge();
            minimax();
            switch (optimal)
            {
                case 0:
                    button1.Image = imageList1.Images[2];
                    status[0] = 2;
                    break;
                case 1:
                    button2.Image = imageList1.Images[2];
                    status[1] = 2;
                    break;
                case 2:
                    button3.Image = imageList1.Images[2];
                    status[2] = 2;
                    break;
                case 3:
                    button4.Image = imageList1.Images[2];
                    status[3] = 2;
                    break;
                case 4:
                    button5.Image = imageList1.Images[2];
                    status[4] = 2;
                    break;
                case 5:
                    button6.Image = imageList1.Images[2];
                    status[5] = 2;
                    break;
                case 6:
                    button7.Image = imageList1.Images[2];
                    status[6] = 2;
                    break;
                case 7:
                    button8.Image = imageList1.Images[2];
                    status[7] = 2;
                    break;
                case 8:
                    button9.Image = imageList1.Images[2];
                    status[8] = 2;
                    break;
            }
            if (win())
            {
                MessageBox.Show("You Lose!");
            }
            else
            {
                int num = 0;
                for (int i = 0; i <= 8; i++)
                {
                    if (status[i] == 0)
                    {
                        num++;
                    }
                }
                if (num == 0)
                {
                    MessageBox.Show("Deadlock");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7_situation == 0)
            {
                button7.Image = imageList1.Images[1];
                status[6] = 1;
                button7_situation = 1;
            }
            else
            {
                MessageBox.Show("wrong input!");
            }
            if (lose())
            {
                MessageBox.Show("You Win!");
            }
            //judge();
            minimax();
            switch (optimal)
            {
                case 0:
                    button1.Image = imageList1.Images[2];
                    status[0] = 2;
                    break;
                case 1:
                    button2.Image = imageList1.Images[2];
                    status[1] = 2;
                    break;
                case 2:
                    button3.Image = imageList1.Images[2];
                    status[2] = 2;
                    break;
                case 3:
                    button4.Image = imageList1.Images[2];
                    status[3] = 2;
                    break;
                case 4:
                    button5.Image = imageList1.Images[2];
                    status[4] = 2;
                    break;
                case 5:
                    button6.Image = imageList1.Images[2];
                    status[5] = 2;
                    break;
                case 6:
                    button7.Image = imageList1.Images[2];
                    status[6] = 2;
                    break;
                case 7:
                    button8.Image = imageList1.Images[2];
                    status[7] = 2;
                    break;
                case 8:
                    button9.Image = imageList1.Images[2];
                    status[8] = 2;
                    break;
            }
            if (win())
            {
                MessageBox.Show("You Win!");
            }
            else
            {
                int num = 0;
                for (int i = 0; i <= 8; i++)
                {
                    if (status[i] == 0)
                    {
                        num++;
                    }
                }
                if (num == 0)
                {
                    MessageBox.Show("Deadlock");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (lose())
            {
                MessageBox.Show("You Win!");
            }
            if (button8_situation == 0)
            {
                button8.Image = imageList1.Images[1];
                status[7] = 1;
                button8_situation = 1;
            }
            else
            {
                MessageBox.Show("wrong input!");
            }
            //judge();
            minimax();
            switch (optimal)
            {
                case 0:
                    button1.Image = imageList1.Images[2];
                    status[0] = 2;
                    break;
                case 1:
                    button2.Image = imageList1.Images[2];
                    status[1] = 2;
                    break;
                case 2:
                    button3.Image = imageList1.Images[2];
                    status[2] = 2;
                    break;
                case 3:
                    button4.Image = imageList1.Images[2];
                    status[3] = 2;
                    break;
                case 4:
                    button5.Image = imageList1.Images[2];
                    status[4] = 2;
                    break;
                case 5:
                    button6.Image = imageList1.Images[2];
                    status[5] = 2;
                    break;
                case 6:
                    button7.Image = imageList1.Images[2];
                    status[6] = 2;
                    break;
                case 7:
                    button8.Image = imageList1.Images[2];
                    status[7] = 2;
                    break;
                case 8:
                    button9.Image = imageList1.Images[2];
                    status[8] = 2;
                    break;
            }
            if (win())
            {
                MessageBox.Show("You Lose!");
            }
            else
            {
                int num = 0;
                for (int i = 0; i <= 8; i++)
                {
                    if (status[i] == 0)
                    {
                        num++;
                    }
                }
                if (num == 0)
                {
                    MessageBox.Show("Deadlock");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9_situation == 0)
            {
                button9.Image = imageList1.Images[1];
                status[8] = 1;
                button9_situation = 1;
            }
            else
            {
                MessageBox.Show("wrong input!");
            }
            //judge();
            if (lose())
            {
                MessageBox.Show("You Win!");
            }
            minimax();
            switch (optimal)
            {
                case 0:
                    button1.Image = imageList1.Images[2];
                    status[0] = 2;
                    break;
                case 1:
                    button2.Image = imageList1.Images[2];
                    status[1] = 2;
                    break;
                case 2:
                    button3.Image = imageList1.Images[2];
                    status[2] = 2;
                    break;
                case 3:
                    button4.Image = imageList1.Images[2];
                    status[3] = 2;
                    break;
                case 4:
                    button5.Image = imageList1.Images[2];
                    status[4] = 2;
                    break;
                case 5:
                    button6.Image = imageList1.Images[2];
                    status[5] = 2;
                    break;
                case 6:
                    button7.Image = imageList1.Images[2];
                    status[6] = 2;
                    break;
                case 7:
                    button8.Image = imageList1.Images[2];
                    status[7] = 2;
                    break;
                case 8:
                    button9.Image = imageList1.Images[2];
                    status[8] = 2;
                    break;
            }
            if (win())
            {
                MessageBox.Show("You Lose!");
            }
            else
            {
                int num = 0;
                for (int i = 0; i <= 8; i++)
                {
                    if (status[i] == 0)
                    {
                        num++;
                    }
                }
                if (num == 0)
                {
                    MessageBox.Show("Deadlock");
                }
            }
        }
        public Boolean matched(int i, int j, int k, int who)
        {
            return (status[i] == who && status[j] == who && status[k] == who);
        }
        public Boolean matched(int who)
        {
            if (matched(0, 1, 2, who))
            {
                return true;
            }
            if (matched(3, 4, 5, who))
            {
                return true;
            }
            if (matched(6, 7, 8, who))
            {
                return true;
            }
            if (matched(0, 3, 6, who))
            {
                return true;
            }
            if (matched(1, 4, 7, who))
            {
                return true;
            }
            if (matched(2, 5, 8, who))
            {
                return true;
            }
            if (matched(0, 4, 8, who))
            {
                return true;
            }
            if (matched(2, 4, 6, who))
            {
                return true;
            }
            return false;
        }
        public void judge()
        {
            if (matched(1))
            {
                MessageBox.Show("X贏了!");
            }
            if (matched(2))
            {
                MessageBox.Show("O贏了!");
            }
            int num = 0;
            foreach (int i in status)
            {
                if (i == 0)
                {
                    num++;
                }
            }
            if (num == 0)
            {
                MessageBox.Show("平手!");
            }
        }
        private int getThreats(int who)
        {
            int numThreats = 0;
            if (isThreat(0, 1, 2, who))
            {
                numThreats++;
            }
            if (isThreat(3, 4, 5, who))
            {
                numThreats++;
            }
            if (isThreat(6, 7, 8, who))
            {
                numThreats++;
            }
            if (isThreat(0, 3, 6, who))
            {
                numThreats++;
            }
            if (isThreat(1, 4, 7, who))
            {
                numThreats++;
            }
            if (isThreat(2, 5, 8, who))
            {
                numThreats++;
            }
            if (isThreat(0, 4, 8, who))
            {
                numThreats++;
            }
            if (isThreat(2, 4, 6, who))
            {
                numThreats++;
            }
            return numThreats;
        }
        public int evaluate()
        {

            return getThreats(2) - getThreats(1);
        }
        private Boolean isThreat(int i, int j, int k, int who)
        {
            if (status[i] == who && status[j] == who && status[k] == 0)
            {
                return true;
            }
            if (status[j] == who && status[k] == who && status[i] == 0)
            {
                return true;
            }
            if (status[i] == who && status[k] == who && status[j] == 0)
            {
                return true;
            }
            return false;
        }
        private int[] GetValidMoves(int[] status)
        {// 可移動的Grid為1，不可移動的為-1
            int[] validmoves = new int[9];
            for (int i = 0; i <= 8; i++)
            {
                validmoves[i] = -1
;
            }
            for (int i = 0; i < 9; i++)
            {
                if (status[i] == 0)
                {
                    validmoves[i] = 1;
                }
            }
            return validmoves;
        }
        private int Min(int depth, int parent_Alpha)
        {
            if (lose())
            {
                return (0);
            }
            if (win())
            {
                return (1);
            }
            if (depth == max_depth)
            {
                return evaluate();
            }
            int Beta = 100000;
            int[] moves = GetValidMoves(status);
            int argmin = -1;
            for (int move = 0; move <= 8; move++)
            {
                if (moves[move] == 1)
                {
                    status[move] = 1;
                    int value = Max(depth + 1, Beta);
                    if (value < Beta)
                    {
                        Beta = value;
                        argmin = move;
                    }
                    remove(ref status, move);
                }
            }
            return evaluate();
        }
        private int Max(int depth, int parent_Beta)
        {
            if(lose())
            {
                return (0);
            }
            if(win())
            {
                return (1);
            }
            if (depth == max_depth)
            {
                //Console.WriteLine(evaluate());
                return evaluate();
            }
            int alpha = -100000;
            int[] moves = GetValidMoves(status);
            int argmax = -1;
            for (int move = 0; move <= 8; move++)
            {
                if (moves[move] == 1)
                {
                    status[move] = 2;
                    int value = Min(depth + 1, alpha);
                    if (value > alpha)
                    {
                        alpha = value;
                        argmax = move;
                    }
                    remove(ref status, move);
                   
                }
            }
            if (depth == 0)
            {
                optimal = argmax;
            }
            return  evaluate();
        }
        private void remove(ref int[] status, int move)
        {
            status[move] = 0;
            Console.WriteLine("status");
            foreach(int i in status)
            {
                Console.WriteLine(i);
            }
        }
        private void minimax()
        {
            int nodenum = 0;
            nodenum = Max(0, 100000);
            Console.WriteLine("optimal move:" + optimal);
        }
        private Boolean win()
        {
            return matched(2);
        }
        private Boolean lose()
        {
            return matched(1);
        }
    }
}
