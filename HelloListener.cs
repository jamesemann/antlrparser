//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\tdbots\techdays\ConsoleApplication2\Antlrtest\\Hello.g4 by ANTLR 4.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="HelloParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6")]
[System.CLSCompliant(false)]
public interface IHelloListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="HelloParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProg([NotNull] HelloParser.ProgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="HelloParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProg([NotNull] HelloParser.ProgContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>OtherEquality</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOtherEquality([NotNull] HelloParser.OtherEqualityContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>OtherEquality</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOtherEquality([NotNull] HelloParser.OtherEqualityContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParens([NotNull] HelloParser.ParensContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParens([NotNull] HelloParser.ParensContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Equals</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEquals([NotNull] HelloParser.EqualsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Equals</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEquals([NotNull] HelloParser.EqualsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Variable</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable([NotNull] HelloParser.VariableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Variable</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable([NotNull] HelloParser.VariableContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Or</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOr([NotNull] HelloParser.OrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Or</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOr([NotNull] HelloParser.OrContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>null</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNull([NotNull] HelloParser.NullContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>null</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNull([NotNull] HelloParser.NullContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>StringLiteral</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStringLiteral([NotNull] HelloParser.StringLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>StringLiteral</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStringLiteral([NotNull] HelloParser.StringLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>MulDiv</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMulDiv([NotNull] HelloParser.MulDivContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MulDiv</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMulDiv([NotNull] HelloParser.MulDivContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddSub([NotNull] HelloParser.AddSubContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddSub([NotNull] HelloParser.AddSubContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>And</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnd([NotNull] HelloParser.AndContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>And</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnd([NotNull] HelloParser.AndContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInt([NotNull] HelloParser.IntContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInt([NotNull] HelloParser.IntContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NotEquals</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotEquals([NotNull] HelloParser.NotEqualsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NotEquals</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotEquals([NotNull] HelloParser.NotEqualsContext context);
}