using static Clinic.Data.Constants.Constants;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.RequestAndResponses.Request
{
	public class CreatePatientRequest : ICreatePersonRequest, ICreatePatientRequest
	{
		public string? Id { get; set; }
		[Required(ErrorMessage = "El campo obra social es requerido")]
		public string SocialWorkNumber { get; set; }
		[Required(ErrorMessage = "El campo nombre es requerido")]
		public string FirstName { get; set; }
		[Required(ErrorMessage = "El campo apellido es requerido")]
		public string LastName { get; set; }
		[Required(ErrorMessage = "El campo numero de telefono es requerido")]
		[RegularExpression(PhonePattern, ErrorMessage = "El número de teléfono no es válido.")]
		public string PhoneNumber { get; set; }
		[Required(ErrorMessage = "El campo fecha de nacimiento es requerido")]
		public DateTime DateOfBirth { get; set; } = DateTime.Now;
		[Required(ErrorMessage = "El campo DNI es requerido")]
		public int DNI { get; set; }
	}
}
