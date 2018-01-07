using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightBall
{
    public  class AnswerGenerator
    {
        public string GetRandomAnswer(string question)
        {
            return string.Format("你问我的问题是{0}",question);
        }
    }
}
