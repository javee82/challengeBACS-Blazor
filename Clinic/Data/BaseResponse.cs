namespace Clinic.Data
{
    public class BaseResponse<T>
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public T Body { get; set; }
    }
}
