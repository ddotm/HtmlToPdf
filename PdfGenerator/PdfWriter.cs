using IronPdf;

namespace PdfGenerator
{
	public class PdfWriter
	{
		public void WriteFile(string html, string fileName)
		{
			var renderer = new HtmlToPdf();
			// Render an HTML document or snippet as a string
			renderer.RenderHtmlAsPdf(html).SaveAs(fileName);
			// Advanced: 
			// Set a "base url" or file path so that images, javascript and CSS can be loaded  
			// var PDF = renderer.RenderHtmlAsPdf("<img src='icons/iron.png'>", @"C:\site\assets\");
			// PDF.SaveAs("html-with-assets.pdf");
		}
	}
}
