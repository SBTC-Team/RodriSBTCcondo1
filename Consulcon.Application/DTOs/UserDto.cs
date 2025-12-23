namespace Consulcon.Application.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string FullName { get; set; }
        public int? RoleId { get; set; }
        public required string Token { get; set; } // Placeholder for future JWT
    }
}
