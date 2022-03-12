using System;
using System.Collections.Generic;
using System.Text;

namespace Diplomarbeit.models
{
    class EmptyForm : App
    {
        public static List<string> Questions = new List<string>();
        public static string Key { get; set; }
        public static string Heading { get; set; }
        public static void addQuestion(string q)
        {
            Questions.Add(q);
        }
        public static string Annotation { get; set; }
    }
}
