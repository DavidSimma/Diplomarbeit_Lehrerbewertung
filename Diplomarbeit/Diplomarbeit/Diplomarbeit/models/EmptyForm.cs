using System;
using System.Collections.Generic;
using System.Text;

namespace Diplomarbeit.models
{
    class EmptyForm : App
    {
        private static List<string> _questions = new List<string>();
        public static string Key { get; set; }
        public static string Heading { get; set; }
        public static List<string> getQuestions ()
        { 
            return _questions; 
        }
        public static void addQuestion(string q)
        {
            _questions.Add(q);
        }
        public static string Annotation { get; set; }
    }
}
