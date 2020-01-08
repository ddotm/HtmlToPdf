using PdfGenerator;

namespace HtmlToPdf
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var pdfWriter = new PdfWriter();
			pdfWriter.WriteFile("<h1>Hello World</h1>", "html-string.pdf");
		}
	}
}
