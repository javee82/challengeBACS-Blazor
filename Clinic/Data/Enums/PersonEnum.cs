using Clinic.Data.Helpers;
namespace Clinic.Data.Enums
{
	public class PersonEnum
	{
		public enum MedicalSpeciallity
		{
			[DisplayText("Cardiologia")]
			Cardiology = 1,
			[DisplayText("Dermatologia")]
			Dermatology,
			[DisplayText("Gastroenterologia")]
			Gastroenterology,
			[DisplayText("Ginecologia Y Obstetricia")]
			GynecologyAndObstetrics,
			[DisplayText("Neurologia")]
			Neurology,
			[DisplayText("Oncologia")]
			Oncology,
			[DisplayText("Ortopedia")]
			Orthopedics,
			[DisplayText("Pediatria")]
			Pediatrics,
			[DisplayText("Psiquiatria")]
			Psychiatry,
			[DisplayText("Radiologia")]
			Radiology
		}
	}
}
