using System.Diagnostics;
using System.IO;
using System.Reflection;
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

			var connections = new dynamic[]
			{
				new
				{
					contactType = "I",
					connectionContactType = "I",
					jobTitleRole = "Manager",
					connectionContact = "Ben Jackson",
					contact = "Dmitri Mogilevski",
					connectionRoles = "Accountant;Business Manager",
					number = "447709786920",
					email = "benjackson007@hotmail.co.uk",
					emailType = "(Home)",
					phoneNumberType = "(Mobile)",
					countryCode = "+1-264",
					extension = ""
				},
				new
				{
					contactType = "I",
					connectionContactType = "I",
					jobTitleRole = "CIO",
					connectionContact = "Jack Porter",
					contact = "Dmitri Mogilevski",
					connectionRoles = "Accountant;Business Manager",
					number = "447709786920",
					email = "benjackson007@hotmail.co.uk",
					emailType = "(Home)",
					phoneNumberType = "(Mobile)",
					countryCode = "+1-264",
					extension = ""
				},
				new
				{
					contactType = "I",
					connectionContactType = "I",
					jobTitleRole = "Senior Dev",
					connectionContact = "Tim Eck",
					contact = "Dmitri Mogilevski",
					connectionRoles = "Accountant;Business Manager",
					number = "447709786920",
					email = "benjackson007@hotmail.co.uk",
					emailType = "(Home)",
					phoneNumberType = "(Mobile)",
					countryCode = "+1-264",
					extension = ""
				}
			};
			var connectionsHtml = string.Empty;
			foreach (var connection in connections)
			{
				connectionsHtml += templateProcessor.Process(2, connection);
			}

			var data = new
			{
				contactDetails = new
				{
					contact_ID = 750,
					contactType = "I",
					companyContact_ID = 0,
					contact = "Dmitri Mogilevski",
					companyName = "Protiviti",
					firstName = "Dmitri",
					middleName = "L",
					lastName = "Mogilevski",
					filedAsName = string.Empty,
					jobTitle = "Manager",
					certificationStatus_ID = 1,
					birthDate = string.Empty,
					gender_ID = 0,
					assistantName = string.Empty,
					assistantPhone = string.Empty,
					assistantEmail = string.Empty,
					note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
					privateNote = "test this thing",
					contactCategory_IDs = "15;57;43;42",
					myContactCategory_IDs = string.Empty,
					securityGroup_IDs = string.Empty,
					redFlagStatus_ID = 2,
					redFlagNote = "test1234",
					profilePicture = "https://paradigmtempodev.blob.core.windows.net/tempo-fs-dev/Contact/750/Add_New_2019-09-01_15-13-40.png",
					agencyContact_ID = 1,
					createdDate = "2019-07-09T23:25:06.6233333",
					updatedDate = "2019-12-19T18:55:59.59",
					contactCategories = "Employee;Manager;Promoter Assistant;Promoter Contact",
					certificationStatus = "Certified"
				},
				connections = connectionsHtml
			};

			var html = templateProcessor.Process(1, data);

			var exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			var pdfPath = $@"{exePath}\report.pdf";
			pdfWriter.WriteFile(html, pdfPath);

			var p = new Process
			{
				StartInfo = new ProcessStartInfo(pdfPath)
				{
					UseShellExecute = true
				}
			};
			p.Start();
		}
	}
}
