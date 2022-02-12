using System;
using System.Collections.Generic;
using System.Text;

namespace ChurchDirectory.DbContext.Models
{
    public class Child
    {
        public string Id { get; set; }

        public string ParentId { get; set; }

        public string Name { get; set; }

        public DateTime? BirthDate { get; set; }

        public string DeathDate { get; set; }

        public string Married { get; set; }

        public bool Member { get; set; }

        public string Comment1 { get; set; }
    }
}
