using Clinic.Data.Helpers;

namespace Clinic.Data.Enums
{
	public static class EnumExtensions
	{
		public static string GetDisplayText(this Enum value)
		{
			var type = value.GetType();
			var memberInfo = type.GetMember(value.ToString());
			if (memberInfo.Length > 0) 
			{
				var attrs = memberInfo[0].GetCustomAttributes(typeof(DisplayTextAttribute), false);
				if (attrs.Length > 0)
				{
					return ((DisplayTextAttribute)attrs[0]).Text;
				}
			}
			return value.ToString();
		}
	}
}
