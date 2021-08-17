

using System.Collections;
using System.Collections.Generic;

namespace Models
{
    public class SystemUnit 
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }

        public IList<Detail> Details { get; set; } = new List<Detail>();


    }
}
