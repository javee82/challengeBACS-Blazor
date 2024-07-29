namespace Clinic.Data
{
	public class Patient
	{
		public Guid PatientId { get; set; }
		public int PersonId { get; set; }
		public Person Person { get; set; }
		public string SocialWorkNumber { get; set; }
	}
}
