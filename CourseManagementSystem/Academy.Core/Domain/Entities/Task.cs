using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Domain.Entities
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DeadLine { get; set; }

        public ICollection<Solution> Solutions { get; set; } = new List<Solution>();
    }
}
