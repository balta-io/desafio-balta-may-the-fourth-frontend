using System.Text.Json.Serialization;

public class CharacterResume
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Name { get; set; } = null!;
}
