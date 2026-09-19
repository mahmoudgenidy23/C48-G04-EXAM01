using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem02;

public class TrueFalseQuestion : Question
{
    public TrueFalseQuestion()
    {
    }

    public TrueFalseQuestion(string header, string body, int mark)
        : base(header, body, mark)
    {
        Answers = new Answer[]
        {
            new Answer(1, "True"),
            new Answer(2, "False")
        };
    }

    public override void Display()
    {
        Console.WriteLine(Header);
        Console.WriteLine(Body);

        foreach (Answer answer in Answers)
        {
            Console.WriteLine(answer);
        }
    }
}

