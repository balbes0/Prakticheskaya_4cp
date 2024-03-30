using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakticheskaya_4
{
    internal class Test
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public CorrectOption CorrectOption { get; set; }
    }

    public enum CorrectOption
    {
        FirstAnswerCorrect,
        SecondAnswerCorrect,
        ThirdAnswerCorrect
    }
}
