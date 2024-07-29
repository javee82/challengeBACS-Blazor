using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.RequestAndResponses.Request
{
	public class CreatePatientRequest
	{
		public string? Id { get; set; }		
		[Required]
		public string SocialWorkNumber { get; set; }
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		public string PhoneNumber { get; set; }
		[Required]
		public DateTime DateOfBirth { get; set; }
		[Required]
		public int DNI { get; set; }
	}
}
