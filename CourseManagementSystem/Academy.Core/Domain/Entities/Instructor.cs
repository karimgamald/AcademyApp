using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Domain.Entities
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email {  get; set; } = string.Empty;
        public string? Phone {  get; set; }
        public string? Bio {  get; set; }
        public string Specialization { get; set; } = string.Empty;

        public ICollection<GroupInstructor> GroupInstructors { get; set; } = new List<GroupInstructor>();

    }
}
