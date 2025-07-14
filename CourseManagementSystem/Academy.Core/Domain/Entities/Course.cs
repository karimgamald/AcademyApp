using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Domain.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public int? CategoryId { get; set; } // foreign key
        public Category? category { get; set; } // navigation property

        public ICollection<Group> Groups { get; set; } = new List<Group>();
    }
}
