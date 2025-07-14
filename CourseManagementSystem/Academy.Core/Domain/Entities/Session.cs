using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Domain.Entities
{
    public class Session
    {
        public int SessionId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime SessionDate { get; set; }
        public DateTime StartTime { get; set; }

        public ICollection<GroupSession> GroupSessions { get; set; } = new List<GroupSession>();

        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

        public ICollection<Task> Tasks { get; set; } = new List<Task>();


    }
}
