//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from DiceGrammarLexer.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Dice.Grammar {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class DiceGrammarLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T_IDENTIFIER=1, T_NUMBER=2, T_MACRO=3, T_EQUALS=4, T_GREATER=5, T_LESS=6, 
		T_GREATER_EQUALS=7, T_LESS_EQUALS=8, T_NOT_EQUALS=9, T_LPAREN=10, T_RPAREN=11, 
		T_LBRACE=12, T_RBRACE=13, T_COMMA=14, T_DOT=15, T_PLUS=16, T_MINUS=17, 
		T_MULTIPLY=18, T_DIVIDE=19, WS=20, T_FUDGE=21, T_D=22, T_KEEP_HIGH=23, 
		T_KEEP_LOW=24, T_DROP_HIGH=25, T_DROP_LOW=26, T_ADVANTAGE=27, T_DISADVANTAGE=28, 
		T_REROLL=29, T_REROLL_ONCE=30, T_EXPLODE=31, T_COMPOUND=32, T_PENETRATE=33, 
		T_CRIT=34, T_CRITFAIL=35, T_FAIL=36, T_SORT_ASC=37, T_SORT_DESC=38, AN_WS=39;
	public const int
		AFTER_NUMBER=1;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE", "AFTER_NUMBER"
	};

	public static readonly string[] ruleNames = {
		"T_IDENTIFIER", "T_NUMBER", "T_MACRO", "T_EQUALS", "T_GREATER", "T_LESS", 
		"T_GREATER_EQUALS", "T_LESS_EQUALS", "T_NOT_EQUALS", "T_LPAREN", "T_RPAREN", 
		"T_LBRACE", "T_RBRACE", "T_COMMA", "T_DOT", "T_PLUS", "T_MINUS", "T_MULTIPLY", 
		"T_DIVIDE", "WS", "AN_NUMBER", "AN_MACRO", "T_FUDGE", "T_D", "T_KEEP_HIGH", 
		"T_KEEP_LOW", "T_DROP_HIGH", "T_DROP_LOW", "T_ADVANTAGE", "T_DISADVANTAGE", 
		"T_REROLL", "T_REROLL_ONCE", "T_EXPLODE", "T_COMPOUND", "T_PENETRATE", 
		"T_CRIT", "T_CRITFAIL", "T_FAIL", "T_SORT_ASC", "T_SORT_DESC", "AN_EQUALS", 
		"AN_GREATER", "AN_LESS", "AN_GREATER_EQUALS", "AN_LESS_EQUALS", "AN_NOT_EQUALS", 
		"AN_LBRACE", "AN_RBRACE", "AN_COMMA", "AN_DOT", "AN_LPAREN", "AN_RPAREN", 
		"AN_PLUS", "AN_MINUS", "AN_MULTIPLY", "AN_DIVIDE", "AN_WS"
	};


	public DiceGrammarLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public DiceGrammarLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, "'F'", "'d'", "'kh'", 
		"'kl'", "'dh'", "'dl'", "'ad'", "'da'", "'rr'", "'ro'", "'!e'", "'!c'", 
		"'!p'", "'cs'", "'cf'", "'f'", "'sa'", "'sd'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "T_IDENTIFIER", "T_NUMBER", "T_MACRO", "T_EQUALS", "T_GREATER", 
		"T_LESS", "T_GREATER_EQUALS", "T_LESS_EQUALS", "T_NOT_EQUALS", "T_LPAREN", 
		"T_RPAREN", "T_LBRACE", "T_RBRACE", "T_COMMA", "T_DOT", "T_PLUS", "T_MINUS", 
		"T_MULTIPLY", "T_DIVIDE", "WS", "T_FUDGE", "T_D", "T_KEEP_HIGH", "T_KEEP_LOW", 
		"T_DROP_HIGH", "T_DROP_LOW", "T_ADVANTAGE", "T_DISADVANTAGE", "T_REROLL", 
		"T_REROLL_ONCE", "T_EXPLODE", "T_COMPOUND", "T_PENETRATE", "T_CRIT", "T_CRITFAIL", 
		"T_FAIL", "T_SORT_ASC", "T_SORT_DESC", "AN_WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "DiceGrammarLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static DiceGrammarLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', ')', '\x162', '\b', '\x1', '\b', '\x1', '\x4', '\x2', 
		'\t', '\x2', '\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', 
		'\x5', '\t', '\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', 
		'\x4', '\b', '\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', 
		'\x4', '\v', '\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', 
		'\x4', '\xE', '\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', 
		'\x10', '\x4', '\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', 
		'\x13', '\t', '\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', 
		'\x15', '\x4', '\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', 
		'\x18', '\t', '\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', 
		'\x1A', '\x4', '\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', 
		'\x1D', '\t', '\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', 
		'\x1F', '\x4', ' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', 
		'\"', '\x4', '#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', 
		'%', '\x4', '&', '\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', 
		'(', '\x4', ')', '\t', ')', '\x4', '*', '\t', '*', '\x4', '+', '\t', '+', 
		'\x4', ',', '\t', ',', '\x4', '-', '\t', '-', '\x4', '.', '\t', '.', '\x4', 
		'/', '\t', '/', '\x4', '\x30', '\t', '\x30', '\x4', '\x31', '\t', '\x31', 
		'\x4', '\x32', '\t', '\x32', '\x4', '\x33', '\t', '\x33', '\x4', '\x34', 
		'\t', '\x34', '\x4', '\x35', '\t', '\x35', '\x4', '\x36', '\t', '\x36', 
		'\x4', '\x37', '\t', '\x37', '\x4', '\x38', '\t', '\x38', '\x4', '\x39', 
		'\t', '\x39', '\x4', ':', '\t', ':', '\x3', '\x2', '\x3', '\x2', '\a', 
		'\x2', 'y', '\n', '\x2', '\f', '\x2', '\xE', '\x2', '|', '\v', '\x2', 
		'\x3', '\x3', '\x6', '\x3', '\x7F', '\n', '\x3', '\r', '\x3', '\xE', '\x3', 
		'\x80', '\x3', '\x3', '\x3', '\x3', '\x6', '\x3', '\x85', '\n', '\x3', 
		'\r', '\x3', '\xE', '\x3', '\x86', '\x5', '\x3', '\x89', '\n', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x6', '\x4', 
		'\x8F', '\n', '\x4', '\r', '\x4', '\xE', '\x4', '\x90', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x5', '\n', '\xA7', '\n', '\n', 
		'\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x6', '\x16', '\xC6', '\n', 
		'\x16', '\r', '\x16', '\xE', '\x16', '\xC7', '\x3', '\x16', '\x3', '\x16', 
		'\x6', '\x16', '\xCC', '\n', '\x16', '\r', '\x16', '\xE', '\x16', '\xCD', 
		'\x5', '\x16', '\xD0', '\n', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x17', '\x3', '\x17', '\x6', '\x17', '\xD6', '\n', '\x17', '\r', '\x17', 
		'\xE', '\x17', '\xD7', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', 
		'\x17', '\x3', '\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', 
		'\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3', '\x1B', '\x3', 
		'\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1D', '\x3', 
		'\x1D', '\x3', '\x1D', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', 
		'\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', ' ', 
		'\x3', '!', '\x3', '!', '\x3', '!', '\x3', '\"', '\x3', '\"', '\x3', '\"', 
		'\x3', '#', '\x3', '#', '\x3', '#', '\x3', '$', '\x3', '$', '\x3', '$', 
		'\x3', '%', '\x3', '%', '\x3', '%', '\x3', '&', '\x3', '&', '\x3', '&', 
		'\x3', '\'', '\x3', '\'', '\x3', '(', '\x3', '(', '\x3', '(', '\x3', ')', 
		'\x3', ')', '\x3', ')', '\x3', '*', '\x3', '*', '\x3', '*', '\x3', '*', 
		'\x3', '+', '\x3', '+', '\x3', '+', '\x3', '+', '\x3', ',', '\x3', ',', 
		'\x3', ',', '\x3', ',', '\x3', '-', '\x3', '-', '\x3', '-', '\x3', '-', 
		'\x3', '-', '\x3', '.', '\x3', '.', '\x3', '.', '\x3', '.', '\x3', '.', 
		'\x3', '/', '\x3', '/', '\x3', '/', '\x3', '/', '\x5', '/', '\x12B', '\n', 
		'/', '\x3', '/', '\x3', '/', '\x3', '\x30', '\x3', '\x30', '\x3', '\x30', 
		'\x3', '\x30', '\x3', '\x30', '\x3', '\x31', '\x3', '\x31', '\x3', '\x31', 
		'\x3', '\x31', '\x3', '\x32', '\x3', '\x32', '\x3', '\x32', '\x3', '\x32', 
		'\x3', '\x32', '\x3', '\x33', '\x3', '\x33', '\x3', '\x33', '\x3', '\x33', 
		'\x3', '\x33', '\x3', '\x34', '\x3', '\x34', '\x3', '\x34', '\x3', '\x34', 
		'\x3', '\x34', '\x3', '\x35', '\x3', '\x35', '\x3', '\x35', '\x3', '\x35', 
		'\x3', '\x36', '\x3', '\x36', '\x3', '\x36', '\x3', '\x36', '\x3', '\x36', 
		'\x3', '\x37', '\x3', '\x37', '\x3', '\x37', '\x3', '\x37', '\x3', '\x37', 
		'\x3', '\x38', '\x3', '\x38', '\x3', '\x38', '\x3', '\x38', '\x3', '\x38', 
		'\x3', '\x39', '\x3', '\x39', '\x3', '\x39', '\x3', '\x39', '\x3', '\x39', 
		'\x3', ':', '\x3', ':', '\x3', ':', '\x3', ':', '\x4', '\x90', '\xD7', 
		'\x2', ';', '\x4', '\x3', '\x6', '\x4', '\b', '\x5', '\n', '\x6', '\f', 
		'\a', '\xE', '\b', '\x10', '\t', '\x12', '\n', '\x14', '\v', '\x16', '\f', 
		'\x18', '\r', '\x1A', '\xE', '\x1C', '\xF', '\x1E', '\x10', ' ', '\x11', 
		'\"', '\x12', '$', '\x13', '&', '\x14', '(', '\x15', '*', '\x16', ',', 
		'\x2', '.', '\x2', '\x30', '\x17', '\x32', '\x18', '\x34', '\x19', '\x36', 
		'\x1A', '\x38', '\x1B', ':', '\x1C', '<', '\x1D', '>', '\x1E', '@', '\x1F', 
		'\x42', ' ', '\x44', '!', '\x46', '\"', 'H', '#', 'J', '$', 'L', '%', 
		'N', '&', 'P', '\'', 'R', '(', 'T', '\x2', 'V', '\x2', 'X', '\x2', 'Z', 
		'\x2', '\\', '\x2', '^', '\x2', '`', '\x2', '\x62', '\x2', '\x64', '\x2', 
		'\x66', '\x2', 'h', '\x2', 'j', '\x2', 'l', '\x2', 'n', '\x2', 'p', '\x2', 
		'r', '\x2', 't', ')', '\x4', '\x2', '\x3', '\x6', '\x4', '\x2', '\x43', 
		'\\', '\x63', '|', '\x5', '\x2', '\x32', ';', '\x43', '\\', '\x63', '|', 
		'\x3', '\x2', '\x32', ';', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', 
		'\"', '\x2', '\x16B', '\x2', '\x4', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x6', '\x3', '\x2', '\x2', '\x2', '\x2', '\b', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\n', '\x3', '\x2', '\x2', '\x2', '\x2', '\f', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\xE', '\x3', '\x2', '\x2', '\x2', '\x2', '\x10', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x12', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x14', '\x3', '\x2', '\x2', '\x2', '\x2', '\x16', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x18', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1A', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1E', '\x3', '\x2', '\x2', '\x2', '\x2', ' ', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\"', '\x3', '\x2', '\x2', '\x2', '\x2', '$', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '&', '\x3', '\x2', '\x2', '\x2', '\x2', '(', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '*', '\x3', '\x2', '\x2', '\x2', '\x3', ',', '\x3', 
		'\x2', '\x2', '\x2', '\x3', '.', '\x3', '\x2', '\x2', '\x2', '\x3', '\x30', 
		'\x3', '\x2', '\x2', '\x2', '\x3', '\x32', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '\x34', '\x3', '\x2', '\x2', '\x2', '\x3', '\x36', '\x3', '\x2', 
		'\x2', '\x2', '\x3', '\x38', '\x3', '\x2', '\x2', '\x2', '\x3', ':', '\x3', 
		'\x2', '\x2', '\x2', '\x3', '<', '\x3', '\x2', '\x2', '\x2', '\x3', '>', 
		'\x3', '\x2', '\x2', '\x2', '\x3', '@', '\x3', '\x2', '\x2', '\x2', '\x3', 
		'\x42', '\x3', '\x2', '\x2', '\x2', '\x3', '\x44', '\x3', '\x2', '\x2', 
		'\x2', '\x3', '\x46', '\x3', '\x2', '\x2', '\x2', '\x3', 'H', '\x3', '\x2', 
		'\x2', '\x2', '\x3', 'J', '\x3', '\x2', '\x2', '\x2', '\x3', 'L', '\x3', 
		'\x2', '\x2', '\x2', '\x3', 'N', '\x3', '\x2', '\x2', '\x2', '\x3', 'P', 
		'\x3', '\x2', '\x2', '\x2', '\x3', 'R', '\x3', '\x2', '\x2', '\x2', '\x3', 
		'T', '\x3', '\x2', '\x2', '\x2', '\x3', 'V', '\x3', '\x2', '\x2', '\x2', 
		'\x3', 'X', '\x3', '\x2', '\x2', '\x2', '\x3', 'Z', '\x3', '\x2', '\x2', 
		'\x2', '\x3', '\\', '\x3', '\x2', '\x2', '\x2', '\x3', '^', '\x3', '\x2', 
		'\x2', '\x2', '\x3', '`', '\x3', '\x2', '\x2', '\x2', '\x3', '\x62', '\x3', 
		'\x2', '\x2', '\x2', '\x3', '\x64', '\x3', '\x2', '\x2', '\x2', '\x3', 
		'\x66', '\x3', '\x2', '\x2', '\x2', '\x3', 'h', '\x3', '\x2', '\x2', '\x2', 
		'\x3', 'j', '\x3', '\x2', '\x2', '\x2', '\x3', 'l', '\x3', '\x2', '\x2', 
		'\x2', '\x3', 'n', '\x3', '\x2', '\x2', '\x2', '\x3', 'p', '\x3', '\x2', 
		'\x2', '\x2', '\x3', 'r', '\x3', '\x2', '\x2', '\x2', '\x3', 't', '\x3', 
		'\x2', '\x2', '\x2', '\x4', 'v', '\x3', '\x2', '\x2', '\x2', '\x6', '~', 
		'\x3', '\x2', '\x2', '\x2', '\b', '\x8C', '\x3', '\x2', '\x2', '\x2', 
		'\n', '\x96', '\x3', '\x2', '\x2', '\x2', '\f', '\x98', '\x3', '\x2', 
		'\x2', '\x2', '\xE', '\x9A', '\x3', '\x2', '\x2', '\x2', '\x10', '\x9C', 
		'\x3', '\x2', '\x2', '\x2', '\x12', '\x9F', '\x3', '\x2', '\x2', '\x2', 
		'\x14', '\xA6', '\x3', '\x2', '\x2', '\x2', '\x16', '\xA8', '\x3', '\x2', 
		'\x2', '\x2', '\x18', '\xAA', '\x3', '\x2', '\x2', '\x2', '\x1A', '\xAE', 
		'\x3', '\x2', '\x2', '\x2', '\x1C', '\xB0', '\x3', '\x2', '\x2', '\x2', 
		'\x1E', '\xB4', '\x3', '\x2', '\x2', '\x2', ' ', '\xB6', '\x3', '\x2', 
		'\x2', '\x2', '\"', '\xB8', '\x3', '\x2', '\x2', '\x2', '$', '\xBA', '\x3', 
		'\x2', '\x2', '\x2', '&', '\xBC', '\x3', '\x2', '\x2', '\x2', '(', '\xBE', 
		'\x3', '\x2', '\x2', '\x2', '*', '\xC0', '\x3', '\x2', '\x2', '\x2', ',', 
		'\xC5', '\x3', '\x2', '\x2', '\x2', '.', '\xD3', '\x3', '\x2', '\x2', 
		'\x2', '\x30', '\xDD', '\x3', '\x2', '\x2', '\x2', '\x32', '\xDF', '\x3', 
		'\x2', '\x2', '\x2', '\x34', '\xE1', '\x3', '\x2', '\x2', '\x2', '\x36', 
		'\xE4', '\x3', '\x2', '\x2', '\x2', '\x38', '\xE7', '\x3', '\x2', '\x2', 
		'\x2', ':', '\xEA', '\x3', '\x2', '\x2', '\x2', '<', '\xED', '\x3', '\x2', 
		'\x2', '\x2', '>', '\xF0', '\x3', '\x2', '\x2', '\x2', '@', '\xF3', '\x3', 
		'\x2', '\x2', '\x2', '\x42', '\xF6', '\x3', '\x2', '\x2', '\x2', '\x44', 
		'\xF9', '\x3', '\x2', '\x2', '\x2', '\x46', '\xFC', '\x3', '\x2', '\x2', 
		'\x2', 'H', '\xFF', '\x3', '\x2', '\x2', '\x2', 'J', '\x102', '\x3', '\x2', 
		'\x2', '\x2', 'L', '\x105', '\x3', '\x2', '\x2', '\x2', 'N', '\x108', 
		'\x3', '\x2', '\x2', '\x2', 'P', '\x10A', '\x3', '\x2', '\x2', '\x2', 
		'R', '\x10D', '\x3', '\x2', '\x2', '\x2', 'T', '\x110', '\x3', '\x2', 
		'\x2', '\x2', 'V', '\x114', '\x3', '\x2', '\x2', '\x2', 'X', '\x118', 
		'\x3', '\x2', '\x2', '\x2', 'Z', '\x11C', '\x3', '\x2', '\x2', '\x2', 
		'\\', '\x121', '\x3', '\x2', '\x2', '\x2', '^', '\x12A', '\x3', '\x2', 
		'\x2', '\x2', '`', '\x12E', '\x3', '\x2', '\x2', '\x2', '\x62', '\x133', 
		'\x3', '\x2', '\x2', '\x2', '\x64', '\x137', '\x3', '\x2', '\x2', '\x2', 
		'\x66', '\x13C', '\x3', '\x2', '\x2', '\x2', 'h', '\x141', '\x3', '\x2', 
		'\x2', '\x2', 'j', '\x146', '\x3', '\x2', '\x2', '\x2', 'l', '\x14A', 
		'\x3', '\x2', '\x2', '\x2', 'n', '\x14F', '\x3', '\x2', '\x2', '\x2', 
		'p', '\x154', '\x3', '\x2', '\x2', '\x2', 'r', '\x159', '\x3', '\x2', 
		'\x2', '\x2', 't', '\x15E', '\x3', '\x2', '\x2', '\x2', 'v', 'z', '\t', 
		'\x2', '\x2', '\x2', 'w', 'y', '\t', '\x3', '\x2', '\x2', 'x', 'w', '\x3', 
		'\x2', '\x2', '\x2', 'y', '|', '\x3', '\x2', '\x2', '\x2', 'z', 'x', '\x3', 
		'\x2', '\x2', '\x2', 'z', '{', '\x3', '\x2', '\x2', '\x2', '{', '\x5', 
		'\x3', '\x2', '\x2', '\x2', '|', 'z', '\x3', '\x2', '\x2', '\x2', '}', 
		'\x7F', '\t', '\x4', '\x2', '\x2', '~', '}', '\x3', '\x2', '\x2', '\x2', 
		'\x7F', '\x80', '\x3', '\x2', '\x2', '\x2', '\x80', '~', '\x3', '\x2', 
		'\x2', '\x2', '\x80', '\x81', '\x3', '\x2', '\x2', '\x2', '\x81', '\x88', 
		'\x3', '\x2', '\x2', '\x2', '\x82', '\x84', '\a', '\x30', '\x2', '\x2', 
		'\x83', '\x85', '\t', '\x4', '\x2', '\x2', '\x84', '\x83', '\x3', '\x2', 
		'\x2', '\x2', '\x85', '\x86', '\x3', '\x2', '\x2', '\x2', '\x86', '\x84', 
		'\x3', '\x2', '\x2', '\x2', '\x86', '\x87', '\x3', '\x2', '\x2', '\x2', 
		'\x87', '\x89', '\x3', '\x2', '\x2', '\x2', '\x88', '\x82', '\x3', '\x2', 
		'\x2', '\x2', '\x88', '\x89', '\x3', '\x2', '\x2', '\x2', '\x89', '\x8A', 
		'\x3', '\x2', '\x2', '\x2', '\x8A', '\x8B', '\b', '\x3', '\x2', '\x2', 
		'\x8B', '\a', '\x3', '\x2', '\x2', '\x2', '\x8C', '\x8E', '\a', ']', '\x2', 
		'\x2', '\x8D', '\x8F', '\v', '\x2', '\x2', '\x2', '\x8E', '\x8D', '\x3', 
		'\x2', '\x2', '\x2', '\x8F', '\x90', '\x3', '\x2', '\x2', '\x2', '\x90', 
		'\x91', '\x3', '\x2', '\x2', '\x2', '\x90', '\x8E', '\x3', '\x2', '\x2', 
		'\x2', '\x91', '\x92', '\x3', '\x2', '\x2', '\x2', '\x92', '\x93', '\a', 
		'_', '\x2', '\x2', '\x93', '\x94', '\x3', '\x2', '\x2', '\x2', '\x94', 
		'\x95', '\b', '\x4', '\x2', '\x2', '\x95', '\t', '\x3', '\x2', '\x2', 
		'\x2', '\x96', '\x97', '\a', '?', '\x2', '\x2', '\x97', '\v', '\x3', '\x2', 
		'\x2', '\x2', '\x98', '\x99', '\a', '@', '\x2', '\x2', '\x99', '\r', '\x3', 
		'\x2', '\x2', '\x2', '\x9A', '\x9B', '\a', '>', '\x2', '\x2', '\x9B', 
		'\xF', '\x3', '\x2', '\x2', '\x2', '\x9C', '\x9D', '\a', '@', '\x2', '\x2', 
		'\x9D', '\x9E', '\a', '?', '\x2', '\x2', '\x9E', '\x11', '\x3', '\x2', 
		'\x2', '\x2', '\x9F', '\xA0', '\a', '>', '\x2', '\x2', '\xA0', '\xA1', 
		'\a', '?', '\x2', '\x2', '\xA1', '\x13', '\x3', '\x2', '\x2', '\x2', '\xA2', 
		'\xA3', '\a', '#', '\x2', '\x2', '\xA3', '\xA7', '\a', '?', '\x2', '\x2', 
		'\xA4', '\xA5', '\a', '>', '\x2', '\x2', '\xA5', '\xA7', '\a', '@', '\x2', 
		'\x2', '\xA6', '\xA2', '\x3', '\x2', '\x2', '\x2', '\xA6', '\xA4', '\x3', 
		'\x2', '\x2', '\x2', '\xA7', '\x15', '\x3', '\x2', '\x2', '\x2', '\xA8', 
		'\xA9', '\a', '*', '\x2', '\x2', '\xA9', '\x17', '\x3', '\x2', '\x2', 
		'\x2', '\xAA', '\xAB', '\a', '+', '\x2', '\x2', '\xAB', '\xAC', '\x3', 
		'\x2', '\x2', '\x2', '\xAC', '\xAD', '\b', '\f', '\x2', '\x2', '\xAD', 
		'\x19', '\x3', '\x2', '\x2', '\x2', '\xAE', '\xAF', '\a', '}', '\x2', 
		'\x2', '\xAF', '\x1B', '\x3', '\x2', '\x2', '\x2', '\xB0', '\xB1', '\a', 
		'\x7F', '\x2', '\x2', '\xB1', '\xB2', '\x3', '\x2', '\x2', '\x2', '\xB2', 
		'\xB3', '\b', '\xE', '\x2', '\x2', '\xB3', '\x1D', '\x3', '\x2', '\x2', 
		'\x2', '\xB4', '\xB5', '\a', '.', '\x2', '\x2', '\xB5', '\x1F', '\x3', 
		'\x2', '\x2', '\x2', '\xB6', '\xB7', '\a', '\x30', '\x2', '\x2', '\xB7', 
		'!', '\x3', '\x2', '\x2', '\x2', '\xB8', '\xB9', '\a', '-', '\x2', '\x2', 
		'\xB9', '#', '\x3', '\x2', '\x2', '\x2', '\xBA', '\xBB', '\a', '/', '\x2', 
		'\x2', '\xBB', '%', '\x3', '\x2', '\x2', '\x2', '\xBC', '\xBD', '\a', 
		',', '\x2', '\x2', '\xBD', '\'', '\x3', '\x2', '\x2', '\x2', '\xBE', '\xBF', 
		'\a', '\x31', '\x2', '\x2', '\xBF', ')', '\x3', '\x2', '\x2', '\x2', '\xC0', 
		'\xC1', '\t', '\x5', '\x2', '\x2', '\xC1', '\xC2', '\x3', '\x2', '\x2', 
		'\x2', '\xC2', '\xC3', '\b', '\x15', '\x3', '\x2', '\xC3', '+', '\x3', 
		'\x2', '\x2', '\x2', '\xC4', '\xC6', '\t', '\x4', '\x2', '\x2', '\xC5', 
		'\xC4', '\x3', '\x2', '\x2', '\x2', '\xC6', '\xC7', '\x3', '\x2', '\x2', 
		'\x2', '\xC7', '\xC5', '\x3', '\x2', '\x2', '\x2', '\xC7', '\xC8', '\x3', 
		'\x2', '\x2', '\x2', '\xC8', '\xCF', '\x3', '\x2', '\x2', '\x2', '\xC9', 
		'\xCB', '\a', '\x30', '\x2', '\x2', '\xCA', '\xCC', '\t', '\x4', '\x2', 
		'\x2', '\xCB', '\xCA', '\x3', '\x2', '\x2', '\x2', '\xCC', '\xCD', '\x3', 
		'\x2', '\x2', '\x2', '\xCD', '\xCB', '\x3', '\x2', '\x2', '\x2', '\xCD', 
		'\xCE', '\x3', '\x2', '\x2', '\x2', '\xCE', '\xD0', '\x3', '\x2', '\x2', 
		'\x2', '\xCF', '\xC9', '\x3', '\x2', '\x2', '\x2', '\xCF', '\xD0', '\x3', 
		'\x2', '\x2', '\x2', '\xD0', '\xD1', '\x3', '\x2', '\x2', '\x2', '\xD1', 
		'\xD2', '\b', '\x16', '\x4', '\x2', '\xD2', '-', '\x3', '\x2', '\x2', 
		'\x2', '\xD3', '\xD5', '\a', ']', '\x2', '\x2', '\xD4', '\xD6', '\v', 
		'\x2', '\x2', '\x2', '\xD5', '\xD4', '\x3', '\x2', '\x2', '\x2', '\xD6', 
		'\xD7', '\x3', '\x2', '\x2', '\x2', '\xD7', '\xD8', '\x3', '\x2', '\x2', 
		'\x2', '\xD7', '\xD5', '\x3', '\x2', '\x2', '\x2', '\xD8', '\xD9', '\x3', 
		'\x2', '\x2', '\x2', '\xD9', '\xDA', '\a', '_', '\x2', '\x2', '\xDA', 
		'\xDB', '\x3', '\x2', '\x2', '\x2', '\xDB', '\xDC', '\b', '\x17', '\x5', 
		'\x2', '\xDC', '/', '\x3', '\x2', '\x2', '\x2', '\xDD', '\xDE', '\a', 
		'H', '\x2', '\x2', '\xDE', '\x31', '\x3', '\x2', '\x2', '\x2', '\xDF', 
		'\xE0', '\a', '\x66', '\x2', '\x2', '\xE0', '\x33', '\x3', '\x2', '\x2', 
		'\x2', '\xE1', '\xE2', '\a', 'm', '\x2', '\x2', '\xE2', '\xE3', '\a', 
		'j', '\x2', '\x2', '\xE3', '\x35', '\x3', '\x2', '\x2', '\x2', '\xE4', 
		'\xE5', '\a', 'm', '\x2', '\x2', '\xE5', '\xE6', '\a', 'n', '\x2', '\x2', 
		'\xE6', '\x37', '\x3', '\x2', '\x2', '\x2', '\xE7', '\xE8', '\a', '\x66', 
		'\x2', '\x2', '\xE8', '\xE9', '\a', 'j', '\x2', '\x2', '\xE9', '\x39', 
		'\x3', '\x2', '\x2', '\x2', '\xEA', '\xEB', '\a', '\x66', '\x2', '\x2', 
		'\xEB', '\xEC', '\a', 'n', '\x2', '\x2', '\xEC', ';', '\x3', '\x2', '\x2', 
		'\x2', '\xED', '\xEE', '\a', '\x63', '\x2', '\x2', '\xEE', '\xEF', '\a', 
		'\x66', '\x2', '\x2', '\xEF', '=', '\x3', '\x2', '\x2', '\x2', '\xF0', 
		'\xF1', '\a', '\x66', '\x2', '\x2', '\xF1', '\xF2', '\a', '\x63', '\x2', 
		'\x2', '\xF2', '?', '\x3', '\x2', '\x2', '\x2', '\xF3', '\xF4', '\a', 
		't', '\x2', '\x2', '\xF4', '\xF5', '\a', 't', '\x2', '\x2', '\xF5', '\x41', 
		'\x3', '\x2', '\x2', '\x2', '\xF6', '\xF7', '\a', 't', '\x2', '\x2', '\xF7', 
		'\xF8', '\a', 'q', '\x2', '\x2', '\xF8', '\x43', '\x3', '\x2', '\x2', 
		'\x2', '\xF9', '\xFA', '\a', '#', '\x2', '\x2', '\xFA', '\xFB', '\a', 
		'g', '\x2', '\x2', '\xFB', '\x45', '\x3', '\x2', '\x2', '\x2', '\xFC', 
		'\xFD', '\a', '#', '\x2', '\x2', '\xFD', '\xFE', '\a', '\x65', '\x2', 
		'\x2', '\xFE', 'G', '\x3', '\x2', '\x2', '\x2', '\xFF', '\x100', '\a', 
		'#', '\x2', '\x2', '\x100', '\x101', '\a', 'r', '\x2', '\x2', '\x101', 
		'I', '\x3', '\x2', '\x2', '\x2', '\x102', '\x103', '\a', '\x65', '\x2', 
		'\x2', '\x103', '\x104', '\a', 'u', '\x2', '\x2', '\x104', 'K', '\x3', 
		'\x2', '\x2', '\x2', '\x105', '\x106', '\a', '\x65', '\x2', '\x2', '\x106', 
		'\x107', '\a', 'h', '\x2', '\x2', '\x107', 'M', '\x3', '\x2', '\x2', '\x2', 
		'\x108', '\x109', '\a', 'h', '\x2', '\x2', '\x109', 'O', '\x3', '\x2', 
		'\x2', '\x2', '\x10A', '\x10B', '\a', 'u', '\x2', '\x2', '\x10B', '\x10C', 
		'\a', '\x63', '\x2', '\x2', '\x10C', 'Q', '\x3', '\x2', '\x2', '\x2', 
		'\x10D', '\x10E', '\a', 'u', '\x2', '\x2', '\x10E', '\x10F', '\a', '\x66', 
		'\x2', '\x2', '\x10F', 'S', '\x3', '\x2', '\x2', '\x2', '\x110', '\x111', 
		'\a', '?', '\x2', '\x2', '\x111', '\x112', '\x3', '\x2', '\x2', '\x2', 
		'\x112', '\x113', '\b', '*', '\x6', '\x2', '\x113', 'U', '\x3', '\x2', 
		'\x2', '\x2', '\x114', '\x115', '\a', '@', '\x2', '\x2', '\x115', '\x116', 
		'\x3', '\x2', '\x2', '\x2', '\x116', '\x117', '\b', '+', '\a', '\x2', 
		'\x117', 'W', '\x3', '\x2', '\x2', '\x2', '\x118', '\x119', '\a', '>', 
		'\x2', '\x2', '\x119', '\x11A', '\x3', '\x2', '\x2', '\x2', '\x11A', '\x11B', 
		'\b', ',', '\b', '\x2', '\x11B', 'Y', '\x3', '\x2', '\x2', '\x2', '\x11C', 
		'\x11D', '\a', '@', '\x2', '\x2', '\x11D', '\x11E', '\a', '?', '\x2', 
		'\x2', '\x11E', '\x11F', '\x3', '\x2', '\x2', '\x2', '\x11F', '\x120', 
		'\b', '-', '\t', '\x2', '\x120', '[', '\x3', '\x2', '\x2', '\x2', '\x121', 
		'\x122', '\a', '>', '\x2', '\x2', '\x122', '\x123', '\a', '?', '\x2', 
		'\x2', '\x123', '\x124', '\x3', '\x2', '\x2', '\x2', '\x124', '\x125', 
		'\b', '.', '\n', '\x2', '\x125', ']', '\x3', '\x2', '\x2', '\x2', '\x126', 
		'\x127', '\a', '#', '\x2', '\x2', '\x127', '\x12B', '\a', '?', '\x2', 
		'\x2', '\x128', '\x129', '\a', '>', '\x2', '\x2', '\x129', '\x12B', '\a', 
		'@', '\x2', '\x2', '\x12A', '\x126', '\x3', '\x2', '\x2', '\x2', '\x12A', 
		'\x128', '\x3', '\x2', '\x2', '\x2', '\x12B', '\x12C', '\x3', '\x2', '\x2', 
		'\x2', '\x12C', '\x12D', '\b', '/', '\v', '\x2', '\x12D', '_', '\x3', 
		'\x2', '\x2', '\x2', '\x12E', '\x12F', '\a', '}', '\x2', '\x2', '\x12F', 
		'\x130', '\x3', '\x2', '\x2', '\x2', '\x130', '\x131', '\b', '\x30', '\f', 
		'\x2', '\x131', '\x132', '\b', '\x30', '\r', '\x2', '\x132', '\x61', '\x3', 
		'\x2', '\x2', '\x2', '\x133', '\x134', '\a', '\x7F', '\x2', '\x2', '\x134', 
		'\x135', '\x3', '\x2', '\x2', '\x2', '\x135', '\x136', '\b', '\x31', '\xE', 
		'\x2', '\x136', '\x63', '\x3', '\x2', '\x2', '\x2', '\x137', '\x138', 
		'\a', '.', '\x2', '\x2', '\x138', '\x139', '\x3', '\x2', '\x2', '\x2', 
		'\x139', '\x13A', '\b', '\x32', '\f', '\x2', '\x13A', '\x13B', '\b', '\x32', 
		'\xF', '\x2', '\x13B', '\x65', '\x3', '\x2', '\x2', '\x2', '\x13C', '\x13D', 
		'\a', '\x30', '\x2', '\x2', '\x13D', '\x13E', '\x3', '\x2', '\x2', '\x2', 
		'\x13E', '\x13F', '\b', '\x33', '\f', '\x2', '\x13F', '\x140', '\b', '\x33', 
		'\x10', '\x2', '\x140', 'g', '\x3', '\x2', '\x2', '\x2', '\x141', '\x142', 
		'\a', '*', '\x2', '\x2', '\x142', '\x143', '\x3', '\x2', '\x2', '\x2', 
		'\x143', '\x144', '\b', '\x34', '\f', '\x2', '\x144', '\x145', '\b', '\x34', 
		'\x11', '\x2', '\x145', 'i', '\x3', '\x2', '\x2', '\x2', '\x146', '\x147', 
		'\a', '+', '\x2', '\x2', '\x147', '\x148', '\x3', '\x2', '\x2', '\x2', 
		'\x148', '\x149', '\b', '\x35', '\x12', '\x2', '\x149', 'k', '\x3', '\x2', 
		'\x2', '\x2', '\x14A', '\x14B', '\a', '-', '\x2', '\x2', '\x14B', '\x14C', 
		'\x3', '\x2', '\x2', '\x2', '\x14C', '\x14D', '\b', '\x36', '\f', '\x2', 
		'\x14D', '\x14E', '\b', '\x36', '\x13', '\x2', '\x14E', 'm', '\x3', '\x2', 
		'\x2', '\x2', '\x14F', '\x150', '\a', '/', '\x2', '\x2', '\x150', '\x151', 
		'\x3', '\x2', '\x2', '\x2', '\x151', '\x152', '\b', '\x37', '\f', '\x2', 
		'\x152', '\x153', '\b', '\x37', '\x14', '\x2', '\x153', 'o', '\x3', '\x2', 
		'\x2', '\x2', '\x154', '\x155', '\a', ',', '\x2', '\x2', '\x155', '\x156', 
		'\x3', '\x2', '\x2', '\x2', '\x156', '\x157', '\b', '\x38', '\f', '\x2', 
		'\x157', '\x158', '\b', '\x38', '\x15', '\x2', '\x158', 'q', '\x3', '\x2', 
		'\x2', '\x2', '\x159', '\x15A', '\a', '\x31', '\x2', '\x2', '\x15A', '\x15B', 
		'\x3', '\x2', '\x2', '\x2', '\x15B', '\x15C', '\b', '\x39', '\f', '\x2', 
		'\x15C', '\x15D', '\b', '\x39', '\x16', '\x2', '\x15D', 's', '\x3', '\x2', 
		'\x2', '\x2', '\x15E', '\x15F', '\t', '\x5', '\x2', '\x2', '\x15F', '\x160', 
		'\x3', '\x2', '\x2', '\x2', '\x160', '\x161', '\b', ':', '\x3', '\x2', 
		'\x161', 'u', '\x3', '\x2', '\x2', '\x2', '\xF', '\x2', '\x3', 'z', '\x80', 
		'\x86', '\x88', '\x90', '\xA6', '\xC7', '\xCD', '\xCF', '\xD7', '\x12A', 
		'\x17', '\a', '\x3', '\x2', '\b', '\x2', '\x2', '\t', '\x4', '\x2', '\t', 
		'\x5', '\x2', '\t', '\x6', '\x2', '\t', '\a', '\x2', '\t', '\b', '\x2', 
		'\t', '\t', '\x2', '\t', '\n', '\x2', '\t', '\v', '\x2', '\x6', '\x2', 
		'\x2', '\t', '\xE', '\x2', '\t', '\xF', '\x2', '\t', '\x10', '\x2', '\t', 
		'\x11', '\x2', '\t', '\f', '\x2', '\t', '\r', '\x2', '\t', '\x12', '\x2', 
		'\t', '\x13', '\x2', '\t', '\x14', '\x2', '\t', '\x15', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Dice.Grammar