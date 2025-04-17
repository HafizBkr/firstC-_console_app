namespace MyApp.Dtos
{
    public record class CreateUser(
        string Email,
        string Username,
        string Password
    );
}