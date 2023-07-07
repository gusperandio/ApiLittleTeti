
using System.Text.Json.Serialization;

namespace LittleTeti.Models;

public class User
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    [JsonIgnore]
    public string PasswordHas { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public Addres Addres { get; set; }
    public IList<Solicitation> Solicitaions { get; set; }
    public IList<Role> Roles { get; set; }
}