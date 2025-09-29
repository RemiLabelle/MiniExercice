namespace MiniExercice
{
    public class CalculatricePostfixe
    {
        public static int EvaluatePostfixExpression(Queue<char> postfixExpression)
        {
            Stack<string> expression = new Stack<string>();

            while (postfixExpression.Count > 0)
            {
                string current = postfixExpression.Dequeue().ToString();
                bool parsed = int.TryParse(current, out int operande);

                if (parsed)
                {
                    expression.Push(current);
                }
                else
                {
                    int var1 = Convert.ToInt32(expression.Pop());
                    int var2 = Convert.ToInt32(expression.Pop());

                    switch (current)
                    {
                        case "+":
                            expression.Push((var1 + var2).ToString());
                            break;
                        case "-":
                            expression.Push((var1 - var2).ToString());
                            break;
                        case "*":
                            expression.Push((var1 * var2).ToString());
                            break;
                        case "/":
                            expression.Push((var1 / var2).ToString());
                            break;
                    }
                }
            }

            return Convert.ToInt32(expression.Pop());
        }
    }
}