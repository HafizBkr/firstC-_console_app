using MyApp.Dtos;

namespace MyApp.Services
{
    public class UserService
    {  
        public void CreateUser(CreateUser createUserDto)
        {
            if (string.IsNullOrWhiteSpace(createUserDto.Email) ||
                string.IsNullOrWhiteSpace(createUserDto.Username) ||
                string.IsNullOrWhiteSpace(createUserDto.Password))
            {
                throw new ArgumentException("All fields are required.");
            }
            Console.WriteLine($"User created: {createUserDto.Username} ({createUserDto.Email})");
        }
    }
}
