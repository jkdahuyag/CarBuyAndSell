namespace CarBuyAndSell.Dto
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string RoleName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Number { get; set; }
        public string ProfilePicture { get; set; }

        public UserDto(int userId, string roleName, string firstName, string lastName, string address, string username, string password, string number, string profilePicture)
        {
            UserId = userId;
            RoleName = roleName;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Username = username;
            Password = password;
            Number = number;
            ProfilePicture = profilePicture;
        }

    }
}
