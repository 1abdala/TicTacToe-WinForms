using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTac_Game.Properties;

namespace TicTac_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            player[0] = new PlayerScore();
            player[1] = new PlayerScore();
        }
        int gamecounter=0;
        string[] playersname = { "Player1", "Player2" };
        class PlayerScore
        {
            public int[,] Score = new int[3, 3]; // Initialized by default
            public int countgames = 0;
        }

        PlayerScore[] player = new PlayerScore[2];
        


        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.Black;
            Pen pen = new Pen(White);
            pen.Width = 10;

            pen.StartCap=System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(pen,250, 200, 580, 200);
            e.Graphics.DrawLine(pen, 250, 300, 580, 300);

            e.Graphics.DrawLine(pen, 350, 125, 350, 375);
            e.Graphics.DrawLine(pen, 480, 125, 480, 375);


            // e.Graphics.DrawLine(pen,)


        }
        private void Cheke_GameEnd()
        {
            // Check if Player 1 wins
            if (player[0].countgames >= 3)
            {
                if ((player[0].Score[0, 0] == 1 && player[0].Score[0, 1] == 1 && player[0].Score[0, 2] == 1) || // Row 1
                    (player[0].Score[1, 0] == 1 && player[0].Score[1, 1] == 1 && player[0].Score[1, 2] == 1) || // Row 2
                    (player[0].Score[2, 0] == 1 && player[0].Score[2, 1] == 1 && player[0].Score[2, 2] == 1) || // Row 3
                    (player[0].Score[0, 0] == 1 && player[0].Score[1, 0] == 1 && player[0].Score[2, 0] == 1) || // Column 1
                    (player[0].Score[0, 1] == 1 && player[0].Score[1, 1] == 1 && player[0].Score[2, 1] == 1) || // Column 2
                    (player[0].Score[0, 2] == 1 && player[0].Score[1, 2] == 1 && player[0].Score[2, 2] == 1) || // Column 3
                    (player[0].Score[0, 0] == 1 && player[0].Score[1, 1] == 1 && player[0].Score[2, 2] == 1) || // Diagonal 1
                    (player[0].Score[0, 2] == 1 && player[0].Score[1, 1] == 1 && player[0].Score[2, 0] == 1))   // Diagonal 2
                {
                    lblWinner.Text = "Player1";
                    MessageBox.Show("Player1 Won", "Game over",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }

            // Check if Player 2 wins
           else  if (player[1].countgames >= 3)
            {
                if ((player[1].Score[0, 0] == 1 && player[1].Score[0, 1] == 1 && player[1].Score[0, 2] == 1) || // Row 1
                    (player[1].Score[1, 0] == 1 && player[1].Score[1, 1] == 1 && player[1].Score[1, 2] == 1) || // Row 2
                    (player[1].Score[2, 0] == 1 && player[1].Score[2, 1] == 1 && player[1].Score[2, 2] == 1) || // Row 3
                    (player[1].Score[0, 0] == 1 && player[1].Score[1, 0] == 1 && player[1].Score[2, 0] == 1) || // Column 1
                    (player[1].Score[0, 1] == 1 && player[1].Score[1, 1] == 1 && player[1].Score[2, 1] == 1) || // Column 2
                    (player[1].Score[0, 2] == 1 && player[1].Score[1, 2] == 1 && player[1].Score[2, 2] == 1) || // Column 3
                    (player[1].Score[0, 0] == 1 && player[1].Score[1, 1] == 1 && player[1].Score[2, 2] == 1) || // Diagonal 1
                    (player[1].Score[0, 2] == 1 && player[1].Score[1, 1] == 1 && player[1].Score[2, 0] == 1))   // Diagonal 2
                {
                    lblWinner.Text = "Player2";
                    MessageBox.Show("Player2 Won", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }

            else if (gamecounter == 8)
            {

                lblWinner.Text = "Draw";
                MessageBox.Show("Draw", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;

            }
        }

        //void change_Image(PictureBox pbx)
        //{
        //    if (pbx.Tag == "taken")
        //    {

        //        MessageBox.Show("Wrong choice ",
        //            "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    if (lblPlayerTurn.Text == playersname[0])
        //    {
        //        player[0].Score[0, 0] = 1;
        //        pbx1.Image = Resources.x_Letter;
        //        pbx1.SizeMode = PictureBoxSizeMode.Zoom;
        //        lblPlayerTurn.Text = playersname[1];
        //        player[0].countgames++;
        //        Cheke_GameEnd();
        //    }
        //    else
        //    {
        //        player[1].Score[0, 0] = 1;

        //        pbx1.Image = Resources.o_Letter;
        //        pbx1.SizeMode = PictureBoxSizeMode.Zoom;
        //        lblPlayerTurn.Text = playersname[0];
        //        player[1].countgames++;
        //        Cheke_GameEnd();


        //    }
        //    gamecounter++;
        //    pbx1.Tag = "taken";


        //}
        private void pbx1_Click(object sender, EventArgs e)
        {
            if (pbx1.Tag == "taken")
            {

                MessageBox.Show("Wrong choice ",
                    "Wrong",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
           
            if (lblPlayerTurn.Text == playersname[0])
            {
                player[0].Score[0, 0] = 1;
                pbx1.Image = Resources.x_Letter;
                pbx1.SizeMode = PictureBoxSizeMode.Zoom;
                lblPlayerTurn.Text = playersname[1];
                player[0].countgames++;
                Cheke_GameEnd();
            }
            else
            {
                player[1].Score[0, 0] = 1;

                pbx1.Image = Resources.o_Letter;
                pbx1.SizeMode = PictureBoxSizeMode.Zoom;
                lblPlayerTurn.Text = playersname[0];
                player[1].countgames++;
                Cheke_GameEnd();


            }
            gamecounter++;
            pbx1.Tag = "taken";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Tag == "taken")
            {

                MessageBox.Show("Wrong choice ",
                    "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lblPlayerTurn.Text == playersname[0])
            {
                player[0].Score[0, 1] = 1;
                pictureBox2.Image = Resources.x_Letter;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                lblPlayerTurn.Text = playersname[1];
                player[0].countgames++;
                Cheke_GameEnd();
            }
            else
            {
                player[1].Score[0, 1] = 1;

                pictureBox2.Image = Resources.o_Letter;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                lblPlayerTurn.Text = playersname[0];
                player[1].countgames++;
                Cheke_GameEnd();


            }
            pictureBox2.Tag = "taken";
            gamecounter++;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Tag == "taken")
            {

                MessageBox.Show("Wrong choice ",
                    "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pictureBox3.Tag = "taken";
            if (lblPlayerTurn.Text == playersname[0])
            {
                player[0].Score[0, 2] = 1;
                pictureBox3.Image = Resources.x_Letter;
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                lblPlayerTurn.Text = playersname[1];
                player[0].countgames++;
                Cheke_GameEnd();
            }
            else
            {
                player[1].Score[0, 2] = 1;

                pictureBox3.Image = Resources.o_Letter;
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                lblPlayerTurn.Text = playersname[0];
                player[1].countgames++;
                Cheke_GameEnd();


            }
            gamecounter++;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Tag == "taken")
            {

                MessageBox.Show("Wrong choice ",
                    "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pictureBox4.Tag = "taken";

            if (lblPlayerTurn.Text == playersname[0])
            {
                player[0].Score[1, 0] = 1;
                pictureBox4.Image = Resources.x_Letter;
                pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
                lblPlayerTurn.Text = playersname[1];
                player[0].countgames++;
                Cheke_GameEnd();
            }
            else
            {
                player[1].Score[1, 0] = 1;

                pictureBox4.Image = Resources.o_Letter;
                pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
                lblPlayerTurn.Text = playersname[0];
                player[1].countgames++;
                Cheke_GameEnd();


            }
            gamecounter++;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            if (pictureBox8.Tag == "taken")
            {

                MessageBox.Show("Wrong choice ",
                    "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pictureBox8.Tag = "taken";
            if (lblPlayerTurn.Text == playersname[0])
            {
                player[0].Score[2, 1] = 1;
                pictureBox8.Image = Resources.x_Letter;
                pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
                lblPlayerTurn.Text = playersname[1];
                player[0].countgames++;
                Cheke_GameEnd();
            }
            else
            {
                player[1].Score[2, 1] = 1;

                pictureBox8.Image = Resources.o_Letter;
                pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
                lblPlayerTurn.Text = playersname[0];
                player[1].countgames++;
                Cheke_GameEnd();


            }
            gamecounter++;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Tag == "taken")
            {

                MessageBox.Show("Wrong choice ",
                    "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pictureBox9.Tag = "taken";

            if (lblPlayerTurn.Text == playersname[0])
            {
                player[0].Score[2, 2] = 1;
                pictureBox9.Image = Resources.x_Letter;
                pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
                lblPlayerTurn.Text = playersname[1];
                player[0].countgames++;
                Cheke_GameEnd();
            }
            else
            {
                player[1].Score[2,2] = 1;

                pictureBox9.Image = Resources.o_Letter;
                pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
                lblPlayerTurn.Text = playersname[0];
                player[1].countgames++;
                Cheke_GameEnd();


            }
            gamecounter++;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Tag == "taken")
            {

                MessageBox.Show("Wrong choice ",
                    "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pictureBox6.Tag = "taken";

            if (lblPlayerTurn.Text == playersname[0])
            {
                player[0].Score[1, 2] = 1;
                pictureBox6.Image = Resources.x_Letter;
                pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
                lblPlayerTurn.Text = playersname[1];
                player[0].countgames++;
                Cheke_GameEnd();
            }
            else
            {
                player[1].Score[1, 2] = 1;

                pictureBox6.Image = Resources.o_Letter;
                pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
                lblPlayerTurn.Text = playersname[0];
                player[1].countgames++;
                Cheke_GameEnd();


            }
            gamecounter++;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Tag == "taken")
            {

                MessageBox.Show("Wrong choice ",
                    "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pictureBox7.Tag = "taken";
            if (lblPlayerTurn.Text == playersname[0])
            {
                player[0].Score[2, 0] = 1;
                pictureBox7.Image = Resources.x_Letter;
                pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
                lblPlayerTurn.Text = playersname[1];
                player[0].countgames++;
                Cheke_GameEnd();
            }
            else
            {
                player[1].Score[2, 0] = 1;

                pictureBox7.Image = Resources.o_Letter;
                pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
                lblPlayerTurn.Text = playersname[0];
                player[1].countgames++;
                Cheke_GameEnd();


            }
            gamecounter++;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Tag == "taken")
            {

                MessageBox.Show("Wrong choice ",
                    "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pictureBox5.Tag = "taken";
            if (lblPlayerTurn.Text == playersname[0])
            {
                player[0].Score[1, 1] = 1;
                pictureBox5.Image = Resources.x_Letter;
                pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
                lblPlayerTurn.Text = playersname[1];
                player[0].countgames++;
                Cheke_GameEnd();
            }
            else
            {
                player[1].Score[1,1] = 1;

                pictureBox5.Image = Resources.o_Letter;
                pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
                lblPlayerTurn.Text = playersname[0];
                player[1].countgames++;
                Cheke_GameEnd();


            }
            gamecounter++;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}
