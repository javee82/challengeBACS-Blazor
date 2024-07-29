using static Clinic.Data.Enums.PersonEnum;

namespace Clinic.Data
{
	public class Doctor
	{
		public Guid DoctorId { get; set; }
		public int PersonId { get; set; }
		public Person Person { get; set; } = new Person();
		public MedicalSpeciallity Speciallity { get; set; }
		public string LicenseNumber { get; set; }
	}
}
