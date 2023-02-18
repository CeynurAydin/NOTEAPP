using NoteApp.Models;
using NoteApp.Repository;

namespace NoteApp.Service
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;
        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public bool CreateNote(Note note)
        {
            _noteRepository.CreateNote(note);
            return true;    
        }

        public bool DeleteNote(int id)
        {
            _noteRepository.DeleteNote(id);
            return true;
        }

        public List<Note> GetAllNote(int id)
        {
            return _noteRepository.GetAllNote(id);
            
        }

        public Note GetNoteById(int id)
        {

            return _noteRepository.GetNoteById(id);
            
        }
    }
}
