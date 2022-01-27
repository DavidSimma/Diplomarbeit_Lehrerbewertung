using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplomarbeit.Models
{
    public class Formular
    {
        public string teacherId { get; set; }
        public string heading { get; set; }
        public string q1 { get; set; }
        public string q2 { get; set; }
        public string q3 { get; set; }
        public string q4 { get; set; }
        public string q5 { get; set; }
        public string q6 { get; set; }
        public string q7 { get; set; }
        public string q8 { get; set; }
        public string annotion { get; set; }

        public Formular() : this("", "", "", "", "", "", "", "", "", "", "") { }
        public Formular(string teacherId, string heading, string q1, string q2, string q3, string q4, string q5, string q6, string q7, string q8, string annotion)
        {
            this.teacherId = teacherId;
            this.heading = heading;
            this.q1 = q1;
            this.q2 = q2;
            this.q3 = q3;
            this.q4 = q4;
            this.q5 = q5;
            this.q6 = q6;
            this.q7 = q7;
            this.q8 = q8;
            this.annotion = annotion;
        }

        public override string ToString()
        {
            return "Das Formular mit der ID " + this.teacherId + " (" + this.heading + ") besitzt 8 Fragen: Frage1 = " + this.q1 + ", Frage2 = " + this.q2 + ", Frage3 = " + this.q3 + ", Frage4 = " + this.q4 + ", Frage5 = " + this.q5 + ", Frage6 = " + this.q6 + ", Frage7 = " + this.q7 + ", Frage8 = " + this.q8 + " und eine Anmerkung = " + this.annotion;
        }
    }
}
