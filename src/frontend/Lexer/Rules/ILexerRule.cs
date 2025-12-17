using Lexer.Tokens;

namespace Lexer.Rules;

public interface ILexerRule
{
    public TokenType TokenType { get; }

    public string Pattern { get; }
}