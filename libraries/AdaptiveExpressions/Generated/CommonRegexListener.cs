//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from CommonRegex.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


#pragma warning disable 3021 // Disable StyleCop warning CS3021 re CLSCompliant attribute in generated files.
#pragma warning disable 0108 // Disable StyleCop warning CS0108, hides inherited member in generated files.

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="CommonRegexParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface ICommonRegexListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParse([NotNull] CommonRegexParser.ParseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParse([NotNull] CommonRegexParser.ParseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.alternation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlternation([NotNull] CommonRegexParser.AlternationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.alternation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlternation([NotNull] CommonRegexParser.AlternationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] CommonRegexParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] CommonRegexParser.ExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElement([NotNull] CommonRegexParser.ElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElement([NotNull] CommonRegexParser.ElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.quantifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuantifier([NotNull] CommonRegexParser.QuantifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.quantifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuantifier([NotNull] CommonRegexParser.QuantifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.quantifier_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuantifier_type([NotNull] CommonRegexParser.Quantifier_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.quantifier_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuantifier_type([NotNull] CommonRegexParser.Quantifier_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.character_class"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCharacter_class([NotNull] CommonRegexParser.Character_classContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.character_class"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCharacter_class([NotNull] CommonRegexParser.Character_classContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.capture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCapture([NotNull] CommonRegexParser.CaptureContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.capture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCapture([NotNull] CommonRegexParser.CaptureContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.non_capture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNon_capture([NotNull] CommonRegexParser.Non_captureContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.non_capture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNon_capture([NotNull] CommonRegexParser.Non_captureContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOption([NotNull] CommonRegexParser.OptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOption([NotNull] CommonRegexParser.OptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.option_flag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOption_flag([NotNull] CommonRegexParser.Option_flagContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.option_flag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOption_flag([NotNull] CommonRegexParser.Option_flagContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtom([NotNull] CommonRegexParser.AtomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtom([NotNull] CommonRegexParser.AtomContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.cc_atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCc_atom([NotNull] CommonRegexParser.Cc_atomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.cc_atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCc_atom([NotNull] CommonRegexParser.Cc_atomContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.shared_atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShared_atom([NotNull] CommonRegexParser.Shared_atomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.shared_atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShared_atom([NotNull] CommonRegexParser.Shared_atomContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral([NotNull] CommonRegexParser.LiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral([NotNull] CommonRegexParser.LiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.cc_literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCc_literal([NotNull] CommonRegexParser.Cc_literalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.cc_literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCc_literal([NotNull] CommonRegexParser.Cc_literalContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.shared_literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShared_literal([NotNull] CommonRegexParser.Shared_literalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.shared_literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShared_literal([NotNull] CommonRegexParser.Shared_literalContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumber([NotNull] CommonRegexParser.NumberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumber([NotNull] CommonRegexParser.NumberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.octal_char"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOctal_char([NotNull] CommonRegexParser.Octal_charContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.octal_char"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOctal_char([NotNull] CommonRegexParser.Octal_charContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.octal_digit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOctal_digit([NotNull] CommonRegexParser.Octal_digitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.octal_digit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOctal_digit([NotNull] CommonRegexParser.Octal_digitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.digits"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDigits([NotNull] CommonRegexParser.DigitsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.digits"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDigits([NotNull] CommonRegexParser.DigitsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.digit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDigit([NotNull] CommonRegexParser.DigitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.digit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDigit([NotNull] CommonRegexParser.DigitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterName([NotNull] CommonRegexParser.NameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitName([NotNull] CommonRegexParser.NameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.alpha_nums"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlpha_nums([NotNull] CommonRegexParser.Alpha_numsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.alpha_nums"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlpha_nums([NotNull] CommonRegexParser.Alpha_numsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.non_close_parens"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNon_close_parens([NotNull] CommonRegexParser.Non_close_parensContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.non_close_parens"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNon_close_parens([NotNull] CommonRegexParser.Non_close_parensContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.non_close_paren"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNon_close_paren([NotNull] CommonRegexParser.Non_close_parenContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.non_close_paren"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNon_close_paren([NotNull] CommonRegexParser.Non_close_parenContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CommonRegexParser.letter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLetter([NotNull] CommonRegexParser.LetterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CommonRegexParser.letter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLetter([NotNull] CommonRegexParser.LetterContext context);
}