namespace ConsoleCalculator
{
    public static class CharExtensions
    {
        public static bool IsOperator(this char symbol) => "+-/*()".IndexOf(symbol) != -1;

        public static byte GetOperationPriority(this char operation)
        {
            return operation switch
            {
                '(' => 0,
                ')' => 1,
                '+' => 2,
                '-' => 3,
                '*' => 4,
                '/' => 4,
                _ => 5
            };
        }
    }
}