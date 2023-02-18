using System.ComponentModel.DataAnnotations;

namespace NoteApp.Models
{
    public class Note
    {

        [Key]
        public int NoteId { get; set; }

        public string? NoteName { get; set; }

        public int? NoteSubId { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
