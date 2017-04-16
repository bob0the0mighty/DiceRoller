//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from DiceGrammar.g4 by ANTLR 4.7

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
		T_NUMBER=1, T_IDENTIFIER=2, T_STRING=3, T_D=4, T_FUDGE=5, T_KEEP_HIGH=6, 
		T_KEEP_LOW=7, T_DROP_HIGH=8, T_DROP_LOW=9, T_ADVANTAGE=10, T_DISADVANTAGE=11, 
		T_REROLL=12, T_REROLL_ONCE=13, T_EXPLODE=14, T_COMPOUND=15, T_PENETRATE=16, 
		T_CRIT=17, T_CRITFAIL=18, T_FAIL=19, T_SORT_ASC=20, T_SORT_DESC=21, T_EQUALS=22, 
		T_GREATER=23, T_LESS=24, T_GREATER_EQUALS=25, T_LESS_EQUALS=26, T_NOT_EQUALS=27, 
		T_LBRACE=28, T_RBRACE=29, T_LSQUARE=30, T_RSQUARE=31, T_COMMA=32, T_DOT=33, 
		T_LPAREN=34, T_RPAREN=35, T_PLUS=36, T_MINUS=37, T_MULTIPLY=38, T_DIVIDE=39, 
		WS=40;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T_NUMBER", "T_IDENTIFIER", "T_STRING", "T_D", "T_FUDGE", "T_KEEP_HIGH", 
		"T_KEEP_LOW", "T_DROP_HIGH", "T_DROP_LOW", "T_ADVANTAGE", "T_DISADVANTAGE", 
		"T_REROLL", "T_REROLL_ONCE", "T_EXPLODE", "T_COMPOUND", "T_PENETRATE", 
		"T_CRIT", "T_CRITFAIL", "T_FAIL", "T_SORT_ASC", "T_SORT_DESC", "T_EQUALS", 
		"T_GREATER", "T_LESS", "T_GREATER_EQUALS", "T_LESS_EQUALS", "T_NOT_EQUALS", 
		"T_LBRACE", "T_RBRACE", "T_LSQUARE", "T_RSQUARE", "T_COMMA", "T_DOT", 
		"T_LPAREN", "T_RPAREN", "T_PLUS", "T_MINUS", "T_MULTIPLY", "T_DIVIDE", 
		"WS"
	};


	public DiceGrammarLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public DiceGrammarLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, "'d'", "'F'", "'kh'", "'kl'", "'dh'", "'dl'", 
		"'ad'", "'da'", "'rr'", "'ro'", "'!e'", "'!c'", "'!p'", "'cs'", "'cf'", 
		"'f'", "'sa'", "'sd'", "'='", "'>'", "'<'", "'>='", "'<='", null, "'{'", 
		"'}'", "'['", "']'", "','", "'.'", "'('", "')'", "'+'", "'-'", "'*'", 
		"'/'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "T_NUMBER", "T_IDENTIFIER", "T_STRING", "T_D", "T_FUDGE", "T_KEEP_HIGH", 
		"T_KEEP_LOW", "T_DROP_HIGH", "T_DROP_LOW", "T_ADVANTAGE", "T_DISADVANTAGE", 
		"T_REROLL", "T_REROLL_ONCE", "T_EXPLODE", "T_COMPOUND", "T_PENETRATE", 
		"T_CRIT", "T_CRITFAIL", "T_FAIL", "T_SORT_ASC", "T_SORT_DESC", "T_EQUALS", 
		"T_GREATER", "T_LESS", "T_GREATER_EQUALS", "T_LESS_EQUALS", "T_NOT_EQUALS", 
		"T_LBRACE", "T_RBRACE", "T_LSQUARE", "T_RSQUARE", "T_COMMA", "T_DOT", 
		"T_LPAREN", "T_RPAREN", "T_PLUS", "T_MINUS", "T_MULTIPLY", "T_DIVIDE", 
		"WS"
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

	public override string GrammarFileName { get { return "DiceGrammar.g4"; } }

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
		'\x5964', '\x2', '*', '\xD0', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', 
		'\t', ')', '\x3', '\x2', '\x5', '\x2', 'U', '\n', '\x2', '\x3', '\x2', 
		'\x6', '\x2', 'X', '\n', '\x2', '\r', '\x2', '\xE', '\x2', 'Y', '\x3', 
		'\x2', '\x3', '\x2', '\x6', '\x2', '^', '\n', '\x2', '\r', '\x2', '\xE', 
		'\x2', '_', '\x5', '\x2', '\x62', '\n', '\x2', '\x3', '\x3', '\x3', '\x3', 
		'\a', '\x3', '\x66', '\n', '\x3', '\f', '\x3', '\xE', '\x3', 'i', '\v', 
		'\x3', '\x3', '\x4', '\x6', '\x4', 'l', '\n', '\x4', '\r', '\x4', '\xE', 
		'\x4', 'm', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', 
		'\x13', '\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', 
		'\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x17', '\x3', '\x17', '\x3', '\x18', '\x3', '\x18', '\x3', '\x19', '\x3', 
		'\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3', 
		'\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', 
		'\x1C', '\x5', '\x1C', '\xB3', '\n', '\x1C', '\x3', '\x1D', '\x3', '\x1D', 
		'\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1F', '\x3', '\x1F', '\x3', ' ', 
		'\x3', ' ', '\x3', '!', '\x3', '!', '\x3', '\"', '\x3', '\"', '\x3', '#', 
		'\x3', '#', '\x3', '$', '\x3', '$', '\x3', '%', '\x3', '%', '\x3', '&', 
		'\x3', '&', '\x3', '\'', '\x3', '\'', '\x3', '(', '\x3', '(', '\x3', ')', 
		'\x3', ')', '\x3', ')', '\x3', ')', '\x2', '\x2', '*', '\x3', '\x3', '\x5', 
		'\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', 
		'\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', 
		'\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13', 
		'%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', '/', 
		'\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x1D', 
		'\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', '\"', '\x43', 
		'#', '\x45', '$', 'G', '%', 'I', '&', 'K', '\'', 'M', '(', 'O', ')', 'Q', 
		'*', '\x3', '\x2', '\a', '\x3', '\x2', '\x32', ';', '\x4', '\x2', '\x43', 
		'\\', '\x63', '|', '\x5', '\x2', '\x32', ';', '\x43', '\\', '\x63', '|', 
		'\a', '\x2', '*', '+', ']', ']', '_', '_', '}', '}', '\x7F', '\x7F', '\f', 
		'\x2', '\v', '\xF', '\"', '\"', '\x87', '\x87', '\xA2', '\xA2', '\x1682', 
		'\x1682', '\x2002', '\x200C', '\x202A', '\x202B', '\x2031', '\x2031', 
		'\x2061', '\x2061', '\x3002', '\x3002', '\x2', '\xD6', '\x2', '\x3', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x35', '\x3', '\x2', '\x2', '\x2', '\x2', '\x37', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x39', '\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '=', '\x3', '\x2', '\x2', '\x2', '\x2', '?', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x41', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x43', '\x3', '\x2', '\x2', '\x2', '\x2', '\x45', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'G', '\x3', '\x2', '\x2', '\x2', '\x2', 'I', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'K', '\x3', '\x2', '\x2', '\x2', '\x2', 'M', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'O', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'Q', '\x3', '\x2', '\x2', '\x2', '\x3', 'T', '\x3', '\x2', '\x2', '\x2', 
		'\x5', '\x63', '\x3', '\x2', '\x2', '\x2', '\a', 'k', '\x3', '\x2', '\x2', 
		'\x2', '\t', 'o', '\x3', '\x2', '\x2', '\x2', '\v', 'q', '\x3', '\x2', 
		'\x2', '\x2', '\r', 's', '\x3', '\x2', '\x2', '\x2', '\xF', 'v', '\x3', 
		'\x2', '\x2', '\x2', '\x11', 'y', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'|', '\x3', '\x2', '\x2', '\x2', '\x15', '\x7F', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '\x82', '\x3', '\x2', '\x2', '\x2', '\x19', '\x85', '\x3', 
		'\x2', '\x2', '\x2', '\x1B', '\x88', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'\x8B', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x8E', '\x3', '\x2', '\x2', 
		'\x2', '!', '\x91', '\x3', '\x2', '\x2', '\x2', '#', '\x94', '\x3', '\x2', 
		'\x2', '\x2', '%', '\x97', '\x3', '\x2', '\x2', '\x2', '\'', '\x9A', '\x3', 
		'\x2', '\x2', '\x2', ')', '\x9C', '\x3', '\x2', '\x2', '\x2', '+', '\x9F', 
		'\x3', '\x2', '\x2', '\x2', '-', '\xA2', '\x3', '\x2', '\x2', '\x2', '/', 
		'\xA4', '\x3', '\x2', '\x2', '\x2', '\x31', '\xA6', '\x3', '\x2', '\x2', 
		'\x2', '\x33', '\xA8', '\x3', '\x2', '\x2', '\x2', '\x35', '\xAB', '\x3', 
		'\x2', '\x2', '\x2', '\x37', '\xB2', '\x3', '\x2', '\x2', '\x2', '\x39', 
		'\xB4', '\x3', '\x2', '\x2', '\x2', ';', '\xB6', '\x3', '\x2', '\x2', 
		'\x2', '=', '\xB8', '\x3', '\x2', '\x2', '\x2', '?', '\xBA', '\x3', '\x2', 
		'\x2', '\x2', '\x41', '\xBC', '\x3', '\x2', '\x2', '\x2', '\x43', '\xBE', 
		'\x3', '\x2', '\x2', '\x2', '\x45', '\xC0', '\x3', '\x2', '\x2', '\x2', 
		'G', '\xC2', '\x3', '\x2', '\x2', '\x2', 'I', '\xC4', '\x3', '\x2', '\x2', 
		'\x2', 'K', '\xC6', '\x3', '\x2', '\x2', '\x2', 'M', '\xC8', '\x3', '\x2', 
		'\x2', '\x2', 'O', '\xCA', '\x3', '\x2', '\x2', '\x2', 'Q', '\xCC', '\x3', 
		'\x2', '\x2', '\x2', 'S', 'U', '\a', '/', '\x2', '\x2', 'T', 'S', '\x3', 
		'\x2', '\x2', '\x2', 'T', 'U', '\x3', '\x2', '\x2', '\x2', 'U', 'W', '\x3', 
		'\x2', '\x2', '\x2', 'V', 'X', '\t', '\x2', '\x2', '\x2', 'W', 'V', '\x3', 
		'\x2', '\x2', '\x2', 'X', 'Y', '\x3', '\x2', '\x2', '\x2', 'Y', 'W', '\x3', 
		'\x2', '\x2', '\x2', 'Y', 'Z', '\x3', '\x2', '\x2', '\x2', 'Z', '\x61', 
		'\x3', '\x2', '\x2', '\x2', '[', ']', '\a', '\x30', '\x2', '\x2', '\\', 
		'^', '\t', '\x2', '\x2', '\x2', ']', '\\', '\x3', '\x2', '\x2', '\x2', 
		'^', '_', '\x3', '\x2', '\x2', '\x2', '_', ']', '\x3', '\x2', '\x2', '\x2', 
		'_', '`', '\x3', '\x2', '\x2', '\x2', '`', '\x62', '\x3', '\x2', '\x2', 
		'\x2', '\x61', '[', '\x3', '\x2', '\x2', '\x2', '\x61', '\x62', '\x3', 
		'\x2', '\x2', '\x2', '\x62', '\x4', '\x3', '\x2', '\x2', '\x2', '\x63', 
		'g', '\t', '\x3', '\x2', '\x2', '\x64', '\x66', '\t', '\x4', '\x2', '\x2', 
		'\x65', '\x64', '\x3', '\x2', '\x2', '\x2', '\x66', 'i', '\x3', '\x2', 
		'\x2', '\x2', 'g', '\x65', '\x3', '\x2', '\x2', '\x2', 'g', 'h', '\x3', 
		'\x2', '\x2', '\x2', 'h', '\x6', '\x3', '\x2', '\x2', '\x2', 'i', 'g', 
		'\x3', '\x2', '\x2', '\x2', 'j', 'l', '\n', '\x5', '\x2', '\x2', 'k', 
		'j', '\x3', '\x2', '\x2', '\x2', 'l', 'm', '\x3', '\x2', '\x2', '\x2', 
		'm', 'k', '\x3', '\x2', '\x2', '\x2', 'm', 'n', '\x3', '\x2', '\x2', '\x2', 
		'n', '\b', '\x3', '\x2', '\x2', '\x2', 'o', 'p', '\a', '\x66', '\x2', 
		'\x2', 'p', '\n', '\x3', '\x2', '\x2', '\x2', 'q', 'r', '\a', 'H', '\x2', 
		'\x2', 'r', '\f', '\x3', '\x2', '\x2', '\x2', 's', 't', '\a', 'm', '\x2', 
		'\x2', 't', 'u', '\a', 'j', '\x2', '\x2', 'u', '\xE', '\x3', '\x2', '\x2', 
		'\x2', 'v', 'w', '\a', 'm', '\x2', '\x2', 'w', 'x', '\a', 'n', '\x2', 
		'\x2', 'x', '\x10', '\x3', '\x2', '\x2', '\x2', 'y', 'z', '\a', '\x66', 
		'\x2', '\x2', 'z', '{', '\a', 'j', '\x2', '\x2', '{', '\x12', '\x3', '\x2', 
		'\x2', '\x2', '|', '}', '\a', '\x66', '\x2', '\x2', '}', '~', '\a', 'n', 
		'\x2', '\x2', '~', '\x14', '\x3', '\x2', '\x2', '\x2', '\x7F', '\x80', 
		'\a', '\x63', '\x2', '\x2', '\x80', '\x81', '\a', '\x66', '\x2', '\x2', 
		'\x81', '\x16', '\x3', '\x2', '\x2', '\x2', '\x82', '\x83', '\a', '\x66', 
		'\x2', '\x2', '\x83', '\x84', '\a', '\x63', '\x2', '\x2', '\x84', '\x18', 
		'\x3', '\x2', '\x2', '\x2', '\x85', '\x86', '\a', 't', '\x2', '\x2', '\x86', 
		'\x87', '\a', 't', '\x2', '\x2', '\x87', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', '\x88', '\x89', '\a', 't', '\x2', '\x2', '\x89', '\x8A', '\a', 
		'q', '\x2', '\x2', '\x8A', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x8B', 
		'\x8C', '\a', '#', '\x2', '\x2', '\x8C', '\x8D', '\a', 'g', '\x2', '\x2', 
		'\x8D', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x8E', '\x8F', '\a', '#', 
		'\x2', '\x2', '\x8F', '\x90', '\a', '\x65', '\x2', '\x2', '\x90', ' ', 
		'\x3', '\x2', '\x2', '\x2', '\x91', '\x92', '\a', '#', '\x2', '\x2', '\x92', 
		'\x93', '\a', 'r', '\x2', '\x2', '\x93', '\"', '\x3', '\x2', '\x2', '\x2', 
		'\x94', '\x95', '\a', '\x65', '\x2', '\x2', '\x95', '\x96', '\a', 'u', 
		'\x2', '\x2', '\x96', '$', '\x3', '\x2', '\x2', '\x2', '\x97', '\x98', 
		'\a', '\x65', '\x2', '\x2', '\x98', '\x99', '\a', 'h', '\x2', '\x2', '\x99', 
		'&', '\x3', '\x2', '\x2', '\x2', '\x9A', '\x9B', '\a', 'h', '\x2', '\x2', 
		'\x9B', '(', '\x3', '\x2', '\x2', '\x2', '\x9C', '\x9D', '\a', 'u', '\x2', 
		'\x2', '\x9D', '\x9E', '\a', '\x63', '\x2', '\x2', '\x9E', '*', '\x3', 
		'\x2', '\x2', '\x2', '\x9F', '\xA0', '\a', 'u', '\x2', '\x2', '\xA0', 
		'\xA1', '\a', '\x66', '\x2', '\x2', '\xA1', ',', '\x3', '\x2', '\x2', 
		'\x2', '\xA2', '\xA3', '\a', '?', '\x2', '\x2', '\xA3', '.', '\x3', '\x2', 
		'\x2', '\x2', '\xA4', '\xA5', '\a', '@', '\x2', '\x2', '\xA5', '\x30', 
		'\x3', '\x2', '\x2', '\x2', '\xA6', '\xA7', '\a', '>', '\x2', '\x2', '\xA7', 
		'\x32', '\x3', '\x2', '\x2', '\x2', '\xA8', '\xA9', '\a', '@', '\x2', 
		'\x2', '\xA9', '\xAA', '\a', '?', '\x2', '\x2', '\xAA', '\x34', '\x3', 
		'\x2', '\x2', '\x2', '\xAB', '\xAC', '\a', '>', '\x2', '\x2', '\xAC', 
		'\xAD', '\a', '?', '\x2', '\x2', '\xAD', '\x36', '\x3', '\x2', '\x2', 
		'\x2', '\xAE', '\xAF', '\a', '#', '\x2', '\x2', '\xAF', '\xB3', '\a', 
		'?', '\x2', '\x2', '\xB0', '\xB1', '\a', '>', '\x2', '\x2', '\xB1', '\xB3', 
		'\a', '@', '\x2', '\x2', '\xB2', '\xAE', '\x3', '\x2', '\x2', '\x2', '\xB2', 
		'\xB0', '\x3', '\x2', '\x2', '\x2', '\xB3', '\x38', '\x3', '\x2', '\x2', 
		'\x2', '\xB4', '\xB5', '\a', '}', '\x2', '\x2', '\xB5', ':', '\x3', '\x2', 
		'\x2', '\x2', '\xB6', '\xB7', '\a', '\x7F', '\x2', '\x2', '\xB7', '<', 
		'\x3', '\x2', '\x2', '\x2', '\xB8', '\xB9', '\a', ']', '\x2', '\x2', '\xB9', 
		'>', '\x3', '\x2', '\x2', '\x2', '\xBA', '\xBB', '\a', '_', '\x2', '\x2', 
		'\xBB', '@', '\x3', '\x2', '\x2', '\x2', '\xBC', '\xBD', '\a', '.', '\x2', 
		'\x2', '\xBD', '\x42', '\x3', '\x2', '\x2', '\x2', '\xBE', '\xBF', '\a', 
		'\x30', '\x2', '\x2', '\xBF', '\x44', '\x3', '\x2', '\x2', '\x2', '\xC0', 
		'\xC1', '\a', '*', '\x2', '\x2', '\xC1', '\x46', '\x3', '\x2', '\x2', 
		'\x2', '\xC2', '\xC3', '\a', '+', '\x2', '\x2', '\xC3', 'H', '\x3', '\x2', 
		'\x2', '\x2', '\xC4', '\xC5', '\a', '-', '\x2', '\x2', '\xC5', 'J', '\x3', 
		'\x2', '\x2', '\x2', '\xC6', '\xC7', '\a', '/', '\x2', '\x2', '\xC7', 
		'L', '\x3', '\x2', '\x2', '\x2', '\xC8', '\xC9', '\a', ',', '\x2', '\x2', 
		'\xC9', 'N', '\x3', '\x2', '\x2', '\x2', '\xCA', '\xCB', '\a', '\x31', 
		'\x2', '\x2', '\xCB', 'P', '\x3', '\x2', '\x2', '\x2', '\xCC', '\xCD', 
		'\t', '\x6', '\x2', '\x2', '\xCD', '\xCE', '\x3', '\x2', '\x2', '\x2', 
		'\xCE', '\xCF', '\b', ')', '\x2', '\x2', '\xCF', 'R', '\x3', '\x2', '\x2', 
		'\x2', '\n', '\x2', 'T', 'Y', '_', '\x61', 'g', 'm', '\xB2', '\x3', '\b', 
		'\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Dice.Grammar
