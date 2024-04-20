using System.Text.Json.Serialization;

public class MovieResume
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;
}
