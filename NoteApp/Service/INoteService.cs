using NoteApp.Models;

namespace NoteApp.Service
{
    public interface INoteService
    {
        List<Note> GetAllNote(int id);
        Note GetNoteById(int id);
        bool CreateNote(Note note);
        bool DeleteNote(int id);
    }
}
