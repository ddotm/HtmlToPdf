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

			var data = new
			{
				contactDetails = new
				{
					contact_ID = 750,
					contactType = "I",
					companyContact_ID = 0,
					contact = "Dmitri Mogilevski",
					companyName = "Protiviti",
					contractingParty_Name = string.Empty,
					contractingParty_AddressLine1 = string.Empty,
					contractingParty_AddressLine2 = string.Empty,
					contractingParty_City = string.Empty,
					contractingParty_StateProvince = string.Empty,
					contractingParty_PostalCode = string.Empty,
					contractingParty_Country_ID = string.Empty,
					venueStage_AgeRestriction = string.Empty,
					venueStage_MaxCapacity = string.Empty,
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
					isPrivate = false,
					isFavorite = true,
					isActive = true,
					emailAddress = string.Empty,
					country_ID = string.Empty,
					address1 = string.Empty,
					address2 = string.Empty,
					city = string.Empty,
					state = string.Empty,
					zipPostal = string.Empty,
					stateProvince = string.Empty,
					businessPhone = string.Empty,
					extension = string.Empty,
					cellPhone = string.Empty,
					webSite = string.Empty,
					user = string.Empty,
					securityGroup_ID = string.Empty,
					businessCountry_ID = string.Empty,
					cellCountry_ID = string.Empty,
					latitude = string.Empty,
					longitude = string.Empty,
					timeZone = string.Empty,
					redFlagStatus_ID = 2,
					redFlagNote = "test1234",
					profilePicture = "https://paradigmtempodev.blob.core.windows.net/tempo-fs-dev/Contact/750/Add_New_2019-09-01_15-13-40.png",
					agencyContact_ID = 1,
					createdDate = "2019-07-09T23:25:06.6233333",
					updatedDate = "2019-12-19T18:55:59.59",
					contactCategories = "Employee;Manager;Promoter Assistant;Promoter Contact",
					contactCertificationStatus = string.Empty,
					myContactCategories = string.Empty,
					certificationStatus = "Certified",
					securityGroups = string.Empty,
					departments = string.Empty,
					homeOffice = string.Empty,
					divisions = string.Empty,
					legacySystemResponses = string.Empty
				}
			};

			var html = templateProcessor.Process(1, data);

			pdfWriter.WriteFile(html, "report.pdf");
		}
	}
}
