namespace Lexer.Tokens;

public enum TokenType
{
    String,
    ShortInteger,   // 2 bytes
    Integer,        // 4 bytes
    BigInteger,     // 8 bytes
    Float,
    Boolean,
    Char,

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
    Null,
    Const,
    Function,
    Class,
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