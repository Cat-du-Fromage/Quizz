using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    class QuestionQuizz
    {
        Dictionary<string, string> questions;

        public QuestionQuizz(string type, Dictionary<string, string> questions)
        {
            this.questions = questions;
        }
    }
}
