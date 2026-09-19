using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem02;

public abstract class Exam
{
    public TimeSpan Time { get; set; }
    public int NumberOfQuestions { get; set; }

    public Subject Subject { get; set; }

    protected Exam()
    {
    }

    protected Exam(TimeSpan time, int numberOfQuestions, Subject subject)
        : this()
    {
        Time = time;
        NumberOfQuestions = numberOfQuestions;
        Subject = subject;
    }

    public abstract void ShowExam();
}

