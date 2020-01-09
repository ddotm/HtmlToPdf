using System;

namespace TemplateProcessing
{
	public class TemplateProcessor
	{
		public string Process(string templateId, dynamic data)
		{
			return "<style>.text-red {color: red;}</style><h1 class=\"text-red\">Hello, world!!!</h1>";
		}
	}
}
