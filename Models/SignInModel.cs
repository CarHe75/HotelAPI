namespace HotelAPI.Models
{
    public class SignInModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<string> Errors { get; set; }
    }
}
