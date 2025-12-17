using System.Text.RegularExpressions;
using Lexer.Tokens;

namespace Lexer.Rules;

public class RegExpRule : ILexerRule
{
    public RegExpRule(TokenType tokenType, string pattern)
    {
        TokenType = tokenType;
        Pattern = pattern;
        CompiledRegex = new Regex(Pattern, RegexOptions.Compiled);
    }

    public TokenType TokenType { get; }
    
    public string Pattern { get; }
    
    public Regex CompiledRegex { get; }
}