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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IHelloListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6")]
[System.CLSCompliant(false)]
public partial class HelloBaseListener : IHelloListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="HelloParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProg([NotNull] HelloParser.ProgContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="HelloParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProg([NotNull] HelloParser.ProgContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>OtherEquality</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOtherEquality([NotNull] HelloParser.OtherEqualityContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>OtherEquality</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOtherEquality([NotNull] HelloParser.OtherEqualityContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParens([NotNull] HelloParser.ParensContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParens([NotNull] HelloParser.ParensContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Equals</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEquals([NotNull] HelloParser.EqualsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Equals</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEquals([NotNull] HelloParser.EqualsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Variable</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariable([NotNull] HelloParser.VariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Variable</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariable([NotNull] HelloParser.VariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Or</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOr([NotNull] HelloParser.OrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Or</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOr([NotNull] HelloParser.OrContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>null</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNull([NotNull] HelloParser.NullContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>null</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNull([NotNull] HelloParser.NullContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>StringLiteral</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStringLiteral([NotNull] HelloParser.StringLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>StringLiteral</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStringLiteral([NotNull] HelloParser.StringLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>MulDiv</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMulDiv([NotNull] HelloParser.MulDivContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>MulDiv</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMulDiv([NotNull] HelloParser.MulDivContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddSub([NotNull] HelloParser.AddSubContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddSub([NotNull] HelloParser.AddSubContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>And</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnd([NotNull] HelloParser.AndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>And</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnd([NotNull] HelloParser.AndContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInt([NotNull] HelloParser.IntContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInt([NotNull] HelloParser.IntContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NotEquals</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNotEquals([NotNull] HelloParser.NotEqualsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NotEquals</c>
	/// labeled alternative in <see cref="HelloParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNotEquals([NotNull] HelloParser.NotEqualsContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}