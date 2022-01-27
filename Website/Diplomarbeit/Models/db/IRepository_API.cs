using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplomarbeit.Models.db
{
    interface IRepository_API
    {
        Task<Formular> GetFormularByID(string id);

        Task<List<Formular>> GetAllFormular();
        Task<List<Feedback>> GetAllFeedback();
        Task<List<Ergebnis>> GetErgebnisByKey(string key);
        Task<List<Ergebnis>> GetKey();
        Task<bool> SendFilledData(Formular formular);
        Task<bool> SendFilledDataFeedback(Feedback feedback);

    }
}
