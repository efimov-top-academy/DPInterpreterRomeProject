namespace DPInterpreterRomeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string roman = "MMXVIII";
            Context context = new Context(roman);

            //Строим 'parse tree'
            List<Expression> tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            //Интерпритатор

            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }
            Console.WriteLine("{0} = {1}",
                roman, context.Output);
        }
    }
}