using System.Text.Json.Serialization;

namespace Core.Dtos.Public;

public class JWT
{
    public string Key { get; set; }
    [JsonIgnore]
    public string Issuer { get; set; }
    [JsonIgnore]
    public DateTime fechaExpedicion { get; set; }
    [JsonIgnore]
    public DateTime fechaExpiracion { get; set; }
    [JsonIgnore]
    public double DurationInMinutes { get; set; }
    [JsonIgnore]
    public string Audience { get; set; }

}
