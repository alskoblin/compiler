using Lexer.Tokens;

namespace Lexer.Lexers;

public interface ILexer
{
    public IEnumerable<BaseToken> Tokenize(string source);
}