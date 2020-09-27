using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_time
{
    public partial class player : Form
    {
        playerClass currentQuiz;
        public int quizLength;
        public int currentQuestion = 0;
        public int QorA = 0;
        public int timer = 10;
        public player(playerClass currentQuiz)
        {
            InitializeComponent();
            this.currentQuiz = currentQuiz;
            this.quizLength = currentQuiz.questions.Count();
        }
        private void InitializeTimer()
        {
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(Timer1_Tick);
 
            timer1.Enabled = true;

        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {
            if (timer == 0) { 
                nextQuestion();
                if (QorA == 1)timer = 10;
                if (QorA == 0 && currentQuiz.nakijkmodus == "check lijst") timer = 10;
                else timer = 3;
            }
            lb_timer.Text = timer.ToString();
            timer--;
        }

        private void display_Load(object sender, EventArgs e)
        {
            nextQuestion();
            if (currentQuiz.tijdmodus == "10 seconden") {
                InitializeTimer();
            }

        }
        private void clickNext(object sender, MouseEventArgs e) {
            //Console.WriteLine(currentQuiz.tijdmodus);
            if (currentQuiz.tijdmodus == "click") {
                nextQuestion();
            }
        }
        private void nextQuestion() {
            Console.WriteLine("start nexT");
            int debugval = 1;
            
            if (currentQuiz.nakijkmodus == "check vraag" && QorA == 0)
            {
                groupBox1.BackColor = SystemColors.Control;
                groupBox2.BackColor = SystemColors.Control;
                groupBox3.BackColor = SystemColors.Control;
                groupBox4.BackColor = SystemColors.Control;
                if (quizLength != currentQuestion)
                {
                    lb_ans_a.Text = currentQuiz.questions[currentQuestion].ans_a;
                    lb_ans_b.Text = currentQuiz.questions[currentQuestion].ans_b;
                    lb_ans_c.Text = currentQuiz.questions[currentQuestion].ans_c;
                    lb_ans_d.Text = currentQuiz.questions[currentQuestion].ans_d;
                    lb_question.Text = currentQuiz.questions[currentQuestion].playerQuestion;
                    pct_playerImg.Load(currentQuiz.questions[currentQuestion].questionImage);
                    currentQuestion++;
                    QorA = 1;
                }
                else
                {
                    lb_ans_a.Text = "";
                    lb_ans_b.Text = "";
                    lb_ans_c.Text = "";
                    lb_ans_d.Text = "";
                    lb_question.Text = "you are out of questions";
                }
            }
            else if(currentQuiz.nakijkmodus == "check lijst" && QorA == 0)
            {
                groupBox1.BackColor = SystemColors.Control;
                groupBox2.BackColor = SystemColors.Control;
                groupBox3.BackColor = SystemColors.Control;
                groupBox4.BackColor = SystemColors.Control;
                Console.WriteLine(currentQuiz.nakijkmodus);
                Console.WriteLine(QorA);
                if (quizLength != currentQuestion)
                {
                    Console.WriteLine(currentQuestion);
                    lb_ans_a.Text = currentQuiz.questions[currentQuestion].ans_a;
                    lb_ans_b.Text = currentQuiz.questions[currentQuestion].ans_b;
                    lb_ans_c.Text = currentQuiz.questions[currentQuestion].ans_c;
                    lb_ans_d.Text = currentQuiz.questions[currentQuestion].ans_d;
                    lb_question.Text = currentQuiz.questions[currentQuestion].playerQuestion;
                    
                    
                    pct_playerImg.ImageLocation = currentQuiz.questions[currentQuestion].questionImage;
                    Console.WriteLine(currentQuiz.questions[currentQuestion].questionImage);
                    
                    
                    currentQuestion++;
                }
                else if (QorA == 0)
                {
                    QorA = 1;
                    currentQuestion = 1;
                }
                else
                {
                    lb_ans_a.Text = "";
                    lb_ans_b.Text = "";
                    lb_ans_c.Text = "";
                    lb_ans_d.Text = "";
                    lb_question.Text = "you are out of questions";
                }
            }
            else
            {
                if (quizLength != currentQuestion)
                {
                    if (currentQuiz.nakijkmodus == "check lijst")
                    {
                        groupBox1.BackColor = SystemColors.Control;
                        groupBox2.BackColor = SystemColors.Control;
                        groupBox3.BackColor = SystemColors.Control;
                        groupBox4.BackColor = SystemColors.Control;
                        lb_ans_a.Text = currentQuiz.questions[currentQuestion - 1].ans_a;
                        lb_ans_b.Text = currentQuiz.questions[currentQuestion - 1].ans_b;
                        lb_ans_c.Text = currentQuiz.questions[currentQuestion - 1].ans_c;
                        lb_ans_d.Text = currentQuiz.questions[currentQuestion - 1].ans_d;
                        lb_question.Text = currentQuiz.questions[currentQuestion - 1].playerQuestion;
                    }
                    switch (char.Parse(currentQuiz.questions[currentQuestion - 1].correct))
                    {
                        case 'a':
                            groupBox1.BackColor = Color.PaleGreen;
                            break;
                        case 'b':
                            groupBox2.BackColor = Color.PaleGreen;
                            break;
                        case 'c':
                            groupBox3.BackColor = Color.PaleGreen;
                            break;
                        case 'd':
                            groupBox4.BackColor = Color.PaleGreen;
                            break;
                    }
                    if (currentQuiz.nakijkmodus == "check vraag") QorA = 0;
                    if (currentQuiz.nakijkmodus == "check lijst") currentQuestion++;
                }
                else
                {
                    groupBox1.BackColor = SystemColors.Control;
                    groupBox2.BackColor = SystemColors.Control;
                    groupBox3.BackColor = SystemColors.Control;
                    groupBox4.BackColor = SystemColors.Control;
                    lb_ans_a.Text = "";
                    lb_ans_b.Text = "";
                    lb_ans_c.Text = "";
                    lb_ans_d.Text = "";
                    lb_question.Text = "you are out of questions";
                }
            }
            
        }
    }
}
