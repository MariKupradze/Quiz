using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Questions
    {
        public string question;
        public string answer1;
        public string answer2;
        public string answer3;
        public int correct;

        public Questions(string question, string answer1, string answer2, string answer3, int correct)
        {
            this.question = question;
            this.answer1 = answer1;
            this.answer2 = answer2;
            this.answer3 = answer3;
            this.correct = correct;
        }
        public Questions()
        {
            
        }

    }
}
