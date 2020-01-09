using PdfGenerator;

namespace HtmlToPdf
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var pdfWriter = new PdfWriter();
			pdfWriter.WriteFile("<style>.text-red {color: red;}</style><h1 class=\"text-red\">Hello, world!</h1>", "html-string.pdf");
		}
	}
}
