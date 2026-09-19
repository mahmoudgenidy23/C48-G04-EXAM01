using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem02;

public class PracticalExam : Exam
{
    public Question[] Questions { get; set; }

    public PracticalExam()
    {
    }

    public PracticalExam(
        TimeSpan time,
        Question[] questions,
        Subject subject)
        : base(time, questions.Length, subject)
    {
        Questions = questions;
    }

    public override void ShowExam()
    {
        Console.WriteLine("\n==============================");
        Console.WriteLine("       PRACTICAL EXAM");
        Console.WriteLine("==============================");

        Console.WriteLine($"Subject: {Subject.SubjectName}");
        Console.WriteLine($"Exam Time: {Time}");
        Console.WriteLine($"Number Of Questions: {NumberOfQuestions}");
        Console.WriteLine();

        int totalGrade = 0;

        foreach (Question question in Questions)
        {
            question.Display();

            Console.Write("Enter your answer: ");
            int userAnswer = int.Parse(Console.ReadLine()!);

            if (question.RightAnswer != null &&
                userAnswer == question.RightAnswer.AnswerId)
            {
                totalGrade += question.Mark;
            }

            Console.WriteLine();
        }

        Console.WriteLine("========= CORRECT ANSWERS =========");

        foreach (Question question in Questions)
        {
            Console.WriteLine(question.Body);

            if (question.RightAnswer != null)
            {
                Console.WriteLine(
                    $"Correct Answer: {question.RightAnswer.AnswerText}");
            }

            Console.WriteLine();
        }

        Console.WriteLine($"Your Grade = {totalGrade}");
    }
}
