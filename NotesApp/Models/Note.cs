using SQLite;

namespace NotesApp.Models
{
    // This class is a data model.
    // A model in MAUI represents the data used in the application by Services and ViewModels.
    // Here, the model is mapped to a SQLite database.
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Title { get; set; } = string.Empty;

        public string Body { get; set; } = string.Empty;

        public DateTime LastModified { get; set; } = DateTime.UtcNow;
    }
}
