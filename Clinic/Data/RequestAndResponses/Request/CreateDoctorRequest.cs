using static Clinic.Data.Enums.PersonEnum;
using static Clinic.Data.Constants.Constants;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.RequestAndResponses.Request
{
	public class CreateDoctorRequest : ICreatePersonRequest, ICreateDoctorRequest
	{
		public string? Id { get; set; }
		[Required(ErrorMessage = "El campo Especialidad es requerido")]
		[Range(1, 10, ErrorMessage ="Debe elegir una de las especialidades disponibles")]
		public MedicalSpeciallity Speciallity { get; set; }
		[Required(ErrorMessage = "El campo Numero de licencia es requerido")]
		public string LicenseNumber { get; set; }
		[Required(ErrorMessage = "El campo Nombre es requerido")]
		public string FirstName { get; set; }
		[Required(ErrorMessage = "El campo Apellido es requerido")]
		public string LastName { get; set; }
		[Required(ErrorMessage = "El campo Numero de telefono es requerido")]
		[RegularExpression(PhonePattern, ErrorMessage = "El número de teléfono no es válido.")]
		public string PhoneNumber { get; set; }
		[Required(ErrorMessage = "El campo Fecha de nacimiento es requerido")]
		public DateTime DateOfBirth { get; set; } = DateTime.Now;
		[Required(ErrorMessage = "El campo DNI es requerido")]
		public int DNI { get; set; }
	}
}
