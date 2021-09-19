namespace MathExpressions
{
    public interface ITokenizer
    {
        Token CurrentToken { get; }
        void NextToken();
    }
}