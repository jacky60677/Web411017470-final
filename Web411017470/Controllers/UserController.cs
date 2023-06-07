using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web411017470.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Music()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Music(string name, int number)
        {
            if (number >= 1 && number <= 7)
            {
                string note = GetNoteByNumber(number);
                ViewBag.Name = name;
                ViewBag.Note = note;
            }
            else
            {
                ViewBag.Error = "錯誤";
            }

            return View();
        }

        private string GetNoteByNumber(int number)
        {
            string[] notes = { "do", "re", "mi", "fa", "so", "la", "xi" };
            return notes[number - 1];
        }
    }
}