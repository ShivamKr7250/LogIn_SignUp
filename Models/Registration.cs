namespace Login_SignUp_API.Models
{
    public class Registration
    {
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public int IsActive { get; set; }
    }
}
