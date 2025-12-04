namespace Lexer.Tokens;

public abstract class BaseToken
{
    private readonly TokenType _type;
    private readonly byte[] _value;

    protected BaseToken(TokenType type, byte[] value)
    {
        _type = type;
        _value = value;
    }
}