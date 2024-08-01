using static Clinic.Data.Enums.PersonEnum;

namespace Clinic.Data.RequestAndResponses.Request
{
	public interface ICreateDoctorRequest
	{
		public string? Id { get; set; }
		public MedicalSpeciallity Speciallity { get; set; }
		public string LicenseNumber { get; set; }
	}
}
