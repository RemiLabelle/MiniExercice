namespace MiniExercice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculatricePostfixe.EvaluatePostfixExpression(new Queue<char>(new char[] { '3', '4', '2', '*', '+' })));
        }
    }
}