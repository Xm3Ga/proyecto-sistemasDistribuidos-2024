using System.Text.Json.Serialization;

namespace NotesAPI.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UserId { get; set; }

        [JsonIgnore]
        public User? User { get; set; }
    }
}
