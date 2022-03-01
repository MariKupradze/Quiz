using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;



namespace Test1
{

    public partial class Form1 : Form
    {
        static FileStream file = new FileStream("quiz.txt", FileMode.Open, FileAccess.Read);
        static StreamReader reader = new StreamReader(file);
        List<Questions> q = new List<Questions>();
        string line = reader.ReadLine();
        int qCount = 1;
        int score = 0;
        
        public Form1()
        {
            

            InitializeComponent();
            
            while (line != null)
            {
                Questions question = new Questions();
                string[] parts = line.Split('\t');
                question.question = parts[0];
                question.answer1 = parts[1];
                question.answer2 = parts[2];
                question.answer3 = parts[3];
                question.correct = Convert.ToInt32(parts[4]);
                q.Add(question);
                line = reader.ReadLine();
            }
            label1.Text = q[0].question;
            radioButton1.Text = q[0].answer1;
            radioButton2.Text = q[0].answer2;
            radioButton3.Text = q[0].answer3;
            if (q[0].correct == 1 && radioButton1.Checked)
            {
                score++;
            }
            else if (q[0].correct == 2 && radioButton2.Checked)
            {
                score++;
            }
            else if (q[0].correct == 3 && radioButton3.Checked)
            {
                score++;
            }
            

            file.Close();
            reader.Close();

        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (q[qCount-1].correct == 1 && radioButton1.Checked)
            {
                score++;
            }
            else if (q[qCount-1].correct == 2 && radioButton2.Checked)
            {
                score++;
            }
            else if (q[qCount-1].correct == 3 && radioButton3.Checked)
            {
                score++;
            }
            


            if (qCount < 10)
            {
                
                label1.Text = q[qCount].question;
                radioButton1.Text = q[qCount].answer1;
                radioButton2.Text = q[qCount].answer2;
                radioButton3.Text = q[qCount].answer3;

                progressBar1.Value++;
                qCount++;
            }
            else
            {
                
                MessageBox.Show(score + "/10", "Score");
                this.Close();

            }
        
            
        }

        
    }
}
