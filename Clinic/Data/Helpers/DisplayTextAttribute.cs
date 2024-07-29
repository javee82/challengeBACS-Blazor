namespace Clinic.Data.Helpers
{
	[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	sealed class DisplayTextAttribute : Attribute
	{
		public string Text { get; }
        public DisplayTextAttribute(string text) => Text = text;
    }
}
