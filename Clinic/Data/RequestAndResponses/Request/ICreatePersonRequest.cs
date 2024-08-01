namespace Clinic.Data.RequestAndResponses.Request
{
	public interface ICreatePersonRequest
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime DateOfBirth { get; set; }
		public int DNI { get; set; }
	}
}
