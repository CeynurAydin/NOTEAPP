using Microsoft.AspNetCore.Mvc;
using NoteApp.Data;
using NoteApp.Models;
using NoteApp.Service;

namespace NoteApp.Controllers
{
    public class NoteController : Controller
    {
        private readonly INoteService _noteService;

        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }
        public IActionResult Index(int id)
        {
          
            return View(_noteService.GetAllNote(id));
         
        }
        public IActionResult AddNote(int id)
        {
            
            var note = new Note();
            if (id != 0)
            {
                note.NoteSubId = id;
            }

            return View(note);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNote(Note note)
        {
            _noteService.CreateNote(note);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _noteService.DeleteNote(id);
         
            return RedirectToAction("Index");
        }
    }
}
