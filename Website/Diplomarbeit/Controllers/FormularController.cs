using Diplomarbeit.Models;
using Diplomarbeit.Models.db;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Diplomarbeit.Controllers
{
    public class FormularController : Controller
    {
        IRepository_API rep = new Repository_API();

        public IActionResult Ergebnis_Formular()
        {
            return View();
        }

        public IActionResult Ergebnis_Auswertung()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FormularNeu()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FormularNeu(Formular newFormular)
        {
            if (newFormular == null)
            {
                return RedirectToAction("FormularNeu", "formular");
            }

            List<Formular> liste = await rep.GetAllFormular();
            Datenkontrolle_Formular(newFormular, liste);

            if (ModelState.IsValid)
            {
                try
                {
                    if (await rep.SendFilledData(newFormular))
                    {
                        return View("Message", new Message("Datenbank-Erfolg",
                            "Das Formular wurde erfolgreich abgespeichert!"));
                    }
                }
                catch (DbException ex)
                {
                    return View("Message", new Message("Datenbank-Fehler",
                        "Das Formular konnte nicht abgespeichert werden!",
                        ex.StackTrace));
                }
                return RedirectToAction("index", "home");
            }
            return View(newFormular);
        }

        [HttpGet]
        public IActionResult Feedback_()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Feedback_(Feedback newFeedback)
        {
            if (newFeedback == null)
            {
                return RedirectToAction("Feedback", "formular");
            }
            List<Feedback> listeF = await rep.GetAllFeedback();
            List<Formular> liste = await rep.GetAllFormular();
            Datenkontrolle_Feedback(newFeedback, listeF, liste);
            if (ModelState.IsValid)
            {
                try
                {
                    if (await rep.SendFilledDataFeedback(newFeedback))
                    {
                            return View("Message", new Message("Datenbank-Erfolg",
                                "Feedback erfolgreich abgespeichert!"));
                    }   
                }
                catch (DbException ex)
                {
                    return View("Message", new Message("Datenbank-Fehler",
                        "Die Eingabe konnte nicht abgespeichert werden!",
                        ex.StackTrace));
                }
                return RedirectToAction("index", "home");
            }
            return View(newFeedback);
        }

        public IActionResult IndividuelleFormulare()
        {
            return View();
        }

        public IActionResult Standardformular()
        {
            return View();
        }

        public async Task<JsonResult> GetAllFormular()
        {
            try
            {
                List<Formular> allFormular = await rep.GetAllFormular();
                if (allFormular != null)
                {
                    return Json(allFormular);
                }
                else
                {
                    return Json("NoFormular");
                }
            }
            catch (Exception)
            {
                return Json("DbError");
            }
        }

        public async Task<JsonResult> GetFormularById(string id)
        {
            try
            {
                Formular formular = await rep.GetFormularByID(id);
                if (formular != null)
                {
                    return Json(formular);
                }
                else
                {
                    return Json("NoFormular");
                }
            }
            catch (Exception)
            {
                return Json("DbError");
            }
        }

        public async Task<JsonResult> GetKey()
        {
            try
            {
                List<Ergebnis> distinct = await rep.GetKey();
                if (distinct != null)
                {
                    return Json(distinct);
                }
                else
                {
                    return Json("NoFormular");
                }
            }
            catch (Exception)
            {
                return Json("DbError");
            }
        }

        public async Task<JsonResult> GetErgebnisByKey(string key)
        {
            try
            {
                List<Ergebnis> allErgebnisse = await rep.GetErgebnisByKey(key);
                if (allErgebnisse != null)
                {
                    return Json(allErgebnisse);
                }
                else
                {
                    return Json("NoFormular");
                }
            }
            catch (Exception)
            {
                return Json("DbError");
            }
        }

        private void Datenkontrolle_Formular(Formular a, List<Formular> l)
        {
            if (a == null)
            {
                return;
            }

            a.teacherId = a.teacherId ?? "";
            a.heading = a.heading ?? "Feedback";
            a.q1 = a.q1 ?? "";
            a.q2 = a.q2 ?? "";
            a.q3 = a.q3 ?? "";
            a.q4 = a.q4 ?? "";
            a.q5 = a.q5 ?? "";
            a.q6 = a.q6 ?? "";
            a.q7 = a.q7 ?? "";
            a.q8 = a.q8 ?? "";
            a.annotion = a.annotion ?? "Anmerkung";

            if (a.teacherId.Length < 1)
            {
                ModelState.AddModelError(nameof(Formular.teacherId), "FormularID muss angegeben werden!");
            }
            if (a.q1.Length < 1)
            {
                ModelState.AddModelError(nameof(Formular.q1), "Frage muss formuliert werden!");
            }
            if (a.q2.Length < 1)
            {
                ModelState.AddModelError(nameof(Formular.q2), "Frage muss formuliert werden!");
            }
            if (a.q3.Length < 1)
            {
                ModelState.AddModelError(nameof(Formular.q3), "Frage muss formuliert werden!");
            }
            if (a.q4.Length < 1)
            {
                ModelState.AddModelError(nameof(Formular.q4), "Frage muss formuliert werden!");
            }
            if (a.q5.Length < 1)
            {
                ModelState.AddModelError(nameof(Formular.q5), "Frage muss formuliert werden!");
            }
            if (a.q6.Length < 1)
            {
                ModelState.AddModelError(nameof(Formular.q6), "Frage muss formuliert werden!");
            }
            if (a.q7.Length < 1)
            {
                ModelState.AddModelError(nameof(Formular.q7), "Frage muss formuliert werden!");
            }
            if (a.q8.Length < 1)
            {
                ModelState.AddModelError(nameof(Formular.q8), "Frage muss formuliert werden!");
            }

            foreach (Formular f in l)
            {
                if (f.teacherId == a.teacherId)
                {
                    ModelState.AddModelError(nameof(Formular.teacherId), "FormularID existiert bereits!");
                }
            }
        }

        private void Datenkontrolle_Feedback(Feedback a, List<Feedback> l, List<Formular> ll)
        {
            if (a == null)
            {
                return;
            }

            a.teacherId = a.teacherId ?? "";
            a.teacherKey = a.teacherKey ?? "";

            if (a.teacherId.Length < 1)
            {
                ModelState.AddModelError(nameof(Formular.teacherId), "FormularID muss angegeben werden!");
            }
            if (a.teacherKey.Length < 1)
            {
                ModelState.AddModelError(nameof(Feedback.teacherKey), "Schlüssel muss angegeben werden!");
            }
            
            foreach (Feedback f in l)
            {
                if (f.teacherKey == a.teacherKey)
                {
                    ModelState.AddModelError(nameof(Feedback.teacherKey), "Schlüssel existiert bereits!");
                }
                
            }
            bool test = true;
            foreach (Formular f in ll)
            {
                if (f.teacherId == a.teacherId)
                {
                    test = false;
                }
            }
            if (test)
            {
                ModelState.AddModelError(nameof(Feedback.teacherId), "FormularID existiert nicht!");
            }
        }
    }
}
