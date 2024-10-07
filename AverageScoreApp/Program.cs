// See https://aka.ms/new-console-template for more information
// Program Name: Average Score App
// Date: September 28, 2024
// Author: K Bola
// Purpose: This Application calculates the average score of five exams
namespace AverageScoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double score1, score2, score3, score4, score5;
            Console.Write("Enter the first Score: ");
            score1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second Score: ");
            score2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the third Score: ");
            score3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the fourth Score: ");
            score4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the fifth Score: ");
            score5 = Convert.ToDouble(Console.ReadLine());
            double sum = score1 + score2 + score3 + score4 + score5;
            double averageScore = sum / 5;
            string formatted = averageScore.ToString("N");
            Console.WriteLine("{0, -5:G} {1, 5:G}", "Scores", "Average Scores");
            Console.WriteLine("{0, -5:N} {1, 5:N}", sum, averageScore);
        }
    }
}
