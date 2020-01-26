using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class PdfManager
    {
        public void StampaRisultatiGironi(DataGridView grid, string nomeTorneo, string disciplina)
        {
            ProgressBar p = new ProgressBar();
                        
            String HtmlReport = "<h2>Atleti iscritti al torneo " + nomeTorneo + " - " + disciplina + "</h2>";

            HtmlReport += "<table style=\"width: 100%;\" border=\"1\">";

            #region atleti
            p.InizializeProgressBar(1, (grid.RowCount + 3) + 2);

            p.Show();
            int i = 1;

            HtmlReport += "<tr>"+
                "<th>Posizione</th>" +
                "<th>Ammesso</th>" +
                "<th>Cognome</th>" +
                "<th>Nome</th>" +
                "<th>Vittorie</th>" +
                "<th>Sconfitte</th>" +
                "<th>Punti Fatti</th>" +
                "<th>Punti Subiti</th>" +
                "<th>Differenziale</th>" +
                "<th>Ranking Esistente</th>" +
                "</tr></br>";
            
            for(int j = 0; j< grid.Rows.Count; j++)
            {
                var row = grid.Rows[j];

                HtmlReport += "<tr>";
                HtmlReport += "<td align=\"center\">" + i + "</td>";
                HtmlReport += "<td align=\"center\">" + (row.Cells[0].Value.ToString() == "True" ? "Si" : "No") + "</td>";
                HtmlReport += "<td align=\"left\">" + row.Cells[5].Value.ToString() + "</td>";
                HtmlReport += "<td align=\"left\">" + row.Cells[6].Value.ToString() + "</td>";
                HtmlReport += "<td align=\"center\">" + row.Cells[7].Value.ToString() + "</td>";
                HtmlReport += "<td align=\"center\">" + row.Cells[8].Value.ToString() + "</td>";
                HtmlReport += "<td align=\"center\">" + row.Cells[9].Value.ToString() + "</td>";
                HtmlReport += "<td align=\"center\">" + row.Cells[10].Value.ToString() + "</td>";
                HtmlReport += "<td align=\"left\">" + 
                    (row.Cells[11].Value.ToString().Length > 10 ? 
                    row.Cells[11].Value.ToString().Substring(0, 8) :
                    row.Cells[11].Value.ToString()) + "</td>";
                HtmlReport += "<td align=\"left\">" + row.Cells[13].Value.ToString() + "</td>";
                HtmlReport += "</tr>";
                
                p.IncrementProgressBar(i++);                
            }

            HtmlReport += "</table></br>";

            //HtmlReport += "<div style=\"page-break-after:always\"></div>";
            p.IncrementProgressBar(i + 1);

            #endregion
            
            p.Close();
            p.Dispose();            

            var htmlContent = String.Format(HtmlReport, DateTime.Now);
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            var pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\AtletiPostGironi" + nomeTorneo + disciplina + ".pdf", pdfBytes);
            Process.Start(".\\PDF\\AtletiPostGironi" + nomeTorneo + disciplina + ".pdf");
        }

        public void StampaBracketOttavi(List<AtletaEliminatorie> campo1, List<AtletaEliminatorie> campo2, List<AtletaEliminatorie> campo3, List<AtletaEliminatorie> campo4)
        {
            String HtmlReport = "";

            String temp = FormattedString.bracket8;

            temp = temp.Replace("##CAMPO##", "Campo Numero " + 1);
            temp = temp.Replace("##1##", campo1[0].Cognome + " " + campo1[0].Nome);
            temp = temp.Replace("##2##", campo1[1].Cognome + " " + campo1[1].Nome);
            temp = temp.Replace("##3##", campo1[2].Cognome + " " + campo1[2].Nome);
            temp = temp.Replace("##4##", campo1[3].Cognome + " " + campo1[3].Nome);
            

            HtmlReport += temp;
            var htmlContent = String.Format(HtmlReport, DateTime.Now);
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            var pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\BracketOttavi_Campo1.pdf", pdfBytes);

            Process.Start(".\\PDF\\BracketOttavi_Campo1.pdf");

            temp = FormattedString.bracket8;
            HtmlReport = "";

            temp = temp.Replace("##CAMPO##", "Campo Numero " + 2);
            temp = temp.Replace("##1##", campo2[0].Cognome + " " + campo2[0].Nome);
            temp = temp.Replace("##2##", campo2[1].Cognome + " " + campo2[1].Nome);
            temp = temp.Replace("##3##", campo2[2].Cognome + " " + campo2[2].Nome);
            temp = temp.Replace("##4##", campo2[3].Cognome + " " + campo2[3].Nome);

            HtmlReport += temp;
            htmlContent = String.Format(HtmlReport, DateTime.Now);
            htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\BracketOttavi_Campo2.pdf", pdfBytes);

            Process.Start(".\\PDF\\BracketOttavi_Campo2.pdf");

            temp = FormattedString.bracket8;
            HtmlReport = "";

            temp = temp.Replace("##CAMPO##", "Campo Numero " + 3);
            temp = temp.Replace("##1##", campo3[0].Cognome + " " + campo3[0].Nome);
            temp = temp.Replace("##2##", campo3[1].Cognome + " " + campo3[1].Nome);
            temp = temp.Replace("##3##", campo3[2].Cognome + " " + campo3[2].Nome);
            temp = temp.Replace("##4##", campo3[3].Cognome + " " + campo3[3].Nome);

            HtmlReport += temp;
            htmlContent = String.Format(HtmlReport, DateTime.Now);
            htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\BracketOttavi_Campo3.pdf", pdfBytes);

            Process.Start(".\\PDF\\BracketOttavi_Campo3.pdf");

            temp = FormattedString.bracket8;
            HtmlReport = "";

            temp = temp = temp.Replace("##CAMPO##", "Campo Numero " + 4);
            temp = temp.Replace("##1##", campo4[0].Cognome + " " + campo4[0].Nome);
            temp = temp.Replace("##2##", campo4[1].Cognome + " " + campo4[1].Nome);
            temp = temp.Replace("##3##", campo4[2].Cognome + " " + campo4[2].Nome);
            temp = temp.Replace("##4##", campo4[3].Cognome + " " + campo4[3].Nome);

            HtmlReport += temp;

            htmlContent = String.Format(HtmlReport, DateTime.Now);
            htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\BracketOttavi_Campo4.pdf", pdfBytes);

            Process.Start(".\\PDF\\BracketOttavi_Campo4.pdf");

        }

        public void StampaBracketSedicesimi(List<AtletaEliminatorie> campo1, List<AtletaEliminatorie> campo2, List<AtletaEliminatorie> campo3, List<AtletaEliminatorie> campo4)
        {
            String HtmlReport = "";

            String temp = FormattedString.bracket16;

            temp = temp.Replace("##CAMPO##", "Campo Numero " + 1);
            temp = temp.Replace("##1##", campo1[0].Cognome + " " + campo1[0].Nome);
            temp = temp.Replace("##2##", campo1[1].Cognome + " " + campo1[1].Nome);
            temp = temp.Replace("##3##", campo1[2].Cognome + " " + campo1[2].Nome);
            temp = temp.Replace("##4##", campo1[3].Cognome + " " + campo1[3].Nome);
            temp = temp.Replace("##5##", campo1[4].Cognome + " " + campo1[4].Nome);
            temp = temp.Replace("##6##", campo1[5].Cognome + " " + campo1[5].Nome);
            temp = temp.Replace("##7##", campo1[6].Cognome + " " + campo1[6].Nome);
            temp = temp.Replace("##8##", campo1[7].Cognome + " " + campo1[7].Nome);

            HtmlReport += temp;
            var htmlContent = String.Format(HtmlReport, DateTime.Now);
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            var pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\BracketSedicesimi_Campo1.pdf", pdfBytes);

            Process.Start(".\\PDF\\BracketSedicesimi_Campo1.pdf");

            temp = FormattedString.bracket16;
            HtmlReport = "";

            temp = temp.Replace("##CAMPO##", "Campo Numero " + 2);
            temp = temp.Replace("##1##", campo2[0].Cognome + " " + campo2[0].Nome);
            temp = temp.Replace("##2##", campo2[1].Cognome + " " + campo2[1].Nome);
            temp = temp.Replace("##3##", campo2[2].Cognome + " " + campo2[2].Nome);
            temp = temp.Replace("##4##", campo2[3].Cognome + " " + campo2[3].Nome);
            temp = temp.Replace("##5##", campo2[4].Cognome + " " + campo2[4].Nome);
            temp = temp.Replace("##6##", campo2[5].Cognome + " " + campo2[5].Nome);
            temp = temp.Replace("##7##", campo2[6].Cognome + " " + campo2[6].Nome);
            temp = temp.Replace("##8##", campo2[7].Cognome + " " + campo2[7].Nome);

            HtmlReport += temp;
            htmlContent = String.Format(HtmlReport, DateTime.Now);
            htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\BracketSedicesimi_Campo2.pdf", pdfBytes);

            Process.Start(".\\PDF\\BracketSedicesimi_Campo2.pdf");

            temp = FormattedString.bracket16;
            HtmlReport = "";

            temp = temp.Replace("##CAMPO##", "Campo Numero " + 3);
            temp = temp.Replace("##1##", campo3[0].Cognome + " " + campo3[0].Nome);
            temp = temp.Replace("##2##", campo3[1].Cognome + " " + campo3[1].Nome);
            temp = temp.Replace("##3##", campo3[2].Cognome + " " + campo3[2].Nome);
            temp = temp.Replace("##4##", campo3[3].Cognome + " " + campo3[3].Nome);
            temp = temp.Replace("##5##", campo3[4].Cognome + " " + campo3[4].Nome);
            temp = temp.Replace("##6##", campo3[5].Cognome + " " + campo3[5].Nome);
            temp = temp.Replace("##7##", campo3[6].Cognome + " " + campo3[6].Nome);
            temp = temp.Replace("##8##", campo3[7].Cognome + " " + campo3[7].Nome);

            HtmlReport += temp;
            htmlContent = String.Format(HtmlReport, DateTime.Now);
            htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\BracketSedicesimi_Campo3.pdf", pdfBytes);

            Process.Start(".\\PDF\\BracketSedicesimi_Campo3.pdf");

            temp = FormattedString.bracket16;
            HtmlReport = "";

            temp = temp = temp.Replace("##CAMPO##", "Campo Numero " + 4);
            temp = temp.Replace("##1##", campo4[0].Cognome + " " + campo4[0].Nome);
            temp = temp.Replace("##2##", campo4[1].Cognome + " " + campo4[1].Nome);
            temp = temp.Replace("##3##", campo4[2].Cognome + " " + campo4[2].Nome);
            temp = temp.Replace("##4##", campo4[3].Cognome + " " + campo4[3].Nome);
            temp = temp.Replace("##5##", campo4[4].Cognome + " " + campo4[4].Nome);
            temp = temp.Replace("##6##", campo4[5].Cognome + " " + campo4[5].Nome);
            temp = temp.Replace("##7##", campo4[6].Cognome + " " + campo4[6].Nome);
            temp = temp.Replace("##8##", campo4[7].Cognome + " " + campo4[7].Nome);

            HtmlReport += temp;

            htmlContent = String.Format(HtmlReport, DateTime.Now);
            htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\BracketSedicesimi_Campo4.pdf", pdfBytes);

            Process.Start(".\\PDF\\BracketSedicesimi_Campo4.pdf");

        }

        public void StampaGironiConIncontri(List<List<Atleta>> gironi, String nomeTorneo, String disciplina)
        {
            String HtmlReport = "";

            ProgressBar p = new ProgressBar();

            p.InizializeProgressBar(1, gironi.Count + 2);
            p.Show();
            Int32 i = 1;

            foreach (List<Atleta> l in gironi)
            {
                String temp = "";
                if (l.Count == 4)
                    temp = FormattedString.tableT4;
                else if (l.Count == 5)
                    temp = FormattedString.tableT5;

                temp = temp.Replace("##TournamentDate##", ""); //TODO ci va la data di inizio e fine torneo da DB
                temp = temp.Replace("##a##", l[0].FullName);
                temp = temp.Replace("##b##", l[1].FullName);
                temp = temp.Replace("##c##", l[2].FullName);
                temp = temp.Replace("##d##", l[3].FullName);

                temp = temp.Replace("##Atleta_a_nome##", l[0].Asd + " - " + l[0].FullName);
                temp = temp.Replace("##Atleta_b_nome##", l[1].Asd + " - " + l[1].FullName);
                temp = temp.Replace("##Atleta_c_nome##", l[2].Asd + " - " + l[2].FullName);
                temp = temp.Replace("##Atleta_d_nome##", l[3].Asd + " - " + l[3].FullName);

                if(l.Count == 5)
                {
                    temp = temp.Replace("##e##", l[4].FullName);
                    temp = temp.Replace("##Atleta_e_nome##", l[4].Asd + " - " + l[4].FullName);
                }

                temp = temp.Replace("##TOURNAMENTNAME##", nomeTorneo + " - " + disciplina);
                temp = temp.Replace("##NomeGirone##", "Girone " + i);

                HtmlReport += temp;
                if(i<gironi.Count)
                    HtmlReport += "<div style=\"page-break-after:always\"></div>";

                i++;
                p.IncrementProgressBar(i);
            }

            var htmlContent = String.Format(HtmlReport, DateTime.Now);
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            var pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\Gironi_inconti_" + nomeTorneo + "_" + disciplina + ".pdf", pdfBytes);

            Process.Start(".\\PDF\\Gironi_inconti_" + nomeTorneo + "_" + disciplina + ".pdf");

            p.IncrementProgressBar(i + 1);

            p.Close();
            p.Dispose();

        }

        public void StampaGironi(List<List<Atleta>> gironi, String nomeTorneo, String disciplina)
        {

            String HtmlReport = "<html><head></head><body><h1>Atleti iscritti al torneo " + nomeTorneo + " - " + disciplina + "</h1>";

            ProgressBar p = new ProgressBar();

            p.InizializeProgressBar(1, gironi.Count + 2);
            p.Show();
            Int32 i = 1;

            foreach (List<Atleta> l in gironi)
            {
                HtmlReport += "<h2>Girone " + i + "</h2>";
                HtmlReport += "<table style=\"width: 100%;\" border=\"1\">";
                HtmlReport += "<tr><th>Associazione</th><th>Cognome</th><th>Nome</th></tr>";
                foreach (Atleta a in l)
                {
                    HtmlReport += "<tr><td>" + a.Asd + "</td><td>" + a.Cognome + "<td>" + a.Nome + "</td></tr>";
                }

                HtmlReport += "</table></br>";
                if(i%5 == 0)
                    HtmlReport += "<div style=\"page-break-after:always\"></div>";

                i++;
                p.IncrementProgressBar(i);
            }

            HtmlReport += "</body></html>";

            var htmlContent = String.Format(HtmlReport, DateTime.Now);
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            var pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\Gironi_" + nomeTorneo + "_" + disciplina + ".pdf", pdfBytes);

            Process.Start(".\\PDF\\Gironi_" + nomeTorneo + "_" + disciplina + ".pdf");

            p.IncrementProgressBar(i + 1);

            p.Close();
            p.Dispose();
        }

        public void StampaAtletiTorneo(List<Atleta> listAtleti, String nomeTorneo, String disciplina)
        {
            ProgressBar p = new ProgressBar();

            String HtmlReport = "<h1>Atleti iscritti al torneo " + nomeTorneo + " - " + disciplina + "</h1>";

            HtmlReport += "<table style=\"width: 100%;\" border=\"1\">";
            HtmlReport += "<tr><th>Associazione</th><th>Cognome</th><th>Nome</th><th>Ranking</th></tr>";

            p.InizializeProgressBar(1, listAtleti.Count+2);

            p.Show();
            int i = 1;

            foreach(Atleta a in listAtleti)
            {
                HtmlReport += "<tr><td>" + a.Asd + "</td><td>" + a.Cognome + "<td>" + a.Nome + "<td align=\"center\">" + a.Ranking + "</td></tr>";


                i++;
                p.IncrementProgressBar(i);
            }

            HtmlReport += "</table></br>";

            var htmlContent = String.Format(HtmlReport, DateTime.Now);
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            var pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\ListaAtleti_" + nomeTorneo + "_" + disciplina + ".pdf", pdfBytes);

            Process.Start(".\\PDF\\ListaAtleti_" + nomeTorneo + "_" + disciplina + ".pdf");

            p.IncrementProgressBar(i+1);

            p.Close();
            p.Dispose();
        }

        public void StampaSedicesimi(List<AtletaEliminatorie> campo1,
                            List<AtletaEliminatorie> campo2,
                            List<AtletaEliminatorie> campo3,
                            List<AtletaEliminatorie> campo4)
        {
            ProgressBar p = new ProgressBar();

            String temp;
            String HtmlReport = FormattedString.header;

            #region campo1
            p.InizializeProgressBar(1, campo1.Count + campo2.Count + campo3.Count + campo4.Count + 2);

            p.Show();
            int i = 1;

            temp = "<A NAME=\"table1\"><H1>Campo 1</H1></A>";
            temp += FormattedString.match.Replace("##a##", campo1[0].Cognome + " " + campo1[0].Nome);
            temp = temp.Replace("##b##", campo1[1].Cognome + " " + campo1[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 1");
            p.IncrementProgressBar(i++);
            temp += FormattedString.match.Replace("##a##", campo1[2].Cognome + " " + campo1[2].Nome);
            temp = temp.Replace("##b##", campo1[3].Cognome + " " + campo1[3].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 2");
            p.IncrementProgressBar(i++);
            temp += FormattedString.match.Replace("##a##", campo1[4].Cognome + " " + campo1[4].Nome);
            temp = temp.Replace("##b##", campo1[5].Cognome + " " + campo1[5].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 3");
            p.IncrementProgressBar(i++);
            temp += FormattedString.match.Replace("##a##", campo1[6].Cognome + " " + campo1[6].Nome);
            temp = temp.Replace("##b##", campo1[7].Cognome + " " + campo1[7].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 4");
            p.IncrementProgressBar(i++);

            temp += FormattedString.footer;

            HtmlReport += temp;
            HtmlReport += "<div style=\"page-break-after:always\"></div>";
            p.IncrementProgressBar(i + 1);

            #endregion

            #region campo2
            temp = "<A NAME=\"table1\"><H1>Campo 2</H1></A>";
            temp += FormattedString.match.Replace("##a##", campo2[0].Cognome + " " + campo2[0].Nome);
            temp = temp.Replace("##b##", campo2[1].Cognome + " " + campo2[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 1");
            p.IncrementProgressBar(i++);
            temp += FormattedString.match.Replace("##a##", campo2[2].Cognome + " " + campo2[2].Nome);
            temp = temp.Replace("##b##", campo2[3].Cognome + " " + campo2[3].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 2");
            p.IncrementProgressBar(i++);
            temp += FormattedString.match.Replace("##a##", campo2[4].Cognome + " " + campo2[4].Nome);
            temp = temp.Replace("##b##", campo2[5].Cognome + " " + campo2[5].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 3");
            p.IncrementProgressBar(i++);
            temp += FormattedString.match.Replace("##a##", campo2[6].Cognome + " " + campo2[6].Nome);
            temp = temp.Replace("##b##", campo2[7].Cognome + " " + campo2[7].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 4");
            p.IncrementProgressBar(i++);

            temp += FormattedString.footer;

            HtmlReport += temp;
            HtmlReport += "<div style=\"page-break-after:always\"></div>";
            p.IncrementProgressBar(i + 1);

            #endregion

            #region campo3
            temp = "<A NAME=\"table1\"><H1>Campo 3</H1></A>";
            temp += FormattedString.match.Replace("##a##", campo3[0].Cognome + " " + campo3[0].Nome);
            temp = temp.Replace("##b##", campo3[1].Cognome + " " + campo3[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 1");
            p.IncrementProgressBar(i++);
            temp += FormattedString.match.Replace("##a##", campo3[2].Cognome + " " + campo3[2].Nome);
            temp = temp.Replace("##b##", campo3[3].Cognome + " " + campo3[3].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 2");
            p.IncrementProgressBar(i++);
            temp += FormattedString.match.Replace("##a##", campo3[4].Cognome + " " + campo3[4].Nome);
            temp = temp.Replace("##b##", campo3[5].Cognome + " " + campo3[5].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 3");
            p.IncrementProgressBar(i++);
            temp += FormattedString.match.Replace("##a##", campo3[6].Cognome + " " + campo3[6].Nome);
            temp = temp.Replace("##b##", campo3[7].Cognome + " " + campo3[7].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 4");
            p.IncrementProgressBar(i++);

            temp += FormattedString.footer;

            HtmlReport += temp;
            HtmlReport += "<div style=\"page-break-after:always\"></div>";
            p.IncrementProgressBar(i + 1);

            #endregion

            #region campo4
            temp = "<A NAME=\"table1\"><H1>Campo 4</H1></A>";
            temp += FormattedString.match.Replace("##a##", campo4[0].Cognome + " " + campo4[0].Nome);
            temp = temp.Replace("##b##", campo4[1].Cognome + " " + campo4[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 1");
            p.IncrementProgressBar(i++);
            temp += FormattedString.match.Replace("##a##", campo4[2].Cognome + " " + campo4[2].Nome);
            temp = temp.Replace("##b##", campo4[3].Cognome + " " + campo4[3].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 2");
            p.IncrementProgressBar(i++);
            temp += FormattedString.match.Replace("##a##", campo4[4].Cognome + " " + campo4[4].Nome);
            temp = temp.Replace("##b##", campo4[5].Cognome + " " + campo4[5].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 3");
            p.IncrementProgressBar(i++);
            temp += FormattedString.match.Replace("##a##", campo4[6].Cognome + " " + campo4[6].Nome);
            temp = temp.Replace("##b##", campo4[7].Cognome + " " + campo4[7].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 4");
            p.IncrementProgressBar(i++);

            temp += FormattedString.footer;

            HtmlReport += temp;
            HtmlReport += "</BODY></HTML>";
            p.IncrementProgressBar(i + 1);

            p.Close();
            p.Dispose();

            #endregion

            var htmlContent = String.Format(HtmlReport, DateTime.Now);
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            var pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\IncontriDirettiSedicesimi.pdf", pdfBytes);

            Process.Start(".\\PDF\\IncontriDirettiSedicesimi.pdf");

            
        }

        public void StampaOttavi(List<AtletaEliminatorie> campo1,
                            List<AtletaEliminatorie> campo2,
                            List<AtletaEliminatorie> campo3,
                            List<AtletaEliminatorie> campo4)
        {
            ProgressBar p = new ProgressBar();

            String temp;
            String HtmlReport = FormattedString.header;

            #region campo1
            p.InizializeProgressBar(1, campo1.Count + campo2.Count + campo3.Count + campo4.Count + 2);

            p.Show();
            int i = 1;

            temp = "<A NAME=\"table1\"><H1>Campo 1</H1></A>";
            temp += FormattedString.match.Replace("##a##", campo1[0].Cognome + " " + campo1[0].Nome);
            temp = temp.Replace("##b##", campo1[1].Cognome + " " + campo1[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 1");
            p.IncrementProgressBar(i++);
            temp += FormattedString.match.Replace("##a##", campo1[2].Cognome + " " + campo1[2].Nome);
            temp = temp.Replace("##b##", campo1[3].Cognome + " " + campo1[3].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 2");
            p.IncrementProgressBar(i++);

            temp += FormattedString.footer;

            HtmlReport += temp;
            HtmlReport += "<div style=\"page-break-after:always\"></div>";
            p.IncrementProgressBar(i + 1);

            #endregion

            #region campo2
            temp = "<A NAME=\"table1\"><H1>Campo 2</H1></A>";
            temp += FormattedString.match.Replace("##a##", campo2[0].Cognome + " " + campo2[0].Nome);
            temp = temp.Replace("##b##", campo2[1].Cognome + " " + campo2[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 1");
            p.IncrementProgressBar(i++);
            temp += FormattedString.match.Replace("##a##", campo2[2].Cognome + " " + campo2[2].Nome);
            temp = temp.Replace("##b##", campo2[3].Cognome + " " + campo2[3].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 2");
            p.IncrementProgressBar(i++);

            temp += FormattedString.footer;

            HtmlReport += temp;
            HtmlReport += "<div style=\"page-break-after:always\"></div>";
            p.IncrementProgressBar(i + 1);

            #endregion

            #region campo3
            temp = "<A NAME=\"table1\"><H1>Campo 3</H1></A>";
            temp += FormattedString.match.Replace("##a##", campo3[0].Cognome + " " + campo3[0].Nome);
            temp = temp.Replace("##b##", campo3[1].Cognome + " " + campo3[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 1");
            p.IncrementProgressBar(i++);
            temp += FormattedString.match.Replace("##a##", campo3[2].Cognome + " " + campo3[2].Nome);
            temp = temp.Replace("##b##", campo3[3].Cognome + " " + campo3[3].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 2");
            p.IncrementProgressBar(i++);

            temp += FormattedString.footer;

            HtmlReport += temp;
            HtmlReport += "<div style=\"page-break-after:always\"></div>";
            p.IncrementProgressBar(i + 1);

            #endregion

            #region campo4
            temp = "<A NAME=\"table1\"><H1>Campo 4</H1></A>";
            temp += FormattedString.match.Replace("##a##", campo4[0].Cognome + " " + campo4[0].Nome);
            temp = temp.Replace("##b##", campo4[1].Cognome + " " + campo4[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 1");
            p.IncrementProgressBar(i++);
            temp += FormattedString.match.Replace("##a##", campo4[2].Cognome + " " + campo4[2].Nome);
            temp = temp.Replace("##b##", campo4[3].Cognome + " " + campo4[3].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 2");
            p.IncrementProgressBar(i++);

            temp += FormattedString.footer;

            HtmlReport += temp;
            HtmlReport += "</BODY></HTML>";
            p.IncrementProgressBar(i + 1);

            p.Close();
            p.Dispose();

            #endregion

            var htmlContent = String.Format(HtmlReport, DateTime.Now);
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            var pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\IncontriDirettiOttavi.pdf", pdfBytes);

            Process.Start(".\\PDF\\IncontriDirettiOttavi.pdf");
        }

        public void StampaQuarti(List<AtletaEliminatorie> campo1,
                            List<AtletaEliminatorie> campo2,
                            List<AtletaEliminatorie> campo3,
                            List<AtletaEliminatorie> campo4)
        {
            ProgressBar p = new ProgressBar();

            String temp;
            String HtmlReport = FormattedString.header;

            #region campo1
            p.InizializeProgressBar(1, campo1.Count + campo2.Count + campo3.Count + campo4.Count + 2);

            p.Show();
            int i = 1;

            temp = "<A NAME=\"table1\"><H1>Campo 1</H1></A>";
            temp += FormattedString.match.Replace("##a##", campo1[0].Cognome + " " + campo1[0].Nome);
            temp = temp.Replace("##b##", campo1[1].Cognome + " " + campo1[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 1");
            p.IncrementProgressBar(i++);
            
            temp += FormattedString.footer;

            HtmlReport += temp;
            HtmlReport += "<div style=\"page-break-after:always\"></div>";
            p.IncrementProgressBar(i + 1);

            #endregion

            #region campo2
            temp = "<A NAME=\"table1\"><H1>Campo 2</H1></A>";
            temp += FormattedString.match.Replace("##a##", campo2[0].Cognome + " " + campo2[0].Nome);
            temp = temp.Replace("##b##", campo2[1].Cognome + " " + campo2[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 1");
            p.IncrementProgressBar(i++);
            
            temp += FormattedString.footer;

            HtmlReport += temp;
            HtmlReport += "<div style=\"page-break-after:always\"></div>";
            p.IncrementProgressBar(i + 1);

            #endregion

            #region campo3
            temp = "<A NAME=\"table1\"><H1>Campo 3</H1></A>";
            temp += FormattedString.match.Replace("##a##", campo3[0].Cognome + " " + campo3[0].Nome);
            temp = temp.Replace("##b##", campo3[1].Cognome + " " + campo3[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 1");
            p.IncrementProgressBar(i++);
            
            temp += FormattedString.footer;

            HtmlReport += temp;
            HtmlReport += "<div style=\"page-break-after:always\"></div>";
            p.IncrementProgressBar(i + 1);

            #endregion

            #region campo4
            temp = "<A NAME=\"table1\"><H1>Campo 4</H1></A>";
            temp += FormattedString.match.Replace("##a##", campo4[0].Cognome + " " + campo4[0].Nome);
            temp = temp.Replace("##b##", campo4[1].Cognome + " " + campo4[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 1");
            p.IncrementProgressBar(i++);
            
            temp += FormattedString.footer;

            HtmlReport += temp;
            HtmlReport += "</BODY></HTML>";
            p.IncrementProgressBar(i + 1);

            p.Close();
            p.Dispose();

            #endregion

            var htmlContent = String.Format(HtmlReport, DateTime.Now);
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            var pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\IncontriDirettiQuarti.pdf", pdfBytes);

            Process.Start(".\\PDF\\IncontriDirettiQuarti.pdf");
        }

        public void StampaSemifinali(List<AtletaEliminatorie> campo1,
                            List<AtletaEliminatorie> campo2)
        {
            ProgressBar p = new ProgressBar();

            String temp;
            String HtmlReport = FormattedString.header;

            #region campo1
            p.InizializeProgressBar(1, campo1.Count + campo2.Count  + 2);

            p.Show();
            int i = 1;

            temp = "<A NAME=\"table1\"><H1>Campo 1</H1></A>";
            temp += FormattedString.match.Replace("##a##", campo1[0].Cognome + " " + campo1[0].Nome);
            temp = temp.Replace("##b##", campo1[1].Cognome + " " + campo1[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 1");
            p.IncrementProgressBar(i++);

            temp += FormattedString.footer;

            HtmlReport += temp;
            HtmlReport += "<div style=\"page-break-after:always\"></div>";
            p.IncrementProgressBar(i + 1);

            #endregion

            #region campo2
            temp = "<A NAME=\"table1\"><H1>Campo 2</H1></A>";
            temp += FormattedString.match.Replace("##a##", campo2[0].Cognome + " " + campo2[0].Nome);
            temp = temp.Replace("##b##", campo2[1].Cognome + " " + campo2[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Incontro 1");
            p.IncrementProgressBar(i++);

            temp += FormattedString.footer;

            HtmlReport += temp;
            HtmlReport += "</BODY></HTML>";
            p.IncrementProgressBar(i + 1);

            p.Close();
            p.Dispose();

            #endregion

            var htmlContent = String.Format(HtmlReport, DateTime.Now);
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            var pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\IncontriDirettiSemifinali.pdf", pdfBytes);

            Process.Start(".\\PDF\\IncontriDirettiSemifinali.pdf");
        }

        public void StampaFinali(List<AtletaEliminatorie> campo1,
                            List<AtletaEliminatorie> campo2)
        {
            ProgressBar p = new ProgressBar();

            String temp;
            String HtmlReport = FormattedString.header;

            #region campo1
            p.InizializeProgressBar(1, (campo1.Count+3) + (campo2.Count+3) + 2);

            p.Show();
            int i = 1;

            temp = "<A NAME=\"table1\"><H1>Campo 1</H1></A>";
            temp += FormattedString.match.Replace("##a##", campo1[0].Cognome + " " + campo1[0].Nome);
            temp = temp.Replace("##b##", campo1[1].Cognome + " " + campo1[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Finale Primo e Secondo Posto");
            temp += "<BR>";
            temp += FormattedString.match.Replace("##a##", campo1[0].Cognome + " " + campo1[0].Nome);
            temp = temp.Replace("##b##", campo1[1].Cognome + " " + campo1[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Finale Primo e Secondo Posto");
            temp += "<BR>";
            temp += FormattedString.match.Replace("##a##", campo1[0].Cognome + " " + campo1[0].Nome);
            temp = temp.Replace("##b##", campo1[1].Cognome + " " + campo1[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Finale Primo e Secondo Posto");
            p.IncrementProgressBar(i++);

            temp += FormattedString.footer;

            HtmlReport += temp;
            HtmlReport += "<div style=\"page-break-after:always\"></div>";
            p.IncrementProgressBar(i + 1);

            #endregion

            #region campo2
            temp = "<A NAME=\"table1\"><H1>Campo 2</H1></A>";
            temp += FormattedString.match.Replace("##a##", campo2[0].Cognome + " " + campo2[0].Nome);
            temp = temp.Replace("##b##", campo2[1].Cognome + " " + campo2[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Finale Terzo e Quarto Posto");
            temp += "<BR>";
            temp += FormattedString.match.Replace("##a##", campo2[0].Cognome + " " + campo2[0].Nome);
            temp = temp.Replace("##b##", campo2[1].Cognome + " " + campo2[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Finale Terzo e Quarto Posto");
            temp += "<BR>";
            temp += FormattedString.match.Replace("##a##", campo2[0].Cognome + " " + campo2[0].Nome);
            temp = temp.Replace("##b##", campo2[1].Cognome + " " + campo2[1].Nome);
            temp = temp.Replace("##INCONTRO##", "Finale Terzo e Quarto Posto");
            p.IncrementProgressBar(i++);

            temp += FormattedString.footer;

            HtmlReport += temp;
            HtmlReport += "</BODY></HTML>";
            p.IncrementProgressBar(i + 1);

            p.Close();
            p.Dispose();

            #endregion

            var htmlContent = String.Format(HtmlReport, DateTime.Now);
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            var pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\IncontriDirettiFinali.pdf", pdfBytes);

            Process.Start(".\\PDF\\IncontriDirettiFinali.pdf");
        }

        public void FineTorneo(String primo, String secondo, String terzo, String quarto, String nomeTorneo, String nomeDisciplina)
        {

            String HtmlReport = "<h1>Podio per il torneo " + nomeTorneo + " - " + nomeDisciplina + "</h1>";

            HtmlReport += "<h2>Primo classificato: " + primo + "</h2>";
            HtmlReport += "<h2>Secondo classificato: " + secondo + "</h2>";
            HtmlReport += "<h3>Terzo classificato: " + terzo + "</h3>";
            HtmlReport += "<h4>Quarto classificato: " + quarto + "</h4>";


            var htmlContent = String.Format(HtmlReport, DateTime.Now);
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            var pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\Podio_" + nomeTorneo + "_" + nomeDisciplina + ".pdf", pdfBytes);

            Process.Start(".\\PDF\\Podio_" + nomeTorneo + "_" + nomeDisciplina + ".pdf");
        }
    }
}
