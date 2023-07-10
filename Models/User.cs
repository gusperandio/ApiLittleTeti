
using System.Text.Json.Serialization;

namespace LittleTeti.Models;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    [JsonIgnore]
    public string PasswordHash { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public Address Address { get; set; }
    public IList<Solicitation> Solicitations { get; set; }
    public IList<Role> Roles { get; set; }
}