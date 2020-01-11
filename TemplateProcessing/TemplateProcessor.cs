using HandlebarsDotNet;
using System.Reflection;

namespace TemplateProcessing
{
	public class TemplateProcessor
	{
		public string Process(int templateId, dynamic data)
		{
			var fileName = this.GetTemplateFileName(templateId);
			var htmlSource = System.IO.File.ReadAllText(fileName);
			var template = Handlebars.Compile(htmlSource);
			var result = template(data);
			return result;
		}

		private string GetTemplateFileName(int id)
		{
			var exePath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			var templatePath = $@"{exePath}/Templates/";
			return id switch
			{
				1 => $@"{templatePath}contact-info.html",
				2 => $@"{templatePath}connections.html",
				_ => string.Empty,
			};
		}
	}
}
