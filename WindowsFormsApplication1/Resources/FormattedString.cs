using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class FormattedString
    {
        #region TableT4
        public static String tableT4 = "<HTML><HEAD><link rel=Stylesheet href=\".\\CSS\\stylesheet.css\"></HEAD>" +
    "<BODY><TABLE FRAME=VOID CELLSPACING=0 COLS=12 RULES=NONE BORDER=0>" +
    "<COLGROUP><COL WIDTH=16><COL WIDTH=144><COL WIDTH=162><COL WIDTH=63><COL WIDTH=10><COL WIDTH=64><COL WIDTH=67><COL WIDTH=171><COL WIDTH=60><COL WIDTH=28><COL WIDTH=85><COL WIDTH=23></COLGROUP>" +
    "<TBODY>" +
        "<TR><TD COLSPAN=12 WIDTH=792 HEIGHT=118 ALIGN=CENTER VALIGN=MIDDLE><BR><IMG SRC=\"img-logo-big.png\" WIDTH=522 HEIGHT=101 HSPACE=120 VSPACE=8></TD></TR>" +
        "<TR><TD COLSPAN=12 HEIGHT=17 ALIGN=CENTER VALIGN=MIDDLE><B><FONT FACE=\"Century\">##TOURNAMENTNAME##</FONT></B></TD></TR>" +
        "<TR><TD COLSPAN=12 HEIGHT=17 ALIGN=CENTER VALIGN=MIDDLE SDVAL=\"43165\" SDNUM=\"1033;0;NNNNMMMM DD, YYYY\"><B><FONT FACE=\"Century\">##TournamentDate##</FONT></B></TD></TR>" +
        "<TR><TD COLSPAN=12 HEIGHT=96 ALIGN=CENTER VALIGN=MIDDLE><B><FONT FACE=\"Century\" SIZE=6>##NomeGirone##</FONT></B></TD></TR>"+
		"<TR>"+
			"<TD HEIGHT=19 ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 ALIGN=CENTER VALIGN=MIDDLE><B>Nome</B></TD>"+
			"<TD STYLE=\"border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=CENTER><B>Vittorie</B></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=CENTER><B>Sconfitte</B></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B>P. Fatti</B></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B>p. Subiti</B></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE><B>Differenziale</B></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		//<!-- ciclo for per numero atleti -->
		"<TR>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=27 ALIGN=LEFT SDVAL=\"1\" SDNUM=\"1033;\"><FONT SIZE=1>1</FONT></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 ALIGN=LEFT VALIGN=MIDDLE><B><FONT SIZE=3>##Atleta_a_nome##</FONT></B></TD>"+
			"<TD STYLE=\"border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=27 ALIGN=LEFT SDVAL=\"1\" SDNUM=\"1033;\"><FONT SIZE=1>2</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 ALIGN=LEFT VALIGN=MIDDLE><B><FONT SIZE=3>##Atleta_b_nome##</FONT></B></TD>" +
            "<TD STYLE=\"border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=27 ALIGN=LEFT SDVAL=\"1\" SDNUM=\"1033;\"><FONT SIZE=1>3</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 ALIGN=LEFT VALIGN=MIDDLE><B><FONT SIZE=3>##Atleta_c_nome##</FONT></B></TD>" +
            "<TD STYLE=\"border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=27 ALIGN=LEFT SDVAL=\"1\" SDNUM=\"1033;\"><FONT SIZE=1>4</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 ALIGN=LEFT VALIGN=MIDDLE><B><FONT SIZE=3>##Atleta_d_nome##</FONT></B></TD>" +
            "<TD STYLE=\"border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        //<!-- fine ciclo for -->
        "<TR>" +
			"<TD STYLE=\"border-top: 1px solid #000000\" HEIGHT=20 ALIGN=LEFT><FONT SIZE=1><BR></FONT></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000\" COLSPAN=3 ALIGN=LEFT VALIGN=MIDDLE><B><FONT SIZE=3><BR></FONT></B></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=20 ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=10 ALIGN=CENTER VALIGN=MIDDLE><B><FONT SIZE=3>Incontri</FONT></B></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 HEIGHT=17 ALIGN=CENTER VALIGN=MIDDLE><BR></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT>Punti</TD>"+
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT>Doppia Morte<BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=CENTER VALIGN=MIDDLE><BR></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT>Punti</TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"1\" SDNUM=\"1033;\"><FONT SIZE=1>1</FONT></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE><B><FONT FACE=\"Century\">##a##</FONT></B></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>"+
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE><B><FONT FACE=\"Century\">##b##</FONT></B></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"2\" SDNUM=\"1033;\"><FONT SIZE=1>2</FONT></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE><B><FONT FACE=\"Century\">##c##</FONT></B></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>"+
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE><B><FONT FACE=\"Century\">##d##</FONT></B></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"3\" SDNUM=\"1033;\"><FONT SIZE=1>3</FONT></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE><B><FONT FACE=\"Century\">##b##</FONT></B></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>"+
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
			
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE><B><FONT FACE=\"Century\">##c##</FONT></B></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"4\" SDNUM=\"1033;\"><FONT SIZE=1>4</FONT></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE><B><FONT FACE=\"Century\">##a##</FONT></B></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>"+
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
			
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE><B><FONT FACE=\"Century\">##d##</FONT></B></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"5\" SDNUM=\"1033;\"><FONT SIZE=1>5</FONT></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE><B><FONT FACE=\"Century\">##a##</FONT></B></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>"+
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
			
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE><B><FONT FACE=\"Century\">##c##</FONT></B></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"6\" SDNUM=\"1033;\"><FONT SIZE=1>6</FONT></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE><B><FONT FACE=\"Century\">##b##</FONT></B></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>"+
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
			
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE><B><FONT FACE=\"Century\">##d##</FONT></B></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ROWSPAN=2 ALIGN=CENTER VALIGN=MIDDLE>Terna Arbitrale</TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=9 ROWSPAN=2 ALIGN=CENTER VALIGN=MIDDLE><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=10 ALIGN=LEFT VALIGN=MIDDLE>Firme per accettazione risultati</TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=6 ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=10 ROWSPAN=4 ALIGN=LEFT VALIGN=LEFT><BR>"+
            "<BR>" + "<BR>" + "<BR>" + "<BR>" +
            "<BR>" +
            "<BR>" +
            "<BR>" +
            "</TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "</TBODY></TABLE></BODY></HTML>";
        #endregion


        /// <summary>
        /// T5
        /// </summary>

        #region TableT5
        public static String tableT5 = "<HTML><HEAD><link rel=Stylesheet href=\".\\CSS\\stylesheet.css\"></HEAD>" +
"<BODY>" +
"<TABLE FRAME=VOID CELLSPACING=0 COLS=12 RULES=NONE BORDER=0>" +
    "<COLGROUP><COL WIDTH=16><COL WIDTH=144><COL WIDTH=162><COL WIDTH=63><COL WIDTH=10><COL WIDTH=66><COL WIDTH=68><COL WIDTH=173><COL WIDTH=61><COL WIDTH=29><COL WIDTH=85><COL WIDTH=21></COLGROUP>" +
    "<TBODY>" +
        "<TR>" +
            "<TD COLSPAN=11 WIDTH=877 HEIGHT=118 ALIGN=CENTER VALIGN=MIDDLE><BR><IMG SRC=\"img-logo-big.png\" WIDTH=525 HEIGHT=101 HSPACE=121 VSPACE=8>" +
			"</TD>" +
			"<TD WIDTH=21 ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD COLSPAN=11 HEIGHT=17 ALIGN=CENTER VALIGN=MIDDLE><B><FONT FACE=\"Century\">##TOURNAMENTNAME##</FONT></B></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD COLSPAN=11 HEIGHT=17 ALIGN=CENTER VALIGN=MIDDLE SDVAL=\"43165\" SDNUM=\"1033;0;NNNNMMMM DD, YYYY\"><B><FONT FACE=\"Century\">##TournamentDate##</FONT></B></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD COLSPAN=11 HEIGHT=94 ALIGN=CENTER VALIGN=TOP><B><FONT FACE=\"Century\" SIZE=6>##NomeGirone##</FONT></B></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD STYLE=\"border-right: 1px solid #000000\" HEIGHT=17 ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 ALIGN=CENTER VALIGN=MIDDLE><B>Nome</B></TD>" +
			"<TD STYLE=\"border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=CENTER><B>Vittorie</B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=CENTER><B>Sconfitte</B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B>Punti Fatti</B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B>P. Subiti</B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE><B>Differenziale</B></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD STYLE=\"border-bottom: 1px solid #000000\" HEIGHT=10 ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=27 ALIGN=LEFT SDVAL=\"1\" SDNUM=\"1033;\"><FONT SIZE=1>1</FONT></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 ALIGN=LEFT VALIGN=MIDDLE><B><FONT SIZE=3><BR></FONT>##Atleta_a_nome##</B></TD>" +
			"<TD STYLE=\"border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=27 ALIGN=LEFT SDVAL=\"2\" SDNUM=\"1033;\"><FONT SIZE=1>2</FONT></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 ALIGN=LEFT VALIGN=MIDDLE><B><FONT SIZE=3><BR></FONT>##Atleta_b_nome##</B></TD>" +
			"<TD STYLE=\"border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=27 ALIGN=LEFT SDVAL=\"3\" SDNUM=\"1033;\"><FONT SIZE=1>3</FONT></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 ALIGN=LEFT VALIGN=MIDDLE><B><FONT SIZE=3><BR></FONT>##Atleta_c_nome##</B></TD>" +
			"<TD STYLE=\"border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=27 ALIGN=LEFT SDVAL=\"4\" SDNUM=\"1033;\"><FONT SIZE=1>4</FONT></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 ALIGN=LEFT VALIGN=MIDDLE><B><FONT SIZE=3><BR></FONT>##Atleta_d_nome##</B></TD>" +
			"<TD STYLE=\"border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=27 ALIGN=LEFT SDVAL=\"5\" SDNUM=\"1033;\"><FONT SIZE=1>5</FONT></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 ALIGN=LEFT VALIGN=MIDDLE><B><FONT SIZE=3><BR></FONT>##Atleta_e_nome##</B></TD>" +
			"<TD STYLE=\"border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD HEIGHT=10 ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD HEIGHT=20 ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=10 ALIGN=CENTER VALIGN=MIDDLE><B><FONT SIZE=3>Incontri</FONT></B></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD HEIGHT=10 ALIGN=CENTER VALIGN=MIDDLE><B><FONT SIZE=3><BR></FONT></B></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
		"<TD ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 HEIGHT=17 ALIGN=CENTER VALIGN=MIDDLE><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT>Punti</TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT>Doppia Morte<BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=CENTER VALIGN=MIDDLE><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT>Punti</TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"1\" SDNUM=\"1033;\"><FONT SIZE=1>1</FONT></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##a##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##b##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"2\" SDNUM=\"1033;\"><FONT SIZE=1>2</FONT></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##c##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##d##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"3\" SDNUM=\"1033;\"><FONT SIZE=1>3</FONT></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##e##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##a##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"4\" SDNUM=\"1033;\"><FONT SIZE=1>4</FONT></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##b##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##c##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"5\" SDNUM=\"1033;\"><FONT SIZE=1>5</FONT></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##d##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##e##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"6\" SDNUM=\"1033;\"><FONT SIZE=1>6</FONT></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##a##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##c##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"7\" SDNUM=\"1033;\"><FONT SIZE=1>7</FONT></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##e##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##b##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"8\" SDNUM=\"1033;\"><FONT SIZE=1>8</FONT></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##a##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##d##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"9\" SDNUM=\"1033;\"><FONT SIZE=1>9</FONT></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##e##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##c##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"10\" SDNUM=\"1033;\"><FONT SIZE=1>10</FONT></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##b##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##d##</FONT></B></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD HEIGHT=25 ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE><B><FONT FACE=\"Century\" SIZE=4><BR></FONT></B></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ROWSPAN=2 ALIGN=CENTER VALIGN=MIDDLE>Terna Arbitrale</TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=9 ROWSPAN=2 ALIGN=CENTER VALIGN=MIDDLE><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>" +
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=10 ALIGN=CENTER VALIGN=MIDDLE>Firme per accettazione risultati</TD>" +
			"<TD ALIGN=LEFT><BR></TD>" +
		"</TR>" +
		"<TR>" +
           "<TD HEIGHT=6 ALIGN=LEFT><BR></TD>" +
           "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=10 ROWSPAN=4 ALIGN=LEFT VALIGN=LEFT><BR>" +
           "<BR>" +
           "<BR>" +
           "<BR>" +
           "<BR>" +
           "</TD>" +
        "</TR>" +
	"</TBODY></TABLE></BODY></HTML>";
        #endregion

        #region TableT6
        public static String tableT6 = "<HTML><HEAD><link rel=Stylesheet href=\".\\CSS\\stylesheet.css\"></HEAD>" +
"<BODY>" +
"<TABLE FRAME=VOID CELLSPACING=0 COLS=12 RULES=NONE BORDER=0>" +
    "<COLGROUP><COL WIDTH=16><COL WIDTH=144><COL WIDTH=162><COL WIDTH=63><COL WIDTH=10><COL WIDTH=66><COL WIDTH=68><COL WIDTH=173><COL WIDTH=61><COL WIDTH=29><COL WIDTH=85><COL WIDTH=21></COLGROUP>" +
    "<TBODY>" +
        "<TR>" +
            "<TD COLSPAN=11 WIDTH=877 HEIGHT=118 ALIGN=CENTER VALIGN=MIDDLE><BR><IMG SRC=\"img-logo-big.png\" WIDTH=525 HEIGHT=101 HSPACE=121 VSPACE=8>" +
            "</TD>" +
            "<TD WIDTH=21 ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD COLSPAN=11 HEIGHT=17 ALIGN=CENTER VALIGN=MIDDLE><B><FONT FACE=\"Century\">##TOURNAMENTNAME##</FONT></B></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD COLSPAN=11 HEIGHT=17 ALIGN=CENTER VALIGN=MIDDLE SDVAL=\"43165\" SDNUM=\"1033;0;NNNNMMMM DD, YYYY\"><B><FONT FACE=\"Century\">##TournamentDate##</FONT></B></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD COLSPAN=11 HEIGHT=94 ALIGN=CENTER VALIGN=TOP><B><FONT FACE=\"Century\" SIZE=6>##NomeGirone##</FONT></B></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-right: 1px solid #000000\" HEIGHT=17 ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 ALIGN=CENTER VALIGN=MIDDLE><B>Nome</B></TD>" +
            "<TD STYLE=\"border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=CENTER><B>Vittorie</B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=CENTER><B>Sconfitte</B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B>Punti Fatti</B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B>P. Subiti</B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE><B>Differenziale</B></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-bottom: 1px solid #000000\" HEIGHT=10 ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=27 ALIGN=LEFT SDVAL=\"1\" SDNUM=\"1033;\"><FONT SIZE=1>1</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 ALIGN=LEFT VALIGN=MIDDLE><B><FONT SIZE=3><BR></FONT>##Atleta_a_nome##</B></TD>" +
            "<TD STYLE=\"border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=27 ALIGN=LEFT SDVAL=\"2\" SDNUM=\"1033;\"><FONT SIZE=1>2</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 ALIGN=LEFT VALIGN=MIDDLE><B><FONT SIZE=3><BR></FONT>##Atleta_b_nome##</B></TD>" +
            "<TD STYLE=\"border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=27 ALIGN=LEFT SDVAL=\"3\" SDNUM=\"1033;\"><FONT SIZE=1>3</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 ALIGN=LEFT VALIGN=MIDDLE><B><FONT SIZE=3><BR></FONT>##Atleta_c_nome##</B></TD>" +
            "<TD STYLE=\"border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=27 ALIGN=LEFT SDVAL=\"4\" SDNUM=\"1033;\"><FONT SIZE=1>4</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 ALIGN=LEFT VALIGN=MIDDLE><B><FONT SIZE=3><BR></FONT>##Atleta_d_nome##</B></TD>" +
            "<TD STYLE=\"border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=27 ALIGN=LEFT SDVAL=\"5\" SDNUM=\"1033;\"><FONT SIZE=1>5</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 ALIGN=LEFT VALIGN=MIDDLE><B><FONT SIZE=3><BR></FONT>##Atleta_e_nome##</B></TD>" +
            "<TD STYLE=\"border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +

        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=27 ALIGN=LEFT SDVAL=\"4\" SDNUM=\"1033;\"><FONT SIZE=1>4</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=3 ALIGN=LEFT VALIGN=MIDDLE><B><FONT SIZE=3><BR></FONT>##Atleta_f_nome##</B></TD>" +
            "<TD STYLE=\"border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=RIGHT SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +

        "<TR>" +
            "<TD HEIGHT=17 ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD HEIGHT=20 ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=10 ALIGN=CENTER VALIGN=MIDDLE><B><FONT SIZE=3>Incontri</FONT></B></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD HEIGHT=10 ALIGN=CENTER VALIGN=MIDDLE><B><FONT SIZE=3><BR></FONT></B></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
        "<TD ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 HEIGHT=17 ALIGN=CENTER VALIGN=MIDDLE><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT>Punti</TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT>Doppia Morte<BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=CENTER VALIGN=MIDDLE><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT>Punti</TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"1\" SDNUM=\"1033;\"><FONT SIZE=1>1</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##a##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##b##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"2\" SDNUM=\"1033;\"><FONT SIZE=1>2</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##c##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##d##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"3\" SDNUM=\"1033;\"><FONT SIZE=1>3</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##e##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##f##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"4\" SDNUM=\"1033;\"><FONT SIZE=1>4</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##a##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##d##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"5\" SDNUM=\"1033;\"><FONT SIZE=1>5</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##b##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##c##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"6\" SDNUM=\"1033;\"><FONT SIZE=1>6</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##d##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##f##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"7\" SDNUM=\"1033;\"><FONT SIZE=1>7</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##c##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##e##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"8\" SDNUM=\"1033;\"><FONT SIZE=1>8</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##b##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##f##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"9\" SDNUM=\"1033;\"><FONT SIZE=1>9</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##a##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##c##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"10\" SDNUM=\"1033;\"><FONT SIZE=1>10</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##d##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##e##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"10\" SDNUM=\"1033;\"><FONT SIZE=1>10</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##c##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##f##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"10\" SDNUM=\"1033;\"><FONT SIZE=1>10</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##a##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##e##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"10\" SDNUM=\"1033;\"><FONT SIZE=1>10</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##b##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##d##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"10\" SDNUM=\"1033;\"><FONT SIZE=1>10</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##a##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##f##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" HEIGHT=33 ALIGN=RIGHT SDVAL=\"10\" SDNUM=\"1033;\"><FONT SIZE=1>10</FONT></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##b##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><B><FONT FACE=\"Century\" SIZE=3><BR></FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=4 ALIGN=LEFT VALIGN=MIDDLE SDVAL=\"0\" SDNUM=\"1033;\"><B><FONT FACE=\"Century\">##e##</FONT></B></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD HEIGHT=25 ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD COLSPAN=2 ALIGN=CENTER VALIGN=MIDDLE><B><FONT FACE=\"Century\" SIZE=4><BR></FONT></B></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD HEIGHT=17 ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ROWSPAN=2 ALIGN=CENTER VALIGN=MIDDLE>Terna Arbitrale</TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=9 ROWSPAN=2 ALIGN=CENTER VALIGN=MIDDLE><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD HEIGHT=17 ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD HEIGHT=17 ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
            "<TD HEIGHT=17 ALIGN=LEFT><BR></TD>" +
            "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=10 ALIGN=CENTER VALIGN=MIDDLE>Firme per accettazione risultati</TD>" +
            "<TD ALIGN=LEFT><BR></TD>" +
        "</TR>" +
        "<TR>" +
           "<TD HEIGHT=6 ALIGN=LEFT><BR></TD>" +
           "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=10 ROWSPAN=4 ALIGN=LEFT VALIGN=LEFT><BR>" +
           "<BR>" +
           "<BR>" +
           "<BR>" +
           "<BR>" +
           "</TD>" +
        "</TR>" +
    "</TBODY></TABLE></BODY></HTML>";
        #endregion

        #region eliminazioni dirette

        public static String header = "<HTML>" +
                "<HEAD><STYLE>font-family:\"Arial\"; font-size:x-small </STYLE></HEAD>" +
                "<BODY TEXT=\"#000000\">";
        public static String match = "<TABLE FRAME=VOID CELLSPACING=0 COLS=9 RULES=NONE BORDER=0>" +
                "<COLGROUP><COL WIDTH=10><COL WIDTH=94><COL WIDTH=124><COL WIDTH=73><COL WIDTH=33><COL WIDTH=73><COL WIDTH=131><COL WIDTH=89><COL WIDTH=10></COLGROUP>" +
                "<TBODY>"+         
                "<TR>" +
                    "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=9 WIDTH=638 HEIGHT=17 ALIGN=CENTER VALIGN=MIDDLE><B>##INCONTRO##</B></TD>" +
                    "</TR>" +
                "<TR>" +
                    "<TD HEIGHT=12 ALIGN=LEFT><BR></TD>" +
                    "<TD ALIGN=LEFT><BR></TD>" +
                    "<TD ALIGN=LEFT><BR></TD>" +
                    "<TD ALIGN=LEFT><BR></TD>" +
                    "<TD ALIGN=LEFT><BR></TD>" +
                    "<TD ALIGN=LEFT><BR></TD>" +
                    "<TD ALIGN=LEFT><BR></TD>" +
                    "<TD ALIGN=LEFT><BR></TD>" +
                    "<TD ALIGN=LEFT><BR></TD>" +
                "</TR>" +
                "<TR>" +
                    "<TD HEIGHT=17 ALIGN=LEFT><BR></TD>" +
                    "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ROWSPAN=2 ALIGN=LEFT VALIGN=MIDDLE><B><BR>##a##</B></TD>" +
                    "<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ROWSPAN=2 ALIGN=CENTER VALIGN=MIDDLE><BR></TD>" +
                    "<TD ROWSPAN=2 ALIGN=CENTER VALIGN=MIDDLE><FONT FACE=\"Castellar\">VS</FONT></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" ROWSPAN=2 ALIGN=CENTER VALIGN=MIDDLE><BR></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=2 ROWSPAN=2 ALIGN=RIGHT VALIGN=MIDDLE><B><BR>##b##</B></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=10 ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><B>Terna_Arbitrale</B></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=7 ROWSPAN=2 ALIGN=CENTER VALIGN=MIDDLE><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=10 ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><B>Firme</B></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: 1px solid #000000\" COLSPAN=7 ROWSPAN=2 ALIGN=CENTER VALIGN=MIDDLE><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD ALIGN=LEFT><BR></TD>"+
		"</TR>"+
		"<TR>"+
			"<TD STYLE=\"border-bottom: 1px solid #000000\" HEIGHT=17 ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-bottom: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-bottom: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-bottom: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-bottom: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-bottom: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-bottom: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-bottom: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
			"<TD STYLE=\"border-bottom: 1px solid #000000\" ALIGN=LEFT><BR></TD>"+
		"</TR>";
		
        public static String footer = "</TBODY></TABLE>";

        #endregion


        public static String bracket16 = "<head><title>bracket </title></head><body>" +
   "<div id=\"H\"    style=\"position:absolute; top:606px; left:1132px;width:24px; height:2x; \">##CAMPO##</div>" +
   "<div id=\"HL2\"  style=\"position:absolute; top:315px; left:900px; width:130px; height:260px; background-image: url(Rood1.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL3\"  style=\"position:absolute; top:635px; left:900px; width:130px; height:260px; background-image: url(Blauw1.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL4\"  style=\"position:absolute; top:145px; left:670px; width:130px; height:110px; background-image: url(Rood1.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL5\"  style=\"position:absolute; top:785px; left:670px; width:130px; height:110px; background-image: url(Rood1.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL6\"  style=\"position:absolute; top:315px; left:670px; width:130px; height:110px; background-image: url(Blauw1.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL7\"  style=\"position:absolute; top:955px; left:670px; width:130px; height:110px; background-image: url(Blauw1.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL8\"  style=\"position:absolute; top:75px;  left:440px; width:130px; height:40px;  background-image: url(Rood1.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL9\"  style=\"position:absolute; top:715px; left:440px; width:130px; height:40px;  background-image: url(Rood1.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL10\" style=\"position:absolute; top:175px; left:440px; width:130px; height:40px;  background-image: url(Blauw1.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL11\" style=\"position:absolute; top:815px; left:440px; width:130px; height:40px;  background-image: url(Blauw1.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL12\" style=\"position:absolute; top:355px; left:440px; width:130px; height:40px;  background-image: url(Rood1.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL13\" style=\"position:absolute; top:995px; left:440px; width:130px; height:40px;  background-image: url(Rood1.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL14\" style=\"position:absolute; top:455px; left:440px; width:130px; height:40px;  background-image: url(Blauw1.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL15\" style=\"position:absolute; top:1095px;left:440px; width:130px; height:40px;  background-image: url(Blauw1.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL16\" style=\"position:absolute; top:30px;  left:210px; width:130px; height:15px;  background-image: url(Rood3.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL17\" style=\"position:absolute; top:670px; left:210px; width:130px; height:15px;  background-image: url(Rood3.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL18\" style=\"position:absolute; top:105px; left:210px; width:130px; height:15px;  background-image: url(Blauw3.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL20\" style=\"position:absolute; top:170px; left:210px; width:130px; height:15px;  background-image: url(Rood3.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL22\" style=\"position:absolute; top:245px; left:210px; width:130px; height:15px;  background-image: url(Blauw3.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL24\" style=\"position:absolute; top:310px; left:210px; width:130px; height:15px;  background-image: url(Rood3.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL26\" style=\"position:absolute; top:385px; left:210px; width:130px; height:15px;  background-image: url(Blauw3.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL27\" style=\"position:absolute; top:1025px;left:210px; width:130px; height:15px;  background-image: url(Blauw3.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL28\" style=\"position:absolute; top:1090px;left:210px; width:130px; height:15px;  background-image: url(Rood3.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL28\" style=\"position:absolute; top:450px; left:210px; width:130px; height:15px;  background-image: url(Rood3.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL30\" style=\"position:absolute; top:525px; left:210px; width:130px; height:15px;  background-image: url(Blauw3.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL31\" style=\"position:absolute; top:1165px;left:210px; width:130px; height:15px;  background-image: url(Blauw3.png); background-size:100% 100%;\"></div>" +

   "<div id=\"H2\"  style=\"position:absolute; top:255px; left:700px; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br><br></FONT></div>" +
   "<div id=\"H4\"  style=\"position:absolute; top:115px; left:470px; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br> <br> </FONT></div>" +
   "<div id=\"H6\"  style=\"position:absolute; top:395px; left:470px; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br> <br> </FONT></div>" +
   "<div id=\"H8\"  style=\"position:absolute; top:45px ; left:240px; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br> <br> </FONT></div>" +
   "<div id=\"H10\" style=\"position:absolute; top:185px; left:240px; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br> <br> </FONT></div>" +
   "<div id=\"H12\" style=\"position:absolute; top:325px; left:240px; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br> <br> </FONT></div>" +
   "<div id=\"H14\" style=\"position:absolute; top:465px; left:240px; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br> <br> </FONT></div>" +
   "<div id=\"H16\" style=\"position:absolute; top:10px;  left:10px ; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br>##1##<br> </FONT></div>" +
   "<div id=\"H18\" style=\"position:absolute; top:80px;  left:10px ; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br>##2##<br> </FONT></div>" +
   "<div id=\"H20\" style=\"position:absolute; top:150px; left:10px ; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br>##3##<br> </FONT></div>" +
   "<div id=\"H22\" style=\"position:absolute; top:220px; left:10px ; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br>##4##<br> </FONT></div>" +
   "<div id=\"H24\" style=\"position:absolute; top:290px; left:10px ; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br>##5##<br> </FONT></div>" +
   "<div id=\"H26\" style=\"position:absolute; top:360px; left:10px ; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br>##6##<br> </FONT></div>" +
   "<div id=\"H28\" style=\"position:absolute; top:430px; left:10px ; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br>##7##<br> </FONT></div>" +
   "<div id=\"H30\" style=\"position:absolute; top:500px; left:10px ; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br>##8##<br> </FONT></div>" +
    "</body></html>";


        public static String bracket8 = "<head><title>bracket </title></head><body>" +
   "<div id=\"H\"    style=\"position:absolute; top:606px; left:1132px;width:24px; height:2x; \">##CAMPO##</div>" +
   "<div id=\"HL2\"  style=\"position:absolute; top:315px; left:900px; width:130px; height:260px; background-image: url(Rood1.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL3\"  style=\"position:absolute; top:635px; left:900px; width:130px; height:260px; background-image: url(Blauw1.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL4\"  style=\"position:absolute; top:145px; left:670px; width:130px; height:110px; background-image: url(Rood1.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL5\"  style=\"position:absolute; top:785px; left:670px; width:130px; height:110px; background-image: url(Rood1.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL6\"  style=\"position:absolute; top:315px; left:670px; width:130px; height:110px; background-image: url(Blauw1.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL7\"  style=\"position:absolute; top:955px; left:670px; width:130px; height:110px; background-image: url(Blauw1.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL8\"  style=\"position:absolute; top:75px;  left:440px; width:130px; height:40px;  background-image: url(Rood1.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL9\"  style=\"position:absolute; top:715px; left:440px; width:130px; height:40px;  background-image: url(Rood1.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL10\" style=\"position:absolute; top:175px; left:440px; width:130px; height:40px;  background-image: url(Blauw1.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL11\" style=\"position:absolute; top:815px; left:440px; width:130px; height:40px;  background-image: url(Blauw1.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL12\" style=\"position:absolute; top:355px; left:440px; width:130px; height:40px;  background-image: url(Rood1.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL13\" style=\"position:absolute; top:995px; left:440px; width:130px; height:40px;  background-image: url(Rood1.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL14\" style=\"position:absolute; top:455px; left:440px; width:130px; height:40px;  background-image: url(Blauw1.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL15\" style=\"position:absolute; top:1095px;left:440px; width:130px; height:40px;  background-image: url(Blauw1.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL16\" style=\"position:absolute; top:30px;  left:210px; width:130px; height:15px;  background-image: url(Rood3.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL17\" style=\"position:absolute; top:670px; left:210px; width:130px; height:15px;  background-image: url(Rood3.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL18\" style=\"position:absolute; top:105px; left:210px; width:130px; height:15px;  background-image: url(Blauw3.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL20\" style=\"position:absolute; top:170px; left:210px; width:130px; height:15px;  background-image: url(Rood3.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL22\" style=\"position:absolute; top:245px; left:210px; width:130px; height:15px;  background-image: url(Blauw3.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL24\" style=\"position:absolute; top:310px; left:210px; width:130px; height:15px;  background-image: url(Rood3.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL26\" style=\"position:absolute; top:385px; left:210px; width:130px; height:15px;  background-image: url(Blauw3.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL27\" style=\"position:absolute; top:1025px;left:210px; width:130px; height:15px;  background-image: url(Blauw3.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL28\" style=\"position:absolute; top:1090px;left:210px; width:130px; height:15px;  background-image: url(Rood3.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL28\" style=\"position:absolute; top:450px; left:210px; width:130px; height:15px;  background-image: url(Rood3.png);  background-size:100% 100%;\"></div>" +
   "<div id=\"HL30\" style=\"position:absolute; top:525px; left:210px; width:130px; height:15px;  background-image: url(Blauw3.png); background-size:100% 100%;\"></div>" +
   "<div id=\"HL31\" style=\"position:absolute; top:1165px;left:210px; width:130px; height:15px;  background-image: url(Blauw3.png); background-size:100% 100%;\"></div>" +   
   "<div id=\"H4\"  style=\"position:absolute; top:115px; left:470px; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br> <br> </FONT></div>" +
   "<div id=\"H8\"  style=\"position:absolute; top:45px ; left:240px; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br> <br> </FONT></div>" +
   "<div id=\"H10\" style=\"position:absolute; top:185px; left:240px; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br> <br> </FONT></div>" +
   "<div id=\"H16\" style=\"position:absolute; top:10px;  left:10px ; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br>##1##<br> </FONT></div>" +
   "<div id=\"H18\" style=\"position:absolute; top:80px;  left:10px ; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br>##2##<br> </FONT></div>" +
   "<div id=\"H20\" style=\"position:absolute; top:150px; left:10px ; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br>##3##<br> </FONT></div>" +
   "<div id=\"H22\" style=\"position:absolute; top:220px; left:10px ; width:200px; height:60px; border:1px solid #000; \"><FONT SIZE=\"4\" COLOR=\"000000\"> <br>##4##<br> </FONT></div>" +
    "</body></html>";

    }
}
