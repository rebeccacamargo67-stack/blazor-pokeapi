using System.Text.Json.Serialization;

namespace BuscarPokemon.Models
{
    public class Pokemon
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("weight")]
        public int Weight { get; set; }

        [JsonPropertyName("sprites")]
        public Sprites? Sprites { get; set; }
    }

    public class Sprites
    {
        [JsonPropertyName("other")]
        public Other? Other { get; set; }
    }

    public class Other
    {
        [JsonPropertyName("official-artwork")]
        public OfficialArtwork? OfficialArtwork { get; set; }
    }

    public class OfficialArtwork
    {
        [JsonPropertyName("front_default")]
        public string? FrontDefault { get; set; }
    }
}
