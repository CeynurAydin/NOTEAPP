



using NoteApp.Models;

namespace NoteApp.Repository
{
    public interface INoteRepository
    {
        List<Note> GetAllNote(int id);
        Note GetNoteById(int id);
        bool CreateNote(Note note);
        bool DeleteNote(int id);

    }
}
