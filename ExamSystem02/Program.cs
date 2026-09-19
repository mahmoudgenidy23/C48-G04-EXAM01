namespace ExamSystem02
{
    internal class Program
    {
        static void Main(string[] args)
        
                    {
            static void Main(string[] args)
            {
                Console.WriteLine("==================================");
                Console.WriteLine("      EXAMINATION SYSTEM");
                Console.WriteLine("==================================");

                // Create Subject
                Subject subject = new Subject(1, "C# OOP");

                Console.WriteLine($"Subject: {subject.SubjectName}");

                Console.WriteLine();
                Console.WriteLine("Choose Exam Type:");
                Console.WriteLine("1. Final Exam");
                Console.WriteLine("2. Practical Exam");

                Console.Write("Enter your choice: ");
                int examType = int.Parse(Console.ReadLine()!);

                // Create Answers
                Answer[] answers =
                {
                new Answer(1, "C#"),
                new Answer(2, "Java"),
                new Answer(3, "Python"),
                new Answer(4, "PHP")
            };

                // Create MCQ Question
                MCQQuestion q1 = new MCQQuestion(
                    "Question 1",
                    "Which language is used in this exam?",
                    5,
                    answers,
                    answers[0]
                );

                // Create True / False Question
                TrueFalseQuestion q2 = new TrueFalseQuestion(
                    "Question 2",
                    "C# supports Object Oriented Programming.",
                    5
                );

                q2.RightAnswer = q2.Answers[0];

                Question[] questions;

                if (examType == 1)
                {
                    questions = new Question[]
                    {
                    q1,
                    q2
                    };

                    FinalExam finalExam = new FinalExam(
                        new TimeSpan(0, 30, 0),
                        questions,
                        subject
                    );

                    subject.CreateExam(finalExam);

                    Console.WriteLine();
                    Console.WriteLine("Exam Created Successfully.");

                    finalExam.ShowExam();
                }
                else if (examType == 2)
                {
                    questions = new Question[]
                    {
                    q1
                    };

                    PracticalExam practicalExam = new PracticalExam(
                        new TimeSpan(0, 20, 0),
                        questions,
                        subject
                    );

                    subject.CreateExam(practicalExam);

                    Console.WriteLine();
                    Console.WriteLine("Exam Created Successfully.");

                    practicalExam.ShowExam();
                }
                else
                {
                    Console.WriteLine("Invalid Exam Type.");
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to close...");
                Console.ReadKey();
            }
        }
    }
}
    