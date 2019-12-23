/* If this file is changed, the corresponding C# files must be regenerated with ANTLR
 * For example: java -jar C:\antlr\antlr-4.7.2-complete.jar -package Dice.Grammar -o Grammar DiceGrammarLexer.g4 DiceGrammarParser.g4
 */

parser grammar DiceGrammarParser;
options { language=CSharp; tokenVocab=DiceGrammarLexer; }

input
    : math_expr EOF
    ;

math_expr
    : add_expr # MathNormal
    ;

add_expr
    : add_expr T_PLUS mult_expr # AddAdd
    | add_expr T_MINUS mult_expr # AddSub
    | mult_expr # AddNone
    ;

mult_expr
    : mult_expr T_MULTIPLY roll_expr # MultMult
    | mult_expr T_DIVIDE roll_expr # MultDiv
    | roll_expr # MultNone
    ;

roll_expr
    : (unary_expr)? T_LBRACE grouped_roll_inner T_RBRACE (grouped_extras)* (group_function)* # RollGroup
    | (unary_expr)? T_D number_expr (basic_extras)* (basic_function)* # RollBasic
    | (unary_expr)? T_D T_FUDGE (unary_expr)? (basic_extras)* (basic_function)* # RollFudge
    | func_expr # RollNone
    ;

func_expr
    : T_MINUS global_function # FuncMinus
    | global_function # FuncFunction
    | unary_expr # FuncNone
    ;

unary_expr
    : T_MINUS number_expr # UnaryExprMinus
    | number_expr # UnaryExprNone
    ;

number_expr
    : T_LPAREN math_expr T_RPAREN # NumberParen
    | number # NumberNumber
    ;

number
    : T_NUMBER # NumberLiteral
    | T_MACRO # NumberMacro
    ;

global_function
    : T_GLOBAL_IDENTIFIER T_LPAREN (function_arg (T_COMMA function_arg)*)? T_RPAREN # GlobalFunction
    | T_D AB_FUNCTION (function_arg (T_COMMA function_arg)*)? T_RPAREN # GlobalFunctionDPrefix
    ;

group_function
    : T_DOT_IDENTIFIER T_LPAREN (function_arg (T_COMMA function_arg)*)? T_RPAREN # GroupFunction
    ;

basic_function
    : T_DOT_IDENTIFIER T_LPAREN (function_arg (T_COMMA function_arg)*)? T_RPAREN # BasicFunction
    ;

function_arg
    : math_expr # FnArgMath
    | explicit_compare_expr # FnArgComp
    ;

grouped_roll_inner
    : grouped_roll_inner T_COMMA math_expr # GroupExtra
    | math_expr # GroupInit
    ;

grouped_extras
    : keep_expr # GroupKeep
    | success_expr # GroupSuccess
    | sort_expr # GroupSort
    | reroll_expr # GroupReroll
    ;

basic_extras
    : reroll_expr # BasicReroll
    | explode_expr # BasicExplode
    | keep_expr # BasicKeep
    | success_expr # BasicSuccess
    | sort_expr # BasicSort
    | crit_expr # BasicCrit
    ;

keep_expr
    : T_KEEP_HIGH unary_expr # KeepHigh
    | T_KEEP_LOW unary_expr # KeepLow
    | T_DROP_HIGH unary_expr # DropHigh
    | T_DROP_LOW unary_expr # DropLow
    | T_ADVANTAGE # Advantage
    | T_DISADVANTAGE # Disadvantage
    ;
    
reroll_expr
    : T_REROLL compare_expr # RerollReroll
    | T_REROLL_ONCE compare_expr # RerollOnce
    ;

explode_expr
    : T_EXPLODE (compare_expr)? # Explode
    | T_COMPOUND (compare_expr)? # Compound
    | T_PENETRATE (compare_expr)? # Penetrate
    ;

success_expr
    : explicit_compare_expr (T_FAIL compare_expr)? # SuccessFail
    ;

compare_expr
    : unary_expr # CompImplicit
    | explicit_compare_expr # CompExplicit
    ;

explicit_compare_expr
    : T_EQUALS unary_expr # CompEquals
    | T_GREATER unary_expr # CompGreater
    | T_LESS unary_expr # CompLess
    | T_GREATER_EQUALS unary_expr # CompGreaterEquals
    | T_LESS_EQUALS unary_expr # CompLessEquals
    | T_NOT_EQUALS unary_expr # CompNotEquals
    ;

sort_expr
    : T_SORT_ASC # SortAsc
    | T_SORT_DESC # SortDesc
    ;

crit_expr
    : T_CRIT compare_expr (T_FAIL compare_expr)? # CritFumble
    | T_CRITFAIL compare_expr # FumbleOnly
    ;
