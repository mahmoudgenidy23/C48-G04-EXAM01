using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ExamSystem02;

public abstract class Question : IComparable<Question>, ICloneable
{
    public string Header { get; set; }
    public string Body { get; set; }
    public int Mark { get; set; }

    public Answer[] Answers { get; set; }
    public Answer RightAnswer { get; set; }

    protected Question()
    {
    }

    protected Question(string header, string body, int mark)
        : this()
    {
        Header = header;
        Body = body;
        Mark = mark;
    }

    public abstract void Display();

    public object Clone()
    {
        Question clonedQuestion = (Question)this.MemberwiseClone();

        if (Answers != null)
        {
            clonedQuestion.Answers = new Answer[Answers.Length];

            for (int i = 0; i < Answers.Length; i++)
            {
                if (Answers[i] != null)
                {
                    clonedQuestion.Answers[i] =
                        new Answer(Answers[i].AnswerId, Answers[i].AnswerText);
                }
            }
        }

        if (RightAnswer != null)
        {
            clonedQuestion.RightAnswer =
                new Answer(RightAnswer.AnswerId, RightAnswer.AnswerText);
        }

        return clonedQuestion;
    }

    public int CompareTo(Question? other)
    {
        if (other == null)
            return 1;

        return Mark.CompareTo(other.Mark);
    }

    public override string ToString()
    {
        return $"{Header}: {Body} - Mark = {Mark}";
    }
}

