using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class Math : Form
    {

        Random randomizer = new Random();

        int addend1;
        int addend2;

        int timeLeft;


        public void startTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            plusleftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            sum.Value = 0;

            //Timer
            timeLeft = 30;
            timeLabel.Text = "30 Seconds";
            timer1.Start();
        }


        //Checking Answer
        private bool CheckTheAnswer()
        {
            if (addend1 + addend2 == sum.Value)
                return true;
            else
                return false;
        }



        public Math()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dividedleftLabel_Click(object sender, EventArgs e)
        {

        }

        private void dividedRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startTheQuiz();
            startButton.Enabled = false;
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }


       


        private void timer1_Tick(object sender, EventArgs e)
        {
            //If answers correct, end quiz and start again

            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("Hooray you got all the answers right", "Congrats!!!!1");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {

            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthofAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthofAnswer);
            }
        }

    }
    }

