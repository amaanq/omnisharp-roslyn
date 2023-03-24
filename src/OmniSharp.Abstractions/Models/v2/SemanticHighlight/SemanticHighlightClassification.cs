namespace OmniSharp.Models.SemanticHighlight
{
    // Enum of the names defined Roslyn's ClassificationTypeNames.
    public enum SemanticHighlightClassification
    {
        Comment,
        ExcludedCode,
        Identifier,
        Keyword,
        ControlKeyword,
        NumericLiteral,
        Operator,
        OperatorOverloaded,
        PreprocessorKeyword,
        StringLiteral,
        WhiteSpace,
        Text,
        StaticSymbol,
        PreprocessorText,
        Punctuation,
        VerbatimStringLiteral,
        StringEscapeCharacter,
        Class,
        Delegate,
        Enum,
        Interface,
        Struct,
        TypeParameter,
        Field,
        EnumMember,
        Constant,
        Variable,
        // TODO: Figure out how to get Variable.Readonly to work
        Parameter,
        Method,
        Property,
        Event,
        Namespace,
        Label,
        XmlDocCommentAttribute,
        XmlDocCommentAttributeQuotes,
        XmlDocCommentAttributeValue,
        XmlDocCommentCDataSection,
        XmlDocCommentComment,
        XmlDocCommentDelimiter,
        XmlDocCommentEntityReference,
        XmlDocComment,
        XmlDocCommentProcessingInstruction,
        XmlDocCommentText,
        XmlLiteralAttribute,
        XmlLiteralAttributeQuotes,
        XmlLiteralAttributeValue,
        XmlLiteralCDataSection,
        XmlLiteralComment,
        XmlLiteralDelimiter,
        XmlLiteralEmbeddedExpression,
        XmlLiteralEntityReference,
        XmlLiteral,
        XmlLiteralProcessingInstruction,
        XmlLiteralText,
        RegexComment,
        RegexCharacterClass,
        RegexAnchor,
        RegexQuantifier,
        RegexGrouping,
        RegexAlternation,
        RegexText,
        RegexSelfEscapedCharacter,
        RegexOtherEscape,
    }
}
