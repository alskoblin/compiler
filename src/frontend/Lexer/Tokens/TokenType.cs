namespace Lexer.Tokens;

public enum TokenType
{
    Type,
    NumberValue,
    StringValue,
    CharValue,
    BooleanValue,
    
    Identifier,

    // ===== Keywords =====
    If,
    Else,
    For,
    While,
    Do,
    Break,
    Continue,
    Return,
    True,
    False,
    Function,
    New,

    // ===== Operators =====

    // Arithmetic
    Plus,           // +
    Minus,          // -
    Multiply,       // *
    Divide,         // /
    Modulo,         // %

    // Unary
    Increment,      // ++
    Decrement,      // --

    // Assignment
    Assign,         // =
    PlusAssign,     // +=
    MinusAssign,    // -=
    MultiplyAssign, // *=
    DivideAssign,   // /=

    // Comparison
    Equal,          // ==
    NotEqual,       // !=
    Greater,        // >
    GreaterEqual,   // >=
    Less,           // <
    LessEqual,      // <=

    // Logical
    And,            // &&
    Or,             // ||
    Not,            // !

    // Bitwise
    BitAnd,         // &
    BitOr,          // |
    BitXor,         // ^
    BitNot,         // ~
    ShiftLeft,      // <<
    ShiftRight,     // >>

    // ===== Punctuation / Symbols =====
    LeftParen,      // (
    RightParen,     // )
    LeftBrace,      // {
    RightBrace,     // }
    LeftBracket,    // [
    RightBracket,   // ]

    Whitespace,     // 
    Semicolon,      // ;
    Colon,          // :
    Comma,          // ,
    Dot,            // .

    // ===== Structural =====
    Array,          // For array type or literal
    Arrow,          // -> or => depending on language

    // ===== Special Tokens =====
    EndOfFile,
    Unknown
}