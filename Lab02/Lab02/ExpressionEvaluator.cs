using System.Globalization;

namespace Lab02
{
    internal class ExpressionEvaluator
    {
        private string text;
        private int position;

        private ExpressionEvaluator(string expression)
        {
            text = expression.Replace('\u2013', '-').Replace('\u2014', '-').Replace('\u2212', '-');
            position = 0;
        }

        public static double Evaluate(string expression)
        {
            ExpressionEvaluator evaluator = new ExpressionEvaluator(expression);
            double value = evaluator.ParseExpression();
            evaluator.SkipSpaces();

            if (evaluator.position != evaluator.text.Length)
            {
                throw new FormatException("Ký tự không hợp lệ ở vị trí " + (evaluator.position + 1));
            }
            return value;
        }

        private double ParseExpression()
        {
            double value = ParseTerm();
            while (true)
            {
                SkipSpaces();
                if (Match('+')) value += ParseTerm();
                else if (Match('-')) value -= ParseTerm();
                else return value;
            }
        }

        private double ParseTerm()
        {
            double value = ParseFactor();
            while (true)
            {
                SkipSpaces();
                if (Match('*'))
                {
                    value *= ParseFactor();
                }
                else if (Match('/'))
                {
                    double divisor = ParseFactor();
                    if (divisor == 0)
                    {
                        throw new DivideByZeroException("Chia cho 0");
                    }
                    value /= divisor;
                }
                else
                {
                    return value;
                }
            }
        }

        private double ParseFactor()
        {
            SkipSpaces();

            if (Match('+')) return ParseFactor();
            if (Match('-')) return -ParseFactor();

            if (Match('('))
            {
                double inner = ParseExpression();
                SkipSpaces();
                if (!Match(')'))
                {
                    throw new FormatException("Thiếu dấu ')'");
                }
                return inner;
            }

            return ParseNumber();
        }

        private double ParseNumber()
        {
            int start = position;
            while (position < text.Length && (char.IsDigit(text[position]) || text[position] == '.'))
            {
                position++;
            }

            if (start == position)
            {
                throw new FormatException("Thiếu toán hạng ở vị trí " + (position + 1));
            }

            string numberText = text.Substring(start, position - start);
            return double.Parse(numberText, CultureInfo.InvariantCulture);
        }

        private bool Match(char expected)
        {
            if (position < text.Length && text[position] == expected)
            {
                position++;
                return true;
            }
            return false;
        }

        private void SkipSpaces()
        {
            while (position < text.Length && char.IsWhiteSpace(text[position]))
            {
                position++;
            }
        }
    }
}