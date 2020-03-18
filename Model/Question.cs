using System.Collections.Generic;

namespace Q1.Model
{
    public class Question
    {
        public int Id { get; set; }
        public string Query { get; set; }
        public string Answer { get; set; }
        public List<string> Variant = new List<string>();
    }
}
