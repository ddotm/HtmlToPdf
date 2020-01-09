using PdfGenerator;
using TemplateProcessing;

namespace HtmlToPdf
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var templateProcessor = new TemplateProcessor();
			var pdfWriter = new PdfWriter();

			var html = templateProcessor.Process("1", new { title = "Hello, templating!"});
			pdfWriter.WriteFile(html, "html-string.pdf");
		}
	}
}
