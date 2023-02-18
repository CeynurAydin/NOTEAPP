using NoteApp.Data;
using NoteApp.Models;

namespace NoteApp.Repository
{
    public class NoteRepository : INoteRepository
    {
        private readonly AppDbContext _db;

        public NoteRepository(AppDbContext db)
        {
            _db = db;
        }
        public bool CreateNote(Note note)
        {
            _db.Add(note);
            _db.SaveChanges();
            return true;
        }

        public bool DeleteNote(int id)
        {
            if (id != 0)
            {

                var main = GetNoteById(id);
              
                main.IsActive = false;
               

                
                var all = _db.Notes.Where(x => x.NoteSubId == id);
                foreach (var item in all)
                {
                    item.IsActive = false;
                    _db.Notes.Update(item);
                    
                }
                _db.Notes.Update(main);
                _db.SaveChanges();
                return true;
            }
            return false;
        }


        public List<Note> GetAllNote(int id)
        {
            if (id == 0)
            {
                var x = _db.Notes.Where(x => x.NoteSubId == null && x.IsActive==true);
                return x.ToList();
               
            }
            else
            { 
                
                return (List<Note>)_db.Notes.Where(x => x.NoteSubId == id && x.IsActive == true).ToList();
            }
        }

        public Note GetNoteById(int id)
        {
            return _db.Notes.Find(id);
        }
    }
}
