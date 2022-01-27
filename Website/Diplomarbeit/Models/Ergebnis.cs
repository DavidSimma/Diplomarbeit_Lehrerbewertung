using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplomarbeit.Models
{
    public class Ergebnis
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

        public int a1 { get; set; }
        public int a2 { get; set; }
        public int a3 { get; set; }
        public int a4 { get; set; }
        public int a5 { get; set; }
        public int a6 { get; set; }
        public int a7 { get; set; }
        public int a8 { get; set; }

        public string annotion { get; set; }
        public string annotionanswer { get; set; }

        public string teacherKey { get; set; }

        public Ergebnis() : this("", "", "", "", "", "", "", "", "", "", 0, 0, 0, 0, 0, 0, 0, 0, "", "", "") { }
        public Ergebnis(string id, string ueberschrift, string f1, string f2, string f3, string f4, string f5, string f6, string f7, string f8, int a1, int a2, int a3, int a4, int a5, int a6, int a7, int a8, string anmerkung, string a9, string key)
        {
            this.teacherId = id;
            this.heading = ueberschrift;
            this.q1 = f1;
            this.q2 = f2;
            this.q3 = f3;
            this.q4 = f4;
            this.q5 = f5;
            this.q6 = f6;
            this.q7 = f7;
            this.q8 = f8;
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
            this.a4 = a4;
            this.a5 = a5;
            this.a6 = a6;
            this.a7 = a7;
            this.a8 = a8;
            this.annotion = anmerkung;
            this.annotionanswer = a9;
            this.teacherKey = key;
        }

        public override string ToString()
        {
            return "Das Ergebnis mit der ID " + this.teacherId + " (" + this.heading + ") besitzt 8 Fragen: Frage1(" + this.q1 + "), Antwort(" + this.a1 + "); Frage2(" + this.q2 + "), Antwort(" + this.a2 + "); Frage3(" + this.q3 + "), Antwort(" + this.a3 + ") Frage4(" + this.q4 + "), Antwort(" + this.a4 + "); Frage5(" + this.q5 + "), Antwort(" + this.a5 + "); Frage6(" + this.q6 + "), Antwort(" + this.a6 + "); Frage7(" + this.q7 + "), Antwort(" + this.a7 + "); Frage8(" + this.q8 + "), Antwort(" + this.a8 + ") und die Anmerkung(" + this.annotion + "), Antwort(" + this.annotionanswer + ") --> (Schlüssel: " + this.teacherKey + ")";
        }
    }
}
