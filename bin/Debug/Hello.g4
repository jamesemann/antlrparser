grammar Hello;
 
@parser::members
{
    protected const int EOF = Eof;
}
 
@lexer::members
{
    protected const int EOF = Eof;
    protected const int HIDDEN = Hidden;
}
 
/*
 * Parser Rules
 */
 
prog: expr+ ;
 
expr : expr op=('*'|'/') expr   # MulDiv
     | expr op=('+'|'-') expr   # AddSub
	 | expr op=('<='|'<'|'>='|'>') expr # OtherEquality
	 | expr EQU expr # Equals
	 | expr NEQU expr # NotEquals
	 | expr AND expr # And
	 | expr OR expr # Or
	 | VAR # Variable
     | INT                  # int
	 | NULL # null
	 | STR # StringLiteral
     | '(' expr ')'         # parens
     ;
 
/*
 * Lexer Rules
 */
VAR : '$'[a-zA-Z0-9]*;
INT : [0-9]+;
MUL : '*';
DIV : '/';
ADD : '+';
SUB : '-';
EQU : '==';
NEQU : '!=';
NULL : 'NULL';
AND : 'AND';
OR : 'OR';
GTE : '>=';
GT : '>';
LTE : '<=';
LT : '<';
STR : '"' (~('"' | '\\' | '\r' | '\n') | '\\' ('"' | '\\'))* '"';
WS
    :   (' ' | '\r' | '\n') -> channel(HIDDEN)
    ;