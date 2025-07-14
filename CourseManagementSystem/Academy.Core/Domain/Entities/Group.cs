using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Domain.Entities
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int? CourseId { get; set; }
        public Course? course { get; set; }

        public ICollection<Session> Sessions { get; set; } = new List<Session>();

        public ICollection<GroupInstructor> GroupInstructors { get; set;} = new List<GroupInstructor>();

        public ICollection<GroupStudent> GroupStudents { get; set; } = new List<GroupStudent>();

        public ICollection<GroupSession> GroupSessions { get; set; }= new List<GroupSession>();
    }
}
