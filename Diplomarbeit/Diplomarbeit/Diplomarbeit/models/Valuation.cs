using System.Collections.Generic;

namespace Diplomarbeit.models
{
    // um Klasse Global zu machen: static und :App
    class Valuation : App
    {
        private static List<int> _answers = new List<int>();
        public static string Key { get; set; }
        public static List<int> getAnswers()
        {
            return _answers;
        }
        public static void addAnswer(int a)
        {
            _answers.Add(a);
        }
        public static string Annotation { get; set; }
        public static string TeacherKey { get; set; }
    }
}
