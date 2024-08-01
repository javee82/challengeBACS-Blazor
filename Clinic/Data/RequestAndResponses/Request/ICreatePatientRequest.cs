namespace Clinic.Data.RequestAndResponses.Request
{
	public interface ICreatePatientRequest
	{
		public string? Id { get; set; }
		public string SocialWorkNumber { get; set; }
	}
}
