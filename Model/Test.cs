using System.Collections.Generic;

namespace Q1.Model
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public List<Question> Questions = new List<Question>();
    }
}
