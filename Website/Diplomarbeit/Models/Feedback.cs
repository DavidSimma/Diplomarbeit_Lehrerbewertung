using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplomarbeit.Models
{
    public class Feedback
    {
        public string teacherId { get; set; }
        public string teacherKey { get; set; }

        public Feedback() : this("", "") { }
        public Feedback(string id, string key)
        {
            this.teacherId = id;
            this.teacherKey = key;
        }

        public override string ToString()
        {
            return "Neues Feedback mit der ID " + this.teacherId + " und dem Schlüssel " + this.teacherKey;
        }
    }
}
