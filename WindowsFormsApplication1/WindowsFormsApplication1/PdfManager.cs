using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class PdfManager
    {
        public void TestPdfCreation()
        {

            //IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();

            String HtmlReport = "<h1>Prova stampa PDF</h1>";

            

            for (int j = 0; j < 5; j++)
            {
                HtmlReport += "<h3>Girone " + (j + 1).ToString() + "</h3>";

                HtmlReport += "<table style=\"width: 100%;\" border=\"3\">";

                for (int i = 0; i < 10; i++)
                    HtmlReport += "<tr><td>" + i.ToString() + "</td></tr>";

                HtmlReport += "</table></br>";

                //pagebreak
                if (j == 2)
                    HtmlReport += "<div style=\"page-break-after:always\"></div>";
            }


            //Renderer.RenderHtmlAsPdf(HtmlReport).SaveAs("d:\\html-string.pdf");
            //HtmlToPdf myPdfMaker = new HtmlToPdf();

            //myPdfMaker.PrintOptions.GrayScale = true;
            //PdfDocument pdf =  myPdfMaker.RenderHtmlAsPdf("<p>hello world</p>");

            var htmlContent = String.Format(HtmlReport,DateTime.Now);
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            var pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            System.IO.File.WriteAllBytes(".\\PDF\\hello.pdf", pdfBytes);

            //htmlToPdf.GeneratePdfFromFile(HtmlReport, null, "D:\\export.pdf");



        }

    }
}
