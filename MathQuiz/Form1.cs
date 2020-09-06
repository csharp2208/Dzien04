using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupQuiz();
        }

        private Random random = new Random((int)DateTime.Now.Ticks);
        private int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }


        private void timerQuiz_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = String.Format("Pozostały czas: {0}sek.", timeLeft);
            if (timeLeft<15)
            {
                lblTimer.ForeColor = Color.Red;
            } else if (timeLeft<30)
            {
                lblTimer.ForeColor = Color.Orange;
            } else
            {
                lblTimer.ForeColor = Color.Black;
            }

            if (timeLeft==0)
            {
                timerQuiz.Stop();
                CheckAnswers();
            }
        }

        private void CheckAnswers()
        {
            int correctAnswers = 0;
            if (quiz1.Result == numQ1.Value) correctAnswers++;
            if (quiz2.Result == numQ2.Value) correctAnswers++;
            if (quiz3.Result == numQ3.Value) correctAnswers++;
            if (quiz4.Result == numQ4.Value) correctAnswers++;

            MessageBox.Show("Liczba poprawnych odpowiedzi: " + correctAnswers,
                "Oto wynik");

            SetupQuiz();
        }

        Quiz quiz1, quiz2, quiz3, quiz4;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Czy na pewno chcesz zamknąć aplikację?";
            string caption = "Pytanie";
            DialogResult result = MessageBox.Show(message, caption, 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timerQuiz.Enabled)
            {
                //zakoncz quiz
                timerQuiz.Enabled = false;
                btnStart.Text = "START";
                CheckAnswers();
            } else
            {
                SetupQuiz();
                timerQuiz.Enabled = true;
                btnStart.Text = "STOP";
            }
        }

        int timeLeft;
        private void SetupQuiz()
        {
            numQ1.Value = 0; numQ2.Value = 0;
            numQ3.Value = 0; numQ4.Value = 0;

            quiz1 = new Quiz(RandomNumber(-10, 10), RandomNumber(-5, 5), "+");
            quiz2 = new Quiz(RandomNumber(-10, 10), RandomNumber(-5, 5), "-");
            quiz3 = new Quiz(RandomNumber(-10, 10), RandomNumber(-5, 5), "*");

            while (true)
            {
                int arg2 = RandomNumber(-5, 5);
                if (arg2!=0)
                {
                    quiz4 = new Quiz(RandomNumber(-10, 10), arg2, "/");
                    break;
                }
            }
            

            lblQ1.Text = quiz1.ToString();
            lblQ2.Text = quiz2.ToString();
            lblQ3.Text = quiz3.ToString();
            lblQ4.Text = quiz4.ToString();

            timeLeft = 60;
            lblTimer.Text = String.Format("Pozostały czas: {0}sek.", timeLeft);
            lblTimer.ForeColor = Color.Black;

            btnStart.Text = "START";

        }
    }
}
