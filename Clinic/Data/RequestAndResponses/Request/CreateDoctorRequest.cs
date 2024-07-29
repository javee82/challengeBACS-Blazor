using static Clinic.Data.Enums.PersonEnum;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.RequestAndResponses.Request
{
	public class CreateDoctorRequest
	{
		public string? Id { get; set; }
		[Required]
		[Range(1, 10)]
		public MedicalSpeciallity Speciallity { get; set; }
		[Required]
		public string LicenseNumber { get; set; }
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		public string PhoneNumber { get; set; }
		[Required]
		public DateTime DateOfBirth { get; set; }  = DateTime.Now;
		[Required]
		public int DNI { get; set; }
	}
}
