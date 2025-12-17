namespace Lexer.Tokens;

public class BaseToken
{
    private readonly TokenType _type;
    private readonly string _value;

    public BaseToken(TokenType type, string value)
    {
        _type = type;
        _value = value;
    }
    
    public TokenType Type => _type;
    public string Value => _value;
}