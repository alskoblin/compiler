using Lexer.Rules;
using Lexer.Tokens;

namespace Lexer.Lexers;

public class RegExpLexer : ILexer
{
    public IEnumerable<BaseToken> Tokenize(string source)
    {
        int pos = 0;
        while (pos < source.Length)
        {
            int maxLength = 0;
            BaseToken? bestToken = null;
            
            var token = source[pos..];
            foreach (var rule in LexerRules())
            {
                var match = rule.CompiledRegex.Match(token);
                
                if (!match.Success)
                    continue;

                if (match.Length > maxLength)
                {
                    maxLength = match.Length;
                    bestToken = new BaseToken(rule.TokenType, match.Value);
                }
            }
            
            if (bestToken == null)
                throw new InvalidOperationException($"Unknown token at position {pos}");
            
            pos += maxLength;

            if (bestToken.Type != TokenType.Whitespace)
            {
                yield return bestToken;
            }
        }

        yield return new BaseToken(TokenType.EndOfFile, string.Empty);
    }

    private static IEnumerable<RegExpRule> LexerRules() =>
    [
        new (tokenType: TokenType.If, pattern: @"^(\bif\b)"),
        new (tokenType: TokenType.Else, pattern: @"^(\belse\b)"),
        new (tokenType: TokenType.Type, pattern: @"^(\bbigint\b)"),
        new (tokenType: TokenType.Type, pattern: @"^(\bshortint\b)"),
        new (tokenType: TokenType.Type, pattern: @"^(\bfloat\b)"),
        new (tokenType: TokenType.Type, pattern: @"^(\bint\b)"),
        new (tokenType: TokenType.Type, pattern: @"^(\char\b)"),
        new (tokenType: TokenType.Type, pattern: @"^(\str\b)"),
        new (tokenType: TokenType.Type, pattern: @"^(\bool\b)"),
        new (tokenType: TokenType.Identifier, pattern: @"^([A-Za-z]\w*)"),
        new (tokenType: TokenType.NumberValue, pattern: @"^(\d+)"),
        new (tokenType: TokenType.Equal, pattern: "^(==)"),
        new (tokenType: TokenType.Assign, pattern: "^(=)"),
        
        new (tokenType: TokenType.Comma, pattern: "^(,)"),
        new (tokenType: TokenType.Semicolon, pattern: "^(;)"),
        new (tokenType: TokenType.Dot, pattern: "^(\\.)"),
        new (tokenType: TokenType.Colon, pattern: "^(:)"),
        
        new (tokenType: TokenType.For, pattern: "^(\bfor\b)"),
        new (tokenType: TokenType.While, pattern: "^(\bwhile\b)"),
        new (tokenType: TokenType.Do, pattern: "^(\bdo\b)"),
        new (tokenType: TokenType.Continue, pattern: "^(\bcontinue\b)"),
        new (tokenType: TokenType.Break, pattern: "^(\bbreak\b)"),
        new (tokenType: TokenType.Return, pattern: "^(\breturn\b)"),
        new (tokenType: TokenType.True, pattern: "^(\bTrue\b)"),
        new (tokenType: TokenType.False, pattern: "^(\bFalse\b)"),
        new (tokenType: TokenType.Function, pattern: "^(\bfn\b)"),
        
        new (tokenType: TokenType.LeftParen, pattern: "^(\\()"),
        new (tokenType: TokenType.RightParen, pattern: "^(\\))"),
        new (tokenType: TokenType.LeftBrace, pattern: "^(\\{)"),
        new (tokenType: TokenType.RightBrace, pattern: "^(\\})"),
        new (tokenType: TokenType.RightParen, pattern: "^(\\))"),
        new (tokenType: TokenType.Whitespace, pattern: "^(\\s)"),
    ];
}